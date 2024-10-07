namespace Project12_7
{
    abstract class Car
    {
        int speed = 0;

        void UpSpeed(int speed)
        {
            this.speed += speed;
        }
    }

    class Sedan : Car
    {

    }

    class Truck : Car
    {

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // error
            // Car car1 = new Car();

            Sedan sedan1 = new Sedan();
            Console.WriteLine("sedan instance create");
            Truck truck1 = new Truck();
            Console.WriteLine("truck instance create");
        }

    }

}