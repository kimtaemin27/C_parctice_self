// 학점 처리 프로그램
namespace Project05_4
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
                Console.WriteLine("취득 점수 " + score + " => ");

                if (score >= 90)
                    Console.Write("A");
                else
                    if (score >= 80)
                        Console.Write("B");
                    else
                        if(score >= 70)
                            Console.Write("C");
                        else
                            if (score >= 60)
                                Console.Write("D");
                            else
                                Console.Write("F");


                Console.WriteLine(" 학점");
            }
        }

    }

}