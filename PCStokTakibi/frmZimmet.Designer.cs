namespace PCStokTakibi
{
    partial class frmZimmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZimmet));
            this.cmbBolum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtPersonelNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dgvZimmetlListesi = new System.Windows.Forms.DataGridView();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBolum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZimmetlListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBolum
            // 
            this.cmbBolum.Location = new System.Drawing.Point(113, 29);
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
            this.cmbBolum.TabIndex = 2;
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(381, 32);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 64);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Kaldır";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(259, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 64);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Zimmetle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Per TCKN:";
            // 
            // mtxtPersonelNo
            // 
            this.mtxtPersonelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtPersonelNo.Location = new System.Drawing.Point(113, 93);
            this.mtxtPersonelNo.Mask = "000000";
            this.mtxtPersonelNo.Name = "mtxtPersonelNo";
            this.mtxtPersonelNo.Size = new System.Drawing.Size(128, 26);
            this.mtxtPersonelNo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Personel:";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(113, 61);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Yönetici",
            "Satınalma",
            "Muhasebe",
            "Personel",
            "Teknik"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(128, 26);
            this.comboBoxEdit1.TabIndex = 15;
            // 
            // dgvZimmetlListesi
            // 
            this.dgvZimmetlListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZimmetlListesi.Location = new System.Drawing.Point(9, 130);
            this.dgvZimmetlListesi.Name = "dgvZimmetlListesi";
            this.dgvZimmetlListesi.Size = new System.Drawing.Size(572, 209);
            this.dgvZimmetlListesi.TabIndex = 17;
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(486, 32);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(99, 64);
            this.btnCikis.TabIndex = 19;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmZimmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 351);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dgvZimmetlListesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.mtxtPersonelNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmZimmet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZİMMET";
            this.Load += new System.EventHandler(this.frmZimmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBolum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZimmetlListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbBolum;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtPersonelNo;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.DataGridView dgvZimmetlListesi;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}