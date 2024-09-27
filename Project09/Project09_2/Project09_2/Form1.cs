using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project09_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_id.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요");
            }
            else
            {
                if(tb_id.Text == "taemin" && tb_pass.Text == "css")
                {
                    MessageBox.Show(tb_id.Text + "님 어서오세요.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("아이디와 비밀번호를 다시 확인하세요.");
                }
            }
        }
    }
}
