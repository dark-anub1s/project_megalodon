using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vault
{
    public partial class passhistory : Form
    {
        public passhistory(List<string> passHistory)
        {
            InitializeComponent();

            if (passHistory.Count() >= 1)
            {
                passHistory1.Text = passHistory[0];
            }

            if (passHistory.Count() >= 2)
            {
                passHistory2.Text = passHistory[1];
            }

            if (passHistory.Count() >= 3)
            {
                passHistory3.Text = passHistory[2];
            }

            if (passHistory.Count() >= 4)
            {
                passHistory4.Text = passHistory[3];
            }

            if (passHistory.Count() >= 5)
            {
                passHistory5.Text = passHistory[4];
            }

            if (passHistory.Count() >= 6)
            {
                passHistory6.Text = passHistory[5];
            }
        }

        private void passHistory5_TextChanged(object sender, EventArgs e)
        {

        }

        private void passHistory1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearList_Click(object sender, EventArgs e)
        {

        }
    }
}
