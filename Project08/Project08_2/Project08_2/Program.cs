namespace Project08_2
{

    class Program
    {

        static void Main(string[] args)
        {
            string str, strRep, strSub;
            string[] strAry;

            Console.Write("문자열 입력 => ");
            str = Console.ReadLine();

            strRep = str.Replace(" ", "$");
            strSub = str.Substring(3, 8);
            strAry = str.Split(' ');

            Console.WriteLine();
            Console.WriteLine("입력 문자열 => " + str);
            Console.WriteLine("바꾼 문자열 => " + strRep);
            Console.WriteLine("일부 문자열 => " + strSub);
            for(int i = 0; i < strAry.Length; i++)
                Console.WriteLine("분리한 문자열 " + i + " => " +  strAry[i]);
        }

    }

}