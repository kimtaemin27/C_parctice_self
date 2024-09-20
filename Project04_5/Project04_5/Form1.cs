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

namespace Project04_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 400, sheight = 400, exitCount = 0;
            int r, g, b, angle, dist;
            float curX, curY;

            this.Text = "마음대로 다니는 거북이";
            this.ClientSize = new Size(sheight, swidth);

            Random rnd = new Random();
            Turtle.Delay = 200;
            
            while(true)
            {
                r = rnd.Next(0, 256);
                g = rnd.Next(0, 256);
                b = rnd.Next(0, 256);

                Turtle.PenColor = Color.FromArgb(r, g, b);

                angle = rnd.Next(0, 360);
                dist = rnd.Next(1, 100);
                Turtle.Rotate(angle);
                Turtle.Forward(dist);
                curX = Turtle.X;
                curY = Turtle.Y;

                if((-swidth / 2 <= curX && curX <= swidth / 2) && (-sheight / 2 <= curY && curY <= sheight / 2))
                {

                }
                else
                {
                    Turtle.PenUp();
                    Turtle.MoveTo(0, 0);
                    Turtle.PenDown();

                    exitCount++;
                    if (exitCount == 5)
                        break;
                }
            }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }
    }
}
