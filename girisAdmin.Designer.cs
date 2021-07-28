namespace DepoProjesi
{
    partial class girisAdmin
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(163, 108);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKAdi
            // 
            this.txtKAdi.Location = new System.Drawing.Point(138, 30);
            this.txtKAdi.Name = "txtKAdi";
            this.txtKAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(138, 72);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // lblKAdi
            // 
            this.lblKAdi.AutoSize = true;
            this.lblKAdi.Location = new System.Drawing.Point(46, 33);
            this.lblKAdi.Name = "lblKAdi";
            this.lblKAdi.Size = new System.Drawing.Size(73, 13);
            this.lblKAdi.TabIndex = 3;
            this.lblKAdi.Text = "Kullanıcı Adı : ";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(82, 78);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 13);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre : ";
            // 
            // girisAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 153);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKAdi);
            this.Controls.Add(this.btnGiris);
            this.Name = "girisAdmin";
            this.Text = "Admin Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblKAdi;
        private System.Windows.Forms.Label lblSifre;
    }
}