namespace Project10_3
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string[] inStrAry;

            inStrAry = File.ReadAllLines("C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\text\\test.txt");
            
            foreach(string inStr in inStrAry)
            {
                Console.WriteLine(inStr);
            }
        }

    }

}