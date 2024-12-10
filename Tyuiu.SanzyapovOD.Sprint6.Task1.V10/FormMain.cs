using Tyuiu.SanzyapovOD.Sprint6.Task1.V10.Lib;
namespace Tyuiu.SanzyapovOD.Sprint6.Task1.V10
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-24-1 Санзяпов Олег Дмитриевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_TDA.Text);
                int endStep = Convert.ToInt32(textBoxVarEnd_TDA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, endStep).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep,endStep);
                textBoxResult_TDA.Text = "";
                textBoxResult_TDA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_TDA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_TDA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_TDA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_TDA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void textBoxVarStart_TDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TDA_TextChanged(object sender, EventArgs e)
        {

        }
    }

}