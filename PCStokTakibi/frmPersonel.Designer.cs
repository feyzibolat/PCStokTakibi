namespace PCStokTakibi
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.mtxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPasif = new System.Windows.Forms.RadioButton();
            this.rdbAktif = new System.Windows.Forms.RadioButton();
            this.dgvPersonelListesi = new System.Windows.Forms.DataGridView();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.txtTCKNbul = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCKNbul.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "T.C. No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(254, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(432, 132);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 51);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(540, 132);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 51);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(648, 132);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(102, 51);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // mtxtTcNo
            // 
            this.mtxtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtTcNo.Location = new System.Drawing.Point(98, 88);
            this.mtxtTcNo.Mask = "00000000000";
            this.mtxtTcNo.Name = "mtxtTcNo";
            this.mtxtTcNo.Size = new System.Drawing.Size(128, 26);
            this.mtxtTcNo.TabIndex = 2;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtTelefon.Location = new System.Drawing.Point(98, 157);
            this.mtxtTelefon.Mask = "(999) 000-00-00";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(128, 26);
            this.mtxtTelefon.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPasif);
            this.groupBox1.Controls.Add(this.rdbAktif);
            this.groupBox1.Location = new System.Drawing.Point(258, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 57);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Aktifliği";
            // 
            // rdbPasif
            // 
            this.rdbPasif.AutoSize = true;
            this.rdbPasif.Location = new System.Drawing.Point(93, 31);
            this.rdbPasif.Name = "rdbPasif";
            this.rdbPasif.Size = new System.Drawing.Size(48, 17);
            this.rdbPasif.TabIndex = 17;
            this.rdbPasif.TabStop = true;
            this.rdbPasif.Text = "Pasif";
            this.rdbPasif.UseVisualStyleBackColor = true;
            // 
            // rdbAktif
            // 
            this.rdbAktif.AutoSize = true;
            this.rdbAktif.Location = new System.Drawing.Point(25, 31);
            this.rdbAktif.Name = "rdbAktif";
            this.rdbAktif.Size = new System.Drawing.Size(46, 17);
            this.rdbAktif.TabIndex = 16;
            this.rdbAktif.TabStop = true;
            this.rdbAktif.Text = "Aktif";
            this.rdbAktif.UseVisualStyleBackColor = true;
            // 
            // dgvPersonelListesi
            // 
            this.dgvPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelListesi.Location = new System.Drawing.Point(12, 239);
            this.dgvPersonelListesi.Name = "dgvPersonelListesi";
            this.dgvPersonelListesi.Size = new System.Drawing.Size(738, 259);
            this.dgvPersonelListesi.TabIndex = 16;
            this.dgvPersonelListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonelListesi_CellClick);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(98, 53);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSoyadi.Properties.Appearance.Options.UseFont = true;
            this.txtSoyadi.Properties.Mask.EditMask = "\\p{L}+";
            this.txtSoyadi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSoyadi.Properties.MaxLength = 50;
            this.txtSoyadi.Size = new System.Drawing.Size(128, 26);
            this.txtSoyadi.TabIndex = 1;
            this.txtSoyadi.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtSoyadi_EditValueChanging);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(98, 20);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAdi.Properties.Appearance.Options.UseFont = true;
            this.txtAdi.Properties.Mask.EditMask = "\\p{L}+";
            this.txtAdi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAdi.Properties.MaxLength = 50;
            this.txtAdi.Size = new System.Drawing.Size(128, 26);
            this.txtAdi.TabIndex = 0;
            this.txtAdi.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtAdi_EditValueChanging);
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(648, 46);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(102, 68);
            this.btnCikis.TabIndex = 18;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtTCKNbul
            // 
            this.txtTCKNbul.Location = new System.Drawing.Point(127, 207);
            this.txtTCKNbul.Name = "txtTCKNbul";
            this.txtTCKNbul.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTCKNbul.Properties.Appearance.Options.UseFont = true;
            this.txtTCKNbul.Properties.Mask.EditMask = "c";
            this.txtTCKNbul.Size = new System.Drawing.Size(128, 26);
            this.txtTCKNbul.TabIndex = 19;
            this.txtTCKNbul.EditValueChanged += new System.EventHandler(this.txtTCKNbul_EditValueChanged);
            this.txtTCKNbul.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTCKNbul_EditValueChanging);
            this.txtTCKNbul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCKNbul_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(15, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "TCKN ile Ara :";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(258, 46);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(382, 68);
            this.txtAdres.TabIndex = 17;
            // 
            // cmbBolum
            // 
            this.cmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Items.AddRange(new object[] {
            "Yönetici",
            "Satınalma",
            "Muhasebe",
            "Personel",
            "Teknik"});
            this.cmbBolum.Location = new System.Drawing.Point(98, 128);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(128, 21);
            this.cmbBolum.TabIndex = 50;
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 508);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTCKNbul);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.dgvPersonelListesi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.mtxtTcNo);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPersonel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCKNbul.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private System.Windows.Forms.MaskedTextBox mtxtTcNo;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPasif;
        private System.Windows.Forms.RadioButton rdbAktif;
        private System.Windows.Forms.DataGridView dgvPersonelListesi;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.TextEdit txtTCKNbul;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ComboBox cmbBolum;
    }
}