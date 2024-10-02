namespace Project10_12
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string folder = "C:\\Windows\\Help\\";
            string[] fileAry = new string[] { };
            string[] dirAry = new string[] { };

            DirectoryInfo dInfo = new DirectoryInfo(folder);
            DirectoryInfo[] dirs = dInfo.GetDirectories("*.*", SearchOption.AllDirectories);

            foreach(DirectoryInfo d in dirs)
            {
                Array.Resize(ref dirAry, dirAry.Length + 1);
                dirAry[dirAry.Length - 1] = d.FullName;

                foreach(FileInfo f in d.GetFiles())
                {
                    Array.Resize(ref fileAry, fileAry.Length + 1);
                    fileAry[fileAry.Length - 1] = f.FullName;
                }
            }

            Console.WriteLine("** 디렉터리 목록 : {0} 개 **", dirAry.Length);
            foreach (string dName in dirAry)
                Console.WriteLine(dName);

            Console.WriteLine("\n** 파일 목록 : {0} 개 **", fileAry.Length);
            foreach (string fName in fileAry)
                Console.WriteLine(fName);
        }

    }

}