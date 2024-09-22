namespace Project05_3
{

    class Program
    {

        static void Main(string[] args)
        {
            // 중첩 if 문
            int a = 75;

            if(a > 50)
            {
                if (a < 100)
                {
                    Console.WriteLine("50 보다 크고 100 보다 작음");
                }
                else
                {
                    Console.WriteLine("100 보다 큼");
                }
            }
            else
            {
                Console.WriteLine("50보다 작음");
            }
        }

    }

}