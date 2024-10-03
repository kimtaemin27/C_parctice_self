namespace Project10_15
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string str = "C# is funny";
            int index = 0;

            while(true)
            {
                try
                {
                    Console.WriteLine("{0} 번째 글자 : {1}", index, str[index]);
                    index++;
                }
                catch
                {
                    break;
                }
            }

            Console.WriteLine("end");
        }

    }

}