using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project09_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            String text = "\n(1) 좋아하는 자동차 : ";
            CheckBox[] chkArray = { cb_benz, cb_bmw, cb_audi, cb_porsche };
            RadioButton[] rdoArray = { rdo_pour, rdo_pick, rdo_raw };

            foreach(CheckBox ck in chkArray)
            {
                if (ck.Checked)
                    text += ck.Text + " ";
            }

            text += "\n(2) 탕수육 먹는법 : ";

            foreach (RadioButton rdo in rdoArray)
            {
                if (rdo.Checked)
                    text += rdo.Text + " ";
            }

            rich_result.Text += text;
        }
    }
}
