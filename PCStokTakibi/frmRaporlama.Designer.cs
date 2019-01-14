namespace PCStokTakibi
{
    partial class frmRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporlama));
            this.btnBolumCikti = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBolum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPersonel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelCikti = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPersonelListesi = new System.Windows.Forms.DataGridView();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBolum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBolumCikti
            // 
            this.btnBolumCikti.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBolumCikti.Appearance.Options.UseFont = true;
            this.btnBolumCikti.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnBolumCikti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBolumCikti.ImageOptions.Image")));
            this.btnBolumCikti.Location = new System.Drawing.Point(26, 214);
            this.btnBolumCikti.Name = "btnBolumCikti";
            this.btnBolumCikti.Size = new System.Drawing.Size(162, 65);
            this.btnBolumCikti.TabIndex = 12;
            this.btnBolumCikti.Text = "Bölüm Bilgisi\r\nÇıktı Al";
            // 
            // cmbBolum
            // 
            this.cmbBolum.EditValue = "Seçin";
            this.cmbBolum.Location = new System.Drawing.Point(110, 23);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbBolum.Properties.Appearance.Options.UseFont = true;
            this.cmbBolum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBolum.Properties.Items.AddRange(new object[] {
            "Yönetici",
            "Satınalma",
            "Muhasebe",
            "Personel",
            "Teknik"});
            this.cmbBolum.Size = new System.Drawing.Size(128, 26);
            this.cmbBolum.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bölüm";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.EditValue = "Seçin";
            this.cmbPersonel.Location = new System.Drawing.Point(326, 23);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbPersonel.Properties.Appearance.Options.UseFont = true;
            this.cmbPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPersonel.Properties.Items.AddRange(new object[] {
            "Yönetici",
            "Satınalma",
            "Muhasebe",
            "Personel",
            "Teknik"});
            this.cmbPersonel.Size = new System.Drawing.Size(128, 26);
            this.cmbPersonel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(249, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personel";
            // 
            // btnPersonelCikti
            // 
            this.btnPersonelCikti.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPersonelCikti.Appearance.Options.UseFont = true;
            this.btnPersonelCikti.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnPersonelCikti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelCikti.ImageOptions.Image")));
            this.btnPersonelCikti.Location = new System.Drawing.Point(194, 214);
            this.btnPersonelCikti.Name = "btnPersonelCikti";
            this.btnPersonelCikti.Size = new System.Drawing.Size(162, 65);
            this.btnPersonelCikti.TabIndex = 17;
            this.btnPersonelCikti.Text = "Personel Bilgisi\r\nÇıktı Al";
            // 
            // dgvPersonelListesi
            // 
            this.dgvPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelListesi.Location = new System.Drawing.Point(12, 67);
            this.dgvPersonelListesi.Name = "dgvPersonelListesi";
            this.dgvPersonelListesi.Size = new System.Drawing.Size(501, 133);
            this.dgvPersonelListesi.TabIndex = 18;
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(362, 215);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(139, 64);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 294);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dgvPersonelListesi);
            this.Controls.Add(this.btnPersonelCikti);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBolumCikti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmRaporlama";
            this.Text = "Raporlama İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.cmbBolum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnBolumCikti;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBolum;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPersonel;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnPersonelCikti;
        private System.Windows.Forms.DataGridView dgvPersonelListesi;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}