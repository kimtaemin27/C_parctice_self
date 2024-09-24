namespace Project08_3
{

    class Program
    {

        static void Main(string[] args)
        {
            // 영문 대문자로 전환해 주는 ToUpper() 메서드
            // 영문 소문자로 전환해 주는 ToLower() 메서드
            // 공백을 제거하는 Trim() 메서드

            string str = "  한글  ABCD   efgh   $#@!    ";
            
            Console.WriteLine("원본 문자열 => [" + str + "]");
            Console.WriteLine("대문자로 => [" + str.ToUpper() + "]");
            Console.WriteLine("소문자로 => [" + str.ToLower() + "]");
            Console.WriteLine("공백제거 => [" + str.Trim() + "]");


            // 모든 공백 없애기
            string resStr1 = "", resStr2 = "";

            Console.WriteLine("원본 문자열 => [" + str + "]");
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    resStr1 += str[i];
            }
            Console.WriteLine("공백제거(직접 한 글자씩) => [" + resStr1 + "]");

            resStr2 = str.Replace(" ", "");
            Console.WriteLine("공백제거(Replace 메서드) => [" + resStr2 + "]");
        }

    }

}