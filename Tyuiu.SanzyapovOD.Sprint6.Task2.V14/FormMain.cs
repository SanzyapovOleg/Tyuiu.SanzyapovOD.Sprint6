using Tyuiu.SanzyapovOD.Sprint6.Task2.V14.Lib;
namespace Tyuiu.SanzyapovOD.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-24-1 Санзяпов Олег Дмитриевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_TDA.Text);
                int stopStep = Convert.ToInt32(textBoxVarEnd_TDA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chart1.Titles.Add("График функции (sin(x)/x+1,2) - sin(x) * 2 - 2x");
                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
