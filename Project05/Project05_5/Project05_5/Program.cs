namespace Project05_5
{

    class Program
    {

        static void Main(string[] args)
        {
            // 삼항 연산자
            // (조건식) ? 참일때 : 거짓일때

            int jumsu = 55;
            string res;

            if (jumsu >= 60)
                res = "합격";
            else
                res = "불합격";

            // 위의 코드를 삼항 연산자로 처리한다면
            res = (jumsu >= 60) ? "합격" : "불합격";
            Console.WriteLine(res);
        }

    }

}