using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace Project07_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 800, sheight = 800;
            this.Text = "거북이 쇼";
            this.ClientSize = new Size(sheight, swidth);
            Turtle.Delay = 10;

            Random rnd = new Random();
            int turtleNumber = rnd.Next(50, 100);
            int[,] turtleAry = new int[turtleNumber, 6];

            for(int i = 0; i < turtleNumber; i++)
            {
                turtleAry[i, 0] = rnd.Next(-swidth / 2, swidth / 2);
                turtleAry[i, 1] = rnd.Next(-swidth / 2, swidth / 2);
                turtleAry[i, 2] = rnd.Next(1, 20);
                turtleAry[i, 3] = rnd.Next(0, 256);
                turtleAry[i, 4] = rnd.Next(2, 256);
                turtleAry[i, 5] = rnd.Next(2, 256);
            }

            for(int i = 0; i < turtleNumber; i++)
            {
                Turtle.PenSize = turtleAry[i, 2];
                Turtle.PenColor = Color.FromArgb(turtleAry[i, 3], turtleAry[i, 4], turtleAry[i, 5]);
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.MoveTo(turtleAry[i, 0], turtleAry[i, 1]);

                int angle = (int)(Math.Atan2(turtleAry[i, 0], turtleAry[i, 1]) * 180 / Math.PI);

                Turtle.RotateTo(angle - 90);
                for(int k = 0; k < 9; k++)
                {
                    Turtle.Forward(turtleAry[i, 2]);
                    Turtle.Rotate(40);
                }
            }
        }
    }
}
