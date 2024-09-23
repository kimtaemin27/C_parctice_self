namespace Project05_1
{

    class Program
    {

        static void Main(string[] args)
        {
            // 기본적인 if 문 사용예시
            int a = 99;

            if (a < 100)
                Console.WriteLine("100 보다 작음");


            // 기본적인 if 문 사용예시 2
            a = 200;

            if (a < 100)
                Console.WriteLine("100 보다 작음");
            Console.WriteLine("확인 문장");

            Console.WriteLine("Program End");

            // 위와 같이 if 문 안에 두개의 문장을 사용하고 싶다면 {} 중괄호 사용

            if (a < 100)
            {
                Console.WriteLine("100 보다 작음");
                Console.WriteLine("확인 문장");
            }
            Console.WriteLine("Program End");


            // if ~ else if 문 사용 예시

            if (a < 100)
                Console.WriteLine("100 보다 작음");
            else
                Console.WriteLine("100 보다 큼");

            // 위와같이 구문 안에서 두 문장을 사용하고 싶다면 {} 중괄호 사용


            if (a < 100)
            {
                Console.WriteLine("100 보다 작음");
                Console.WriteLine("확인 문장1");
            }
            else
            {
                Console.WriteLine("100 보다 큼");
                Console.WriteLine("확인 문장2");
            }
            Console.WriteLine("Program End");

        }

    }

}