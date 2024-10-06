using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project11_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num_1.Maximum = num_2.Maximum = Int32.MaxValue;
            num_1.Minimum = num_2.Minimum = Int32.MinValue;
        }

        private void btm_add_Click(object sender, EventArgs e)
        {
            int result = CookMath.Add((int)num_1.Value, (int)num_2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int result = CookMath.Subtract((int)num_1.Value, (int)num_2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int result = CookMath.Divide((int)num_1.Value, (int)num_2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            int result = CookMath.Myltiply((int)num_1.Value, (int)num_2.Value);
            tb_result.Text = result.ToString();
        }
    }

    public static class CookMath
    {
        public static double COOK_PI = 3.141592653;
        public static double COOK_E = 2.718281;

        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Myltiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Divide(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
