namespace Project08_4
{

    class Program
    {

        static void Main(string[] args)
        {
            // 두 문자열을 비교하는 CompareTo() 메서드
            // 문자열의 포함을 확인하는 Contains() 메서드
            string str1 = "C# Programming";
            string str2 = "C# IT CookBook";

            Console.WriteLine("원 문자열1 => [" + str1 + "]");
            Console.WriteLine("원 문자열2 => [" + str2 + "]");

            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str1.Contains("C#"));


            // 문자열이 숫자인지 확인하는 Char.IsDigit() 메서드
            string str;
            bool numYN = true;

            Console.Write("문자열 입력 => ");
            str = Console.ReadLine();

            Console.Write(str + " --> ");
            foreach(char c in str)
            {
                if(!Char.IsDigit(c))
                    numYN = false;
            }

            if (!numYN)
                Console.WriteLine("숫자가 아닙니다");
            else
                Console.WriteLine("숫자입니다");
        }

    }

}