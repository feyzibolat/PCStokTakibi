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
    public partial class frmPCEkle : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmPCEkle()
        {
            InitializeComponent();
        }

        void tabloGuncelle()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "SELECT * FROM tblBilgisayar WHERE pcAd LIKE '" + txtPCBul.Text + "%'";
                komut.ExecuteNonQuery();
                komut.Dispose();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblBilgisayar");
                dgvPCListesi.DataSource = ds.Tables["tblBilgisayar"];
                sqlConnection.Close();
                dgvPCListesi.Columns[0].HeaderText = "PC ID";
                dgvPCListesi.Columns[0].Width = 60;
                dgvPCListesi.Columns[1].HeaderText = "PC Adı";
                dgvPCListesi.Columns[2].HeaderText = "PC Açıklaması";

            }

        }

        void inputlariTemizle()
        {
            txtPCAciklama.Text = txtPCAdi.Text = txtPCBul.Text = "";
        }


        private void btnPCOlustur_Click(object sender, EventArgs e)
        {
            if (txtPCAdi.Text != "" && txtPCAciklama.Text != "")
            {

            
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "INSERT INTO tblBilgisayar VALUES(@AD,@ACIKLAMA)"; // SQL Kayıt Girişi
                    komut.Parameters.AddWithValue("@AD", txtPCAdi.Text);
                    komut.Parameters.AddWithValue("@ACIKLAMA", txtPCAciklama.Text);
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
                    komut.Dispose();
                    sqlConnection.Close();
                    tabloGuncelle();
                    inputlariTemizle();
                    MessageBox.Show("Ekleme Başarılı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string pcAd = dgvPCListesi.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show(pcAd + " isimli Bilgisayarı Silmek istediğinize eminmisiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {// if ile onay iste
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "DELETE FROM tblBilgisayar WHERE pcID=@pcID"; // seçilen pcID'ye göre bilgisayarı sil
                    komut.Parameters.AddWithValue("@pcID", dgvPCListesi.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
                    komut.Dispose();
                    sqlConnection.Close();
                    tabloGuncelle();
                    inputlariTemizle();
                }

            }
        }

        private void frmPCEkle_Load(object sender, EventArgs e)
        {
            //yüklenince dgvPCListesi ayarları yap.
            dgvPCListesi.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvPCListesi.RowHeadersVisible = false;
            dgvPCListesi.ReadOnly = true;
            dgvPCListesi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPCListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPCListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPCListesi.MultiSelect = false;
            dgvPCListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPCListesi.AllowUserToAddRows = false;
            tabloGuncelle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "UPDATE tblBilgisayar SET pcAd=@AD,pcAciklama=@ACIKLAMA WHERE pcID=@secilenID"; // SQL Update Ayarları
                komut.Parameters.AddWithValue("@secilenID", dgvPCListesi.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@AD", txtPCAdi.Text);
                komut.Parameters.AddWithValue("@ACIKLAMA", txtPCAciklama.Text);
                komut.ExecuteNonQuery();
                komut.Parameters.Clear();
                komut.Dispose();
                sqlConnection.Close(); //Bağlantıyı Kapat
                tabloGuncelle();
                inputlariTemizle();
            }
        }

        private void dgvPCListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPCAdi.Text = dgvPCListesi.CurrentRow.Cells[1].Value.ToString();
            txtPCAciklama.Text = dgvPCListesi.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtPCBul_EditValueChanged(object sender, EventArgs e)
        {
            tabloGuncelle();//txtPCBul değer değiştiğince tabloyu guncelle:);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
