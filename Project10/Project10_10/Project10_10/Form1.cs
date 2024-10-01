using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int XSIZE = 512;
        int YSIZE = 512;

        Bitmap bitmap;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(XSIZE, YSIZE);
            picturebox.Location = new System.Drawing.Point(0, 0);
            picturebox.Size = new System.Drawing.Size(XSIZE, YSIZE);

            bitmap = new Bitmap(XSIZE, YSIZE);

            Random rnd = new Random();
            for(int i = 0; i < XSIZE; i++)
                for(int k = 0; k < YSIZE; k++)
                {
                    byte data = (byte)rnd.Next(0, 256);
                    Color c = Color.FromArgb(data, data, data);
                    bitmap.SetPixel(i, k, c);
                }

            picturebox.Image = bitmap;
        }
    }
}
