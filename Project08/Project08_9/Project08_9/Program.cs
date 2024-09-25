namespace Project08_9
{
    // 지역 변수와 전역 변수의 비교
    internal class Program
    {
        static int a = 100;

        static void Func1()
        {
            int a = 200;
            Console.WriteLine("func1() 에서 a 의 값 = > {0} ", a);
        }


        static void Main(string[] args)
        {
            Func1();
            Console.WriteLine("Main() 에서 a 의 값 = > {0} ", a);
        }

    }

}