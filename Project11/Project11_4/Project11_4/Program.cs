namespace Project11_4
{
    class Car
    {
        private int speed = 0;

        public void UpSpeed(int value)
        {
            if (speed + value > 200)
                speed = 200;
            else
                speed = speed + value;

            Console.WriteLine("현재 속도 ==> {0}", GetSpeed());
        }
        public void DownSpeed(int value)
        {
            if (speed - value < 0)
                speed = 0;
            else
                speed = speed - value;

            Console.WriteLine("현재 속도 ==> {0}", GetSpeed());
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

            myCar1.UpSpeed(100);
            myCar1.UpSpeed(150);

            myCar1.DownSpeed(50);
            myCar1.DownSpeed(160);
        }

    }

}