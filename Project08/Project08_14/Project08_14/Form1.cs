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

namespace Project08_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }


        static bool IsNumberInArray(int[] ar, int num)
        {
            bool dupYN = false;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == num)
                    dupYN = true;
            }
            return dupYN;
        }


        static Random rnd = new Random();


        static void GetLotto(int[] ary)
        {
            int idx = 0;
            int pickNum;

            while(true)
            {
                pickNum = rnd.Next(1, 45);
                if (IsNumberInArray(ary, pickNum))
                    continue;

                ary[idx] = pickNum;
                if (idx >= 5)
                    break;

                idx++;
            }
        }


        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 600, sheight = 600;
            this.Text = "거북이 로또 추첨";
            this.ClientSize = new Size(sheight, swidth);
            Turtle.Delay = 50;

            int[] lottoAry = new int[6];

            GetLotto(lottoAry);
            Array.Sort(lottoAry, 0, 6);

            string lottoText = "";
            foreach(int n in lottoAry)
            {
                lottoText += n.ToString() + " ";
            }
            tb_lotto.Text = lottoText;

            Turtle.PenSize = 5;
            for(int i = 0; i < 45; i++)
            {
                Turtle.PenColor = Color.Gray;
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.RotateTo(i * 8);
                Turtle.Forward(150);
            }

            Turtle.PenSize = 10;
            for(int i = 0; i < lottoAry.Length; i++)
            {
                int R = rnd.Next(0, 256);
                int G = rnd.Next(0, 256);
                int B = rnd.Next(0, 256);
                Turtle.PenColor = Color.FromArgb(R, G, B);
                Turtle.PenUp();
                Turtle.PenDown();
                Turtle.RotateTo(lottoAry[i] * 8);
                Turtle.Forward(170);
            }
        }
    }
}
