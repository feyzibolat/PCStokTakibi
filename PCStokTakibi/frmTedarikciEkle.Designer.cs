namespace PCStokTakibi
{
    partial class frmTedarikciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTedarikciEkle));
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTedarikciOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.txtTedarikciAdi = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTedarikciAdres = new System.Windows.Forms.TextBox();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTedarikciBul = new DevExpress.XtraEditors.TextEdit();
            this.dgvTedarikciListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTedarikciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTedarikciBul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(547, 208);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(102, 47);
            this.btnCikis.TabIndex = 60;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTedarikciOlustur);
            this.groupBox1.Controls.Add(this.txtTedarikciAdi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTedarikciAdres);
            this.groupBox1.Location = new System.Drawing.Point(2, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 252);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Oluştur";
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtTelefon.Location = new System.Drawing.Point(99, 67);
            this.mtxtTelefon.Mask = "(999) 000-00-00";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(128, 26);
            this.mtxtTelefon.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Telefon:";
            // 
            // btnTedarikciOlustur
            // 
            this.btnTedarikciOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTedarikciOlustur.Appearance.Options.UseFont = true;
            this.btnTedarikciOlustur.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTedarikciOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTedarikciOlustur.ImageOptions.Image")));
            this.btnTedarikciOlustur.Location = new System.Drawing.Point(57, 194);
            this.btnTedarikciOlustur.Name = "btnTedarikciOlustur";
            this.btnTedarikciOlustur.Size = new System.Drawing.Size(114, 47);
            this.btnTedarikciOlustur.TabIndex = 44;
            this.btnTedarikciOlustur.Text = "Ekle";
            this.btnTedarikciOlustur.Click += new System.EventHandler(this.btnTedarikciOlustur_Click);
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(99, 26);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTedarikciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtTedarikciAdi.Properties.Mask.EditMask = "c";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(128, 26);
            this.txtTedarikciAdi.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "T. Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "T. Adres:";
            // 
            // txtTedarikciAdres
            // 
            this.txtTedarikciAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikciAdres.Location = new System.Drawing.Point(13, 124);
            this.txtTedarikciAdres.Multiline = true;
            this.txtTedarikciAdres.Name = "txtTedarikciAdres";
            this.txtTedarikciAdres.Size = new System.Drawing.Size(214, 64);
            this.txtTedarikciAdres.TabIndex = 45;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(439, 208);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(102, 47);
            this.btnDuzenle.TabIndex = 58;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(331, 208);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 47);
            this.btnSil.TabIndex = 57;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(255, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Tedarikçi Ara:";
            // 
            // txtTedarikciBul
            // 
            this.txtTedarikciBul.Location = new System.Drawing.Point(366, 12);
            this.txtTedarikciBul.Name = "txtTedarikciBul";
            this.txtTedarikciBul.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTedarikciBul.Properties.Appearance.Options.UseFont = true;
            this.txtTedarikciBul.Properties.Mask.EditMask = "c";
            this.txtTedarikciBul.Size = new System.Drawing.Size(132, 26);
            this.txtTedarikciBul.TabIndex = 55;
            this.txtTedarikciBul.EditValueChanged += new System.EventHandler(this.txtTedarikciBul_EditValueChanged);
            // 
            // dgvTedarikciListesi
            // 
            this.dgvTedarikciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTedarikciListesi.Location = new System.Drawing.Point(252, 43);
            this.dgvTedarikciListesi.Name = "dgvTedarikciListesi";
            this.dgvTedarikciListesi.Size = new System.Drawing.Size(455, 159);
            this.dgvTedarikciListesi.TabIndex = 54;
            this.dgvTedarikciListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTedarikciListesi_CellClick);
            // 
            // frmTedarikciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 273);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTedarikciBul);
            this.Controls.Add(this.dgvTedarikciListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTedarikciEkle";
            this.Text = "Tedarikçi İşlemleri";
            this.Load += new System.EventHandler(this.frmTedarikciEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTedarikciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTedarikciBul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnTedarikciOlustur;
        private DevExpress.XtraEditors.TextEdit txtTedarikciAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTedarikciAdres;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtTedarikciBul;
        private System.Windows.Forms.DataGridView dgvTedarikciListesi;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.Label label5;
    }
}