namespace Project10_7
{

    internal class Program
    {

        static void Main(string[] args)
        {
            StreamReader inFp;
            StreamWriter outFp;
            string inStr;

            inFp = new StreamReader("C:\\windows\\win.ini");
            outFp = new StreamWriter("C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\text\\test3.txt");

            while(true)
            {
                inStr = inFp.ReadLine();
                if (inStr == null)
                    break;
                outFp.WriteLine(inStr);
            }

            inFp.Close();
            outFp.Close();
            Console.WriteLine("---정상적으로 파일이 복사되었음---");
        }

    }

}