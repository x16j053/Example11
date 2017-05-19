using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            int year = int.Parse(tbxYear.Text);

            if (year % 4 != 0)
                lblResult.Text = "平年です";
            else
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        lblResult.Text = "うるう年です";
                    else
                        lblResult.Text = "平年です";
                }
                else
                    lblResult.Text = "うるう年です";
            }
        }
    }
}
