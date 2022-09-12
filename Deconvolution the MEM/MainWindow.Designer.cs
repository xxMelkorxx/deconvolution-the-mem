
namespace Deconvolution_the_MEM
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBoxgraph_graphInputReconstSgnls;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.GroupBox groupBox_pulseResponse_outputSgnl;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Label label_amplitude1;
            System.Windows.Forms.Label label_standartDeviation1;
            System.Windows.Forms.Label label_mathExpectation1;
            System.Windows.Forms.Label label_mathExpectation2;
            System.Windows.Forms.Label label_standartDeviation2;
            System.Windows.Forms.Label label_amplitude2;
            System.Windows.Forms.Label label_mathExpectation3;
            System.Windows.Forms.Label label_standartDeviation3;
            System.Windows.Forms.Label label_amplitude3;
            System.Windows.Forms.Label label__amplitudePR;
            System.Windows.Forms.Label label_standartDeviationPR;
            System.Windows.Forms.Label label_energyNoise;
            System.Windows.Forms.Label label_onoffNoise;
            System.Windows.Forms.Label label_valueFunctional;
            System.Windows.Forms.Label label_accuracy;
            System.Windows.Forms.Label label_deviation;
            this.chart_graphInitReconstSgnl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_graphPulseResponseOutSgnl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_deconvolution = new System.Windows.Forms.GroupBox();
            this.textBox_accuracy = new System.Windows.Forms.TextBox();
            this.textBox_deviation = new System.Windows.Forms.TextBox();
            this.textBox_valueFunctional = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.groupBox_paramSgnl = new System.Windows.Forms.GroupBox();
            this.groupBox_dome3 = new System.Windows.Forms.GroupBox();
            this.numUpDown_mathExpectation3 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_standartDeviation3 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_amplitude3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox_dome2 = new System.Windows.Forms.GroupBox();
            this.numUpDown_mathExpectation2 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_standartDeviation2 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_amplitude2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox_dome1 = new System.Windows.Forms.GroupBox();
            this.numUpDown_mathExpectation1 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_standartDeviation1 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_amplitude1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox_pulseResponse = new System.Windows.Forms.GroupBox();
            this.numUpDown_standartDeviationPR = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_amplitudePR = new System.Windows.Forms.NumericUpDown();
            this.groupBox_paramNoise = new System.Windows.Forms.GroupBox();
            this.checkBox_onoffNoise = new System.Windows.Forms.CheckBox();
            this.numUpDown_energyNoise = new System.Windows.Forms.NumericUpDown();
            this.button_generateSgnl = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            groupBoxgraph_graphInputReconstSgnls = new System.Windows.Forms.GroupBox();
            groupBox_pulseResponse_outputSgnl = new System.Windows.Forms.GroupBox();
            label_amplitude1 = new System.Windows.Forms.Label();
            label_standartDeviation1 = new System.Windows.Forms.Label();
            label_mathExpectation1 = new System.Windows.Forms.Label();
            label_mathExpectation2 = new System.Windows.Forms.Label();
            label_standartDeviation2 = new System.Windows.Forms.Label();
            label_amplitude2 = new System.Windows.Forms.Label();
            label_mathExpectation3 = new System.Windows.Forms.Label();
            label_standartDeviation3 = new System.Windows.Forms.Label();
            label_amplitude3 = new System.Windows.Forms.Label();
            label__amplitudePR = new System.Windows.Forms.Label();
            label_standartDeviationPR = new System.Windows.Forms.Label();
            label_energyNoise = new System.Windows.Forms.Label();
            label_onoffNoise = new System.Windows.Forms.Label();
            label_valueFunctional = new System.Windows.Forms.Label();
            label_accuracy = new System.Windows.Forms.Label();
            label_deviation = new System.Windows.Forms.Label();
            groupBoxgraph_graphInputReconstSgnls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphInitReconstSgnl)).BeginInit();
            groupBox_pulseResponse_outputSgnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphPulseResponseOutSgnl)).BeginInit();
            this.groupBox_deconvolution.SuspendLayout();
            this.groupBox_paramSgnl.SuspendLayout();
            this.groupBox_dome3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_mathExpectation3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_standartDeviation3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amplitude3)).BeginInit();
            this.groupBox_dome2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_mathExpectation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_standartDeviation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amplitude2)).BeginInit();
            this.groupBox_dome1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_mathExpectation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_standartDeviation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amplitude1)).BeginInit();
            this.groupBox_pulseResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_standartDeviationPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amplitudePR)).BeginInit();
            this.groupBox_paramNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_energyNoise)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxgraph_graphInputReconstSgnls
            // 
            groupBoxgraph_graphInputReconstSgnls.Controls.Add(this.chart_graphInitReconstSgnl);
            groupBoxgraph_graphInputReconstSgnls.Location = new System.Drawing.Point(231, 13);
            groupBoxgraph_graphInputReconstSgnls.Name = "groupBoxgraph_graphInputReconstSgnls";
            groupBoxgraph_graphInputReconstSgnls.Size = new System.Drawing.Size(741, 232);
            groupBoxgraph_graphInputReconstSgnls.TabIndex = 0;
            groupBoxgraph_graphInputReconstSgnls.TabStop = false;
            groupBoxgraph_graphInputReconstSgnls.Text = "График исходного и восстановленого входных сигналов";
            // 
            // chart_graphInitReconstSgnl
            // 
            this.chart_graphInitReconstSgnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.Maximum = 50D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart_graphInitReconstSgnl.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart_graphInitReconstSgnl.Legends.Add(legend1);
            this.chart_graphInitReconstSgnl.Location = new System.Drawing.Point(6, 19);
            this.chart_graphInitReconstSgnl.Name = "chart_graphInitReconstSgnl";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Исходный сигнал";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Восстановленный сигнал";
            this.chart_graphInitReconstSgnl.Series.Add(series1);
            this.chart_graphInitReconstSgnl.Series.Add(series2);
            this.chart_graphInitReconstSgnl.Size = new System.Drawing.Size(729, 207);
            this.chart_graphInitReconstSgnl.TabIndex = 0;
            this.chart_graphInitReconstSgnl.Text = "chart_graphInitReconstSgnl";
            // 
            // groupBox_pulseResponse_outputSgnl
            // 
            groupBox_pulseResponse_outputSgnl.Controls.Add(this.chart_graphPulseResponseOutSgnl);
            groupBox_pulseResponse_outputSgnl.Location = new System.Drawing.Point(231, 250);
            groupBox_pulseResponse_outputSgnl.Name = "groupBox_pulseResponse_outputSgnl";
            groupBox_pulseResponse_outputSgnl.Size = new System.Drawing.Size(741, 232);
            groupBox_pulseResponse_outputSgnl.TabIndex = 1;
            groupBox_pulseResponse_outputSgnl.TabStop = false;
            groupBox_pulseResponse_outputSgnl.Text = "График импульсной характеристики и выходного сигнала";
            // 
            // chart_graphPulseResponseOutSgnl
            // 
            this.chart_graphPulseResponseOutSgnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Interval = 10D;
            chartArea2.AxisX.Maximum = 50D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart_graphPulseResponseOutSgnl.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.IsDockedInsideChartArea = false;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart_graphPulseResponseOutSgnl.Legends.Add(legend2);
            this.chart_graphPulseResponseOutSgnl.Location = new System.Drawing.Point(6, 19);
            this.chart_graphPulseResponseOutSgnl.Name = "chart_graphPulseResponseOutSgnl";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Выходной сигнал";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Импульсная характеристика";
            this.chart_graphPulseResponseOutSgnl.Series.Add(series3);
            this.chart_graphPulseResponseOutSgnl.Series.Add(series4);
            this.chart_graphPulseResponseOutSgnl.Size = new System.Drawing.Size(729, 207);
            this.chart_graphPulseResponseOutSgnl.TabIndex = 2;
            this.chart_graphPulseResponseOutSgnl.Text = "chart1";
            // 
            // label_amplitude1
            // 
            label_amplitude1.AutoSize = true;
            label_amplitude1.Location = new System.Drawing.Point(6, 21);
            label_amplitude1.Name = "label_amplitude1";
            label_amplitude1.Size = new System.Drawing.Size(23, 13);
            label_amplitude1.TabIndex = 3;
            label_amplitude1.Text = "A =";
            // 
            // label_standartDeviation1
            // 
            label_standartDeviation1.AutoSize = true;
            label_standartDeviation1.Location = new System.Drawing.Point(6, 47);
            label_standartDeviation1.Name = "label_standartDeviation1";
            label_standartDeviation1.Size = new System.Drawing.Size(23, 13);
            label_standartDeviation1.TabIndex = 4;
            label_standartDeviation1.Text = "σ =";
            // 
            // label_mathExpectation1
            // 
            label_mathExpectation1.AutoSize = true;
            label_mathExpectation1.Location = new System.Drawing.Point(6, 73);
            label_mathExpectation1.Name = "label_mathExpectation1";
            label_mathExpectation1.Size = new System.Drawing.Size(28, 13);
            label_mathExpectation1.TabIndex = 5;
            label_mathExpectation1.Text = "t0 = ";
            // 
            // label_mathExpectation2
            // 
            label_mathExpectation2.AutoSize = true;
            label_mathExpectation2.Location = new System.Drawing.Point(6, 73);
            label_mathExpectation2.Name = "label_mathExpectation2";
            label_mathExpectation2.Size = new System.Drawing.Size(28, 13);
            label_mathExpectation2.TabIndex = 5;
            label_mathExpectation2.Text = "t0 = ";
            // 
            // label_standartDeviation2
            // 
            label_standartDeviation2.AutoSize = true;
            label_standartDeviation2.Location = new System.Drawing.Point(6, 47);
            label_standartDeviation2.Name = "label_standartDeviation2";
            label_standartDeviation2.Size = new System.Drawing.Size(23, 13);
            label_standartDeviation2.TabIndex = 4;
            label_standartDeviation2.Text = "σ =";
            // 
            // label_amplitude2
            // 
            label_amplitude2.AutoSize = true;
            label_amplitude2.Location = new System.Drawing.Point(6, 21);
            label_amplitude2.Name = "label_amplitude2";
            label_amplitude2.Size = new System.Drawing.Size(23, 13);
            label_amplitude2.TabIndex = 3;
            label_amplitude2.Text = "A =";
            // 
            // label_mathExpectation3
            // 
            label_mathExpectation3.AutoSize = true;
            label_mathExpectation3.Location = new System.Drawing.Point(6, 73);
            label_mathExpectation3.Name = "label_mathExpectation3";
            label_mathExpectation3.Size = new System.Drawing.Size(28, 13);
            label_mathExpectation3.TabIndex = 5;
            label_mathExpectation3.Text = "t0 = ";
            // 
            // label_standartDeviation3
            // 
            label_standartDeviation3.AutoSize = true;
            label_standartDeviation3.Location = new System.Drawing.Point(6, 47);
            label_standartDeviation3.Name = "label_standartDeviation3";
            label_standartDeviation3.Size = new System.Drawing.Size(23, 13);
            label_standartDeviation3.TabIndex = 4;
            label_standartDeviation3.Text = "σ =";
            // 
            // label_amplitude3
            // 
            label_amplitude3.AutoSize = true;
            label_amplitude3.Location = new System.Drawing.Point(6, 21);
            label_amplitude3.Name = "label_amplitude3";
            label_amplitude3.Size = new System.Drawing.Size(23, 13);
            label_amplitude3.TabIndex = 3;
            label_amplitude3.Text = "A =";
            // 
            // label__amplitudePR
            // 
            label__amplitudePR.AutoSize = true;
            label__amplitudePR.Location = new System.Drawing.Point(6, 21);
            label__amplitudePR.Name = "label__amplitudePR";
            label__amplitudePR.Size = new System.Drawing.Size(23, 13);
            label__amplitudePR.TabIndex = 2;
            label__amplitudePR.Text = "A =";
            // 
            // label_standartDeviationPR
            // 
            label_standartDeviationPR.AutoSize = true;
            label_standartDeviationPR.Location = new System.Drawing.Point(6, 47);
            label_standartDeviationPR.Name = "label_standartDeviationPR";
            label_standartDeviationPR.Size = new System.Drawing.Size(23, 13);
            label_standartDeviationPR.TabIndex = 3;
            label_standartDeviationPR.Text = "σ =";
            // 
            // label_energyNoise
            // 
            label_energyNoise.AutoSize = true;
            label_energyNoise.Location = new System.Drawing.Point(6, 21);
            label_energyNoise.Name = "label_energyNoise";
            label_energyNoise.Size = new System.Drawing.Size(69, 13);
            label_energyNoise.TabIndex = 2;
            label_energyNoise.Text = "Энергия (%):";
            // 
            // label_onoffNoise
            // 
            label_onoffNoise.AutoSize = true;
            label_onoffNoise.Location = new System.Drawing.Point(6, 45);
            label_onoffNoise.Name = "label_onoffNoise";
            label_onoffNoise.Size = new System.Drawing.Size(162, 13);
            label_onoffNoise.TabIndex = 3;
            label_onoffNoise.Text = "Наложения шума (вкл / выкл):";
            // 
            // label_valueFunctional
            // 
            label_valueFunctional.AutoSize = true;
            label_valueFunctional.Location = new System.Drawing.Point(69, 30);
            label_valueFunctional.Name = "label_valueFunctional";
            label_valueFunctional.Size = new System.Drawing.Size(128, 13);
            label_valueFunctional.TabIndex = 4;
            label_valueFunctional.Text = "Значение функционала:";
            // 
            // label_accuracy
            // 
            label_accuracy.AutoSize = true;
            label_accuracy.Location = new System.Drawing.Point(359, 30);
            label_accuracy.Name = "label_accuracy";
            label_accuracy.Size = new System.Drawing.Size(57, 13);
            label_accuracy.TabIndex = 5;
            label_accuracy.Text = "Точность:";
            // 
            // label_deviation
            // 
            label_deviation.AutoSize = true;
            label_deviation.Location = new System.Drawing.Point(508, 29);
            label_deviation.Name = "label_deviation";
            label_deviation.Size = new System.Drawing.Size(71, 13);
            label_deviation.TabIndex = 6;
            label_deviation.Text = "Отклонение:";
            // 
            // groupBox_deconvolution
            // 
            this.groupBox_deconvolution.Controls.Add(label_deviation);
            this.groupBox_deconvolution.Controls.Add(label_accuracy);
            this.groupBox_deconvolution.Controls.Add(label_valueFunctional);
            this.groupBox_deconvolution.Controls.Add(this.textBox_accuracy);
            this.groupBox_deconvolution.Controls.Add(this.textBox_deviation);
            this.groupBox_deconvolution.Controls.Add(this.textBox_valueFunctional);
            this.groupBox_deconvolution.Controls.Add(this.button_Start);
            this.groupBox_deconvolution.Location = new System.Drawing.Point(231, 488);
            this.groupBox_deconvolution.Name = "groupBox_deconvolution";
            this.groupBox_deconvolution.Size = new System.Drawing.Size(741, 61);
            this.groupBox_deconvolution.TabIndex = 1;
            this.groupBox_deconvolution.TabStop = false;
            this.groupBox_deconvolution.Text = "Деконволюция свёртки";
            // 
            // textBox_accuracy
            // 
            this.textBox_accuracy.Location = new System.Drawing.Point(422, 26);
            this.textBox_accuracy.Name = "textBox_accuracy";
            this.textBox_accuracy.Size = new System.Drawing.Size(80, 20);
            this.textBox_accuracy.TabIndex = 3;
            this.textBox_accuracy.Text = "1,0E-6";
            this.textBox_accuracy.WordWrap = false;
            // 
            // textBox_deviation
            // 
            this.textBox_deviation.Location = new System.Drawing.Point(585, 26);
            this.textBox_deviation.Name = "textBox_deviation";
            this.textBox_deviation.ReadOnly = true;
            this.textBox_deviation.Size = new System.Drawing.Size(150, 20);
            this.textBox_deviation.TabIndex = 2;
            // 
            // textBox_valueFunctional
            // 
            this.textBox_valueFunctional.Location = new System.Drawing.Point(203, 26);
            this.textBox_valueFunctional.Name = "textBox_valueFunctional";
            this.textBox_valueFunctional.ReadOnly = true;
            this.textBox_valueFunctional.Size = new System.Drawing.Size(150, 20);
            this.textBox_valueFunctional.TabIndex = 1;
            // 
            // button_Start
            // 
            this.button_Start.Enabled = false;
            this.button_Start.Location = new System.Drawing.Point(6, 15);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(50, 40);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.Click += new System.EventHandler(this.OnClickButtonStart);
            // 
            // groupBox_paramSgnl
            // 
            this.groupBox_paramSgnl.Controls.Add(this.groupBox_dome3);
            this.groupBox_paramSgnl.Controls.Add(this.groupBox_dome2);
            this.groupBox_paramSgnl.Controls.Add(this.groupBox_dome1);
            this.groupBox_paramSgnl.Location = new System.Drawing.Point(12, 13);
            this.groupBox_paramSgnl.Name = "groupBox_paramSgnl";
            this.groupBox_paramSgnl.Size = new System.Drawing.Size(213, 331);
            this.groupBox_paramSgnl.TabIndex = 2;
            this.groupBox_paramSgnl.TabStop = false;
            this.groupBox_paramSgnl.Text = "Параметра сигнала";
            // 
            // groupBox_dome3
            // 
            this.groupBox_dome3.Controls.Add(label_mathExpectation3);
            this.groupBox_dome3.Controls.Add(label_standartDeviation3);
            this.groupBox_dome3.Controls.Add(label_amplitude3);
            this.groupBox_dome3.Controls.Add(this.numUpDown_mathExpectation3);
            this.groupBox_dome3.Controls.Add(this.numUpDown_standartDeviation3);
            this.groupBox_dome3.Controls.Add(this.numUpDown_amplitude3);
            this.groupBox_dome3.Location = new System.Drawing.Point(6, 227);
            this.groupBox_dome3.Name = "groupBox_dome3";
            this.groupBox_dome3.Size = new System.Drawing.Size(201, 98);
            this.groupBox_dome3.TabIndex = 2;
            this.groupBox_dome3.TabStop = false;
            this.groupBox_dome3.Text = "Купол №3";
            // 
            // numUpDown_mathExpectation3
            // 
            this.numUpDown_mathExpectation3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_mathExpectation3.DecimalPlaces = 1;
            this.numUpDown_mathExpectation3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_mathExpectation3.Location = new System.Drawing.Point(100, 71);
            this.numUpDown_mathExpectation3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_mathExpectation3.Name = "numUpDown_mathExpectation3";
            this.numUpDown_mathExpectation3.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_mathExpectation3.TabIndex = 2;
            this.numUpDown_mathExpectation3.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numUpDown_standartDeviation3
            // 
            this.numUpDown_standartDeviation3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_standartDeviation3.DecimalPlaces = 1;
            this.numUpDown_standartDeviation3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_standartDeviation3.Location = new System.Drawing.Point(100, 45);
            this.numUpDown_standartDeviation3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_standartDeviation3.Name = "numUpDown_standartDeviation3";
            this.numUpDown_standartDeviation3.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_standartDeviation3.TabIndex = 1;
            this.numUpDown_standartDeviation3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numUpDown_amplitude3
            // 
            this.numUpDown_amplitude3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_amplitude3.DecimalPlaces = 1;
            this.numUpDown_amplitude3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_amplitude3.Location = new System.Drawing.Point(100, 19);
            this.numUpDown_amplitude3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_amplitude3.Name = "numUpDown_amplitude3";
            this.numUpDown_amplitude3.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_amplitude3.TabIndex = 0;
            this.numUpDown_amplitude3.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            // 
            // groupBox_dome2
            // 
            this.groupBox_dome2.Controls.Add(label_mathExpectation2);
            this.groupBox_dome2.Controls.Add(label_standartDeviation2);
            this.groupBox_dome2.Controls.Add(label_amplitude2);
            this.groupBox_dome2.Controls.Add(this.numUpDown_mathExpectation2);
            this.groupBox_dome2.Controls.Add(this.numUpDown_standartDeviation2);
            this.groupBox_dome2.Controls.Add(this.numUpDown_amplitude2);
            this.groupBox_dome2.Location = new System.Drawing.Point(6, 123);
            this.groupBox_dome2.Name = "groupBox_dome2";
            this.groupBox_dome2.Size = new System.Drawing.Size(201, 98);
            this.groupBox_dome2.TabIndex = 1;
            this.groupBox_dome2.TabStop = false;
            this.groupBox_dome2.Text = "Купол №2";
            // 
            // numUpDown_mathExpectation2
            // 
            this.numUpDown_mathExpectation2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_mathExpectation2.DecimalPlaces = 1;
            this.numUpDown_mathExpectation2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_mathExpectation2.Location = new System.Drawing.Point(100, 71);
            this.numUpDown_mathExpectation2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_mathExpectation2.Name = "numUpDown_mathExpectation2";
            this.numUpDown_mathExpectation2.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_mathExpectation2.TabIndex = 2;
            this.numUpDown_mathExpectation2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numUpDown_standartDeviation2
            // 
            this.numUpDown_standartDeviation2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_standartDeviation2.DecimalPlaces = 1;
            this.numUpDown_standartDeviation2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_standartDeviation2.Location = new System.Drawing.Point(100, 45);
            this.numUpDown_standartDeviation2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_standartDeviation2.Name = "numUpDown_standartDeviation2";
            this.numUpDown_standartDeviation2.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_standartDeviation2.TabIndex = 1;
            this.numUpDown_standartDeviation2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numUpDown_amplitude2
            // 
            this.numUpDown_amplitude2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_amplitude2.DecimalPlaces = 1;
            this.numUpDown_amplitude2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_amplitude2.Location = new System.Drawing.Point(100, 19);
            this.numUpDown_amplitude2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_amplitude2.Name = "numUpDown_amplitude2";
            this.numUpDown_amplitude2.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_amplitude2.TabIndex = 0;
            this.numUpDown_amplitude2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox_dome1
            // 
            this.groupBox_dome1.Controls.Add(label_mathExpectation1);
            this.groupBox_dome1.Controls.Add(label_standartDeviation1);
            this.groupBox_dome1.Controls.Add(label_amplitude1);
            this.groupBox_dome1.Controls.Add(this.numUpDown_mathExpectation1);
            this.groupBox_dome1.Controls.Add(this.numUpDown_standartDeviation1);
            this.groupBox_dome1.Controls.Add(this.numUpDown_amplitude1);
            this.groupBox_dome1.Location = new System.Drawing.Point(6, 19);
            this.groupBox_dome1.Name = "groupBox_dome1";
            this.groupBox_dome1.Size = new System.Drawing.Size(201, 98);
            this.groupBox_dome1.TabIndex = 0;
            this.groupBox_dome1.TabStop = false;
            this.groupBox_dome1.Text = "Купол №1";
            // 
            // numUpDown_mathExpectation1
            // 
            this.numUpDown_mathExpectation1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_mathExpectation1.DecimalPlaces = 1;
            this.numUpDown_mathExpectation1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_mathExpectation1.Location = new System.Drawing.Point(100, 71);
            this.numUpDown_mathExpectation1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_mathExpectation1.Name = "numUpDown_mathExpectation1";
            this.numUpDown_mathExpectation1.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_mathExpectation1.TabIndex = 2;
            this.numUpDown_mathExpectation1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numUpDown_standartDeviation1
            // 
            this.numUpDown_standartDeviation1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_standartDeviation1.DecimalPlaces = 1;
            this.numUpDown_standartDeviation1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_standartDeviation1.Location = new System.Drawing.Point(100, 45);
            this.numUpDown_standartDeviation1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_standartDeviation1.Name = "numUpDown_standartDeviation1";
            this.numUpDown_standartDeviation1.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_standartDeviation1.TabIndex = 1;
            this.numUpDown_standartDeviation1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numUpDown_amplitude1
            // 
            this.numUpDown_amplitude1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_amplitude1.DecimalPlaces = 1;
            this.numUpDown_amplitude1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_amplitude1.Location = new System.Drawing.Point(100, 19);
            this.numUpDown_amplitude1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_amplitude1.Name = "numUpDown_amplitude1";
            this.numUpDown_amplitude1.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_amplitude1.TabIndex = 0;
            this.numUpDown_amplitude1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox_pulseResponse
            // 
            this.groupBox_pulseResponse.Controls.Add(label_standartDeviationPR);
            this.groupBox_pulseResponse.Controls.Add(label__amplitudePR);
            this.groupBox_pulseResponse.Controls.Add(this.numUpDown_standartDeviationPR);
            this.groupBox_pulseResponse.Controls.Add(this.numUpDown_amplitudePR);
            this.groupBox_pulseResponse.Location = new System.Drawing.Point(12, 350);
            this.groupBox_pulseResponse.Name = "groupBox_pulseResponse";
            this.groupBox_pulseResponse.Size = new System.Drawing.Size(213, 71);
            this.groupBox_pulseResponse.TabIndex = 3;
            this.groupBox_pulseResponse.TabStop = false;
            this.groupBox_pulseResponse.Text = "Испульсная характеристика";
            // 
            // numUpDown_standartDeviationPR
            // 
            this.numUpDown_standartDeviationPR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_standartDeviationPR.DecimalPlaces = 1;
            this.numUpDown_standartDeviationPR.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_standartDeviationPR.Location = new System.Drawing.Point(106, 45);
            this.numUpDown_standartDeviationPR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_standartDeviationPR.Name = "numUpDown_standartDeviationPR";
            this.numUpDown_standartDeviationPR.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_standartDeviationPR.TabIndex = 1;
            this.numUpDown_standartDeviationPR.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numUpDown_amplitudePR
            // 
            this.numUpDown_amplitudePR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_amplitudePR.DecimalPlaces = 1;
            this.numUpDown_amplitudePR.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUpDown_amplitudePR.Location = new System.Drawing.Point(106, 19);
            this.numUpDown_amplitudePR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDown_amplitudePR.Name = "numUpDown_amplitudePR";
            this.numUpDown_amplitudePR.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_amplitudePR.TabIndex = 0;
            this.numUpDown_amplitudePR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox_paramNoise
            // 
            this.groupBox_paramNoise.Controls.Add(label_onoffNoise);
            this.groupBox_paramNoise.Controls.Add(label_energyNoise);
            this.groupBox_paramNoise.Controls.Add(this.checkBox_onoffNoise);
            this.groupBox_paramNoise.Controls.Add(this.numUpDown_energyNoise);
            this.groupBox_paramNoise.Location = new System.Drawing.Point(12, 427);
            this.groupBox_paramNoise.Name = "groupBox_paramNoise";
            this.groupBox_paramNoise.Size = new System.Drawing.Size(213, 81);
            this.groupBox_paramNoise.TabIndex = 4;
            this.groupBox_paramNoise.TabStop = false;
            this.groupBox_paramNoise.Text = "Параметры шума";
            // 
            // checkBox_onoffNoise
            // 
            this.checkBox_onoffNoise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_onoffNoise.AutoSize = true;
            this.checkBox_onoffNoise.Location = new System.Drawing.Point(178, 45);
            this.checkBox_onoffNoise.Name = "checkBox_onoffNoise";
            this.checkBox_onoffNoise.Size = new System.Drawing.Size(15, 14);
            this.checkBox_onoffNoise.TabIndex = 1;
            this.checkBox_onoffNoise.UseVisualStyleBackColor = true;
            // 
            // numUpDown_energyNoise
            // 
            this.numUpDown_energyNoise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDown_energyNoise.DecimalPlaces = 1;
            this.numUpDown_energyNoise.Location = new System.Drawing.Point(106, 19);
            this.numUpDown_energyNoise.Name = "numUpDown_energyNoise";
            this.numUpDown_energyNoise.Size = new System.Drawing.Size(95, 20);
            this.numUpDown_energyNoise.TabIndex = 0;
            this.numUpDown_energyNoise.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_generateSgnl
            // 
            this.button_generateSgnl.Location = new System.Drawing.Point(12, 518);
            this.button_generateSgnl.Name = "button_generateSgnl";
            this.button_generateSgnl.Size = new System.Drawing.Size(213, 25);
            this.button_generateSgnl.TabIndex = 5;
            this.button_generateSgnl.Text = "Сгенерировать";
            this.button_generateSgnl.UseVisualStyleBackColor = true;
            this.button_generateSgnl.Click += new System.EventHandler(this.OnClickButtonGenerateSgnl);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTickTimer);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 556);
            this.Controls.Add(this.button_generateSgnl);
            this.Controls.Add(this.groupBox_paramNoise);
            this.Controls.Add(this.groupBox_pulseResponse);
            this.Controls.Add(this.groupBox_paramSgnl);
            this.Controls.Add(this.groupBox_deconvolution);
            this.Controls.Add(groupBox_pulseResponse_outputSgnl);
            this.Controls.Add(groupBoxgraph_graphInputReconstSgnls);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "ННГУ ИТФИ | Деконволюция свёртки методом максимума энтропии";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            groupBoxgraph_graphInputReconstSgnls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphInitReconstSgnl)).EndInit();
            groupBox_pulseResponse_outputSgnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphPulseResponseOutSgnl)).EndInit();
            this.groupBox_deconvolution.ResumeLayout(false);
            this.groupBox_deconvolution.PerformLayout();
            this.groupBox_paramSgnl.ResumeLayout(false);
            this.groupBox_dome3.ResumeLayout(false);
            this.groupBox_dome3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_mathExpectation3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_standartDeviation3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amplitude3)).EndInit();
            this.groupBox_dome2.ResumeLayout(false);
            this.groupBox_dome2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_mathExpectation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_standartDeviation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amplitude2)).EndInit();
            this.groupBox_dome1.ResumeLayout(false);
            this.groupBox_dome1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_mathExpectation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_standartDeviation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amplitude1)).EndInit();
            this.groupBox_pulseResponse.ResumeLayout(false);
            this.groupBox_pulseResponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_standartDeviationPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_amplitudePR)).EndInit();
            this.groupBox_paramNoise.ResumeLayout(false);
            this.groupBox_paramNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_energyNoise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_deconvolution;
        private System.Windows.Forms.GroupBox groupBox_paramSgnl;
        private System.Windows.Forms.GroupBox groupBox_dome3;
        private System.Windows.Forms.NumericUpDown numUpDown_mathExpectation3;
        private System.Windows.Forms.NumericUpDown numUpDown_standartDeviation3;
        private System.Windows.Forms.NumericUpDown numUpDown_amplitude3;
        private System.Windows.Forms.GroupBox groupBox_dome2;
        private System.Windows.Forms.NumericUpDown numUpDown_mathExpectation2;
        private System.Windows.Forms.NumericUpDown numUpDown_standartDeviation2;
        private System.Windows.Forms.NumericUpDown numUpDown_amplitude2;
        private System.Windows.Forms.GroupBox groupBox_dome1;
        private System.Windows.Forms.NumericUpDown numUpDown_mathExpectation1;
        private System.Windows.Forms.NumericUpDown numUpDown_standartDeviation1;
        private System.Windows.Forms.NumericUpDown numUpDown_amplitude1;
        private System.Windows.Forms.GroupBox groupBox_pulseResponse;
        private System.Windows.Forms.NumericUpDown numUpDown_standartDeviationPR;
        private System.Windows.Forms.NumericUpDown numUpDown_amplitudePR;
        private System.Windows.Forms.GroupBox groupBox_paramNoise;
        private System.Windows.Forms.CheckBox checkBox_onoffNoise;
        private System.Windows.Forms.NumericUpDown numUpDown_energyNoise;
        private System.Windows.Forms.TextBox textBox_accuracy;
        private System.Windows.Forms.TextBox textBox_deviation;
        private System.Windows.Forms.TextBox textBox_valueFunctional;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_generateSgnl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphInitReconstSgnl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphPulseResponseOutSgnl;
    }
}

