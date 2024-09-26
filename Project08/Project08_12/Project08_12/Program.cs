namespace Project08_12
{

    internal class Program
    {
        static void Func1(int a)
        {
            a = a + 1;
            Console.WriteLine("전달받은 a => {0}", a);
        }

        static void Func2(ref int a)
        {
            // ref 는 예약어
            // ref는 Reference 는 참조의 약자로
            // 전달할 때에 값이아닌 주소를 전달한다.
            a = a + 1;
            Console.WriteLine("전달받은 a => {0}", a);
        }

        static void Main(string[] args)
        {
            int a = 10;
            
            Func1(a);
            Console.WriteLine("Func1() 실행 후의 a => {0}", a);

            a = 10;
            Func2(ref a);
            Console.WriteLine("Func2() 실행 후의 a => {0}", a);
        }

    }

}