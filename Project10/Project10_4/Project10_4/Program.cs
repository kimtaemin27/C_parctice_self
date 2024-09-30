namespace Project10_4
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string[] inStrAry;
            string fName;

            Console.Write("파일명을 입력하세요 : ");
            fName = Console.ReadLine();

            inStrAry = File.ReadAllLines(fName);

            foreach(string inStr in inStrAry)
            {
                Console.WriteLine(inStr);
            }
        }

    }

}