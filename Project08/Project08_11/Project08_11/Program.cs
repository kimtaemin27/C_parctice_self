namespace Project08_11
{

    internal class Program
    {
        static int[] DrawDice()
        {
            Random rnd = new Random();
            int[] diceAry = new int[rnd.Next(5, 11)];

            for (int i = 0; i < diceAry.Length; i++)
                diceAry[i] = rnd.Next(1, 7);

            return diceAry;
        }

        static void Main(string[] args)
        {
            int[] ary;
            ary = DrawDice();

            Console.Write("{0}회 던졌음 => ", ary.Length);

            for(int i = 0;i < ary.Length; i++)
                Console.Write(ary[i] + " ");

            Console.WriteLine();
        }

    }

}