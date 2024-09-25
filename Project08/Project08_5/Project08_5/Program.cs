namespace Project08_5
{

    class Program
    {

        static void Main(string[] args)
        {
            // 입력한 문자의 개수세기 및 거꾸로 출력하기
            string str;
            int lowerCnt = 0, upperCnt = 0, numCnt = 0, hanCnt = 0, etcCnt = 0;

            Console.Write("문자열 입력 => ");
            str = Console.ReadLine();

            foreach(char c in str)
            {
                if ('a' <= c && c <= 'z')
                    lowerCnt++;
                else if ('A' <= c && c <= 'Z')
                    upperCnt++;
                else if ('0' <= c && c <= '9')
                    numCnt++;
                else if ('가' <= c && c <= '힣')
                    hanCnt++;
                else
                    etcCnt++;
            }

            Console.WriteLine("소문자 : {0}, 대문자 : {1}, 숫자 : {2}, 한글 : {3}, 기타 : {4}", lowerCnt, upperCnt, numCnt, hanCnt, etcCnt);

            Console.WriteLine();
            Console.Write("거꾸로 출력 => ");
            for(int i = str.Length - 1; i >= 0; i--)
                Console.Write(str[i]);
            Console.WriteLine();
        }

    }

}