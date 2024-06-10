namespace Proiect_POO_bun
{
    partial class UniCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniCatalog));
            this.Main_panel = new System.Windows.Forms.Panel();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.submitUserButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_panel.Controls.Add(this.showPasswordCheckBox);
            this.Main_panel.Controls.Add(this.submitUserButton);
            this.Main_panel.Controls.Add(this.passwordBox);
            this.Main_panel.Controls.Add(this.userBox);
            this.Main_panel.Controls.Add(this.pictureBox1);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_panel.Margin = new System.Windows.Forms.Padding(2);
            this.Main_panel.MaximumSize = new System.Drawing.Size(375, 406);
            this.Main_panel.MinimumSize = new System.Drawing.Size(375, 406);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(375, 406);
            this.Main_panel.TabIndex = 0;
            this.Main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_panel_Paint);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.showPasswordCheckBox.BackColor = System.Drawing.Color.Black;
            this.showPasswordCheckBox.BackgroundImage = global::Proiect_POO_bun.Properties.Resources.show_password;
            this.showPasswordCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPasswordCheckBox.FlatAppearance.BorderSize = 0;
            this.showPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("UT Sans Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(247, 204);
            this.showPasswordCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(35, 35);
            this.showPasswordCheckBox.TabIndex = 3;
            this.showPasswordCheckBox.UseVisualStyleBackColor = false;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // submitUserButton
            // 
            this.submitUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.submitUserButton.FlatAppearance.BorderSize = 0;
            this.submitUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitUserButton.Font = new System.Drawing.Font("UT Sans Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitUserButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitUserButton.Location = new System.Drawing.Point(88, 276);
            this.submitUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitUserButton.Name = "submitUserButton";
            this.submitUserButton.Size = new System.Drawing.Size(194, 39);
            this.submitUserButton.TabIndex = 0;
            this.submitUserButton.Text = "Login";
            this.submitUserButton.UseVisualStyleBackColor = false;
            this.submitUserButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.submitUserButton_MouseClick);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("UT Sans Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(88, 204);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(162, 35);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.SystemColors.Window;
            this.userBox.Font = new System.Drawing.Font("UT Sans Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.Location = new System.Drawing.Point(88, 154);
            this.userBox.Margin = new System.Windows.Forms.Padding(2);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(194, 35);
            this.userBox.TabIndex = 1;
            this.userBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userBox.Enter += new System.EventHandler(this.userBox_Enter);
            this.userBox.Leave += new System.EventHandler(this.userBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Proiect_POO_bun.Properties.Resources.pfp;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(134, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UniCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_POO_bun.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 366);
            this.Controls.Add(this.Main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UniCatalog";
            this.Text = "UniCatalog";
            this.Main_panel.ResumeLayout(false);
            this.Main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button submitUserButton;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}

