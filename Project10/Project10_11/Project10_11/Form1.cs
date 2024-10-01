using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int XSIZE = 512, YSIZE = 512;
        byte[,] inImage;
        Bitmap bitmap;

        void LoadImage(string fname)
        {
            BinaryReader fp = new BinaryReader(File.Open(fname, FileMode.Open));
            inImage = new byte[XSIZE, YSIZE];

            for(int i = 0; i < XSIZE; i++)
                for(int k = 0; k < YSIZE; k++)
                    inImage[i, k] = fp.ReadByte();

            fp.Close();
        }

        void DisplayImage()
        {
            for(int i = 0;i < XSIZE; i++)
                for(int k = 0;k < YSIZE; k++)
                {
                    byte data = inImage[k, i];
                    Color c = Color.FromArgb(data, data, data);
                    bitmap.SetPixel(i, k, c);
                }

            picturebox.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(XSIZE, YSIZE);
            picturebox.Location = new System.Drawing.Point(XSIZE, YSIZE);
            picturebox.Size = new System.Drawing.Size(XSIZE, YSIZE);

            bitmap = new Bitmap(XSIZE, YSIZE);

            string fileName = "C:\\Users\\user\\Desktop\\tm_git\\C_parctice_self\\images\\test.raw";
            LoadImage(fileName);

            DisplayImage();
        }
    }
}
