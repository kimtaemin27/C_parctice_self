using System.Reflection.Metadata.Ecma335;

namespace Project10_2
{

    internal class Program
    {

        static void Main(string[] args)
        {
            StreamReader inFp;
            string inStr;

            inFp = new StreamReader("C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\text\\test.txt");

            while(true)
            {
                inStr = inFp.ReadLine();
                if (inStr == null)
                    break;
                Console.WriteLine(inStr);
            }

            inFp.Close();
        }

    }

}