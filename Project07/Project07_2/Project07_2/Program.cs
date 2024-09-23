namespace Project07_2
{

    class Program
    {

        static void Main(string[] args)
        {
            // for 문으로 배열의 인자 이용
            int[] aa = new int[4];
            int hap;

            for (int i = 0; i <= 3; i++)
            {
                Console.Write("{0} 번째 숫자를 입력하세요 : ", i + 1);
                aa[i] = int.Parse(Console.ReadLine());
            }

            hap = aa[0] + aa[1] + aa[2] + aa[3];

            Console.WriteLine("합계 => {0}", hap);


            // 배열의 초기화 예1
            int[] aaa = { 100, 200, 300, 400 };
            int[] bbb = new int[] { 100, 200, 300 };
            int[] ccc;
            ccc = new int[] { 100, 200 };
            int[] ddd = new int[1];
            ddd[0] = 100;

            for (int i = 0; i < 4; i++)
                Console.Write("aaa[{0}] => {1}\t", i, aaa[i]);
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
                Console.Write("bbb[{0}] => {1}\t", i, bbb[i]);
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
                Console.Write("ccc[{0}] => {1}\t", i, ccc[i]);
            Console.WriteLine();

            for (int i = 0; i < 1; i++)
                Console.Write("ddd[{0}] => {1}\t", i, ddd[i]);
            Console.WriteLine();


            int[] aaaa = new int[100];
            int[] bbbb = new int[100];

            for(int i = 0; i< 100; i++)
            {
                aaaa[i] = i * 2;
            }

            for(int i = 0; i < 100; i++)
            {
                bbbb[i] = aaaa[99 - i];
            }

            Console.WriteLine("bbbb[0] 은 {0}, bb[99] 는 {1} 입력됨", bbbb[0], bbbb[99]);
        }

    }

}