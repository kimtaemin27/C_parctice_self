namespace Project12_3
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("기본 클래스 생성자 호출(파라미터 없음)");
        }

        public Car(string str)
        {
            Console.WriteLine("기본 클래스 생성자 호출 ==> {0} ", str);
        }
    }

    class Sedan : Car
    {
        public Sedan(string str)
        {
            Console.WriteLine("파생 클래스 생성자 호출 ==> {0}", str);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan("C#");
        }

    }

}