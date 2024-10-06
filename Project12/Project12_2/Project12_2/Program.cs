namespace Project12_2
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("기본 클래스 생성자 호출");
        }
    }

    class Sedan : Car
    {
        public Sedan()
        {
            Console.WriteLine("파생 클래스 생성자 호출");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan();
        }

    }

}