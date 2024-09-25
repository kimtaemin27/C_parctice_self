// 커피 타는 프로그램
namespace Project08_6
{

    class Program
    {

        static void Main(string[] args)
        {
            int coffee;

            Console.Write("어떤 커피 (1: 보통, 2: 설탕, 3: 블랙)");
            coffee = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("# 1. 뜨거운 물을 준비한다.");
            Console.WriteLine("# 2. 종이컵을 준비한다.");

            switch(coffee)
            {
                case 1:
                    Console.WriteLine("# 3. 보통커피를 탄다");
                    break;
                case 2:
                    Console.WriteLine("# 3. 설탕커피를 탄다");
                    break;
                case 3:
                    Console.WriteLine("# 3. 블랙커피를 탄다");
                    break;
                default:
                    Console.WriteLine("# 3. 아무거나 탄다");
                    break;
            }

            Console.WriteLine("# 4. 물을 붓는다");
            Console.WriteLine("# 5. 스푼으로 저어서 녹인다");

            Console.WriteLine("커피 완성");
        }

    }

}