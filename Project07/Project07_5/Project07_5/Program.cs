namespace Project07_5
{

    class Program
    {

        static void Main(string[] args)
        {
            // 2차 배열의 사용 예
            int[,] ary = new int[3, 4];

            ary[0, 0] = 1;
            ary[0, 1] = 2;
            ary[0, 2] = 3;
            ary[0, 3] = 4;
            ary[1, 0] = 5;
            ary[1, 1] = 6;
            ary[1, 2] = 7;
            ary[1, 3] = 8;
            ary[2, 0] = 9;
            ary[2, 1] = 10;
            ary[2, 2] = 11;
            ary[2, 3] = 12;

            Console.WriteLine("ary[0, 0]부터 ary[2, 3]까지 출력");

            Console.WriteLine("{0, 3:D} {1, 3:D} {2, 3:D} {3, 3:D}", ary[0, 0], ary[0, 1], ary[0, 2], ary[0, 3]);
            Console.WriteLine("{0, 3:D} {1, 3:D} {2, 3:D} {3, 3:D}", ary[1, 0], ary[1, 1], ary[1, 2], ary[1, 3]);
            Console.WriteLine("{0, 3:D} {1, 3:D} {2, 3:D} {3, 3:D}", ary[2, 0], ary[2, 1], ary[2, 2], ary[2, 3]);


            // 중첩 for 문을 활용한 2차원 배열의 사용 예
            int[,] ary2 = new int[3, 4];
            int value = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    ary2[i, k] = value;
                    value++;
                }
            }

            Console.WriteLine("ary2[0, 0]부터 ary2[2, 3]까지 출력");

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write("{0, 3:D}", ary2[i, k]);
                }
                Console.WriteLine();
            }


            // 2차원 배열의 초기화
            int[,] ary3 =
            {
                { 1, 2, 3, 4},
                { 5, 6, 7, 8},
                { 9, 10, 11, 12}
            };

            Console.WriteLine("ary3[0, 0]부터 ary[2, 3] 까지 출력");
            
            for(int i = 0; i < 3; i++)
            {
                for(int k = 0; k < 4; k++)
                {
                    Console.Write("{0, 3:D}", ary3[i, k]);
                }
                Console.WriteLine();
            }


            // 배열 크기의 동적 할당
            int row, col;

            Console.Write("행 개수를 입력 : ");
            row = int.Parse(Console.ReadLine());
            Console.Write("열 개수를 입력 : ");
            col = int.Parse(Console.ReadLine());

            int[,] ary4 = new int[row, col];
            value = 1;

            for(int i = 0; i < row; i++)
            {
                for(int k = 0; k < col; k++)
                {
                    ary4[i, k] = value;
                    value++;
                }
            }

            Console.WriteLine("ary4[0, 0] 부터 ary[{0}, {1}] 까지 출력", row, col);
            for(int i = 0; i < row; i++)
            {
                for(int k = 0; k < col; k++)
                {
                    Console.Write("{0, 3:D}", ary4[i, k]);
                }
                Console.WriteLine();
            }
        }
    }

}