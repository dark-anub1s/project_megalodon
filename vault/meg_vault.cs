/*
 Author: Tyler Higgins
 Date: 7-9-2022
 Program Discription: This will be a modification of a program I have already written in Python.
 This program is a password manager that uses RSA for the user account
 Estamated Time to Complete: 4 Hours (2 hours in)
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
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace vault
{
    public partial class megalogon_login : Form
    {
        public megalogon_login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_box.Text == "thiggins" && rsa_private_key.Text == "key")
            {
                user_account user_acc = new user_account();
                this.Hide();
                user_acc.Closed += (s, args) => this.Close();
                user_acc.Show();
            }
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void rsa_private_key_TextChanged(object sender, EventArgs e)
        {

        }

        private void open_key_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog rsa_key = new OpenFileDialog();
                rsa_key.Title = "RSA Private Key";


                if (rsa_key.ShowDialog() == DialogResult.OK)
                {
                    rsa_private_key.Text = rsa_key.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Error.");
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            user_registration new_user = new user_registration();
            new_user.Show();
        }

        private void user_icon_Click(object sender, EventArgs e)
        {

        }

        private void rsa_icon_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }

    public class RsaEncryption
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        private RSAParameters _privayeKey;
        private RSAParameters _publicKey;

        public RsaEncryption()
        {
            _privayeKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
        }

        public string GetPublicKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _publicKey);

            return sw.ToString();
        }

        public string GetPrivateKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));

            xs.Serialize(sw, _privayeKey);

            return sw.ToString();
        }
    }

}
