//  짝수, 홀수 구분 프로그램
namespace Project05_2
{

    class Program
    {

        static void Main(string[] args)
        {
            int a;

            Console.Write("정수를 입력하세요 : ");
            a = int.Parse(Console.ReadLine());

            if ( a % 2 == 0)
            {
                Console.WriteLine("짝수 입니다.");
            }
            else
            {
                Console.WriteLine("홀수 입니다.");
            }
        }

    }

}