using Tyuiu.SanzyapovOD.Sprint6.Task4.V1.Lib;
namespace Tyuiu.SanzyapovOD.Sprint6.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = -5;
            int stop = 5;
            DataService ds = new DataService();
            double[] wait = new double[11];
            wait[0] = -12.18;
            wait[1] = 16.03;
            wait[2] = 18.87;
            wait[3] = 4.96;
            wait[4] = -9.99;
            wait[5] = -2.00;
            wait[6] = 2.16;
            wait[7] = -7.54;
            wait[8] = -22.76;
            wait[9] = -20.45;
            wait[10] = 7.77;
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}