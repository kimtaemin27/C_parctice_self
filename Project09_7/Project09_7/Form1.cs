using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project09_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            cb_alt.Checked = cb_ctrl.Checked = cb_shift.Checked = false;

            if (e.Alt == true)
                cb_alt.Checked = true;
            if(e.Control == true)
                cb_ctrl.Checked = true;
            if(e.Shift == true)
                cb_shift.Checked = true;

            char keyValue = (char)e.KeyValue;
            tb_key.Text = keyValue.ToString();
        }
    }
}
