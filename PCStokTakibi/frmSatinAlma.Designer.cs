using System;

namespace PCStokTakibi
{
    partial class frmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor));
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarkodAra = new DevExpress.XtraEditors.TextEdit();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.dgvParcaListesi = new System.Windows.Forms.DataGridView();
            this.btnAtikGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnParcaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.chbKategorideAra = new DevExpress.XtraEditors.CheckEdit();
            this.cmbKategorideAra = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gbTedarikciBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbTedarikListesi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTedarikciEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbSatinAlmaveStok = new System.Windows.Forms.GroupBox();
            this.txtParcaAdedi = new System.Windows.Forms.NumericUpDown();
            this.txtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateAlisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.btnParcaDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTdrkDuzenle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDuzenleAdedi = new System.Windows.Forms.NumericUpDown();
            this.txtDuzenleFiyat = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateDuzenleTarih = new DevExpress.XtraEditors.DateEdit();
            this.cmbAitOlduguPC = new System.Windows.Forms.ComboBox();
            this.gbStokDuzenle = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbParcaKategori = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtParcaAdi = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParcaAciklama = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtParcaBarkod = new DevExpress.XtraEditors.TextEdit();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkodAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbKategorideAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategorideAra.Properties)).BeginInit();
            this.gbTedarikciBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSatinAlmaveStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaAdedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAlisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAlisTarihi.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuzenleAdedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuzenleFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDuzenleTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDuzenleTarih.Properties)).BeginInit();
            this.gbStokDuzenle.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaBarkod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(15, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Barkod Ara:";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(114, 381);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBarkodAra.Properties.Appearance.Options.UseFont = true;
            this.txtBarkodAra.Properties.Mask.EditMask = "c";
            this.txtBarkodAra.Size = new System.Drawing.Size(128, 26);
            this.txtBarkodAra.TabIndex = 41;
            this.txtBarkodAra.EditValueChanged += new System.EventHandler(this.txtBarkodAra_EditValueChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(981, 228);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(170, 62);
            this.btnCikis.TabIndex = 40;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dgvParcaListesi
            // 
            this.dgvParcaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcaListesi.Location = new System.Drawing.Point(12, 412);
            this.dgvParcaListesi.Name = "dgvParcaListesi";
            this.dgvParcaListesi.Size = new System.Drawing.Size(1155, 390);
            this.dgvParcaListesi.TabIndex = 38;
            this.dgvParcaListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcaListesi_CellClick);
            // 
            // btnAtikGonder
            // 
            this.btnAtikGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAtikGonder.Appearance.Options.UseFont = true;
            this.btnAtikGonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAtikGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtikGonder.ImageOptions.Image")));
            this.btnAtikGonder.Location = new System.Drawing.Point(981, 159);
            this.btnAtikGonder.Name = "btnAtikGonder";
            this.btnAtikGonder.Size = new System.Drawing.Size(170, 63);
            this.btnAtikGonder.TabIndex = 34;
            this.btnAtikGonder.Text = "Atığa Gönder";
            this.btnAtikGonder.Click += new System.EventHandler(this.btnAtikGonder_Click);
            // 
            // btnParcaEkle
            // 
            this.btnParcaEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnParcaEkle.Appearance.Options.UseFont = true;
            this.btnParcaEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnParcaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParcaEkle.ImageOptions.Image")));
            this.btnParcaEkle.Location = new System.Drawing.Point(24, 289);
            this.btnParcaEkle.Name = "btnParcaEkle";
            this.btnParcaEkle.Size = new System.Drawing.Size(251, 51);
            this.btnParcaEkle.TabIndex = 33;
            this.btnParcaEkle.Text = "Yeni Parça Ekle";
            this.btnParcaEkle.Click += new System.EventHandler(this.btnParcaEkle_Click);
            // 
            // chbKategorideAra
            // 
            this.chbKategorideAra.Location = new System.Drawing.Point(271, 382);
            this.chbKategorideAra.Name = "chbKategorideAra";
            this.chbKategorideAra.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chbKategorideAra.Properties.Appearance.Options.UseFont = true;
            this.chbKategorideAra.Properties.Caption = "Şu Kategoride Ara:";
            this.chbKategorideAra.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chbKategorideAra.Size = new System.Drawing.Size(155, 24);
            this.chbKategorideAra.TabIndex = 43;
            this.chbKategorideAra.CheckedChanged += new System.EventHandler(this.chbKategorideAra_CheckedChanged);
            // 
            // cmbKategorideAra
            // 
            this.cmbKategorideAra.EditValue = "Seçin";
            this.cmbKategorideAra.Enabled = false;
            this.cmbKategorideAra.Location = new System.Drawing.Point(432, 381);
            this.cmbKategorideAra.Name = "cmbKategorideAra";
            this.cmbKategorideAra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbKategorideAra.Properties.Appearance.Options.UseFont = true;
            this.cmbKategorideAra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKategorideAra.Properties.Items.AddRange(new object[] {
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
            this.cmbKategorideAra.Size = new System.Drawing.Size(128, 26);
            this.cmbKategorideAra.TabIndex = 44;
            this.cmbKategorideAra.EditValueChanged += new System.EventHandler(this.cmbKategorideAra_EditValueChanged);
            // 
            // gbTedarikciBilgileri
            // 
            this.gbTedarikciBilgileri.Controls.Add(this.cmbTedarikListesi);
            this.gbTedarikciBilgileri.Controls.Add(this.label1);
            this.gbTedarikciBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTedarikciBilgileri.Location = new System.Drawing.Point(24, 32);
            this.gbTedarikciBilgileri.Name = "gbTedarikciBilgileri";
            this.gbTedarikciBilgileri.Size = new System.Drawing.Size(251, 79);
            this.gbTedarikciBilgileri.TabIndex = 45;
            this.gbTedarikciBilgileri.TabStop = false;
            this.gbTedarikciBilgileri.Text = "Tedarikçi Bilgileri";
            // 
            // cmbTedarikListesi
            // 
            this.cmbTedarikListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTedarikListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTedarikListesi.FormattingEnabled = true;
            this.cmbTedarikListesi.Location = new System.Drawing.Point(96, 30);
            this.cmbTedarikListesi.Name = "cmbTedarikListesi";
            this.cmbTedarikListesi.Size = new System.Drawing.Size(138, 21);
            this.cmbTedarikListesi.TabIndex = 48;
            this.cmbTedarikListesi.DropDown += new System.EventHandler(this.cmbTedarikListesi_DropDown);
            this.cmbTedarikListesi.DropDownClosed += new System.EventHandler(this.cmbTedarikListesi_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tedarikçi:";
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTedarikciEkle.Appearance.Options.UseFont = true;
            this.btnTedarikciEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTedarikciEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTedarikciEkle.ImageOptions.Image")));
            this.btnTedarikciEkle.Location = new System.Drawing.Point(981, 90);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(170, 63);
            this.btnTedarikciEkle.TabIndex = 44;
            this.btnTedarikciEkle.Text = "Tedarikçi Yönetim";
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbSatinAlmaveStok);
            this.groupBox1.Controls.Add(this.gbTedarikciBilgileri);
            this.groupBox1.Controls.Add(this.btnParcaEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(19, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 353);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Stok Gir";
            // 
            // gbSatinAlmaveStok
            // 
            this.gbSatinAlmaveStok.Controls.Add(this.txtParcaAdedi);
            this.gbSatinAlmaveStok.Controls.Add(this.txtAlisFiyati);
            this.gbSatinAlmaveStok.Controls.Add(this.label3);
            this.gbSatinAlmaveStok.Controls.Add(this.label2);
            this.gbSatinAlmaveStok.Controls.Add(this.label4);
            this.gbSatinAlmaveStok.Controls.Add(this.dateAlisTarihi);
            this.gbSatinAlmaveStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSatinAlmaveStok.Location = new System.Drawing.Point(24, 117);
            this.gbSatinAlmaveStok.Name = "gbSatinAlmaveStok";
            this.gbSatinAlmaveStok.Size = new System.Drawing.Size(251, 142);
            this.gbSatinAlmaveStok.TabIndex = 46;
            this.gbSatinAlmaveStok.TabStop = false;
            this.gbSatinAlmaveStok.Text = "Satın Alma ve Stok Bilgileri";
            // 
            // txtParcaAdedi
            // 
            this.txtParcaAdedi.Location = new System.Drawing.Point(119, 92);
            this.txtParcaAdedi.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtParcaAdedi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParcaAdedi.Name = "txtParcaAdedi";
            this.txtParcaAdedi.Size = new System.Drawing.Size(100, 20);
            this.txtParcaAdedi.TabIndex = 55;
            this.txtParcaAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParcaAdedi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcaAdedi_KeyPress);
            this.txtParcaAdedi.Leave += new System.EventHandler(this.txtParcaAdedi_Leave);
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(119, 61);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAlisFiyati.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAlisFiyati.Properties.Mask.EditMask = "\\d+";
            this.txtAlisFiyati.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAlisFiyati.Properties.MaxLength = 6;
            this.txtAlisFiyati.Properties.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtAlisFiyati.TabIndex = 47;
            this.txtAlisFiyati.EditValueChanged += new System.EventHandler(this.txtAlisFiyati_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Alış Fiyatı(TL):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Alış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Parça Adedi:";
            // 
            // dateAlisTarihi
            // 
            this.dateAlisTarihi.EditValue = new System.DateTime(2018, 12, 25, 14, 56, 15, 0);
            this.dateAlisTarihi.Location = new System.Drawing.Point(119, 29);
            this.dateAlisTarihi.Name = "dateAlisTarihi";
            this.dateAlisTarihi.Properties.AllowMouseWheel = false;
            this.dateAlisTarihi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateAlisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAlisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAlisTarihi.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateAlisTarihi.Properties.MaxValue = new System.DateTime(2018, 12, 27, 0, 0, 0, 0);
            this.dateAlisTarihi.Size = new System.Drawing.Size(100, 20);
            this.dateAlisTarihi.TabIndex = 0;
            this.dateAlisTarihi.EditValueChanged += new System.EventHandler(this.dateAlisTarihi_EditValueChanged);
            this.dateAlisTarihi.Enter += new System.EventHandler(this.dateAlisTarihi_Enter);
            // 
            // btnParcaDuzenle
            // 
            this.btnParcaDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnParcaDuzenle.Appearance.Options.UseFont = true;
            this.btnParcaDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnParcaDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParcaDuzenle.ImageOptions.Image")));
            this.btnParcaDuzenle.Location = new System.Drawing.Point(376, 296);
            this.btnParcaDuzenle.Name = "btnParcaDuzenle";
            this.btnParcaDuzenle.Size = new System.Drawing.Size(251, 51);
            this.btnParcaDuzenle.TabIndex = 35;
            this.btnParcaDuzenle.Text = "Parça Bilgisi Düzenle";
            this.btnParcaDuzenle.Click += new System.EventHandler(this.btnParcaDuzenle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTdrkDuzenle);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(24, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 79);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tedarikçi Bilgileri";
            // 
            // cmbTdrkDuzenle
            // 
            this.cmbTdrkDuzenle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTdrkDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTdrkDuzenle.FormattingEnabled = true;
            this.cmbTdrkDuzenle.Location = new System.Drawing.Point(96, 30);
            this.cmbTdrkDuzenle.Name = "cmbTdrkDuzenle";
            this.cmbTdrkDuzenle.Size = new System.Drawing.Size(138, 21);
            this.cmbTdrkDuzenle.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(14, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Tedarikçi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDuzenleAdedi);
            this.groupBox3.Controls.Add(this.txtDuzenleFiyat);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dateDuzenleTarih);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(24, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 166);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satın Alma ve Stok Bilgileri";
            // 
            // txtDuzenleAdedi
            // 
            this.txtDuzenleAdedi.Location = new System.Drawing.Point(124, 108);
            this.txtDuzenleAdedi.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtDuzenleAdedi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDuzenleAdedi.Name = "txtDuzenleAdedi";
            this.txtDuzenleAdedi.Size = new System.Drawing.Size(100, 20);
            this.txtDuzenleAdedi.TabIndex = 56;
            this.txtDuzenleAdedi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDuzenleFiyat
            // 
            this.txtDuzenleFiyat.Location = new System.Drawing.Point(124, 74);
            this.txtDuzenleFiyat.Name = "txtDuzenleFiyat";
            this.txtDuzenleFiyat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuzenleFiyat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuzenleFiyat.Properties.Mask.EditMask = "\\d+";
            this.txtDuzenleFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDuzenleFiyat.Properties.MaxLength = 4;
            this.txtDuzenleFiyat.Properties.Name = "txtAlisFiyati";
            this.txtDuzenleFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtDuzenleFiyat.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Alış Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "Parça Adedi:";
            // 
            // dateDuzenleTarih
            // 
            this.dateDuzenleTarih.EditValue = null;
            this.dateDuzenleTarih.Location = new System.Drawing.Point(124, 42);
            this.dateDuzenleTarih.Name = "dateDuzenleTarih";
            this.dateDuzenleTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDuzenleTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDuzenleTarih.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateDuzenleTarih.Properties.MaxValue = new System.DateTime(2018, 12, 27, 0, 0, 0, 0);
            this.dateDuzenleTarih.Size = new System.Drawing.Size(100, 20);
            this.dateDuzenleTarih.TabIndex = 0;
            // 
            // cmbAitOlduguPC
            // 
            this.cmbAitOlduguPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAitOlduguPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAitOlduguPC.FormattingEnabled = true;
            this.cmbAitOlduguPC.Location = new System.Drawing.Point(112, 126);
            this.cmbAitOlduguPC.Name = "cmbAitOlduguPC";
            this.cmbAitOlduguPC.Size = new System.Drawing.Size(177, 21);
            this.cmbAitOlduguPC.TabIndex = 49;
            // 
            // gbStokDuzenle
            // 
            this.gbStokDuzenle.Controls.Add(this.groupBox5);
            this.gbStokDuzenle.Controls.Add(this.groupBox3);
            this.gbStokDuzenle.Controls.Add(this.groupBox4);
            this.gbStokDuzenle.Controls.Add(this.btnParcaDuzenle);
            this.gbStokDuzenle.Enabled = false;
            this.gbStokDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStokDuzenle.Location = new System.Drawing.Point(320, 22);
            this.gbStokDuzenle.Name = "gbStokDuzenle";
            this.gbStokDuzenle.Size = new System.Drawing.Size(633, 353);
            this.gbStokDuzenle.TabIndex = 47;
            this.gbStokDuzenle.TabStop = false;
            this.gbStokDuzenle.Text = "Stok Bilgisi Düzenle";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbParcaKategori);
            this.groupBox5.Controls.Add(this.simpleButton1);
            this.groupBox5.Controls.Add(this.cmbAitOlduguPC);
            this.groupBox5.Controls.Add(this.txtParcaAdi);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtParcaAciklama);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txtParcaBarkod);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Location = new System.Drawing.Point(284, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 264);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parça Bilgileri";
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
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(294, 126);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(22, 21);
            this.simpleButton1.TabIndex = 51;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Ait Olduğu PC:";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(16, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Açıklaması:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(15, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 20);
            this.label18.TabIndex = 41;
            this.label18.Text = "Kategori:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(15, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 20);
            this.label19.TabIndex = 10;
            this.label19.Text = "Barkod:";
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(15, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 20);
            this.label20.TabIndex = 11;
            this.label20.Text = "Parça Adı:";
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 814);
            this.Controls.Add(this.btnTedarikciEkle);
            this.Controls.Add(this.gbStokDuzenle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbKategorideAra);
            this.Controls.Add(this.chbKategorideAra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dgvParcaListesi);
            this.Controls.Add(this.btnAtikGonder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmRapor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satın Alma İşlemleri";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkodAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbKategorideAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategorideAra.Properties)).EndInit();
            this.gbTedarikciBilgileri.ResumeLayout(false);
            this.gbTedarikciBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbSatinAlmaveStok.ResumeLayout(false);
            this.gbSatinAlmaveStok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaAdedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAlisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAlisTarihi.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuzenleAdedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuzenleFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDuzenleTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDuzenleTarih.Properties)).EndInit();
            this.gbStokDuzenle.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaBarkod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtBarkodAra;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private System.Windows.Forms.DataGridView dgvParcaListesi;
        private DevExpress.XtraEditors.SimpleButton btnAtikGonder;
        private DevExpress.XtraEditors.SimpleButton btnParcaEkle;
        private DevExpress.XtraEditors.CheckEdit chbKategorideAra;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKategorideAra;
        private System.Windows.Forms.GroupBox gbTedarikciBilgileri;
        private DevExpress.XtraEditors.SimpleButton btnTedarikciEkle;
        private System.Windows.Forms.ComboBox cmbTedarikListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbSatinAlmaveStok;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateAlisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtParcaAdedi;
        private DevExpress.XtraEditors.SimpleButton btnParcaDuzenle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit dateDuzenleTarih;
        private System.Windows.Forms.GroupBox gbStokDuzenle;
        private System.Windows.Forms.ComboBox cmbTdrkDuzenle;
        private DevExpress.XtraEditors.TextEdit txtDuzenleFiyat;
        private System.Windows.Forms.NumericUpDown txtDuzenleAdedi;
        private System.Windows.Forms.ComboBox cmbAitOlduguPC;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbParcaKategori;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtParcaAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParcaAciklama;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.TextEdit txtParcaBarkod;
        private System.Windows.Forms.Label label20;
    }
}