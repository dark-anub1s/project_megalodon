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
    public partial class user_account : Form
    {
        public user_account()
        {
            InitializeComponent();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pass_gen passwordGen = new pass_gen();
            passwordGen.Show();
        }
    }
}
