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
    public partial class frmTedarikciEkle : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmTedarikciEkle()
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
                komut.CommandText = "SELECT * FROM tblTedarikci WHERE tedarikciAdi LIKE '" + txtTedarikciBul.Text + "%'";
                komut.ExecuteNonQuery();
                komut.Dispose();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblTedarikci");
                dgvTedarikciListesi.DataSource = ds.Tables["tblTedarikci"];
                sqlConnection.Close();
                dgvTedarikciListesi.Columns[0].HeaderText = "Tedarikçi ID";
                dgvTedarikciListesi.Columns[0].Width = 60;
                dgvTedarikciListesi.Columns[1].HeaderText = "Tedarikçi Adı";
                dgvTedarikciListesi.Columns[2].HeaderText = "Tedarikçi Adres";
                dgvTedarikciListesi.Columns[3].HeaderText = "Tedarikçi Telefon";

            }

        }

        void inputlariTemizle()
        {
            txtTedarikciAdres.Text = txtTedarikciAdi.Text = txtTedarikciBul.Text = mtxtTelefon.Text = "";
        }

        private void btnTedarikciOlustur_Click(object sender, EventArgs e)
        {
            if (txtTedarikciAdi.Text != "" && txtTedarikciAdres.Text != "" && mtxtTelefon.Text != "(   )    -  -")
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "INSERT INTO tblTedarikci VALUES(@AD,@ADRES,@TEL)";
                    komut.Parameters.AddWithValue("@AD", txtTedarikciAdi.Text);
                    komut.Parameters.AddWithValue("@ADRES", txtTedarikciAdres.Text);
                    komut.Parameters.AddWithValue("@TEL", mtxtTelefon.Text);
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
            string tdrAd = dgvTedarikciListesi.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show(tdrAd + " isimli Tedarikçiyi Silmek istediğinize eminmisiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sqlConnection.State == ConnectionState.Closed)// Bağlantı yoksa bağlantı aç.
                {
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "DELETE FROM tblTedarikci WHERE tedarikciID=@tedarikciID"; 
                    komut.Parameters.AddWithValue("@tedarikciID", dgvTedarikciListesi.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
                    komut.Dispose();
                    sqlConnection.Close();
                    tabloGuncelle();
                    inputlariTemizle();
                }

            }
        }

        private void frmTedarikciEkle_Load(object sender, EventArgs e)
        {
            dgvTedarikciListesi.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvTedarikciListesi.RowHeadersVisible = false;
            dgvTedarikciListesi.ReadOnly = true;
            dgvTedarikciListesi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTedarikciListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTedarikciListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTedarikciListesi.MultiSelect = false;
            dgvTedarikciListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTedarikciListesi.AllowUserToAddRows = false;
            tabloGuncelle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtTedarikciAdi.Text != "" && txtTedarikciAdres.Text != "" && mtxtTelefon.Text != "(   )    -  -")
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {// inputlardaki değerleri alıp güncelle
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "UPDATE tblTedarikci SET tedarikciAdi=@tedarikciAdi,tedarikciAdres=@tedarikciAdres,tedarikciTel=@tedarikciTel WHERE tedarikciID=@secilenID";
                    komut.Parameters.AddWithValue("@secilenID", dgvTedarikciListesi.CurrentRow.Cells[0].Value.ToString());
                    komut.Parameters.AddWithValue("@tedarikciAdi", txtTedarikciAdi.Text);
                    komut.Parameters.AddWithValue("@tedarikciAdres", txtTedarikciAdres.Text);
                    komut.Parameters.AddWithValue("@tedarikciTel", mtxtTelefon.Text);
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
                    komut.Dispose();
                    sqlConnection.Close();
                    tabloGuncelle();
                    inputlariTemizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!");
            }
        }

        private void txtTedarikciBul_EditValueChanged(object sender, EventArgs e)
        {
            tabloGuncelle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTedarikciListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTedarikciAdi.Text = dgvTedarikciListesi.CurrentRow.Cells[1].Value.ToString();
            txtTedarikciAdres.Text = dgvTedarikciListesi.CurrentRow.Cells[2].Value.ToString();
            mtxtTelefon.Text = dgvTedarikciListesi.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
