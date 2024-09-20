using System.Runtime.Intrinsics.X86;

namespace Project04_1
{

    class Program
    {

        static void Main(string[] args)
        {
            int num;
            int v1 = 5, v2 = 3;

            num = v1 + v2;
            Console.WriteLine("{0:D} + {1:D} = {2:D}", v1, v2, num);

            num = v1 - v2;
            Console.WriteLine("{0:D} - {1:D} = {2:D}", v1, v2, num);

            num = v1 * v2;
            Console.WriteLine("{0:D} * {1:D} = {2:D}", v1, v2, num);

            num = v1 / v2;
            Console.WriteLine("{0:D} / {1:D} = {2:D}", v1, v2, num);

            num = v1 % v2;
            Console.WriteLine("{0:D} % {1:D} = {2:D}", v1, v2, num);


            // 연산자 우선순위와 강제 형 변환
            int a = 2, b = 3, c = 4;
            int result1, mok, namugi;
            float result2;

            result1 = a +b - c;
            Console.WriteLine("{0:D} + {1:D} - {2:D} = {3:D}", a, b, c, result1);

            result1 = a + b * c;
            Console.WriteLine("{0:D} + {1:D} * {2:D} = {3:D}", a, b, c, result1);

            result2 = a + b / (float)c;
            Console.WriteLine("{0:D} + {1:D} * {2:D} = {3:F}", a, b, c, result1);

            mok = c / b;
            Console.WriteLine("{0:D} / {1:D} dml ahrtdms {2:D}", c, b, mok);

            namugi = c % b;
            Console.WriteLine("{0:D} / {1:D} 의 나머지는 {2:D}", c, b, namugi);


            // 문자열과 숫자의 상호 변환
            string s1 = "100", s2 = "100.123";
            Console.WriteLine(int.Parse(s1) + float.Parse(s2));

            int n1 = 100;
            float n2 = 100.123f;
            Console.WriteLine(n1.ToString() + n2.ToString());


            // 대입 연산자와 증감 연산자
            num = 10;

            num++;
            Console.WriteLine("num++ => " + num);

            num--;
            Console.WriteLine("num-- => " + num);

            num+= 5;
            Console.WriteLine("num+= 5 => " + num);

            num-= 5;
            Console.WriteLine("num-= 5 => " + num);

            num*= 5;
            Console.WriteLine("num*= 5 => " + num);

            num /= 5;
            Console.WriteLine("num/= 5 => " + num);

            num %= 5;
            Console.WriteLine("num%= 5 => " + num);


            // 증감연산자의 작동 순서
            a = 10;
            b = a++;

            Console.WriteLine(b);
            b = ++a;
            Console.WriteLine(b);
        }

    }

}