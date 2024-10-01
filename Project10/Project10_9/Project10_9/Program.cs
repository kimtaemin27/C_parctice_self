namespace Project10_9
{

    internal class Program
    {

        static void Main(string[] args)
        {
            BinaryReader inFp;
            BinaryWriter outFp;

            string infname = "C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\write.exe";
            string outFname = "C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\write2.exe";

            inFp = new BinaryReader(File.Open(infname, FileMode.Open));
            outFp = new BinaryWriter(File.Open(outFname, FileMode.Create));

            long len = new FileInfo(infname).Length;
            for(long i = 0; i < len; i++)
            {
                byte data = inFp.ReadByte();
                outFp.Write(data);
            }

            inFp.Close();
            outFp.Close();
            Console.WriteLine("---정상적으로 바이너리 파일이 복사되었다.---");
        }

    }

}