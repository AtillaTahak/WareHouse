namespace DepoProjesi
{
    partial class adminPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbUrunSil = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpUrunSil = new System.Windows.Forms.GroupBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.grpUrunGüncelle = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.txtUrunMaliyet = new System.Windows.Forms.TextBox();
            this.lblUrunSatis = new System.Windows.Forms.Label();
            this.btnUrunGüncelle = new System.Windows.Forms.Button();
            this.UrunAdet = new System.Windows.Forms.Label();
            this.lblUrunMaliyet = new System.Windows.Forms.Label();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunCikisAdi = new System.Windows.Forms.ComboBox();
            this.txtUrunCikisAdet = new System.Windows.Forms.TextBox();
            this.btnUrunCikis = new System.Windows.Forms.Button();
            this.lblToplamMaliyet = new System.Windows.Forms.Label();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUrunSil.SuspendLayout();
            this.grpUrunGüncelle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(465, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbUrunSil
            // 
            this.cmbUrunSil.FormattingEnabled = true;
            this.cmbUrunSil.Location = new System.Drawing.Point(74, 15);
            this.cmbUrunSil.Name = "cmbUrunSil";
            this.cmbUrunSil.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunSil.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(114, 56);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // grpUrunSil
            // 
            this.grpUrunSil.Controls.Add(this.lblUrunAdi);
            this.grpUrunSil.Controls.Add(this.btnSil);
            this.grpUrunSil.Controls.Add(this.cmbUrunSil);
            this.grpUrunSil.Location = new System.Drawing.Point(755, 35);
            this.grpUrunSil.Name = "grpUrunSil";
            this.grpUrunSil.Size = new System.Drawing.Size(224, 104);
            this.grpUrunSil.TabIndex = 3;
            this.grpUrunSil.TabStop = false;
            this.grpUrunSil.Text = "Ürün Sil";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(13, 23);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(57, 13);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Ürün Adı : ";
            // 
            // grpUrunGüncelle
            // 
            this.grpUrunGüncelle.Controls.Add(this.btnTemizle);
            this.grpUrunGüncelle.Controls.Add(this.txtUrunAdi);
            this.grpUrunGüncelle.Controls.Add(this.btnAra);
            this.grpUrunGüncelle.Controls.Add(this.txtAra);
            this.grpUrunGüncelle.Controls.Add(this.lblAra);
            this.grpUrunGüncelle.Controls.Add(this.txtUrunMaliyet);
            this.grpUrunGüncelle.Controls.Add(this.lblUrunSatis);
            this.grpUrunGüncelle.Controls.Add(this.btnUrunGüncelle);
            this.grpUrunGüncelle.Controls.Add(this.UrunAdet);
            this.grpUrunGüncelle.Controls.Add(this.lblUrunMaliyet);
            this.grpUrunGüncelle.Controls.Add(this.txtUrunAdet);
            this.grpUrunGüncelle.Controls.Add(this.label1);
            this.grpUrunGüncelle.Controls.Add(this.txtSatisFiyat);
            this.grpUrunGüncelle.Location = new System.Drawing.Point(12, 35);
            this.grpUrunGüncelle.Name = "grpUrunGüncelle";
            this.grpUrunGüncelle.Size = new System.Drawing.Size(256, 325);
            this.grpUrunGüncelle.TabIndex = 12;
            this.grpUrunGüncelle.TabStop = false;
            this.grpUrunGüncelle.Text = "Ürün Güncelleme";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(16, 270);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(102, 23);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Enabled = false;
            this.txtUrunAdi.Location = new System.Drawing.Point(100, 91);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(118, 20);
            this.txtUrunAdi.TabIndex = 15;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(194, 37);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(56, 20);
            this.btnAra.TabIndex = 14;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(79, 38);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 13;
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(13, 40);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(50, 13);
            this.lblAra.TabIndex = 12;
            this.lblAra.Text = "Ürün id : ";
            // 
            // txtUrunMaliyet
            // 
            this.txtUrunMaliyet.Location = new System.Drawing.Point(100, 137);
            this.txtUrunMaliyet.Name = "txtUrunMaliyet";
            this.txtUrunMaliyet.Size = new System.Drawing.Size(118, 20);
            this.txtUrunMaliyet.TabIndex = 4;
            this.txtUrunMaliyet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunMaliyet_KeyPress);
            // 
            // lblUrunSatis
            // 
            this.lblUrunSatis.AutoSize = true;
            this.lblUrunSatis.Location = new System.Drawing.Point(2, 234);
            this.lblUrunSatis.Name = "lblUrunSatis";
            this.lblUrunSatis.Size = new System.Drawing.Size(92, 13);
            this.lblUrunSatis.TabIndex = 10;
            this.lblUrunSatis.Text = "Ürün Satış Fiyati : ";
            // 
            // btnUrunGüncelle
            // 
            this.btnUrunGüncelle.Location = new System.Drawing.Point(150, 268);
            this.btnUrunGüncelle.Name = "btnUrunGüncelle";
            this.btnUrunGüncelle.Size = new System.Drawing.Size(100, 26);
            this.btnUrunGüncelle.TabIndex = 0;
            this.btnUrunGüncelle.Text = "Ürünü Güncelle";
            this.btnUrunGüncelle.UseVisualStyleBackColor = true;
            this.btnUrunGüncelle.Click += new System.EventHandler(this.btnUrunGüncelle_Click);
            // 
            // UrunAdet
            // 
            this.UrunAdet.AutoSize = true;
            this.UrunAdet.Location = new System.Drawing.Point(13, 188);
            this.UrunAdet.Name = "UrunAdet";
            this.UrunAdet.Size = new System.Drawing.Size(64, 13);
            this.UrunAdet.TabIndex = 9;
            this.UrunAdet.Text = "Ürün Adet : ";
            // 
            // lblUrunMaliyet
            // 
            this.lblUrunMaliyet.AutoSize = true;
            this.lblUrunMaliyet.Location = new System.Drawing.Point(7, 140);
            this.lblUrunMaliyet.Name = "lblUrunMaliyet";
            this.lblUrunMaliyet.Size = new System.Drawing.Size(77, 13);
            this.lblUrunMaliyet.TabIndex = 8;
            this.lblUrunMaliyet.Text = "Ürün Maliyeti : ";
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(100, 188);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(118, 20);
            this.txtUrunAdet.TabIndex = 5;
            this.txtUrunAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Adi : ";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(100, 227);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(118, 20);
            this.txtSatisFiyat.TabIndex = 6;
            this.txtSatisFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisFiyat_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbUrunCikisAdi);
            this.groupBox1.Controls.Add(this.txtUrunCikisAdet);
            this.groupBox1.Controls.Add(this.btnUrunCikis);
            this.groupBox1.Location = new System.Drawing.Point(764, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 143);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UrunCikis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adı";
            // 
            // cmbUrunCikisAdi
            // 
            this.cmbUrunCikisAdi.FormattingEnabled = true;
            this.cmbUrunCikisAdi.Location = new System.Drawing.Point(88, 20);
            this.cmbUrunCikisAdi.Name = "cmbUrunCikisAdi";
            this.cmbUrunCikisAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunCikisAdi.TabIndex = 2;
            this.cmbUrunCikisAdi.SelectedIndexChanged += new System.EventHandler(this.cmbUrunCikisAdi_SelectedIndexChanged);
            // 
            // txtUrunCikisAdet
            // 
            this.txtUrunCikisAdet.Location = new System.Drawing.Point(88, 53);
            this.txtUrunCikisAdet.Name = "txtUrunCikisAdet";
            this.txtUrunCikisAdet.Size = new System.Drawing.Size(121, 20);
            this.txtUrunCikisAdet.TabIndex = 1;
            this.txtUrunCikisAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunCikisAdet_KeyPress);
            // 
            // btnUrunCikis
            // 
            this.btnUrunCikis.Location = new System.Drawing.Point(134, 96);
            this.btnUrunCikis.Name = "btnUrunCikis";
            this.btnUrunCikis.Size = new System.Drawing.Size(75, 23);
            this.btnUrunCikis.TabIndex = 0;
            this.btnUrunCikis.Text = "Ürün Çıkış";
            this.btnUrunCikis.UseVisualStyleBackColor = true;
            this.btnUrunCikis.Click += new System.EventHandler(this.btnUrunCikis_Click);
            // 
            // lblToplamMaliyet
            // 
            this.lblToplamMaliyet.AutoSize = true;
            this.lblToplamMaliyet.Location = new System.Drawing.Point(281, 403);
            this.lblToplamMaliyet.Name = "lblToplamMaliyet";
            this.lblToplamMaliyet.Size = new System.Drawing.Size(35, 13);
            this.lblToplamMaliyet.TabIndex = 14;
            this.lblToplamMaliyet.Text = "label4";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(626, 403);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(35, 13);
            this.lblToplamSatis.TabIndex = 15;
            this.lblToplamSatis.Text = "label5";
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 455);
            this.Controls.Add(this.lblToplamSatis);
            this.Controls.Add(this.lblToplamMaliyet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpUrunGüncelle);
            this.Controls.Add(this.grpUrunSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "adminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUrunSil.ResumeLayout(false);
            this.grpUrunSil.PerformLayout();
            this.grpUrunGüncelle.ResumeLayout(false);
            this.grpUrunGüncelle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbUrunSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox grpUrunSil;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.GroupBox grpUrunGüncelle;
        private System.Windows.Forms.TextBox txtUrunMaliyet;
        private System.Windows.Forms.Label lblUrunSatis;
        private System.Windows.Forms.Button btnUrunGüncelle;
        private System.Windows.Forms.Label UrunAdet;
        private System.Windows.Forms.Label lblUrunMaliyet;
        private System.Windows.Forms.TextBox txtUrunAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunCikisAdi;
        private System.Windows.Forms.TextBox txtUrunCikisAdet;
        private System.Windows.Forms.Button btnUrunCikis;
        private System.Windows.Forms.Label lblToplamMaliyet;
        private System.Windows.Forms.Label lblToplamSatis;
    }
}