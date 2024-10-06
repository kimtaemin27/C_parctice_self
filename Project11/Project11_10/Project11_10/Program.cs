namespace Project11_10
{
    class Car
    {
        // 인스턴스 변수
        private int speed;
        // 클래스 변수
        public static int count = 0;

        public Car()
        {
            count++;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("인스턴스 생성 전의 count => {0}", Car.count);

            Car myCar1 = new Car();
            Console.WriteLine("차 1대 생성 후, 총 count => {0}", Car.count);

            Car myCar2 = new Car();
            Console.WriteLine("차 2대 생성 후, 총 count => {0}", Car.count);
        }

    }

}