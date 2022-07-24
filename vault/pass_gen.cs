/*
 * Project time estimate 2 hours
 * Project time: 2 hours
 */
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
    public partial class pass_gen : Form
    {
        private static bool upper, lower, number, special;
        private static int PasswordSize;
        private List<string> passHistList = new List<string>();

        private void UpperCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void passGenerate_Click(object sender, EventArgs e)
        {
            if (UpperCheck.CheckState == CheckState.Checked)
            {
                upper = true;
            }

            if (LowerCheck.CheckState == CheckState.Checked)
            {
                lower = true;
            }

            if (NumberCheck.CheckState == CheckState.Checked)
            {
                number = true;
            }

            if (SpecialCheck.CheckState == CheckState.Checked)
            {
                special = true;
            }

            passLabel.Text = PasswordGenerator.GeneratePassword(upper, lower, number, special, PasswordSize);

            if (passHistList.Count == 6)
            {
                passHistList.RemoveAt(0);
                passHistList.Add(passLabel.Text);
            }
            else
            {
                passHistList.Add(passLabel.Text);
            }
        }

        private void pass_gen_Load(object sender, EventArgs e)
        {

        }

        private void pass_gen_Load_1(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passhistory passHistory = new passhistory(passHistList);
            passHistory.Show();
        }

        public pass_gen()
        {
            InitializeComponent();
        }

        private void passSize_Scroll(object sender, EventArgs e)
        {
            passSizeLabel.Text = passSize.Value.ToString();
            PasswordSize = passSize.Value;
        }

        private void passSizeLabel_Click(object sender, EventArgs e)
        {

        }
    }
    public static class PasswordGenerator
    {
        private static string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string Numbers = "1234567890";
        private static string SpecialChars = "!@#$%^&*()_-+=?><,.:;";

        public static string GeneratePassword(
            bool useUpper,
            bool useLower,
            bool useNumbers,
            bool useSpecial,
            int PasswordSize)
        {
            Random rand = new Random();
            string charSet = string.Empty;
            char[] password = new char[PasswordSize];

            if (useUpper) charSet += Upper;
            if (useLower) charSet += Upper.ToLower();
            if (useNumbers) charSet += Numbers;
            if (useSpecial) charSet += SpecialChars;

            for (int i = 0; i < PasswordSize; i++)
            {
                password[i] = charSet[rand.Next(charSet.Length - 1)];
            }

            return string.Join(null, password);
        }
    }
}
