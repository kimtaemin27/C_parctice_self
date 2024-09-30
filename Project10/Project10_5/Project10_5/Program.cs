namespace Project10_5
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string[] inStrAry;
            string fName;

            Console.Write("파일명을 입력하세요 : ");
            fName = Console.ReadLine();

            if(File.Exists(fName))
            {
                inStrAry = File.ReadAllLines(fName);

                foreach(string inStr in inStrAry)
                {
                    Console.WriteLine(inStr);
                }
            }
            else
            {
                Console.WriteLine("{0} 파일이 없습니다.", fName);
            }
        }

    }

}