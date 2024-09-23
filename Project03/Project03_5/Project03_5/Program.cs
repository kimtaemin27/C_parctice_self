// 비트 프로그램
namespace Project03_5
{

    class Program
    {

        static void Main(string[] args)
        {
            int sel;
            string num;
            int num10 = 0;

            Console.Write("입력 진수 결정(16/10/2) : ");
            sel = Convert.ToInt32(Console.ReadLine());

            Console.Write("값 입력 : ");
            num = Console.ReadLine();

            if(sel == 16) 
                num10 = Convert.ToInt32(num, 16);
            if (sel == 10)
                num10 = Convert.ToInt32(num, 10);
            if (sel == 2)
                num10 = Convert.ToInt32(num, 2);

            Console.WriteLine("16진수 => " + Convert.ToString(num10, 16));
            Console.WriteLine("10진수 => " + Convert.ToString(num10, 10));
            Console.WriteLine("2진수 => " + Convert.ToString(num10, 2));
        }

    }

}