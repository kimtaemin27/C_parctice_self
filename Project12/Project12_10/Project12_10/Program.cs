namespace Project12_10
{
    interface ICar
    {
        void Work();
    }

    class Sedan : ICar
    {
        public void Work()
        {
            Console.WriteLine("승용차가 사람을 태우고 있습니다.");
        }
    }

    class Truck : ICar
    {
        public void Work()
        {
            Console.WriteLine("트럭이 짐을 싣고 있습니다.");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan();
            sedan1.Work();
            Truck truck1 = new Truck();
            truck1.Work();
        }

    }

}