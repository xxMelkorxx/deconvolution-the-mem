using System;

namespace Deconvolution_the_MEM
{
    class Calculations
    {
        /// <summary>
        /// Гауссова функиция.
        /// </summary>
        /// <param name="a">Амплитуда</param>
        /// <param name="sigma">Дисперсия</param>
        /// <param name="shift">Сдвиг</param>
        /// <param name="t">Переменная времени</param>
        private static double GaussFunction(double a, double shift, double sigma, double t)
        {
            return a * Math.Exp(-Math.Pow((t - shift) / sigma, 2));
        }

        /// <summary>
        /// Генерация гауссова сигнала.
        /// </summary>
        /// <param name="length">Число отсчётов</param>
        /// <param name="a">Амплитуды</param>
        /// <param name="sigma">Дисперсия</param>
        /// <param name="shift">Сдвиг</param>
        /// <param name="dt">Частота дискретизации</param>
        /// <returns>Дискретный гауссов сигнал</returns>
        public static double[] GenerateGaussSignal(int length, double[] a, double[] shift, double[] sigma, double dt)
        {
            var result = new double[length];

            for (var i = 0; i < length; i++)
            for (var k = 0; k < a.Length; k++)
                result[i] += GaussFunction(a[k], shift[k], sigma[k], i * dt);

            return result;
        }

        /// <summary>
        /// Циклическая свёртка.
        /// </summary>
        /// <param name="x">Вход</param>
        /// <param name="h">Импульсная характеристика</param>
        /// <returns></returns>
        public static double[] Convolusion(double[] x, double[] h)
        {
            var length = x.Length;
            var y = new double[length];
            for (var i = 0; i < length; i++)
            {
                y[i] = 0;
                for (var k = 0; k < length; k++)
                    y[i] += x[k] * h[(i - k) < 0 ? i - k + length : i - k];
            }

            return y;
        }

        /// <summary>
        /// Вычисление средне квадратичного отклонения.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static double Deviation(double[] first, double[] second)
        {
            var deviation = 0.0;
            for (var i = 0; i < first.Length; i++)
                deviation += Math.Pow(first[i] - second[i], 2);
            
            return deviation;
        }

        /// <summary>
        /// Наложение белого шума на сигнал.
        /// </summary>
        /// <param name="initSignal">Исходный сигнал</param>
        /// <param name="intensity">Интенсивность шума</param>
        /// <returns></returns>
        public static double[] NoiseSignal(double[] initSignal, int intensity)
        {
            var lenght = initSignal.Length;
            var noiseSignal = new double[lenght];
            var rnd = new Random(DateTime.Now.Millisecond);

            // Генерация последовательности нормально распределённых случайных чисел.
            var massRand = new double[lenght];
            var energyRandMass = 0.0;
            for (var i = 0; i < lenght; i++)
            {
                massRand[i] = 0;
                for (var n = 0; n < 12; n++)
                    massRand[i] += rnd.Next(-100, 100);
                massRand[i] /= 12;
                energyRandMass += massRand[i] * massRand[i];
            }

            // Подсчёт энергии шума относительно энергии сигнала.
            var energySignal = 0.0;
            for (var i = 0; i < lenght; i++)
                energySignal += initSignal[i] * initSignal[i];
            var energyNoise = energySignal * (intensity / 100.0);

            // Нормировка случайной последовательности.
            for (var i = 0; i < lenght; i++)
                massRand[i] *= Math.Sqrt(energyNoise / energyRandMass);

            // Накладывание шума на исходный сигнал.
            for (var i = 0; i < lenght; i++)
                noiseSignal[i] = Math.Abs(initSignal[i] + massRand[i]);

            return noiseSignal;
        }
    }
}