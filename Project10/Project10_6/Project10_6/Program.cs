namespace Project10_6
{

    internal class Program
    {

        static void Main(string[] args)
        {
            // 출력 파일
            StreamWriter outFp;
            // 출력 문자열
            string outStr;
            string fName;

            outFp = new StreamWriter("C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\text\\test2.txt");

            while(true)
            {
                Console.Write("내용 입력 : ");
                outStr = Console.ReadLine();

                if (outStr != "")
                    outFp.WriteLine(outStr);
                else
                    break;
            }

            outFp.Close();
            Console.WriteLine("---정상적으로 파일에 써짐---");
        }

    }

}