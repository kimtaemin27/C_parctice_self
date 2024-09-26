namespace Project08_13
{

    internal class Program
    {
        static void Func1(char x, char y)
        {
            char imsi;
            imsi = x;
            x = y;
            y = imsi;
        }

        static void Func2(ref char x, ref char y)
        {
            char imsi;
            imsi = x;
            x = y;
            y = imsi;
        }


        static void Main(string[] args)
        {
            char x = 'A', y = 'Z';
            Console.WriteLine("원래 값          : x = {0}, y = {1}", x, y);
            Func1(x, y);
            Console.WriteLine("값을 전달한 후   : x = {0}, y = {1}", x, y);

            Console.WriteLine();

            x = 'A';
            y = 'Z';
            Console.WriteLine("원래 값          : x = {0}, y = {1}", x, y);
            Func2(ref x, ref y);
            Console.WriteLine("값을 전달한 후   : x = {0}, y = {1}", x, y);
        }

    }

}