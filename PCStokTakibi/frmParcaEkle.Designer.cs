namespace PCStokTakibi
{
    partial class frmParcaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParcaEkle));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbParcaKategori = new System.Windows.Forms.ComboBox();
            this.btnPCEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cmbAitOlduguPC = new System.Windows.Forms.ComboBox();
            this.btnParcaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtParcaAdi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParcaAciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParcaBarkod = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaBarkod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbParcaKategori);
            this.groupBox3.Controls.Add(this.btnPCEkle);
            this.groupBox3.Controls.Add(this.cmbAitOlduguPC);
            this.groupBox3.Controls.Add(this.btnParcaEkle);
            this.groupBox3.Controls.Add(this.txtParcaAdi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtParcaAciklama);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtParcaBarkod);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 324);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parça Bilgileri";
            // 
            // cmbParcaKategori
            // 
            this.cmbParcaKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbParcaKategori.FormattingEnabled = true;
            this.cmbParcaKategori.Items.AddRange(new object[] {
            "ANAKART",
            "CPU",
            "GPU",
            "HDD/SSD",
            "RAM",
            "SES KARTI",
            "KASA",
            "MONITOR",
            "KLAVYE",
            "FARE",
            "OPTIK SURUCU",
            "YAZICI"});
            this.cmbParcaKategori.Location = new System.Drawing.Point(111, 94);
            this.cmbParcaKategori.Name = "cmbParcaKategori";
            this.cmbParcaKategori.Size = new System.Drawing.Size(205, 21);
            this.cmbParcaKategori.TabIndex = 52;
            // 
            // btnPCEkle
            // 
            this.btnPCEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPCEkle.Appearance.Options.UseFont = true;
            this.btnPCEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnPCEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPCEkle.ImageOptions.Image")));
            this.btnPCEkle.Location = new System.Drawing.Point(294, 126);
            this.btnPCEkle.Name = "btnPCEkle";
            this.btnPCEkle.Size = new System.Drawing.Size(22, 21);
            this.btnPCEkle.TabIndex = 51;
            this.btnPCEkle.Click += new System.EventHandler(this.btnPCEkle_Click);
            // 
            // cmbAitOlduguPC
            // 
            this.cmbAitOlduguPC.FormattingEnabled = true;
            this.cmbAitOlduguPC.Items.AddRange(new object[] {
            "Yeni Oluştur"});
            this.cmbAitOlduguPC.Location = new System.Drawing.Point(111, 126);
            this.cmbAitOlduguPC.Name = "cmbAitOlduguPC";
            this.cmbAitOlduguPC.Size = new System.Drawing.Size(177, 21);
            this.cmbAitOlduguPC.TabIndex = 50;
            // 
            // btnParcaEkle
            // 
            this.btnParcaEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnParcaEkle.Appearance.Options.UseFont = true;
            this.btnParcaEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnParcaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParcaEkle.ImageOptions.Image")));
            this.btnParcaEkle.Location = new System.Drawing.Point(214, 252);
            this.btnParcaEkle.Name = "btnParcaEkle";
            this.btnParcaEkle.Size = new System.Drawing.Size(102, 41);
            this.btnParcaEkle.TabIndex = 41;
            this.btnParcaEkle.Text = "Ekle";
            this.btnParcaEkle.Click += new System.EventHandler(this.btnParcaEkle_Click);
            // 
            // txtParcaAdi
            // 
            this.txtParcaAdi.Location = new System.Drawing.Point(111, 57);
            this.txtParcaAdi.Name = "txtParcaAdi";
            this.txtParcaAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtParcaAdi.Properties.Appearance.Options.UseFont = true;
            this.txtParcaAdi.Properties.MaxLength = 50;
            this.txtParcaAdi.Size = new System.Drawing.Size(205, 26);
            this.txtParcaAdi.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ait Olduğu PC:";
            // 
            // txtParcaAciklama
            // 
            this.txtParcaAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParcaAciklama.Location = new System.Drawing.Point(20, 182);
            this.txtParcaAciklama.MaxLength = 100;
            this.txtParcaAciklama.Multiline = true;
            this.txtParcaAciklama.Name = "txtParcaAciklama";
            this.txtParcaAciklama.Size = new System.Drawing.Size(296, 64);
            this.txtParcaAciklama.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Açıklaması:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Kategori:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Barkod:";
            // 
            // txtParcaBarkod
            // 
            this.txtParcaBarkod.Location = new System.Drawing.Point(111, 24);
            this.txtParcaBarkod.Name = "txtParcaBarkod";
            this.txtParcaBarkod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtParcaBarkod.Properties.Appearance.Options.UseFont = true;
            this.txtParcaBarkod.Properties.Mask.EditMask = "\\d+";
            this.txtParcaBarkod.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtParcaBarkod.Properties.MaxLength = 10;
            this.txtParcaBarkod.Size = new System.Drawing.Size(205, 26);
            this.txtParcaBarkod.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Parça Adı:";
            // 
            // frmParcaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 350);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmParcaEkle";
            this.Text = "Yeni Parça Ekle";
            this.Load += new System.EventHandler(this.frmParcaEkle_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaBarkod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtParcaBarkod;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnParcaEkle;
        private System.Windows.Forms.TextBox txtParcaAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtParcaAdi;
        private System.Windows.Forms.ComboBox cmbAitOlduguPC;
        private DevExpress.XtraEditors.SimpleButton btnPCEkle;
        private System.Windows.Forms.ComboBox cmbParcaKategori;
    }
}