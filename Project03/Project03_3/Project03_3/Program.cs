// 변수
namespace Project03_3
{

    class Program
    {

        static void Main(string[] args)
        {
            bool boolVar = true;
            int intVar = 0;
            float floatVar = 0.0f;
            char charVar = ' ';
            string strVar = " ";
            // 예약어는 변수명으로 사용 불가
            // 변수의 종류를 확인하려면 GetType() 메서드를 사용하면 된다.

            Console.WriteLine(boolVar.GetType());
            Console.WriteLine(intVar.GetType());
            Console.WriteLine(floatVar.GetType());
            Console.WriteLine(charVar.GetType());
            Console.WriteLine(strVar.GetType());

            // 변수에 값을 대입할 수도 있다.
            boolVar = false;
            intVar = 100;
            floatVar = 123.45f;
            charVar = 'A';
            strVar = "안녕?";

            // 변수값을 변수에 넣을 수도 있다.
            int var1, var2;
            var2 = 200;
            var1 = var2;

            // 계산 결과를 넣을 수도 있다.
            var1 = 100 + 100;

            // 숫자와 변수의 연산을 넣을 수도 있다.
            var1 = var2 + 100;
        }

    }

}