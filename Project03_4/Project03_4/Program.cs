// 비트, 진수 사용법
namespace Project03_4
{

    class Program
    {

        static void Main(string[] args)
        {
            byte decData, binData, hexData;

            decData = 147;
            binData = 0b10010011;
            hexData = 0x93;

            Console.WriteLine("10진수(decData) : " + decData);
            Console.WriteLine("2진수(binData) : " + binData);
            Console.WriteLine("16진수(hexData) : " + hexData);

            // Convert.ToString(값, 진수); 를 사용하면 저장된 숫자를 다른 진수로 표현할 수 있다.
            Console.WriteLine("10진수(decData) : " + Convert.ToString(decData, 10));
            Console.WriteLine("2진수(binData) : " + Convert.ToString(binData, 2));
            Console.WriteLine("16진수(hexData) : " + Convert.ToString(hexData, 16));

            // 각 진수의 문자열을 10진수로 변환하려면 Convert.ToInt(문자열, 진수) 를 사용하면 된다.
            Console.WriteLine(Convert.ToInt32("12341234", 10));
            Console.WriteLine(Convert.ToInt32("11111111", 2));
            Console.WriteLine(Convert.ToInt32("FFFF", 16));
        }

    }

}