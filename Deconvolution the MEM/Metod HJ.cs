using System;

namespace Deconvolution_the_MEM
{
    static class Metod_HJ
    {
        private static double TAU = 1e-6f; // Точность вычислений
        private static int i, j, bs, ps, length;
        private static double z, h, k, fi, fb;
        private static double[] b, y, p, Y, H;
        /// <summary>
        /// Метод инициализации
        /// </summary>
        /// <param name="x">Коэффициенты</param>
        /// <param name="Y">Свёртка</param>
        /// <param name="H">Импульсная характеристика</param>
        /// <param name="tau">Точность вычислений</param>
        public static void InitializationMHJ(ref double[] x, double[] Y, double[] H, double tau = 1e-6f)
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            length = x.Length;
            TAU = tau;
            
            x = new double[length];
            b = new double[length];
            y = new double[length];
            p = new double[length];
            Metod_HJ.Y = Y;
            Metod_HJ.H = H;

            h = 1;
            x[0] = 1;
            for (i = 1; i < length; i++) 
                x[i] = (float)rnd.NextDouble(); //Начальное приближение

            k = h;
            for (i = 0; i < length; i++) 
                y[i] = p[i] = b[i] = x[i];

            fi = Functional(Y, H, x);
            ps = 0; bs = 1; fb = fi;

            j = 0;
        }
        
        /// <summary>
        /// Метод вычислений
        /// </summary>
        /// <param name="x">Коэффициенты</param>
        /// <param name="iter">Количество итераций</param>
        /// <returns></returns>
        public static double CalculationMHJ(ref double[] x, int iter)
        {
            for (; iter > 0; iter--) {
                x[j] = y[j] + k;
                z = Functional(Y, H, x);
                if (z >= fi) {
                    x[j] = y[j] - k;
                    z = Functional(Y, H, x);
                    if (z < fi) y[j] = x[j];
                    else x[j] = y[j];
                }
                else y[j] = x[j];
                fi = Functional(Y, H, x);

                if (j < length - 1) { j++; continue; }
                if (fi + 1e-8 >= fb) {
                    if (ps == 1 && bs == 0) {
                        for (i = 0; i < length; i++)
                            p[i] = y[i] = x[i] = b[i];
                        z = Functional(Y, H, x);
                        bs = 1; ps = 0; fi = z; fb = z; j = 0;
                        continue;
                    }
                    k /= 10f;
                    if (k < TAU) break;
                    j = 0;
                    continue;
                }

                for (i = 0; i < length; i++) {
                    p[i] = 2 * y[i] - b[i];
                    b[i] = y[i];
                    x[i] = p[i];
                    y[i] = x[i];
                }
                z = Functional(Y, H, x);
                fb = fi; ps = 1; bs = 0; fi = z; j = 0;
            }

            for (i = 0; i < length; i++) 
                x[i] = p[i];

            return fb;
        }

        /// <summary>
        /// Функционал.
        /// </summary>
        /// <param name="y">Свёртка</param>
        /// <param name="h">Импульсная характеристика</param>
        /// <param name="L">Коэффициенты</param>
        /// <returns></returns>
        public static double Functional(double[] y, double[] h, double[] lambda)
        {
            var resValue = 0.0;
            var fi = new double[length];
            
            var sum = Calculations.Convolusion(lambda, h);
            for (var i = 0; i < length; i++)
                fi[i] = Math.Exp(-1 - sum[i]);

            var yi = Calculations.Convolusion(fi, h);
            for (var i = 0; i < length; i++)
                resValue += Math.Pow(y[i] - yi[i], 2);

            return resValue;
        }
    }
}