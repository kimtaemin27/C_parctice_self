namespace Project06_8
{

    class Program
    {

        static void Main(string[] args)
        {
            // 문자를 숫자로 변환하는 예
            string str = "123";
            int num;

            num = str[0] - '0';
            Console.WriteLine(num);

            num = str[1] - '0';
            Console.WriteLine(num);

            num = str[2] - '0';
            Console.WriteLine(num);
        }

    }

}