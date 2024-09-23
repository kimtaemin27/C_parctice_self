namespace Project07_4
{

    class Program
    {

        static void Main(string[] args)
        {
            // 1 차원 배열의 활용 예
            int[] ary = new int[0];
            int num, hap = 0;
            double avg;

            while(true)
            {
                Console.Write("숫자를 입력하세요(0은 종료) : ");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;

                Array.Resize(ref ary, ary.Length + 1);
                ary[ary.Length - 1] = num;  
            }

            for (int i = 0; i < ary.Length; i++)
                hap += ary[i];

            avg = (float)hap / ary.Length;

            Console.WriteLine("합계 => {0}", hap);
            Console.WriteLine("평균 => {0}", avg);
            Array.Resize(ref ary, 0);
        }

    }

}