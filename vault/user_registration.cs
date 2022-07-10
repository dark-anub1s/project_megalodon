using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vault
{
    public partial class user_registration : Form
    {
        string priKey;
        string pubKey;
        public user_registration()
        {
            InitializeComponent();
        }

        private void generate_rsa_pair_Click(object sender, EventArgs e)
        {
            RsaEncryption rsa = new RsaEncryption();

            priKey = rsa.GetPrivateKey();

            pubKey = rsa.GetPublicKey();

            Save.Show();
            generate_rsa_pair.Hide();
            MessageBox.Show("RSA Key Pair Has been Generated");
        }

        private void key_save_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_username_Click(object sender, EventArgs e)
        {
            try
            {
                //This block will be used to check that the provided username is not already in the database.
                var checkUsername = new_user_box.Text;
            }

            catch
            {

            }
        }

        private void new_user_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Private Key";
            save.Filter = "Key File (*.key)|*.key| All Files (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                key_save_box.Text = save.FileName;
                StreamWriter write = new StreamWriter(save.FileName);

                write.Write(priKey);
                write.Dispose();
            }

        }
    }
}
