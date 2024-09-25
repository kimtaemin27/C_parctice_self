namespace Project08_8
{

    class Program
    {
        static int Plus(int v1, int v2)
        {
            int result;
            result = v1 + v2;
            return result;
        }

        static int Calc(int v1, char op, int v2)
        {
            int result;

            switch(op)
            {
                case '+':
                    result = v1 + v2;
                    break;
                case '-':
                    result = v1 - v2;
                    break;
                case '*':
                    result = v1 * v2;
                    break;
                case '/':
                    result = v1 / v2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }


        static void Main(string[] args)
        {
            int hap;
            hap = Plus(100, 200);
            Console.WriteLine("100 과 200 의 Plus() 메서드 결과는: {0}", hap);

            int res;
            char oper;
            int n1, n2;

            Console.Write("첫 번째 숫자를 입력 : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("연산자 (+, -, *, /) : ");
            oper = Console.ReadLine()[0];
            Console.Write("두 번째 숫자를 입력 : ");
            n2 = int.Parse(Console.ReadLine());

            res = Calc(n1, oper, n2);

            Console.WriteLine("계산 결과 : {0}", res);
        }

    }

}