namespace Project07_1
{

    class Program
    {

        static void Main(string[] args)
        {
            int a, b, c, d;
            int hap;

            Console.Write("1번째 숫자 입력 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("2번째 숫자 입력 : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("3번째 숫자 입력 : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("4번째 숫자 입력 : ");
            d = int.Parse(Console.ReadLine());

            hap = a + b + c + d;

            Console.WriteLine("합계 => {0}", hap);


            // int 형 배열에 값을 대입하고 출력
            int[] aa = new int[4];
             hap = 0;

            Console.Write("1번째 숫자를 입력하세요 : ");
            aa[0] = int.Parse(Console.ReadLine());
            Console.Write("2번째 숫자를 입력하세요 : ");
            aa[1] = int.Parse(Console.ReadLine());
            Console.Write("3번째 숫자를 입력하세요 : ");
            aa[2] = int.Parse(Console.ReadLine());
            Console.Write("4번째 숫자를 입력하세요 : ");
            aa[3] = int.Parse(Console.ReadLine());

            hap = aa[0] + aa[1] + aa[2] + aa[3];

            Console.WriteLine("합계 => {0}", hap);
        }

    }

}