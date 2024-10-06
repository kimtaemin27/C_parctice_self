namespace Project12_1
{
    class Car
    {
        public string color;
        public int speed;


        public void Upspeed(int value)
        {
            speed = speed + value;
        }

        public void DownSpeed(int value)
        {
            speed = speed - value;
        }
    }

    class Sedan : Car
    {
        public int seatNum;

        public int GetSeatNum()
        {
            return seatNum;
        }
    }

    class Truck : Car
    {
        public int capacity;

        public int GetCapacity()
        {
            return capacity;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan();
            Truck truck1 = new Truck();

            sedan1.Upspeed(150);
            truck1.Upspeed(100);

            sedan1.seatNum = 5;
            truck1.capacity = 50;

            Console.WriteLine("승용차 속도는 {0}km, 좌석수는 {1}개 입니다.", sedan1.speed, sedan1.GetSeatNum());
            Console.WriteLine("트럭 속도는 {0}km, 적재량은 {1}톤 입니다.", truck1.speed, truck1.GetCapacity());
        }

    }

}