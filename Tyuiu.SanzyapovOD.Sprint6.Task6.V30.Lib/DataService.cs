using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SanzyapovOD.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] words = line.Split(' ');
                    if (words.Length >= 4)
                    {

                        resStr += words[3] + " ";
                    }
                }
            }
            return resStr;
        }
    }
}
