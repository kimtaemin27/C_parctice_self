namespace Project11_2
{
    class Car
    {
        public string color;
        public int speed;

        public void UpSpeed(int value)
        {
            speed = speed + value;
        }

        public void DownSpeed(int value)
        {
            speed = speed - value;
        }

        public string GetColor()
        {
            return color;
        }

        public int getSpeed()
        {
            return speed;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.color = "Red";
            myCar1.speed = 0;

            myCar1.UpSpeed(30);
            Console.WriteLine("자동차1 의 색생은 {0} 이며, 현재 속도는 {1}km 입니다.", myCar1.color, myCar1.speed);
            Console.WriteLine("자동차1 의 색상은 {0} 이며, 현재 속도는 {1}km 입니다.", myCar1.GetColor(), myCar1.getSpeed());
        }

    }

}