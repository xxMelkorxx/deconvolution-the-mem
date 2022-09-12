using System;

namespace Deconvolution_the_MEM
{
    class MainFunctions
    {
        /// <summary>
        /// Гауссова функиция.
        /// </summary>
        /// <param name="A">Амплитуда</param>
        /// <param name="SKO">Среднеквдаратичное отклонение</param>
        /// <param name="E">Математическое ожидание</param>
        /// <param name="t">Переменная времени</param>
        private static double GaussFunction(double A, double E, double sigma, double t)
        {
            return A * Math.Exp(-Math.Pow((t - E) / sigma, 2));
        }
        /// <summary>
        /// Генерация гауссова сигнала.
        /// </summary>
        /// <param name="length">Число отсчётов</param>
        /// <param name="A">Амплитуды</param>
        /// <param name="SKO">Среднеквдаратичные отклонения</param>
        /// <param name="E">Математические ожидания</param>
        /// <param name="dt">Частота дискретизации</param>
        /// <returns>Дискретный гауссов сигнал</returns>
        public static double[] GenerateGaussSignal(int length, double[] A, double[] E, double[] sigma, double dt)
        {
            var signal = new double[length];
            for (int i = 0; i < length; i++)
                for (int k = 0; k < A.Length; k++)
                    signal[i] += GaussFunction(A[k], E[k], sigma[k], i * dt);
            return signal;
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
            for (var i = 0; i < length; i++) {
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
            for (int i = 0; i < first.Length; i++)
                deviation += Math.Pow(first[i] - second[i], 2);
            return deviation;
        }

        /// <summary>
        /// Наложение белого шума на сигнал.
        /// </summary>
        /// <param name="Sgnl">Исходный сигнал</param>
        /// <param name="intensity">Интенсивность шума</param>
        /// <returns></returns>
        public static double[] NoiseSignal(double[] sgnl, int intensity)
        {
            var lenght = sgnl.Length;
            var noiseSgnl = new double[lenght];
            var rnd = new Random(Guid.NewGuid().GetHashCode());

            // Генерация последовательности нормально распределённых случайных чисел.
            var massRand = new double[lenght];      // Массив случайных чисел.
            var energyRandMass = 0.0;               // Энергия последовательности.
            for (var i = 0; i < lenght; i++) {
                massRand[i] = 0;
                for (var n = 0; n < 12; n++)
                    massRand[i] += rnd.Next(-100, 100);
                massRand[i] /= 12;
                energyRandMass += massRand[i] * massRand[i];
            }

            // Подсчёт энергии шума относительно энергии сигнала.
            var energySignal = 0.0;                                 // Полная энергия сигнала.
            for (var i = 0; i < lenght; i++)
                energySignal += sgnl[i] * sgnl[i];
            var energyNoise = energySignal * (intensity / 100f);  // Энергия шума относительно энергии сигнала.

            // Нормировка случайной последовательности.
            for (var i = 0; i < lenght; i++)
                massRand[i] = massRand[i] * Math.Sqrt(energyNoise / energyRandMass);

            // Накладывание шума на исходный сигнал.
            for (var i = 0; i < lenght; i++)
                noiseSgnl[i] = Math.Abs(sgnl[i] + massRand[i]);

            return noiseSgnl;
        }

        /// <summary>
        /// Поиск максимального значения по оси Y.
        /// </summary>
        /// <param name="massPoints">Массив точек.</param>
        /// <returns></returns>
        public static double MaxArray(double[] array)
        {
            var max = 0.0;
            for (var i = 0; i < array.Length; i++)
                if (max < array[i]) max = array[i];
            return max;
        }
    }
}