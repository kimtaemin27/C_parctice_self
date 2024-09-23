namespace Project06_4
{

    class Program
    {

        static void Main(string[] args)
        {
            // while 문
            int i;

            i = 0;
            while(i < 3)
            {
                Console.WriteLine("while 문");
                i++;
            }


            // while 문을 사용한 1 ~ 10 까지의 합계 구하기
            int hap = 0;
            i = 1;

            while (i <= 10)
            {
                hap = hap + i;
                i++;
            }

            Console.WriteLine("1부터 10 까지의 합 : {0}", hap);


            // do ~ while 문
            bool yn;

            Console.Write("true 또는 false 입력 : ");
            yn = bool.Parse(Console.ReadLine());

            while(yn)
            {
                Console.WriteLine("while 문이 수행되었습니다. ");
            }

            do
            {
                Console.WriteLine("do ~ while 문이 수행되었습니다. ");
            } while (yn);
            // do ~ while 은 무조건 한번은 실행한다
        }

    }

}