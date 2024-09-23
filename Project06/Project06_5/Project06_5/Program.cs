namespace Project06_5
{

    class Program
    {

        static void Main(string[] args)
        {
            // 반복문을 탈출시키는 제어문 : break 문
            // 사용 예 1
            int i;

            for(i = 1; i < 100; i++)
            {
                Console.WriteLine("for 문 {0} 회 실행", i);
                break;
            }
            Console.WriteLine("for 문 end");


            // 사용 예 2
            int num1, num2;
            while(true)
            {
                Console.Write("값 1 입력 : ");
                num1 = int.Parse(Console.ReadLine());

                if (num1 == 0)
                    break;

                Console.Write("값 2 입력 : ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            }
            Console.WriteLine("반복문 탈출");
        }

    }

}