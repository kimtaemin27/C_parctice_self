using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project09_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void masktb_brith_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void datepick_brith_ValueChanged(object sender, EventArgs e)
        {
            masktb_brith.Text = datepick_brith.Value.ToString();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            list_lang.Items.Add(combo_lang.Text);
        }

    }
}
