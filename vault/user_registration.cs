﻿using System;
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
    public partial class user_registration : Form
    {
        public user_registration()
        {
            InitializeComponent();
        }

        private void generate_rsa_pair_Click(object sender, EventArgs e)
        {
            RsaEncryption rsa = new RsaEncryption();

            rsa_private.Text = rsa.GetPrivateKey();

            rsa_public.Text = rsa.GetPublicKey();
        }
    }
}
