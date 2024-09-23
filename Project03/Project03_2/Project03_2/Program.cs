namespace Project03_2
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("한 행입니다. 또 한 행입니다.");
            Console.WriteLine("한 행입니다. \n또 한 행입니다.");
            // Console.WriteLine() 메서드는 내용을 출력한 후 다음 행으로 넘어간다.
            // 강제로 한 행을 넘기고 싶으면 이스케이프 문자인 \n 을 사용하면 된다.

            // \n = 새로운 줄로 이동
            // \t = 다음 탭으로 이동
            // \b = 뒤로 한 칸 이동
            // \\ = \ 을 출력
            // \' = ' 을 출력
            // \" = " 을 출력

            Console.WriteLine("\n줄바꿈\n연습");
            Console.WriteLine("\t탭키\t연습");
            Console.WriteLine("글자가\"강조\"되는 효과1");
            Console.WriteLine("글자가\'강조\'되는 효과2");
            Console.WriteLine("\\\\\\ 역슬래쉬 세개 출력");
            Console.WriteLine("\\n \\t \\를 그대로 출력");

            Console.WriteLine("        ★");
            Console.WriteLine("      ★★★");
            Console.WriteLine("    ★★★★★");
            Console.WriteLine("  ★★★★★★★");
            Console.WriteLine("★★★★★★★★★");
            Console.WriteLine("  ★★★★★★★");
            Console.WriteLine("    ★★★★★");
            Console.WriteLine("      ★★★");
            Console.WriteLine("        ★");

            Console.WriteLine("♥♥♥♥♥♥♥♥♥");
            Console.WriteLine("  ♥♥♥♥♥♥♥  ");
            Console.WriteLine("    ♥♥♥♥♥    ");
            Console.WriteLine("      ♥♥♥      ");
            Console.WriteLine("        ♥        ");
            Console.WriteLine("      ♥♥♥      ");
            Console.WriteLine("    ♥♥♥♥♥    ");
            Console.WriteLine("  ♥♥♥♥♥♥♥  ");
            Console.WriteLine("♥♥♥♥♥♥♥♥♥");
        }
 
    }

}