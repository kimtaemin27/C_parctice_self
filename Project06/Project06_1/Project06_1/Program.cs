namespace Project06_1
{

    class Program
    {

        static void Main(string[] args)
        {
            // for 문
            int i;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("for문");
            }

            // -- 도 사용가능
            for (i = 3; i > 0; i--)
            {
                Console.WriteLine("for문");
            }

            // 합계 구하는 법
            int hap = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;
            Console.WriteLine("1 부터 10 까지 합 : {0}", hap);

            // for 문 사용하기
            hap = 0;
            for (i = 1; i <= 10; i++)
            {
                hap = hap + i;
            }

            Console.WriteLine("1 부터 10 까지 합 : {0}", hap);


            // 500 ~ 1000 사이 홀수의 합 구하기
            hap = 0;

            for (i = 501; i <= 1000; i += 2)
            {
                hap = hap + i;
            }

            Console.WriteLine("500 부터 1000 까지 홀수의 합 : {0}", hap);


            // 1 부터 입력한 수까지의 합 구하기
            int num;
            hap = 0;

            Console.Write("값 입력 : ");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                hap = hap + i;
            }

            Console.WriteLine("1 부터 {0} 까지 합 : {1}", num, hap);


            hap = 0;
            int num1, num2, num3;

            Console.Write("시작값 입력 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("끝값 입력 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("증가값 입력 : ");
            num3 = int.Parse(Console.ReadLine());

            for (i = num1; i <= num2; i += num3)
            {
                hap = hap + i;
            }

            Console.WriteLine("{0} 부터 {1} 까지 {2} 씩 증가한 합계 : {3}", num1, num2, num3, hap);
        }

    }

}