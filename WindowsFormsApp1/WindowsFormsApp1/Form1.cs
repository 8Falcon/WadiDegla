using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int subscription = 10000;
        short membersubscription = 5000;
        short football = 500;
        short swim = 1000;
        short basketball = 800;
        int costgame;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            short number, numbergame;
            int value;

            number = short.Parse(txtnumber.Text);
            numbergame = short.Parse(txtnumgame.Text);
            value = number * membersubscription + subscription;

            if (chkpasket.Checked)
            {
                costgame = numbergame * basketball;
            }
            else if (chkfoot.Checked)
            {
                costgame = numbergame * football;
            } 
            else if (chkswim.Checked)
            {
                costgame = numbergame * swim;
            }
            txtcostgame.Text = costgame.ToString();
            txtvalue.Text = value.ToString();
            txttotal.Text = (value + costgame).ToString();
        }
    }
}
