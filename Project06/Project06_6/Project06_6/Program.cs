namespace Project06_6
{

    class Program
    {

        static void Main(string[] args)
        {
            // 반복문의 처음으로 돌려보내는 제어문 continue 문
            int hap = 0;
            int i;

            for(i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    continue;

                hap += i;
            }

            Console.WriteLine(" 1 ~ 100 까지의 합 (3의 배수 제외) : {0}", hap);


            // 특정 위치로 이동시키는 제어문 goto 문
            // goto 문은 별도의 레이블을 지정해 놓고 그 레이블로 건너뛰게 하는 구문
            hap = 0;

            for(i = 1; i <= 100; i++)
            {
                hap += i;

                if (hap > 2000)
                    goto mygoto;
            }

        mygoto:
            Console.WriteLine("1부터 {0} 까지 합하면 2000 이 넘는다.", i);


            // 메서드가 호출된 위치로 돌려보내는 제어문 return 문
            hap = 0;

            for (i = 1; i <= 100; i++)
                hap += i;

            Console.WriteLine("1 부터 100 까지의 합은 {0} 이다.", hap);
            return;

            Console.WriteLine("프로그램 끝");
        }

    }

}