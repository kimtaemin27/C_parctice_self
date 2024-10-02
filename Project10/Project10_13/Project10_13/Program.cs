using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace Project10_13
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string folder1, folder2;

            folder1 = "C:\\Windows\\Help\\";
            folder2 = "C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\Project10";

            if(Directory.Exists(folder1))
            {
                FileSystem.CopyDirectory(folder1, folder2, UIOption.AllDialogs);
                Console.WriteLine("{0} 폴더가 {1} 폴더로 복사됨.", folder2, folder2);
            }
        }

    }

}