// 순번 및 서식 사용법

namespace Project03_1
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello?");
            Console.WriteLine("{0}", "Hello??");
            // {0} 은 문자열의 순번값

            Console.WriteLine("이름={0}, 나이={1}", "둘리", 35);
            // 중괄호는 제외하고 출력된다

            Console.WriteLine("100");
            Console.WriteLine("{0:D}", 100);
            // "" 따옴표 안에 있으면 글자든 숫자든 무조건 글자로 취급

            Console.WriteLine("100 + 100");
            Console.WriteLine("{0:D}", 100 + 100);
            // {0:D} 에서 0은 순번 D 는 숫자를 의미한다
            // D 는 정수를 의미하는 Decimal 을 의미한다
            // 서식의 개수와 따옴표 뒤에 나오는 숫자의 개수는 같아야한다

            // C 또는 c = 통화값, Currency 의 약자
            // D 또는 d = 정수, Decimal 의 약자
            // E 또는 e = 지수 표기법, Exponent 의 약자
            // F 또는 f = 고정 소수점, Floating 의 약자
            // N 또는 n = 세자리마다 콤마를 지원, Number 의 약자
            // P 또는 p = 백분율, Percentage 의 약자
            // X 또는 x = 16진수, Hex 의 약자

            Console.WriteLine("{0:D} / {1:D} = {2:F}", 100, 200, 0.5);

            Console.WriteLine("{0:D}", 123);
            // 위의 경우 그냥 0의 자리부터 123 출력
            // 123
            Console.WriteLine("{0,5:D}", 123);
            // 위의 경우 5자리 확보 후 왼쪽 2공간은 놔두고 오른쪽 정렬으로 123 출력
            //   123
            Console.WriteLine("{0,5:D5}", 123);
            // 위의 경우 5자리 확보 후 왼쪽 2공간은 0으로 채우고 오른쪽 정렬으로 123 출력
            // 00123

            Console.WriteLine("{0:F}", 123.456);
            // 위의 경우 기본 상태에선 소수점 아래 두자리까지만 출력 (반올림 하여)
            // 123.46
            Console.WriteLine("{0,8:F1}", 123.456);
            // 위의 경우 8자리 확보후 오른쪽 정렬 후 F1 이니 소수점 한자리만 출력 (반올림 하여)
            //    123.5
            Console.WriteLine("{0,8:F4}", 123.456);
            // 위의 경우 수수점 아래 네자리 출력 오른쪽 빈칸은 0으로 채운다
            // 123.4560

            Console.WriteLine("{0:S}", "CSharp");
            // 위의 경우 자리수 만큼 모두 출력
            // CSharp
            Console.WriteLine("{0,8:S}", "CSharp");
            // 위의 경우 8자리 확보후 오른쪽 정렬하여 출력
            //   CSharp
        }
    }
}