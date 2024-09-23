// switch case 문을 활용한 학점 계산 프로그램
namespace Project05_7
{

    class Program
    {

        static void Main(string[] args)
        {
            int score;
            Random rnd = new Random();

            for(int i = 0; i < 5; i++)
            {
                score = rnd.Next(0, 100);
                Console.Write("취득 점수 " + score + " => ");

                switch(score/10)
                {
                    case 10:
                    case 9:
                        Console.Write("A");
                        break;
                    case 8:
                        Console.Write("B");
                        break;
                    case 7:
                        Console.Write("C");
                        break;
                    case 6:
                        Console.Write("D");
                        break;
                    default:
                        Console.Write("F");
                        break;
                }
                Console.WriteLine(" 학점");
            }
        }

    }

}