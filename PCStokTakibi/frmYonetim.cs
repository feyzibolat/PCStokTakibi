using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCStokTakibi
{
    public partial class frmYonetim : Form
    {
        string dbString = frmLogin.dbString;

        public frmYonetim()
        {
            InitializeComponent();
        }

        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public int kullYetkiID { get; set; }
        public string kullYetki { get; set; }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            frmPersonel personelFormu = new frmPersonel(); // personelFormu formunu aç
            this.Hide();
            personelFormu.StartPosition = FormStartPosition.CenterScreen;
            personelFormu.ShowDialog();
            this.Show();
        }

        private void btnZimmet_Click(object sender, EventArgs e)
        {
            frmZimmet zimmetFormu = new frmZimmet(); // zimmetFormu formunu aç
            this.Hide();
            zimmetFormu.StartPosition = FormStartPosition.CenterScreen;
            zimmetFormu.ShowDialog();
            this.Show();
        }

        private void btnSatinalma_Click(object sender, EventArgs e)
        {
            frmRapor satinalmaFormu = new frmRapor(); // satinalmaFormu formunu aç
            this.Hide();
            satinalmaFormu.StartPosition = FormStartPosition.CenterScreen;
            satinalmaFormu.ShowDialog();
            this.Show();
        }

        private void btnAtikDepo_Click(object sender, EventArgs e)
        {
            frmAtikDepo atikDepoFormu = new frmAtikDepo(); // atikDepoFormu formunu aç
            this.Hide();
            atikDepoFormu.StartPosition = FormStartPosition.CenterScreen;
            atikDepoFormu.ShowDialog();
            this.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmRaporlama raporFormu = new frmRaporlama(); // raporFormu formunu aç
            this.Hide();
            raporFormu.StartPosition = FormStartPosition.CenterScreen;
            raporFormu.ShowDialog();
            this.Show();
        }

        private void btnKull_Click(object sender, EventArgs e)
        {
            frmKullanici kullFormu = new frmKullanici(); // kullFormu formunu aç
            this.Hide();
            kullFormu.StartPosition = FormStartPosition.CenterScreen;
            kullFormu.ShowDialog();
            this.Show();
        }

        private void frmYonetim_Load(object sender, EventArgs e)
        {
            /* Singleton Tasarım Kalıbı */
            Sirket sirket = Sirket.getInstance();
            sirket.Hosgeldiniz();
            /* Singleton Tasarım Kalıbı */


            switch (kullYetkiID)
            {
                case 1:
                    kullYetki = "Admin";
                    break;
                case 2:
                    kullYetki = "Yönetici";
                    break;
                case 3:
                    kullYetki = "Bölüm Yetkilisi";
                    break;
            }

            if (kullYetki=="Admin")
            {
                //
            }
            else if (kullYetki == "Yönetici")
            {
                //
            }
            else if (kullYetki == "Bölüm Yetkilisi")
            {
                btnRapor.Enabled = true;
                btnZimmet.Enabled = false;
                btnPersonel.Enabled = false;
                btnSatinalma.Enabled = false;
                btnAtikDepo.Enabled = false;
                btnKull.Enabled = false;
            }

            label1.Text = "Hoşgeldiniz, Sayın " + kullaniciAdi.ToUpper().ToString();
            label2.Text = "Kullanıcı Rolünüz: " + kullYetki.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
