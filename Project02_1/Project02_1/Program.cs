// 계산기 프로그램 만들기 1

namespace Project02_1 {

    class Progran {
        
        static void Main(string[] args)
        {
            int a, b;
            int result;

            a = 100;
            b = 50;

            result = a + b;
            Console.WriteLine(a + " + " + b + " = " + result);

            result = a - b;
            Console.WriteLine(a + " - " + b + " = " + result);

            result = a * b;
            Console.WriteLine(a + " * " + b + " = " + result);

            result = a / b;
            Console.WriteLine(a + " / "  + b + " = " + result);
        }
    }
}