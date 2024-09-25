namespace Project08_10
{

    internal class Program
    {
        static void Func1()
        {
            Console.WriteLine("void형 메서드는 돌려줄게 없다.");
        }
        static int Func2()
        {
            return 100;
        }


        static void Main(string[] args)
        {
            int a;

            Func1();

            a = Func2();
            Console.WriteLine("int 형 메서드에서 돌려준 값 => {0}", a);
        }

    }

}