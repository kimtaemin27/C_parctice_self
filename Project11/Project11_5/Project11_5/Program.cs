namespace Project11_5
{
    class Car
    {
        private int speed = 0;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Car myCar1 = new Car();

            myCar1.Speed = 100;
            Console.WriteLine("차량 속도 ==> {0}", myCar1.Speed);
        }

    }

}