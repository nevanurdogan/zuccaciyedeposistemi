namespace nevanurdogan_241701060
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.Label();
            this.txtAlis = new System.Windows.Forms.Label();
            this.txtSatis = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDepoForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZÜCCAYİYE DEPO SİSTEMİ";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.AutoSize = true;
            this.txtUrunAdi.Location = new System.Drawing.Point(56, 83);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(61, 16);
            this.txtUrunAdi.TabIndex = 1;
            this.txtUrunAdi.Text = "Ürün Adı:";
            // 
            // txtKategori
            // 
            this.txtKategori.AutoSize = true;
            this.txtKategori.Location = new System.Drawing.Point(56, 120);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(60, 16);
            this.txtKategori.TabIndex = 2;
            this.txtKategori.Text = "Kategori:";
            // 
            // txtStok
            // 
            this.txtStok.AutoSize = true;
            this.txtStok.Location = new System.Drawing.Point(56, 160);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(76, 16);
            this.txtStok.TabIndex = 3;
            this.txtStok.Text = "Stok Adedi:";
            this.txtStok.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAlis
            // 
            this.txtAlis.AutoSize = true;
            this.txtAlis.Location = new System.Drawing.Point(56, 200);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(67, 16);
            this.txtAlis.TabIndex = 4;
            this.txtAlis.Text = "Alış Fiyatı:";
            this.txtAlis.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSatis
            // 
            this.txtSatis.AutoSize = true;
            this.txtSatis.Location = new System.Drawing.Point(51, 235);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(72, 16);
            this.txtSatis.TabIndex = 5;
            this.txtSatis.Text = "Satiş Fiyat:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 229);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(59, 322);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(158, 45);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "➕ EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(223, 322);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(158, 45);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "✏️ GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(142, 394);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(158, 45);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "🗑️ SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 367);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDepoForm
            // 
            this.btnDepoForm.Location = new System.Drawing.Point(527, 439);
            this.btnDepoForm.Name = "btnDepoForm";
            this.btnDepoForm.Size = new System.Drawing.Size(156, 41);
            this.btnDepoForm.TabIndex = 15;
            this.btnDepoForm.Text = "Depo Giriş-Çıkış";
            this.btnDepoForm.UseVisualStyleBackColor = true;
            this.btnDepoForm.Click += new System.EventHandler(this.btnDepoForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 492);
            this.Controls.Add(this.btnDepoForm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSatis);
            this.Controls.Add(this.txtAlis);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUrunAdi;
        private System.Windows.Forms.Label txtKategori;
        private System.Windows.Forms.Label txtStok;
        private System.Windows.Forms.Label txtAlis;
        private System.Windows.Forms.Label txtSatis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDepoForm;
    }
}

