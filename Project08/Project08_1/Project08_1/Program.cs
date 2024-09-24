namespace Project08_1
{

    class Program
    {

        static void Main(string[] args)
        {
            // 문자열의 길이를 구하는 LEngth 속성 사용
            string str = "IT CookBook C#";
            int len;

            len = str.Length;

            Console.WriteLine("문자열 : {0} ", str);
            Console.WriteLine("문자열 길이 : {0} ", len);
            // 한글, 영문, 공백, 기호 등을 각각 한 글자로 처리한다


            // 문자열 중 일부 문자를 변경
            string str2;

            Console.Write("문자열 입력 => ");
            str2 = Console.ReadLine();

            Console.Write("출력 문자열 => ");
            for(int i = 0; i < str2.Length; i++)
            {
                if (str2[i] == 'o')
                    Console.Write("{0}", "$");
                else
                    Console.Write("{0}", str2[i]);
            }
            Console.WriteLine();


            // 문자의 처음을 확인하는 StartsWith() 메서드
            // 문자의 끝을 확인하는 EndsWith() 메서드
            string str3;

            Console.Write("문자열 입력 => ");
            str3 = Console.ReadLine();

            Console.Write("출력 문자열 => ");

            if (!str3.StartsWith("("))
                Console.Write("(");

            for (int i = 0; i < str3.Length; i++)
                Console.Write("{0}", str3[i]);

            if (!str3.EndsWith(")"))
                Console.Write(")");

            Console.WriteLine();


            // 특정 문자열의 위치를 찾는 IndexOf() 메서드
            // 찾고자 하는 문자열이 여러개일경우 마지막에 나오는 위치를 알려주는 LastIndexOf() 메서드
            string str4 = "C# 공부중, C# 연습중, C# 하는중";

            Console.WriteLine("문자열 => " + str4);

            Console.Write("C# 이 처음 나오는 위치 => ");
            Console.WriteLine(str4.IndexOf("C#"));
            Console.Write("C# 이 마지막으로 나오는 위치 => ");
            Console.WriteLine(str4.LastIndexOf("C#"));


            // 특정 문자열을 다른 문자열로 대체시키는 Replace() 메서드
            string str5 = str4.Replace("C#", "씨샵");
            Console.WriteLine(str5);


            // 문자열을 추출하는 Substring() 메서드
            string str6 = str4.Substring(0, 2);
            Console.WriteLine(str6);


            // 문자열을 분리하는 Split() 메서드
            string[] str7 = str4.Split(',');
        }

    }

}