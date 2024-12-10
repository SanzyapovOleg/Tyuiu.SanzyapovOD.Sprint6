using Tyuiu.SanzyapovOD.Sprint6.Task2.V14.Lib;
namespace Tyuiu.SanzyapovOD.Sprint6.Task2.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxMain_TDA = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxInput_TDA = new GroupBox();
            labelVarEnd_TDA = new Label();
            textBoxVarEnd_TDA = new TextBox();
            labelVarStart_TDA = new Label();
            textBoxVarStart_TDA = new TextBox();
            groupBoxOutput_TDA = new GroupBox();
            dataGridView1 = new DataGridView();
            labelResult_TDA = new Label();
            button1 = new Button();
            button2 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxMain_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput_TDA.SuspendLayout();
            groupBoxOutput_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMain_TDA
            // 
            groupBoxMain_TDA.AccessibleName = "Условие";
            groupBoxMain_TDA.Controls.Add(pictureBox1);
            groupBoxMain_TDA.Location = new Point(6, 12);
            groupBoxMain_TDA.Name = "groupBoxMain_TDA";
            groupBoxMain_TDA.Size = new Size(651, 255);
            groupBoxMain_TDA.TabIndex = 0;
            groupBoxMain_TDA.TabStop = false;
            groupBoxMain_TDA.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1313;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 227);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxInput_TDA
            // 
            groupBoxInput_TDA.Controls.Add(labelVarEnd_TDA);
            groupBoxInput_TDA.Controls.Add(textBoxVarEnd_TDA);
            groupBoxInput_TDA.Controls.Add(labelVarStart_TDA);
            groupBoxInput_TDA.Controls.Add(textBoxVarStart_TDA);
            groupBoxInput_TDA.Location = new Point(6, 273);
            groupBoxInput_TDA.Name = "groupBoxInput_TDA";
            groupBoxInput_TDA.Size = new Size(455, 85);
            groupBoxInput_TDA.TabIndex = 1;
            groupBoxInput_TDA.TabStop = false;
            groupBoxInput_TDA.Text = "Ввод данных";
            // 
            // labelVarEnd_TDA
            // 
            labelVarEnd_TDA.AutoSize = true;
            labelVarEnd_TDA.Location = new Point(263, 26);
            labelVarEnd_TDA.Name = "labelVarEnd_TDA";
            labelVarEnd_TDA.Size = new Size(72, 15);
            labelVarEnd_TDA.TabIndex = 3;
            labelVarEnd_TDA.Text = "Конец шага\r\n";
            // 
            // textBoxVarEnd_TDA
            // 
            textBoxVarEnd_TDA.Location = new Point(263, 44);
            textBoxVarEnd_TDA.Name = "textBoxVarEnd_TDA";
            textBoxVarEnd_TDA.Size = new Size(180, 23);
            textBoxVarEnd_TDA.TabIndex = 2;
            // 
            // labelVarStart_TDA
            // 
            labelVarStart_TDA.AutoSize = true;
            labelVarStart_TDA.Location = new Point(24, 26);
            labelVarStart_TDA.Name = "labelVarStart_TDA";
            labelVarStart_TDA.Size = new Size(69, 15);
            labelVarStart_TDA.TabIndex = 1;
            labelVarStart_TDA.Text = "Старт шага\r\n";
            // 
            // textBoxVarStart_TDA
            // 
            textBoxVarStart_TDA.Location = new Point(24, 44);
            textBoxVarStart_TDA.Multiline = true;
            textBoxVarStart_TDA.Name = "textBoxVarStart_TDA";
            textBoxVarStart_TDA.Size = new Size(166, 23);
            textBoxVarStart_TDA.TabIndex = 4;
            // 
            // groupBoxOutput_TDA
            // 
            groupBoxOutput_TDA.Controls.Add(dataGridView1);
            groupBoxOutput_TDA.Controls.Add(labelResult_TDA);
            groupBoxOutput_TDA.Location = new Point(663, 12);
            groupBoxOutput_TDA.Name = "groupBoxOutput_TDA";
            groupBoxOutput_TDA.Size = new Size(329, 346);
            groupBoxOutput_TDA.TabIndex = 2;
            groupBoxOutput_TDA.TabStop = false;
            groupBoxOutput_TDA.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(317, 296);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelResult_TDA
            // 
            labelResult_TDA.AutoSize = true;
            labelResult_TDA.Location = new Point(6, 26);
            labelResult_TDA.Name = "labelResult_TDA";
            labelResult_TDA.Size = new Size(63, 15);
            labelResult_TDA.TabIndex = 1;
            labelResult_TDA.Text = "Результат:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(468, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 65);
            button1.TabIndex = 3;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(549, 287);
            button2.Name = "button2";
            button2.Size = new Size(103, 65);
            button2.TabIndex = 4;
            button2.Text = "Выполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(998, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(469, 340);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 379);
            Controls.Add(chart1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBoxOutput_TDA);
            Controls.Add(groupBoxInput_TDA);
            Controls.Add(groupBoxMain_TDA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Санзяпов О.Д.";
            groupBoxMain_TDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInput_TDA.ResumeLayout(false);
            groupBoxInput_TDA.PerformLayout();
            groupBoxOutput_TDA.ResumeLayout(false);
            groupBoxOutput_TDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_TDA;
        private GroupBox groupBoxInput_TDA;
        private GroupBox groupBoxOutput_TDA;
        private Label labelResult_TDA;
        private TextBox textBoxVarStart_TDA;
        private Label labelVarStart_TDA;
        private Label labelVarEnd_TDA;
        private TextBox textBoxVarEnd_TDA;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}