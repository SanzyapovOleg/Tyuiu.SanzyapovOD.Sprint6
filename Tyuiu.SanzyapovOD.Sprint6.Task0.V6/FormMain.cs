using Tyuiu.SanzyapovOD.Sprint6.Task0.V6.Lib;
namespace Tyuiu.SanzyapovOD.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBox5.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox3.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНб-24-1 Санзяпов Олег Дмитриевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
