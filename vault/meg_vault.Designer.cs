
namespace vault
{
    partial class megalogon_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_button = new System.Windows.Forms.Button();
            this.user_icon = new System.Windows.Forms.PictureBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.rsa_icon = new System.Windows.Forms.PictureBox();
            this.rsa_private_key = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.open_key = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsa_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(162)))));
            this.login_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_button.Location = new System.Drawing.Point(98, 502);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(256, 27);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // user_icon
            // 
            this.user_icon.Image = global::vault.Properties.Resources.User_Login1;
            this.user_icon.Location = new System.Drawing.Point(23, 280);
            this.user_icon.Name = "user_icon";
            this.user_icon.Size = new System.Drawing.Size(48, 48);
            this.user_icon.TabIndex = 1;
            this.user_icon.TabStop = false;
            // 
            // username_box
            // 
            this.username_box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_box.Location = new System.Drawing.Point(77, 292);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(165, 26);
            this.username_box.TabIndex = 2;
            this.username_box.Text = "Username";
            this.username_box.TextChanged += new System.EventHandler(this.username_box_TextChanged);
            // 
            // rsa_icon
            // 
            this.rsa_icon.Image = global::vault.Properties.Resources.private_rsa;
            this.rsa_icon.Location = new System.Drawing.Point(23, 354);
            this.rsa_icon.Name = "rsa_icon";
            this.rsa_icon.Size = new System.Drawing.Size(48, 48);
            this.rsa_icon.TabIndex = 3;
            this.rsa_icon.TabStop = false;
            // 
            // rsa_private_key
            // 
            this.rsa_private_key.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rsa_private_key.Location = new System.Drawing.Point(77, 366);
            this.rsa_private_key.Name = "rsa_private_key";
            this.rsa_private_key.Size = new System.Drawing.Size(267, 26);
            this.rsa_private_key.TabIndex = 4;
            this.rsa_private_key.Text = "RSA Private Key";
            this.rsa_private_key.TextChanged += new System.EventHandler(this.rsa_private_key_TextChanged);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.logo.Image = global::vault.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(98, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(256, 256);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // open_key
            // 
            this.open_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(161)))));
            this.open_key.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.open_key.Location = new System.Drawing.Point(362, 366);
            this.open_key.Name = "open_key";
            this.open_key.Size = new System.Drawing.Size(75, 26);
            this.open_key.TabIndex = 6;
            this.open_key.Text = "Open";
            this.open_key.UseVisualStyleBackColor = false;
            this.open_key.Click += new System.EventHandler(this.open_key_Click);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(161)))));
            this.register_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.register_button.Location = new System.Drawing.Point(98, 546);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(256, 26);
            this.register_button.TabIndex = 7;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // megalogon_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(462, 642);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.open_key);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.rsa_private_key);
            this.Controls.Add(this.rsa_icon);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.user_icon);
            this.Controls.Add(this.login_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "megalogon_login";
            this.Text = "Megalodon: RSA Password Manager";
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsa_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.PictureBox user_icon;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.PictureBox rsa_icon;
        private System.Windows.Forms.TextBox rsa_private_key;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button open_key;
        private System.Windows.Forms.Button register_button;
    }
}

