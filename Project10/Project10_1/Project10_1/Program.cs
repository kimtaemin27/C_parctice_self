namespace Project10_1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            StreamReader inFp;
            string inStr;

            inFp = new StreamReader("C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\text\\test.txt");

            inStr = inFp.ReadLine();
            Console.WriteLine(inStr);

            inStr = inFp.ReadLine();
            Console.WriteLine(inStr);

            inStr = inFp.ReadLine();
            Console.WriteLine(inStr);

            inFp.Close();
        }

    }

}