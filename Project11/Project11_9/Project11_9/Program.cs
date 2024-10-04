// 일반 메서드 오버로딩
namespace Project11_9
{
    class Calc
    {
        public void addValue(double v1, double v2)
        {
            Console.WriteLine("double값 계산 => {0}", (v1 + v2));
        }

        public void addValue(int v1, int v2)
        {
            Console.WriteLine("int값 계산 => {0}", (v1 + v2));
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Calc myCalc = new Calc();

            myCalc.addValue(1.1, 1.1);
            myCalc.addValue(1, 1);
        }

    }

}