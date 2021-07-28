namespace DepoProjesi
{
    partial class frmMain
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
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunMaliyet = new System.Windows.Forms.TextBox();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunMaliyet = new System.Windows.Forms.Label();
            this.UrunAdet = new System.Windows.Forms.Label();
            this.lblUrunSatis = new System.Windows.Forms.Label();
            this.grpUrunGiris = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.lblToplamMaliyet = new System.Windows.Forms.Label();
            this.grpUrunGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(123, 213);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ürünü Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdmin.Location = new System.Drawing.Point(0, 394);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(800, 56);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(98, 34);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // txtUrunMaliyet
            // 
            this.txtUrunMaliyet.Location = new System.Drawing.Point(98, 80);
            this.txtUrunMaliyet.Name = "txtUrunMaliyet";
            this.txtUrunMaliyet.Size = new System.Drawing.Size(100, 20);
            this.txtUrunMaliyet.TabIndex = 4;
            this.txtUrunMaliyet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunMaliyet_KeyPress);
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(98, 131);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdet.TabIndex = 5;
            this.txtUrunAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdet_KeyPress);
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(98, 170);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyat.TabIndex = 6;
            this.txtSatisFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisFiyat_KeyPress);
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(32, 41);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(57, 13);
            this.lblUrunAdi.TabIndex = 7;
            this.lblUrunAdi.Text = "Ürün Adi : ";
            // 
            // lblUrunMaliyet
            // 
            this.lblUrunMaliyet.AutoSize = true;
            this.lblUrunMaliyet.Location = new System.Drawing.Point(20, 87);
            this.lblUrunMaliyet.Name = "lblUrunMaliyet";
            this.lblUrunMaliyet.Size = new System.Drawing.Size(77, 13);
            this.lblUrunMaliyet.TabIndex = 8;
            this.lblUrunMaliyet.Text = "Ürün Maliyeti : ";
            // 
            // UrunAdet
            // 
            this.UrunAdet.AutoSize = true;
            this.UrunAdet.Location = new System.Drawing.Point(25, 134);
            this.UrunAdet.Name = "UrunAdet";
            this.UrunAdet.Size = new System.Drawing.Size(64, 13);
            this.UrunAdet.TabIndex = 9;
            this.UrunAdet.Text = "Ürün Adet : ";
            // 
            // lblUrunSatis
            // 
            this.lblUrunSatis.AutoSize = true;
            this.lblUrunSatis.Location = new System.Drawing.Point(0, 177);
            this.lblUrunSatis.Name = "lblUrunSatis";
            this.lblUrunSatis.Size = new System.Drawing.Size(92, 13);
            this.lblUrunSatis.TabIndex = 10;
            this.lblUrunSatis.Text = "Ürün Satış Fiyati : ";
            // 
            // grpUrunGiris
            // 
            this.grpUrunGiris.Controls.Add(this.txtUrunMaliyet);
            this.grpUrunGiris.Controls.Add(this.lblUrunSatis);
            this.grpUrunGiris.Controls.Add(this.btnUrunEkle);
            this.grpUrunGiris.Controls.Add(this.UrunAdet);
            this.grpUrunGiris.Controls.Add(this.txtUrunAdi);
            this.grpUrunGiris.Controls.Add(this.lblUrunMaliyet);
            this.grpUrunGiris.Controls.Add(this.txtUrunAdet);
            this.grpUrunGiris.Controls.Add(this.lblUrunAdi);
            this.grpUrunGiris.Controls.Add(this.txtSatisFiyat);
            this.grpUrunGiris.Location = new System.Drawing.Point(12, 54);
            this.grpUrunGiris.Name = "grpUrunGiris";
            this.grpUrunGiris.Size = new System.Drawing.Size(224, 262);
            this.grpUrunGiris.TabIndex = 11;
            this.grpUrunGiris.TabStop = false;
            this.grpUrunGiris.Text = "Ürün Giriş";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(526, 252);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(604, 330);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(35, 13);
            this.lblToplamSatis.TabIndex = 17;
            this.lblToplamSatis.Text = "label5";
            // 
            // lblToplamMaliyet
            // 
            this.lblToplamMaliyet.AutoSize = true;
            this.lblToplamMaliyet.Location = new System.Drawing.Point(259, 330);
            this.lblToplamMaliyet.Name = "lblToplamMaliyet";
            this.lblToplamMaliyet.Size = new System.Drawing.Size(35, 13);
            this.lblToplamMaliyet.TabIndex = 16;
            this.lblToplamMaliyet.Text = "label4";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplamSatis);
            this.Controls.Add(this.lblToplamMaliyet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpUrunGiris);
            this.Controls.Add(this.btnAdmin);
            this.Name = "frmMain";
            this.Text = "Depo Projesi";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpUrunGiris.ResumeLayout(false);
            this.grpUrunGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunMaliyet;
        private System.Windows.Forms.TextBox txtUrunAdet;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunMaliyet;
        private System.Windows.Forms.Label UrunAdet;
        private System.Windows.Forms.Label lblUrunSatis;
        private System.Windows.Forms.GroupBox grpUrunGiris;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label lblToplamMaliyet;
    }
}

