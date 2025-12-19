namespace nevanurdogan_241701060
{
    partial class FormDepoHareket2
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
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGirisMiktar = new System.Windows.Forms.TextBox();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.cmbGirisUrun = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCikisMiktar = new System.Windows.Forms.TextBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbCikisUrun = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDepoHareket = new System.Windows.Forms.DataGridView();
            this.grpGiris.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGiris
            // 
            this.grpGiris.Controls.Add(this.button1);
            this.grpGiris.Controls.Add(this.txtGirisMiktar);
            this.grpGiris.Controls.Add(this.cmbTedarikci);
            this.grpGiris.Controls.Add(this.cmbGirisUrun);
            this.grpGiris.Location = new System.Drawing.Point(47, 36);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(279, 305);
            this.grpGiris.TabIndex = 0;
            this.grpGiris.TabStop = false;
            this.grpGiris.Text = "Depo Giriş ";
            this.grpGiris.Enter += new System.EventHandler(this.grpGiris_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGirisMiktar
            // 
            this.txtGirisMiktar.Location = new System.Drawing.Point(52, 145);
            this.txtGirisMiktar.Name = "txtGirisMiktar";
            this.txtGirisMiktar.Size = new System.Drawing.Size(138, 22);
            this.txtGirisMiktar.TabIndex = 2;
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(52, 93);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(138, 24);
            this.cmbTedarikci.TabIndex = 1;
            // 
            // cmbGirisUrun
            // 
            this.cmbGirisUrun.FormattingEnabled = true;
            this.cmbGirisUrun.Location = new System.Drawing.Point(52, 36);
            this.cmbGirisUrun.Name = "cmbGirisUrun";
            this.cmbGirisUrun.Size = new System.Drawing.Size(138, 24);
            this.cmbGirisUrun.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCikisMiktar);
            this.groupBox1.Controls.Add(this.cmbMusteri);
            this.groupBox1.Controls.Add(this.cmbCikisUrun);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(486, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Çıkış";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCikisMiktar
            // 
            this.txtCikisMiktar.Location = new System.Drawing.Point(82, 145);
            this.txtCikisMiktar.Name = "txtCikisMiktar";
            this.txtCikisMiktar.Size = new System.Drawing.Size(137, 22);
            this.txtCikisMiktar.TabIndex = 3;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(82, 93);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(137, 24);
            this.cmbMusteri.TabIndex = 2;
            // 
            // cmbCikisUrun
            // 
            this.cmbCikisUrun.FormattingEnabled = true;
            this.cmbCikisUrun.Location = new System.Drawing.Point(82, 36);
            this.cmbCikisUrun.Name = "cmbCikisUrun";
            this.cmbCikisUrun.Size = new System.Drawing.Size(137, 24);
            this.cmbCikisUrun.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvDepoHareket
            // 
            this.dgvDepoHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepoHareket.Location = new System.Drawing.Point(87, 364);
            this.dgvDepoHareket.Name = "dgvDepoHareket";
            this.dgvDepoHareket.RowHeadersWidth = 51;
            this.dgvDepoHareket.RowTemplate.Height = 24;
            this.dgvDepoHareket.Size = new System.Drawing.Size(658, 246);
            this.dgvDepoHareket.TabIndex = 2;
            // 
            // FormDepoHareket2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 641);
            this.Controls.Add(this.dgvDepoHareket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGiris);
            this.Name = "FormDepoHareket2";
            this.Text = "FormDepoHareket2";
            this.Load += new System.EventHandler(this.FormDepoHareket2_Load);
            this.grpGiris.ResumeLayout(false);
            this.grpGiris.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGirisMiktar;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.ComboBox cmbGirisUrun;
        private System.Windows.Forms.DataGridView dgvDepoHareket;
        private System.Windows.Forms.TextBox txtCikisMiktar;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbCikisUrun;
        private System.Windows.Forms.Button button2;
    }
}