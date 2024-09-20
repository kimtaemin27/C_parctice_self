namespace Project04_3
{

    class Program
    {

        static void Main(string[] args)
        {
            // 비교 연산자
            int a = 100, b = 200;

            Console.WriteLine("{0} == {1} 는 {2} 다.", a, b, a == b);
            Console.WriteLine("{0} != {1} 는 {2} 다.", a, b, a != b);
            Console.WriteLine("{0} > {1} 는 {2} 다.", a, b, a > b);
            Console.WriteLine("{0} < {1} 는 {2} 다.", a, b, a < b);
            Console.WriteLine("{0} >= {1} 는 {2} 다.", a, b, a >= b);
            Console.WriteLine("{0} <= {1} 는 {2} 다.", a, b, a <= b);


            // 논리 연산자
            a = 99;

            Console.WriteLine("AND 연산 : {0}", (a >= 100) && (a <= 200));
            Console.WriteLine("OR 연산 : {0}", (a >= 100) || (a <= 200));
            Console.WriteLine("NOT 연산 : {0}", !(a >= 100));


            // 비트 연산자
            Console.WriteLine("10 & 7 => " + (10 & 7) );
            Console.WriteLine("123 & 456 => " + (123 & 456));
            Console.WriteLine("0xFFFF & 0x0000 => " + (0xFFFF & 0x0000));


            // 비트 논리합 연산자
            Console.WriteLine("10 | 7 => " + (10 | 7));
            Console.WriteLine("123 | 456 => " + (123 | 456));
            Console.WriteLine("0xFFFF | 0x0000 => " + (0xFFFF | 0x0000));


            // 비트 배타적 논리합 연산자
            Console.WriteLine("10 ^ 7 => " + (10 ^ 7));
            Console.WriteLine("123 ^ 456 => " + (123 ^ 456));
            Console.WriteLine("0xFFFF ^ 0x0000 => " + (0xFFFF ^ 0x0000));


            // 비트 연산자 응용
            char ch1 = 'A';
            int mask = 0x0F;

            Console.WriteLine("{0:X} & {1:D} = {2:X}", Convert.ToString(ch1, 16), mask, ch1 & mask);
            Console.WriteLine("{0:X} | {1:D} = {2:X}", Convert.ToString(ch1, 16), mask, ch1 | mask);

            mask = 'a' - 'A';

            char ch2 = (char)(ch1 ^ mask);
            Console.WriteLine("{0:C} ^ {1:D} = {2:C}", ch1, mask, ch2);
            ch1 = (char)(ch2 ^ mask);
            Console.WriteLine("{0:C} ^ {1:D} = {2:C}", ch2, mask, ch1);


            // 비트 부정 연산자
            int n = 12345;
            Console.WriteLine(~n + 1);


            // 비트 왼쪽 시프트 연산자
            n = 10;
            Console.WriteLine((n << 1) + " , " + (n << 2) + " , " + (n << 3) + " , " + (n << 4));


            // 비트 왼쪽 시프트 연산자
            n = 10;
            Console.WriteLine((n >> 1) + " , " + (n >> 2) + " , " + (n >> 3) + " , " + (n >> 4));


            // 비트 시프트 연산자와 반복문
            n = 100;
            int result;
            
            for(int i = 0; i < 5; i++)
            {
                result = n << i;
                Console.WriteLine("{0:D} << {1:D} = {2:D} ", n, i, result);
            }

            for(int i = 1; i < 5; i++)
            {
                result = n >> i;
                Console.WriteLine("{0:D} >> {1:D} = {2:D} ", n, i, result);
            }
        }

    }

}