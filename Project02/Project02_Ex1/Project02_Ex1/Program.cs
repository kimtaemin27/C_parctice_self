// 계산기 예제 1

namespace Project02_Ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double result;

            string str;

            Console.Write("첫번째 계산할 값을 입력하세요 =>");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);

            Console.Write("두번째 계산할 값을 입력하세요 =>");
            str = Console.ReadLine();
            b = Convert.ToDouble(str);

            result = a + b;
            Console.WriteLine(a + " + " + b + " = " + result);

            result = a - b;
            Console.WriteLine(a + " - " + b + " = " + result);
            
            result = a * b;
            Console.WriteLine(a + " * " + b + " = " + result);
            
            result = a / b;
            Console.WriteLine(a + " / " + b + " = " + result);
            
            result = a % b;
            Console.WriteLine(a + " % " + b + " = " + result);
            
            result = Math.Pow(a,b);
            Console.WriteLine(a + " ^ " + b + " = " + result);
        }
    }
}