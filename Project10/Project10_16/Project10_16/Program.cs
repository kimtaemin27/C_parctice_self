namespace Project10_16
{

    internal class Program
    {

        static void Main(string[] args)
        {
            // 다양한 예외 처리
            int[] numAry = new int[2];

            Console.Write("숫자 1 --> ");
            numAry[0] = int.Parse(Console.ReadLine());
            Console.Write("숫자 2 --> ");
            numAry[1] = int.Parse(Console.ReadLine());

            try
            {
                // DivideByZeroException
                int res = numAry[0] / numAry[1];
                // FormatException
                numAry[0] = int.Parse("백");
                // IndexOutOfRangeException
                numAry[2] = numAry[0];
                // DriveNotFoundException
                Directory.Delete("C/없는디렉터리/", true);
                // FileNotFoundException
                File.Move("C/없는파일.exe", "C/없는파일2.exe");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DriveNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

}