using System;
using System.Linq;
using System.Windows.Forms;

namespace Deconvolution_the_MEM
{
    public partial class MainWindow : Form
    {
        // Частота дискретизации
        private const double Dt = 1f;

        // Число отсчётов
        private const int Length = 51;
        private double _coefNorm;
        private double[] _inputSignal, _pulseResponse, _lambda;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            OnClickButtonGenerateSignal(null, EventArgs.Empty);
        }

        private void OnClickButtonGenerateSignal(object sender, EventArgs e)
        {
            // Исходный сигнал.
            _inputSignal = Calculations.GenerateGaussSignal(Length, new[]
            {
                (double)numUpDown_a1.Value,
                (double)numUpDown_a2.Value,
                (double)numUpDown_a3.Value
            }, new[]
            {
                (double)numUpDown_shift1.Value,
                (double)numUpDown_shift2.Value,
                (double)numUpDown_shift3.Value
            }, new[]
            {
                (double)numUpDown_sigma1.Value,
                (double)numUpDown_sigma2.Value,
                (double)numUpDown_sigma3.Value
            }, Dt);

            // Импульсная характеристика.
            _pulseResponse = Calculations.GenerateGaussSignal(Length, new[]
            {
                (double)numUpDown_aPR.Value
            }, new[]
            {
                0.0
            }, new[]
            {
                (double)numUpDown_sigmaPR.Value
            }, Dt);

            for (var i = 0; i < Length / 2; i++)
                _pulseResponse[Length - i - 1] = _pulseResponse[i];

            // Выходной сигнал.
            var outputSignal = Calculations.Convolusion(_inputSignal, _pulseResponse);

            // Наложение шума на выходной сигнал
            if (checkBox_onoffNoise.Checked)
                outputSignal = Calculations.NoiseSignal(outputSignal, (int)numUpDown_energyNoise.Value);

            _coefNorm = _inputSignal.Max() / outputSignal.Max();
            for (var i = 0; i < Length; i++) // Нормировка
                outputSignal[i] *= _coefNorm;

            // Массив неопределённых коэффициентов Лагранжа
            _lambda = new double[Length];
            // Инициализация Хука-Дживса.
            Metod_HJ.InitializationMHJ(ref _lambda, outputSignal, _pulseResponse);

            // Отрисовка графиков.
            chart_graphInitReconstSgnl.ChartAreas[0].AxisY.Maximum = _inputSignal.Max() * 1.1;
            chart_graphInitReconstSgnl.Series[0].Points.Clear();
            chart_graphPulseResponseOutSgnl.Series[0].Points.Clear();
            chart_graphPulseResponseOutSgnl.Series[1].Points.Clear();
            for (var i = 0; i < Length; i++)
            {
                chart_graphInitReconstSgnl.Series[0].Points.AddXY(Dt * i, _inputSignal[i]);
                chart_graphPulseResponseOutSgnl.Series[0].Points.AddXY(Dt * i, _pulseResponse[i]);
                chart_graphPulseResponseOutSgnl.Series[1].Points.AddXY(Dt * i, outputSignal[i]);
            }

            button_Start.Enabled = true;
        }

        private void OnTickTimer(object sender, EventArgs e)
        {
            // Подсчёт функционала.
            const int iterations = 100;
            var fb = Metod_HJ.CalculationMHJ(ref _lambda, iterations);
            textBox_valueFunctional.Text = fb.ToString("F5");

            var restoreSignal = new double[Length];
            var sum = Calculations.Convolusion(_lambda, _pulseResponse);
            for (var i = 0; i < Length; i++)
                restoreSignal[i] = Math.Exp(-1 - sum[i]) / _coefNorm;

            // Подсчёт отклонения.
            textBox_deviation.Text = Calculations.Deviation(_inputSignal, restoreSignal).ToString("F5");

            // Отрисовка графиков.
            chart_graphInitReconstSgnl.Series[1].Points.Clear();
            for (var i = 0; i < Length; i++)
                chart_graphInitReconstSgnl.Series[1].Points.AddXY(Dt * i, restoreSignal[i]);
        }

        private void OnClickButtonStart(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                button_Start.Text = "Старт!";
                textBox_accuracy.ReadOnly = false;
            }
            else
            {
                timer.Start();
                button_Start.Text = "Стоп!";
                textBox_accuracy.ReadOnly = true;
            }
        }
    }
}