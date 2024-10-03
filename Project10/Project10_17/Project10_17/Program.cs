namespace Project10_17
{

    internal class Program
    {

        static void Main(string[] args)
        {
            int num1, num2;

            try
            {
                Console.Write("숫자1 --> ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("숫자2 --> ");
                num2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("오류발생.");
            }
            finally
            {
                Console.WriteLine("이 부분은 무조건 나옴.");
            }
        }

    }

}