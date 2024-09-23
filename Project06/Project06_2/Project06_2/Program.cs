using System.Runtime.CompilerServices;

namespace Project06_2
{

    class Program
    {

        static void Main(string[] args)
        {
            // 입력한 단에 맞는 구구단 출력
            int dan;

            Console.Write("몇 단 설정 : ");
            dan = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} X {1} = {2, 2:D}", dan, i, dan * i);
            }


            // 중첩 for 문
            for (int i = 0; i < 3; i++)
            {
                for(int k = 0; k < 2; k++)
                {
                    Console.WriteLine("i 값 : {0}, k값 : {1}", i, k);
                }
            }

            // 전체 구구단 출력
            for(int i = 2; i < 10; i++)
            {
                for(int k = 1; k < 10; k++)
                {
                    Console.WriteLine("{0} X {1} = {2, 2:D}", i, k, i * k);
                }
                Console.WriteLine();
            }
        }

    }

}