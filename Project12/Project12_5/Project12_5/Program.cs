namespace Project12_5
{
    class Car
    {
        protected string color;
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
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan();

            sedan1.SetSpeed(188);
            sedan1.SetColor("Red");
            Console.WriteLine("Sedan speed => {0}", sedan1.speed);
            // 오류 Console.WriteLine("Sedan color => {0}", sedan1.color);
            Console.WriteLine("Sedan color => {0}", sedan1.GetColor());
        }

    }

}