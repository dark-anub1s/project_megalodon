
namespace vault
{
    partial class pass_gen
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
            this.passSize = new System.Windows.Forms.TrackBar();
            this.passSizeLabel = new System.Windows.Forms.Label();
            this.passGenerate = new System.Windows.Forms.Button();
            this.UpperCheck = new System.Windows.Forms.CheckBox();
            this.LowerCheck = new System.Windows.Forms.CheckBox();
            this.NumberCheck = new System.Windows.Forms.CheckBox();
            this.SpecialCheck = new System.Windows.Forms.CheckBox();
            this.UsePass = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.passSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passSize
            // 
            this.passSize.Location = new System.Drawing.Point(172, 168);
            this.passSize.Maximum = 128;
            this.passSize.Name = "passSize";
            this.passSize.Size = new System.Drawing.Size(380, 45);
            this.passSize.TabIndex = 0;
            this.passSize.TickFrequency = 10;
            this.passSize.Scroll += new System.EventHandler(this.passSize_Scroll);
            // 
            // passSizeLabel
            // 
            this.passSizeLabel.AutoSize = true;
            this.passSizeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passSizeLabel.Location = new System.Drawing.Point(535, 195);
            this.passSizeLabel.Name = "passSizeLabel";
            this.passSizeLabel.Size = new System.Drawing.Size(17, 18);
            this.passSizeLabel.TabIndex = 1;
            this.passSizeLabel.Text = "0";
            this.passSizeLabel.Click += new System.EventHandler(this.passSizeLabel_Click);
            // 
            // passGenerate
            // 
            this.passGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.passGenerate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passGenerate.Location = new System.Drawing.Point(270, 260);
            this.passGenerate.Name = "passGenerate";
            this.passGenerate.Size = new System.Drawing.Size(181, 23);
            this.passGenerate.TabIndex = 3;
            this.passGenerate.Text = "Generate Password";
            this.passGenerate.UseVisualStyleBackColor = false;
            this.passGenerate.Click += new System.EventHandler(this.passGenerate_Click);
            // 
            // UpperCheck
            // 
            this.UpperCheck.AutoSize = true;
            this.UpperCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpperCheck.Location = new System.Drawing.Point(194, 219);
            this.UpperCheck.Name = "UpperCheck";
            this.UpperCheck.Size = new System.Drawing.Size(70, 22);
            this.UpperCheck.TabIndex = 4;
            this.UpperCheck.Text = "Upper";
            this.UpperCheck.UseVisualStyleBackColor = true;
            this.UpperCheck.CheckedChanged += new System.EventHandler(this.UpperCheck_CheckedChanged);
            // 
            // LowerCheck
            // 
            this.LowerCheck.AutoSize = true;
            this.LowerCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LowerCheck.Location = new System.Drawing.Point(270, 219);
            this.LowerCheck.Name = "LowerCheck";
            this.LowerCheck.Size = new System.Drawing.Size(70, 22);
            this.LowerCheck.TabIndex = 5;
            this.LowerCheck.Text = "Lower";
            this.LowerCheck.UseVisualStyleBackColor = true;
            // 
            // NumberCheck
            // 
            this.NumberCheck.AutoSize = true;
            this.NumberCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberCheck.Location = new System.Drawing.Point(347, 221);
            this.NumberCheck.Name = "NumberCheck";
            this.NumberCheck.Size = new System.Drawing.Size(90, 22);
            this.NumberCheck.TabIndex = 6;
            this.NumberCheck.Text = "Numbers";
            this.NumberCheck.UseVisualStyleBackColor = true;
            // 
            // SpecialCheck
            // 
            this.SpecialCheck.AutoSize = true;
            this.SpecialCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecialCheck.Location = new System.Drawing.Point(444, 223);
            this.SpecialCheck.Name = "SpecialCheck";
            this.SpecialCheck.Size = new System.Drawing.Size(80, 22);
            this.SpecialCheck.TabIndex = 7;
            this.SpecialCheck.Text = "Special";
            this.SpecialCheck.UseVisualStyleBackColor = true;
            // 
            // UsePass
            // 
            this.UsePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.UsePass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsePass.Location = new System.Drawing.Point(535, 260);
            this.UsePass.Name = "UsePass";
            this.UsePass.Size = new System.Drawing.Size(161, 23);
            this.UsePass.TabIndex = 8;
            this.UsePass.Text = "Save Password";
            this.UsePass.UseVisualStyleBackColor = false;
            // 
            // passLabel
            // 
            this.passLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.passLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(12, 46);
            this.passLabel.MaxLength = 130;
            this.passLabel.Multiline = true;
            this.passLabel.Name = "passLabel";
            this.passLabel.ReadOnly = true;
            this.passLabel.Size = new System.Drawing.Size(694, 116);
            this.passLabel.TabIndex = 9;
            this.passLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // pass_gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(720, 309);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.UsePass);
            this.Controls.Add(this.SpecialCheck);
            this.Controls.Add(this.NumberCheck);
            this.Controls.Add(this.LowerCheck);
            this.Controls.Add(this.UpperCheck);
            this.Controls.Add(this.passGenerate);
            this.Controls.Add(this.passSizeLabel);
            this.Controls.Add(this.passSize);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pass_gen";
            this.Text = "pass_gen";
            this.Load += new System.EventHandler(this.pass_gen_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.passSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar passSize;
        private System.Windows.Forms.Label passSizeLabel;
        private System.Windows.Forms.Button passGenerate;
        private System.Windows.Forms.CheckedListBox Upper;
        private System.Windows.Forms.CheckBox UpperCheck;
        private System.Windows.Forms.CheckBox LowerCheck;
        private System.Windows.Forms.CheckBox NumberCheck;
        private System.Windows.Forms.CheckBox SpecialCheck;
        private System.Windows.Forms.Button UsePass;
        private System.Windows.Forms.TextBox passLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
    }
}