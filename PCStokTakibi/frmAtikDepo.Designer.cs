namespace PCStokTakibi
{
    partial class frmAtikDepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtikDepo));
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.dgvAtikListesi = new System.Windows.Forms.DataGridView();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.cmbKategorideAra = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chbKategorideAra = new DevExpress.XtraEditors.CheckEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarkodAra = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtikListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategorideAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbKategorideAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkodAra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(140, 264);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(163, 64);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Depodan Çıkar";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvAtikListesi
            // 
            this.dgvAtikListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtikListesi.Location = new System.Drawing.Point(32, 59);
            this.dgvAtikListesi.Name = "dgvAtikListesi";
            this.dgvAtikListesi.Size = new System.Drawing.Size(541, 199);
            this.dgvAtikListesi.TabIndex = 17;
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(309, 264);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(163, 64);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // cmbKategorideAra
            // 
            this.cmbKategorideAra.EditValue = "Seçin";
            this.cmbKategorideAra.Enabled = false;
            this.cmbKategorideAra.Location = new System.Drawing.Point(445, 28);
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
            this.cmbKategorideAra.TabIndex = 52;
            // 
            // chbKategorideAra
            // 
            this.chbKategorideAra.Location = new System.Drawing.Point(284, 29);
            this.chbKategorideAra.Name = "chbKategorideAra";
            this.chbKategorideAra.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chbKategorideAra.Properties.Appearance.Options.UseFont = true;
            this.chbKategorideAra.Properties.Caption = "Şu Kategoride Ara:";
            this.chbKategorideAra.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chbKategorideAra.Size = new System.Drawing.Size(155, 24);
            this.chbKategorideAra.TabIndex = 51;
            this.chbKategorideAra.CheckedChanged += new System.EventHandler(this.chbKategorideAra_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(28, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Barkod Ara:";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(127, 28);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBarkodAra.Properties.Appearance.Options.UseFont = true;
            this.txtBarkodAra.Properties.Mask.EditMask = "c";
            this.txtBarkodAra.Size = new System.Drawing.Size(128, 26);
            this.txtBarkodAra.TabIndex = 49;
            this.txtBarkodAra.EditValueChanged += new System.EventHandler(this.txtBarkodAra_EditValueChanged);
            // 
            // frmAtikDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 351);
            this.Controls.Add(this.cmbKategorideAra);
            this.Controls.Add(this.chbKategorideAra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dgvAtikListesi);
            this.Controls.Add(this.btnSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtikDepo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATIK DEPO";
            this.Load += new System.EventHandler(this.frmAtikDepo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtikListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategorideAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbKategorideAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkodAra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.DataGridView dgvAtikListesi;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKategorideAra;
        private DevExpress.XtraEditors.CheckEdit chbKategorideAra;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtBarkodAra;
    }
}