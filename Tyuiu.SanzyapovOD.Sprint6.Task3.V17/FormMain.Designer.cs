namespace Tyuiu.SanzyapovOD.Sprint6.Task3.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            labelResult_TDA = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 367);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(223, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(317, 339);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 339);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 44);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(374, 249);
            textBox2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelResult_TDA);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(564, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 299);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // labelResult_TDA
            // 
            labelResult_TDA.AutoSize = true;
            labelResult_TDA.Location = new Point(6, 19);
            labelResult_TDA.Name = "labelResult_TDA";
            labelResult_TDA.Size = new Size(63, 15);
            labelResult_TDA.TabIndex = 2;
            labelResult_TDA.Text = "Результат:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 27F);
            button1.Location = new Point(570, 317);
            button1.Name = "button1";
            button1.Size = new Size(75, 62);
            button1.TabIndex = 5;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 27F);
            button2.Location = new Point(651, 317);
            button2.Name = "button2";
            button2.Size = new Size(224, 62);
            button2.TabIndex = 6;
            button2.Text = "Выполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 391);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 17 | Санзяпов О.Д.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Label labelResult_TDA;
        private Button button1;
        private Button button2;
    }
}
