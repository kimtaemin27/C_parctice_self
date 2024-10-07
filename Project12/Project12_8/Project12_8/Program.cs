namespace Project12_8
{
    abstract class Car
    {
        int speed = 0;

        public void UpSpeed(int speed)
        {
            this.speed += speed;
        }

        public abstract void Work();
    }

    class Sedan : Car
    {
        public override void Work()
        {
            Console.WriteLine("Person in sedan");
        }
    }

    class Truck : Car
    {
        public override void Work()
        {
            Console.WriteLine("Person in truck");
        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // error
            // Car car1 = new Car();

            Sedan sedan1 = new Sedan();
            sedan1.Work();
            Truck truck1 = new Truck();
            truck1.Work();

            truck1.UpSpeed(200);
        }

    }

}