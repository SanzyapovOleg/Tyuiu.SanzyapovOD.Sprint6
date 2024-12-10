using Tyuiu.SanzyapovOD.Sprint6.Task3.V17.Lib;
namespace Tyuiu.SanzyapovOD.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 22, 32, -16, 24, 27 },
                                          { 3, -20, 24, -20, 25 },
                                          { 21, 17, -8, -19, 17 },
                                          { 8, 22, 28, 27, 19 },
                                          { 11, 20, 12, 27, 29 } };
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-24-1 Санзяпов Олег Дмитриевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    textBox2.AppendText($"{mtrx[i, j]} \t");
                }
                textBox2.AppendText(Environment.NewLine);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
