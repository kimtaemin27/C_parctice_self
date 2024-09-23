namespace Project03_6
{

    class Program
    {

        static void Main(string[] args)
        {
            // 정수형
            int n1 = 100, n2 = 200;
            float result;

            result = n1 / n2;
            Console.WriteLine(String.Format("{0:F}", result));

            // 실수형
            float flt = 0.12345678901234567890123456789f;
            double dbl = 0.12345678901234567890123456789;
            decimal dec = 0.12345678901234567890123456789m;

            Console.WriteLine(flt);
            Console.WriteLine(dbl);
            Console.WriteLine(dec);

            // 불 형
            bool b1 = true;
            bool b2 = (100 == 100);
            bool b3 = (10 > 100);

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);

            // 문자형
            char ch1 = 'A';
            char ch2 = '\u0041';
            char ch3 = '가';
            char ch4 = '\uAC00';

            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(ch4);
            Console.WriteLine((char)(ch1 + 1));
            Console.WriteLine((char)(ch3 + 1));

            // 문자열형
            string str1 = "IT CookBook~";
            string str2 = "C#";
            string str3 = str1 + str2;

            Console.WriteLine(str3);
            Console.WriteLine(str2.Length);
            Console.WriteLine(str2[0]);
            Console.WriteLine(str2[0].GetType());
            Console.WriteLine(str2[str2.Length-1]);

            // var 형
            var data1 = 100;
            var data2 = "C# 코딩";
            var data3 = 3.14f;
            var data4 = 3.14;

            Console.WriteLine(data1.GetType());
            Console.WriteLine(data2.GetType());
            Console.WriteLine(data3.GetType());
            Console.WriteLine(data4.GetType());
        }

    }

}