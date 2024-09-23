namespace Project05_6
{

    class Program
    {

        static void Main(string[] args)
        {
            // switch case 문
            int a;

            Console.Write("1 ~ 4 중 선택");
            a = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Console.WriteLine("1을 선택");
                    break;
                case 2:
                    Console.WriteLine("2를 선택");
                    break;
                case 3:
                    Console.WriteLine("3을 선택");
                    break;
                case 4:
                    Console.WriteLine("4를 선택");
                    break;
                default:
                    Console.WriteLine("이상한것을 선택");
                    break;
            }
        }

    }

}