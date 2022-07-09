
namespace vault
{
    partial class user_registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generate_rsa_pair = new System.Windows.Forms.Button();
            this.rsa_private = new System.Windows.Forms.TextBox();
            this.rsa_public = new System.Windows.Forms.TextBox();
            this.private_key = new System.Windows.Forms.Label();
            this.public_key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generate_rsa_pair
            // 
            this.generate_rsa_pair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generate_rsa_pair.Location = new System.Drawing.Point(476, 604);
            this.generate_rsa_pair.Name = "generate_rsa_pair";
            this.generate_rsa_pair.Size = new System.Drawing.Size(203, 23);
            this.generate_rsa_pair.TabIndex = 0;
            this.generate_rsa_pair.Text = "Create RSA Pair";
            this.generate_rsa_pair.UseVisualStyleBackColor = true;
            this.generate_rsa_pair.Click += new System.EventHandler(this.generate_rsa_pair_Click);
            // 
            // rsa_private
            // 
            this.rsa_private.Location = new System.Drawing.Point(12, 331);
            this.rsa_private.Multiline = true;
            this.rsa_private.Name = "rsa_private";
            this.rsa_private.Size = new System.Drawing.Size(443, 296);
            this.rsa_private.TabIndex = 1;
            // 
            // rsa_public
            // 
            this.rsa_public.Location = new System.Drawing.Point(697, 331);
            this.rsa_public.Multiline = true;
            this.rsa_public.Name = "rsa_public";
            this.rsa_public.Size = new System.Drawing.Size(443, 296);
            this.rsa_public.TabIndex = 2;
            // 
            // private_key
            // 
            this.private_key.AutoSize = true;
            this.private_key.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.private_key.ForeColor = System.Drawing.SystemColors.Control;
            this.private_key.Location = new System.Drawing.Point(13, 310);
            this.private_key.Name = "private_key";
            this.private_key.Size = new System.Drawing.Size(88, 18);
            this.private_key.TabIndex = 3;
            this.private_key.Text = "Private Key";
            // 
            // public_key
            // 
            this.public_key.AutoSize = true;
            this.public_key.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.public_key.ForeColor = System.Drawing.SystemColors.Control;
            this.public_key.Location = new System.Drawing.Point(697, 310);
            this.public_key.Name = "public_key";
            this.public_key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.public_key.Size = new System.Drawing.Size(82, 18);
            this.public_key.TabIndex = 4;
            this.public_key.Text = "Public Key";
            // 
            // user_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1152, 700);
            this.Controls.Add(this.public_key);
            this.Controls.Add(this.private_key);
            this.Controls.Add(this.rsa_public);
            this.Controls.Add(this.rsa_private);
            this.Controls.Add(this.generate_rsa_pair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "user_registration";
            this.Text = "Megalondon Vault User Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_rsa_pair;
        private System.Windows.Forms.TextBox rsa_private;
        private System.Windows.Forms.TextBox rsa_public;
        private System.Windows.Forms.Label private_key;
        private System.Windows.Forms.Label public_key;
    }
}