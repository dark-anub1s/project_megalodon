
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
            this.user_add = new System.Windows.Forms.PictureBox();
            this.new_user_box = new System.Windows.Forms.TextBox();
            this.check_username = new System.Windows.Forms.Button();
            this.file_save = new System.Windows.Forms.PictureBox();
            this.key_save_box = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.file_save)).BeginInit();
            this.SuspendLayout();
            // 
            // generate_rsa_pair
            // 
            this.generate_rsa_pair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.generate_rsa_pair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generate_rsa_pair.Location = new System.Drawing.Point(461, 135);
            this.generate_rsa_pair.Name = "generate_rsa_pair";
            this.generate_rsa_pair.Size = new System.Drawing.Size(203, 23);
            this.generate_rsa_pair.TabIndex = 0;
            this.generate_rsa_pair.Text = "Create RSA Pair";
            this.generate_rsa_pair.UseVisualStyleBackColor = false;
            this.generate_rsa_pair.Click += new System.EventHandler(this.generate_rsa_pair_Click);
            // 
            // user_add
            // 
            this.user_add.Image = global::vault.Properties.Resources.User_Add;
            this.user_add.Location = new System.Drawing.Point(13, 64);
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(48, 48);
            this.user_add.TabIndex = 5;
            this.user_add.TabStop = false;
            // 
            // new_user_box
            // 
            this.new_user_box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.new_user_box.Location = new System.Drawing.Point(67, 76);
            this.new_user_box.Name = "new_user_box";
            this.new_user_box.Size = new System.Drawing.Size(166, 26);
            this.new_user_box.TabIndex = 6;
            this.new_user_box.Text = "Username";
            this.new_user_box.TextChanged += new System.EventHandler(this.new_user_box_TextChanged);
            // 
            // check_username
            // 
            this.check_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.check_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_username.Location = new System.Drawing.Point(239, 78);
            this.check_username.Name = "check_username";
            this.check_username.Size = new System.Drawing.Size(65, 24);
            this.check_username.TabIndex = 7;
            this.check_username.Text = "Check";
            this.check_username.UseVisualStyleBackColor = false;
            this.check_username.Click += new System.EventHandler(this.check_username_Click);
            // 
            // file_save
            // 
            this.file_save.Image = global::vault.Properties.Resources.FIle_Save;
            this.file_save.Location = new System.Drawing.Point(13, 119);
            this.file_save.Name = "file_save";
            this.file_save.Size = new System.Drawing.Size(48, 48);
            this.file_save.TabIndex = 8;
            this.file_save.TabStop = false;
            // 
            // key_save_box
            // 
            this.key_save_box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key_save_box.Location = new System.Drawing.Point(67, 132);
            this.key_save_box.Name = "key_save_box";
            this.key_save_box.Size = new System.Drawing.Size(388, 26);
            this.key_save_box.TabIndex = 9;
            this.key_save_box.Text = "Save Private Key";
            this.key_save_box.TextChanged += new System.EventHandler(this.key_save_box_TextChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(68, 165);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(165, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // user_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1152, 700);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.key_save_box);
            this.Controls.Add(this.file_save);
            this.Controls.Add(this.check_username);
            this.Controls.Add(this.new_user_box);
            this.Controls.Add(this.user_add);
            this.Controls.Add(this.generate_rsa_pair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "user_registration";
            this.Text = "Megalondon Vault User Registration";
            ((System.ComponentModel.ISupportInitialize)(this.user_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.file_save)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_rsa_pair;
        private System.Windows.Forms.PictureBox user_add;
        private System.Windows.Forms.TextBox new_user_box;
        private System.Windows.Forms.Button check_username;
        private System.Windows.Forms.PictureBox file_save;
        private System.Windows.Forms.TextBox key_save_box;
        private System.Windows.Forms.Button Save;
    }
}