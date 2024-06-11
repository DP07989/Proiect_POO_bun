namespace Proiect_POO_bun
{
    partial class AddPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrograma));
            this.NumeLabel = new System.Windows.Forms.Label();
            this.PrescurtareLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrescurtareTB = new System.Windows.Forms.TextBox();
            this.NumeTB = new System.Windows.Forms.TextBox();
            this.DurataTB = new System.Windows.Forms.TextBox();
            this.TipTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeLabel
            // 
            this.NumeLabel.AutoSize = true;
            this.NumeLabel.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeLabel.Location = new System.Drawing.Point(16, 78);
            this.NumeLabel.Name = "NumeLabel";
            this.NumeLabel.Size = new System.Drawing.Size(43, 20);
            this.NumeLabel.TabIndex = 0;
            this.NumeLabel.Text = "Nume";
            // 
            // PrescurtareLabel
            // 
            this.PrescurtareLabel.AutoSize = true;
            this.PrescurtareLabel.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescurtareLabel.Location = new System.Drawing.Point(16, 118);
            this.PrescurtareLabel.Name = "PrescurtareLabel";
            this.PrescurtareLabel.Size = new System.Drawing.Size(77, 20);
            this.PrescurtareLabel.TabIndex = 2;
            this.PrescurtareLabel.Text = "Prescurtare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UT Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Durata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UT Sans Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adăugați o programă";
            // 
            // PrescurtareTB
            // 
            this.PrescurtareTB.Location = new System.Drawing.Point(98, 118);
            this.PrescurtareTB.Name = "PrescurtareTB";
            this.PrescurtareTB.Size = new System.Drawing.Size(245, 27);
            this.PrescurtareTB.TabIndex = 8;
            // 
            // NumeTB
            // 
            this.NumeTB.Location = new System.Drawing.Point(98, 78);
            this.NumeTB.Name = "NumeTB";
            this.NumeTB.Size = new System.Drawing.Size(245, 27);
            this.NumeTB.TabIndex = 9;
            // 
            // DurataTB
            // 
            this.DurataTB.Location = new System.Drawing.Point(98, 154);
            this.DurataTB.Name = "DurataTB";
            this.DurataTB.Size = new System.Drawing.Size(245, 27);
            this.DurataTB.TabIndex = 10;
            // 
            // TipTB
            // 
            this.TipTB.Location = new System.Drawing.Point(98, 196);
            this.TipTB.Name = "TipTB";
            this.TipTB.Size = new System.Drawing.Size(245, 27);
            this.TipTB.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipTB);
            this.Controls.Add(this.DurataTB);
            this.Controls.Add(this.NumeTB);
            this.Controls.Add(this.PrescurtareTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrescurtareLabel);
            this.Controls.Add(this.NumeLabel);
            this.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPrograma";
            this.Text = "Adăugare Programă";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeLabel;
        private System.Windows.Forms.Label PrescurtareLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrescurtareTB;
        private System.Windows.Forms.TextBox NumeTB;
        private System.Windows.Forms.TextBox DurataTB;
        private System.Windows.Forms.TextBox TipTB;
        private System.Windows.Forms.Button button1;
    }
}