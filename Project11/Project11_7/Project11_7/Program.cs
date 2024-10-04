// 생성자 사용
namespace Project11_7
{
    class Car
    {
        private string color;
        private int speed;

        public Car(string color, int speed)
        {
            this.color = color;
            this.speed = speed;
        }

        public string GetColor()
        {
            return color;
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
            Car myCar1 = new Car("Red", 0);
            Car myCar2 = new Car("Blue", 30);

            Console.WriteLine("myCar1 의 색상은 {0} 이며, 현재 속도는 {1}km 입니다.", myCar1.GetColor(), myCar1.GetSpeed());
            Console.WriteLine("myCar2 의 색상은 {0} 이며, 현재 속도는 {1}km 입니다.", myCar2.GetColor(), myCar2.GetSpeed());
        }

    }

}