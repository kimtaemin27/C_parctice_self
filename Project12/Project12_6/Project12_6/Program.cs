using System.Runtime.CompilerServices;

namespace Project12_6
{
    class Car
    {
        public int speed;

        public void UpSpeed(int speed)
        {
            this.speed += speed;
            Console.WriteLine("This speed (void class) : {0}km", this.speed);
        }
    }

    class Sedan : Car
    {
        public void UpSpeed(int speed)
        {
            this.speed += speed;
            if (this.speed > 150)
                this.speed = 150;
            Console.WriteLine("This speed (other class) : {0}km", this.speed);
        }
    }

    class Truck : Car
    {

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan();
            Truck truck1 = new Truck();

            Console.Write("Sedan --> ");
            sedan1.UpSpeed(200);

            Console.Write("Truck --> ");
            truck1.UpSpeed(200);
        }

    }

}