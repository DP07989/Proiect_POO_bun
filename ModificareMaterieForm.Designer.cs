namespace Proiect_POO_bun
{
    partial class ModificareMaterieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificareMaterieForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProfesorTB = new System.Windows.Forms.TextBox();
            this.CrediteTB = new System.Windows.Forms.TextBox();
            this.CodTB = new System.Windows.Forms.TextBox();
            this.NumeTB = new System.Windows.Forms.TextBox();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UT Sans Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificați o materie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Profesor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Credite";
            // 
            // ProfesorTB
            // 
            this.ProfesorTB.Location = new System.Drawing.Point(89, 160);
            this.ProfesorTB.Name = "ProfesorTB";
            this.ProfesorTB.Size = new System.Drawing.Size(238, 22);
            this.ProfesorTB.TabIndex = 6;
            // 
            // CrediteTB
            // 
            this.CrediteTB.Location = new System.Drawing.Point(90, 194);
            this.CrediteTB.Name = "CrediteTB";
            this.CrediteTB.Size = new System.Drawing.Size(238, 22);
            this.CrediteTB.TabIndex = 7;
            // 
            // CodTB
            // 
            this.CodTB.Location = new System.Drawing.Point(90, 129);
            this.CodTB.Name = "CodTB";
            this.CodTB.Size = new System.Drawing.Size(238, 22);
            this.CodTB.TabIndex = 8;
            // 
            // NumeTB
            // 
            this.NumeTB.Location = new System.Drawing.Point(90, 102);
            this.NumeTB.Name = "NumeTB";
            this.NumeTB.Size = new System.Drawing.Size(238, 22);
            this.NumeTB.TabIndex = 9;
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(90, 70);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(238, 22);
            this.IDTB.TabIndex = 10;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("UT Sans Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(131, 230);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 33);
            this.OK.TabIndex = 11;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ModificareMaterieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 275);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.NumeTB);
            this.Controls.Add(this.CodTB);
            this.Controls.Add(this.CrediteTB);
            this.Controls.Add(this.ProfesorTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModificareMaterieForm";
            this.Text = "Modificare Materie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProfesorTB;
        private System.Windows.Forms.TextBox CrediteTB;
        private System.Windows.Forms.TextBox CodTB;
        private System.Windows.Forms.TextBox NumeTB;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Button OK;
    }
}