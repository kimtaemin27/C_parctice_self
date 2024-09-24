namespace Project07_7
{

    class Program
    {

        static void Main(string[] args)
        {
            // 스택의 구현
            char[] parking = new char[5];
            int top = 0;

            parking[top] = 'A';
            Console.WriteLine(" {0} 자동차가 주차장에 들어감", parking[top]);
            top++;

            parking[top] = 'B';
            Console.WriteLine(" {0} 자동차가 주차장에 들어감", parking[top]);
            top++;

            parking[top] = 'C';
            Console.WriteLine(" {0} 자동차가 주차장에 들어감", parking[top]);
            top++;

            Console.WriteLine();

            top--;
            Console.WriteLine(" {0} 자동차가 주차장을 빠져나감", parking[top]);
            parking[top] = ' ';

            top--;
            Console.WriteLine(" {0} 자동차가 주차장을 빠져나감", parking[top]);
            parking[top] = ' ';

            top--;
            Console.WriteLine(" {0} 자동차가 주차장을 빠져나감", parking[top]);
            parking[top] = ' ';
        }

    }

}