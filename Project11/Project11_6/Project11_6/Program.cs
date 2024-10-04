namespace Project11_6
{
    class Car
    {
        private string color;
        private int speed;

        public Car()
        {
            color = "Red";
            speed = 0;
        }

        public string GetColor()
        {
            return color;
        }

        public int GetSpeed()
        {
            return speed;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            Car myCar2 = new Car();

            Console.WriteLine("자동차1 의 색상은 {0} 이며, 속도는 {1}km 입니다.", myCar1.GetColor(), myCar1.GetSpeed());
            Console.WriteLine("자동차2 의 색상은 {0} 이며, 속도는 {1}km 입니다.", myCar2.GetColor(), myCar2.GetSpeed());
        }

    }

}