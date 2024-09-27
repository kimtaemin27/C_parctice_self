using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project09_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_image_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                tb_type.Text = "왼쪽";
            else if (e.Button == MouseButtons.Right)
                tb_type.Text = "오른쪽";
            else
                tb_type.Text = "가운데";

            if (e.Clicks == 2)
                tb_action.Text = "더블 클릭";
            else
                tb_action.Text = "한 번 클릭";

            tb_x.Text = e.X.ToString();
            tb_y.Text = e.Y.ToString();
        }

        private void pb_image_DoubleClick(object sender, EventArgs e)
        {
            if (pb_image.SizeMode == PictureBoxSizeMode.Normal)
                pb_image.SizeMode = PictureBoxSizeMode.StretchImage;
            else if (pb_image.SizeMode == PictureBoxSizeMode.StretchImage)
                pb_image.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pb_image.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
