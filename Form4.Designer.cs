namespace Proiect_POO_bun
{
    partial class ModifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUser));
            this.ExecuteQueryButton = new System.Windows.Forms.Button();
            this.Titlu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.NumeTextBox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExecuteQueryButton
            // 
            this.ExecuteQueryButton.Location = new System.Drawing.Point(128, 172);
            this.ExecuteQueryButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ExecuteQueryButton.Name = "ExecuteQueryButton";
            this.ExecuteQueryButton.Size = new System.Drawing.Size(45, 36);
            this.ExecuteQueryButton.TabIndex = 15;
            this.ExecuteQueryButton.Text = "OK";
            this.ExecuteQueryButton.UseVisualStyleBackColor = true;
            this.ExecuteQueryButton.Click += new System.EventHandler(this.ExecuteQueryButton_Click);
            // 
            // Titlu
            // 
            this.Titlu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Titlu.AutoSize = true;
            this.Titlu.Font = new System.Drawing.Font("UT Sans Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlu.Location = new System.Drawing.Point(98, 9);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(127, 26);
            this.Titlu.TabIndex = 14;
            this.Titlu.Text = "Adauga student";
            this.Titlu.Click += new System.EventHandler(this.Titlu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UT Sans Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Parolă";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UT Sans Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nume";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(78, 135);
            this.PassTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(210, 27);
            this.PassTextBox.TabIndex = 9;
            // 
            // NumeTextBox
            // 
            this.NumeTextBox.Location = new System.Drawing.Point(78, 91);
            this.NumeTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NumeTextBox.Name = "NumeTextBox";
            this.NumeTextBox.Size = new System.Drawing.Size(210, 27);
            this.NumeTextBox.TabIndex = 8;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("UT Sans Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(16, 54);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(20, 20);
            this.IDlabel.TabIndex = 17;
            this.IDlabel.Text = "ID";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(78, 49);
            this.IDtextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(210, 27);
            this.IDtextBox.TabIndex = 16;
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 271);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.ExecuteQueryButton);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.NumeTextBox);
            this.Font = new System.Drawing.Font("UT Sans Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ModifyUser";
            this.Text = "Adaugare";
            this.Load += new System.EventHandler(this.ModifyUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteQueryButton;
        private System.Windows.Forms.Label Titlu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox NumeTextBox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox IDtextBox;
    }
}