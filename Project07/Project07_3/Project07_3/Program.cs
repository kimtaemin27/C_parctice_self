namespace Project07_3
{

    class Program
    {

        static void Main(string[] args)
        {
            // 배열 요소의 개수와 크기를 계산하는 예
            int[] aa = { 10, 20, 30, 40, 50 };
            int count, size;

            count = aa.Length;
            size = count * sizeof(int);

            Console.WriteLine("배열 aa[]의 요소의 개수는 {0} 개 입니다.", count);
            Console.WriteLine("배열 aa[]의 요소의 전체 크기는 {0} 바이트 입니다", size);


            // 배열의 크기를 변경하는 예
            int[] aaa = { 10, 20, 30 };

            Console.WriteLine("현재 배열의 크기 => {0}", aaa.Length);
            Console.Write("현 배열 내용 =>");
            for (int i = 0; i < aaa.Length; i++)
                Console.Write("{0, 3:D}", aaa[i]);
            Console.WriteLine();

            Array.Resize(ref aaa, 5);

            Console.WriteLine("새 배열 크기 => {0}", aaa.Length);
            Console.Write("새 배열 내용 =>");
            for (int i = 0; i < aaa.Length; i++)
                Console.Write("{0, 3:D}", aaa[i]);
            Console.WriteLine();


            // foreach 문의 사용
            int[] aaaa = { 10, 20, 30 };
            for(int i = 0; i < aaaa.Length; i++)
            {
                int data = aaaa[i];
                Console.WriteLine(data);
            }
            // 위 내용을 아래같이
            foreach (int data in aaaa)
                Console.WriteLine(data);
        }

    }

}