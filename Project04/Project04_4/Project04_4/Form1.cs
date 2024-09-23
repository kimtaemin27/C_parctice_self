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

namespace Project04_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            // Turtle.Forward();

            // 밀리초 단위로 지정하는 속도 0 으로 지정하면 움직임이 보이지 않는다.
            Turtle.Delay = 500;
            // 움직이는 각도
            // Turtle.Rotate(45);
            // 움직이는 거리
            // Turtle.Forward(100);
            // Turtle.Rotate(45);
            // 뒤로 움직이는 거리
            // Turtle.Backward(100);

            // 펜의 색상 지정
            Turtle.PenColor = Color.Red;


            // 펜을 사용하지 않겠다는 기능
            Turtle.PenUp();
            // 좌우거리, 상하거리 를 지정해서 지정한 만큼 이동시킨다
            Turtle.MoveTo(-150, 0);
            for(int i = 0; i < 9; i++)
            {
                Turtle.PenDown();
                Turtle.Rotate(45);
                Turtle.Forward(50);

                Turtle.PenUp();
                Turtle.Rotate(20);
                Turtle.Forward(50);
            }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }
    }
}
