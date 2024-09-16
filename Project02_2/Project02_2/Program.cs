// 계산기 프로그램 만들기 2
namespace Project02_2{
    class Program {

        static void Main(string[] args)
        {
            int a, b;
            int result;

            string str;

            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            result = a + b;
            Console.WriteLine(a + " + " + b + " = " + result);

            result = a - b;
            Console.WriteLine(a + " - " + b + " = " + result);

            result = a * b;
            Console.WriteLine(a + " * " + b + " = " + result);

            result = a / b;
            Console.WriteLine(a + " / " + b + " = " + result);

        }
    }
}