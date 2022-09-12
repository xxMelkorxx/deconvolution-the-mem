using System;
using System.Windows.Forms;

namespace Deconvolution_the_MEM
{
    public partial class MainWindow : Form
    {
        private readonly double dt = 1f;        // Частота дискретизации
        private readonly int length = 51;       // Число отсчётов
        private double norma;
        private double[] inputSgnl, pulseResponse, lambda;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            OnClickButtonGenerateSgnl(null, EventArgs.Empty);
        }

        private void OnClickButtonGenerateSgnl(object sender, EventArgs e)
        {
            // Инициализация параметров.
            var A1 = (double)numUpDown_amplitude1.Value;
            var A2 = (double)numUpDown_amplitude2.Value;
            var A3 = (double)numUpDown_amplitude3.Value;
            var sigma1 = (double)numUpDown_standartDeviation1.Value;
            var sigma2 = (double)numUpDown_standartDeviation2.Value;
            var sigma3 = (double)numUpDown_standartDeviation3.Value;
            var t01 = (double)numUpDown_mathExpectation1.Value;
            var t02 = (double)numUpDown_mathExpectation2.Value;
            var t03 = (double)numUpDown_mathExpectation3.Value;
            var APR = (double)numUpDown_amplitudePR.Value;
            var sigmaPR = (double)numUpDown_standartDeviationPR.Value;
            var energyNoise = (int)numUpDown_energyNoise.Value;
            
            // Исходный сигнал.
            inputSgnl = MainFunctions.GenerateGaussSignal(length, new double[3] { A1, A2, A3 }, new double[3] { t01, t02, t03 }, new double[3] { sigma1, sigma2, sigma3 }, dt);
            // Импульсной характеристики.
            pulseResponse = MainFunctions.GenerateGaussSignal(length, new double[1] { APR }, new double[1] { 0.0 }, new double[1] { sigmaPR }, dt);
            for (var i = 0; i < length / 2; i++)
                pulseResponse[length - i - 1] = pulseResponse[i];
            // Выходной сигнал.
            var outputSgnl = MainFunctions.Convolusion(inputSgnl, pulseResponse);
            if (checkBox_onoffNoise.Checked == true)    // Наложение шума на выходной сигнал
                outputSgnl = MainFunctions.NoiseSignal(outputSgnl, energyNoise);
            norma = MainFunctions.MaxArray(inputSgnl) / MainFunctions.MaxArray(outputSgnl);
            for (var i = 0; i < length; i++)            // Нормировка
                outputSgnl[i] *= norma;

            // Инициализация Хука-Дживса.
            lambda = new double[length];             // Массив неопределённых коэффициентов Лагранжа
            Metod_HJ.InitializationMHJ(ref lambda, outputSgnl, pulseResponse);

            // Отрисовка графиков.
            chart_graphInitReconstSgnl.ChartAreas[0].AxisY.Maximum = MainFunctions.MaxArray(inputSgnl) * 1.1;
            chart_graphInitReconstSgnl.Series[0].Points.Clear();
            chart_graphPulseResponseOutSgnl.Series[0].Points.Clear();
            chart_graphPulseResponseOutSgnl.Series[1].Points.Clear();
            for (int i = 0; i < length; i++) {
                chart_graphInitReconstSgnl.Series[0].Points.AddXY(dt * i, inputSgnl[i]);
                chart_graphPulseResponseOutSgnl.Series[0].Points.AddXY(dt * i, pulseResponse[i]);
                chart_graphPulseResponseOutSgnl.Series[1].Points.AddXY(dt * i, outputSgnl[i]);
            }

            button_Start.Enabled = true;
        }

        private void OnTickTimer(object sender, EventArgs e)
        {
            // Подсчёт функционала.
            int iterations = 100;
            var fb = Metod_HJ.CalculationMHJ(ref lambda, iterations);
            textBox_valueFunctional.Text = string.Format("{0}", fb);

            var reconstSgnl = new double[length];
            var sum = MainFunctions.Convolusion(lambda, pulseResponse);
            for (var i = 0; i < length; i++)
                reconstSgnl[i] = Math.Exp(-1 - sum[i]) / norma;

            // Подсчёт отклонения.
            textBox_deviation.Text = string.Format("{0}", MainFunctions.Deviation(inputSgnl, reconstSgnl));

            // Отрисовка графиков.
            chart_graphInitReconstSgnl.Series[1].Points.Clear();
            for (int i = 0; i < length; i++)
                chart_graphInitReconstSgnl.Series[1].Points.AddXY(dt * i, reconstSgnl[i]);
        }

        private void OnClickButtonStart(object sender, EventArgs e)
        {
            if (timer.Enabled) {
                timer.Stop();
                button_Start.Text = "Старт!";
                textBox_accuracy.ReadOnly = false;
            }
            else {
                timer.Start();
                button_Start.Text = "Стоп!";
                textBox_accuracy.ReadOnly = true;
            }
        }
    }
}