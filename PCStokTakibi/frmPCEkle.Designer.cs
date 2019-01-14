namespace PCStokTakibi
{
    partial class frmPCEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPCEkle));
            this.txtPCAciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPCOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPCBul = new DevExpress.XtraEditors.TextEdit();
            this.dgvPCListesi = new System.Windows.Forms.DataGridView();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtPCAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCBul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCAdi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPCAciklama
            // 
            this.txtPCAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPCAciklama.Location = new System.Drawing.Point(16, 80);
            this.txtPCAciklama.MaxLength = 100;
            this.txtPCAciklama.Multiline = true;
            this.txtPCAciklama.Name = "txtPCAciklama";
            this.txtPCAciklama.Size = new System.Drawing.Size(214, 64);
            this.txtPCAciklama.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "PC Açıklaması:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "PC Adı:";
            // 
            // btnPCOlustur
            // 
            this.btnPCOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPCOlustur.Appearance.Options.UseFont = true;
            this.btnPCOlustur.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnPCOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPCOlustur.ImageOptions.Image")));
            this.btnPCOlustur.Location = new System.Drawing.Point(60, 150);
            this.btnPCOlustur.Name = "btnPCOlustur";
            this.btnPCOlustur.Size = new System.Drawing.Size(114, 47);
            this.btnPCOlustur.TabIndex = 44;
            this.btnPCOlustur.Text = "Ekle";
            this.btnPCOlustur.Click += new System.EventHandler(this.btnPCOlustur_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(265, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "PC Ara:";
            // 
            // txtPCBul
            // 
            this.txtPCBul.Location = new System.Drawing.Point(334, 16);
            this.txtPCBul.Name = "txtPCBul";
            this.txtPCBul.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPCBul.Properties.Appearance.Options.UseFont = true;
            this.txtPCBul.Properties.Mask.EditMask = "c";
            this.txtPCBul.Properties.MaxLength = 50;
            this.txtPCBul.Size = new System.Drawing.Size(132, 26);
            this.txtPCBul.TabIndex = 47;
            this.txtPCBul.EditValueChanged += new System.EventHandler(this.txtPCBul_EditValueChanged);
            // 
            // dgvPCListesi
            // 
            this.dgvPCListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPCListesi.Location = new System.Drawing.Point(262, 48);
            this.dgvPCListesi.Name = "dgvPCListesi";
            this.dgvPCListesi.Size = new System.Drawing.Size(455, 116);
            this.dgvPCListesi.TabIndex = 46;
            this.dgvPCListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPCListesi_CellClick);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(442, 170);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(102, 47);
            this.btnDuzenle.TabIndex = 50;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(334, 170);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 47);
            this.btnSil.TabIndex = 49;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtPCAdi
            // 
            this.txtPCAdi.Location = new System.Drawing.Point(79, 25);
            this.txtPCAdi.Name = "txtPCAdi";
            this.txtPCAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPCAdi.Properties.Appearance.Options.UseFont = true;
            this.txtPCAdi.Properties.Mask.EditMask = "c";
            this.txtPCAdi.Properties.MaxLength = 50;
            this.txtPCAdi.Size = new System.Drawing.Size(132, 26);
            this.txtPCAdi.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPCOlustur);
            this.groupBox1.Controls.Add(this.txtPCAdi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPCAciklama);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 210);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Oluştur";
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(550, 170);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(102, 47);
            this.btnCikis.TabIndex = 53;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmPCEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 235);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPCBul);
            this.Controls.Add(this.dgvPCListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPCEkle";
            this.Text = "Bilgisayar İşlemleri";
            this.Load += new System.EventHandler(this.frmPCEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPCBul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCAdi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPCAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnPCOlustur;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtPCBul;
        private System.Windows.Forms.DataGridView dgvPCListesi;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtPCAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}