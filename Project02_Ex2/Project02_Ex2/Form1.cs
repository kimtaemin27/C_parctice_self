using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1, x2, y2;
        Pen pen = new Pen(Color.Black, 10);

        private void btn_red_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, 10);
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Yellow, 10);
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;

            Graphics g = CreateGraphics();
            g.DrawLine(pen, x1, y1, x2, y2);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

    }
}
