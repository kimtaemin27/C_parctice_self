namespace Project12_4
{
    class Car
    {
        private string color;
        public int speed;
    }

    class Sedan : Car
    {
        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        public void SetColor(String color)
        {
            // 오류
            // this.color = color;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan();

            sedan1.SetSpeed(188);
            Console.WriteLine("승용차 속도 => {0}", sedan1.speed);
        }

    }

}