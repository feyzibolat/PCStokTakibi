using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PCStokTakibi
{
    public partial class frmKullanici : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmKullanici()
        {
            InitializeComponent();
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            //Veritabanı işlemleri
            dgvKullListesi.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvKullListesi.RowHeadersVisible = false;
            dgvKullListesi.ReadOnly = true;
            dgvKullListesi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKullListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKullListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKullListesi.MultiSelect = false;
            dgvKullListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullListesi.AllowUserToAddRows = false;
            tabloGuncelle();
        }

        void tabloGuncelle()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "SELECT K.kullID,K.kullAdi,K.kullSifre,R.rolAdi " +
                                    "FROM tblKullanici K INNER JOIN tblRol R ON K.rolID = R.rolID";
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblKullanici");
                dgvKullListesi.DataSource = ds.Tables["tblKullanici"];
                sqlConnection.Close();
                dgvKullListesi.Columns[0].HeaderText = "Kullanıcı ID";
                dgvKullListesi.Columns[1].HeaderText = "Kullanıcı Adı";
                dgvKullListesi.Columns[2].HeaderText = "Kullanıcı Şifre";
                dgvKullListesi.Columns[3].HeaderText = "Rol Adı";

            }

        }

        void inputlariTemizle()
        {
            txtKullaniciAdi.Text = txtSifre.Text = "";
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "" && cmbRol.Text != "") //inputlar boş değilse
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    int kullRolID = 0;
                    switch (cmbRol.Text)
                    {
                        case "Admin":
                            kullRolID = 1;
                            break;
                        case "Yönetici":
                            kullRolID = 2;
                            break;
                        case "Bölüm Yetkilisi":
                            kullRolID = 3;
                            break;
                        default:
                            kullRolID = 0;
                            break;
                    }
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "INSERT INTO tblKullanici(rolID,kullAdi,kullSifre) VALUES(@kullRolID,@kullAdi,@kullSifre)"; //SQL kayıt işlemi
                    komut.Parameters.AddWithValue("@kullAdi", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@kullSifre", txtSifre.Text);
                    komut.Parameters.AddWithValue("@kullRolID", kullRolID);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    sqlConnection.Close();
                    tabloGuncelle();
                    //MessageBox.Show("Kaydedildi!");

                }
                inputlariTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string kullAd = dgvKullListesi.CurrentRow.Cells[2].Value.ToString();
            if (MessageBox.Show("["+kullAd+"]"+" isimli kullanıcıyı Silmek istediğinize eminmisiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "DELETE FROM tblKullanici WHERE kullID=@kullID";
                    komut.Parameters.AddWithValue("@kullID", dgvKullListesi.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    sqlConnection.Close();
                    tabloGuncelle();
                    //MessageBox.Show("Seçilen Kayıt Silindi!");
                }
                inputlariTemizle();

            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "" && cmbRol.Text != "")
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "UPDATE tblKullanici SET kullAdi=@kullAdi,kullSifre=@kullSifre,rolID=(SELECT rolID FROM tblRol WHERE rolAdi=@kullRol) WHERE kullID=@secilenKullID";
                    komut.Parameters.AddWithValue("@secilenKullID", dgvKullListesi.CurrentRow.Cells[0].Value.ToString());
                    komut.Parameters.AddWithValue("@kullAdi", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@kullSifre", txtSifre.Text);
                    komut.Parameters.AddWithValue("@kullRol", cmbRol.Text);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    sqlConnection.Close();
                    tabloGuncelle();
                    //MessageBox.Show("Seçilen Kayıt Güncellendi!");
                }
                inputlariTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!");
            }
        }

        private void dgvKullListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dgvKullListesi değerleri inputlara bas
            txtKullaniciAdi.Text = dgvKullListesi.CurrentRow.Cells[1].Value.ToString();
            txtSifre.Text = dgvKullListesi.CurrentRow.Cells[2].Value.ToString();
            cmbRol.Text = dgvKullListesi.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close(); // KAPAT
        }

        private void txtKullaniciAdi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 20) // 20den fazla uzunluk engeli
                    e.Cancel = true;
        }

        private void txtSifre_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 20) // 20den fazla uzunluk engeli
                    e.Cancel = true;
        }
    }
}
