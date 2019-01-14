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
    public partial class frmPersonel : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmPersonel()
        {
            InitializeComponent();
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            // form açılınca dgvPersonelListes ayarlarını yükle
            txtAdres.MaxLength = 100;
            dgvPersonelListesi.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvPersonelListesi.RowHeadersVisible = false;
            dgvPersonelListesi.ReadOnly = true;
            dgvPersonelListesi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPersonelListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonelListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPersonelListesi.MultiSelect = false;
            dgvPersonelListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonelListesi.AllowUserToAddRows = false;
            rdbAktif.Checked = true;
            tabloGuncelle();
        }

        void tabloGuncelle()
        {
            txtTCKNbul.Text = "";
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "SELECT * FROM tblPersonel";
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblPersonel");
                dgvPersonelListesi.DataSource = ds.Tables["tblPersonel"];
                sqlConnection.Close();
                dgvPersonelListesi.Columns[0].HeaderText = "TCKN";
                dgvPersonelListesi.Columns[1].HeaderText = "AD";
                dgvPersonelListesi.Columns[2].HeaderText = "SOYAD";
                dgvPersonelListesi.Columns[3].HeaderText = "ADRES";
                dgvPersonelListesi.Columns[4].HeaderText = "TELEFON";
                dgvPersonelListesi.Columns[5].HeaderText = "BÖLÜM";
                dgvPersonelListesi.Columns[6].HeaderText = "AKTİFLİK";

            }

        }

        void inputlariTemizle()
        {
            txtAdi.Text = txtSoyadi.Text = txtAdres.Text = cmbBolum.Text = mtxtTelefon.Text = mtxtTcNo.Text = "";
            rdbAktif.Checked = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "" && txtSoyadi.Text != "" && mtxtTelefon.Text != "(   )    -  -" && mtxtTcNo.Text != "" && cmbBolum.Text != "" && txtAdres.Text != "")
            {//inputların boş kontrolü
                if (sqlConnection.State == ConnectionState.Closed)
            {
                int perBolumID = 0;
                switch (cmbBolum.Text)
                {
                    case "Yönetici":
                        perBolumID = 5;
                        break;
                    case "Satınalma":
                        perBolumID = 4;
                        break;
                    case "Muhasebe":
                        perBolumID = 3;
                        break;
                    case "Personel":
                        perBolumID = 2;
                        break;
                    case "Teknik":
                        perBolumID = 1;
                        break;
                    default:
                        perBolumID = 0;
                        break;
                }
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "INSERT INTO tblPersonel VALUES(@TCKN,@AD,@SOYAD,@ADRES,@TEL,@BOLUM,@AKTIFLIK)";
                komut.Parameters.AddWithValue("@TCKN", mtxtTcNo.Text);//SQL Komutları
                komut.Parameters.AddWithValue("@AD", txtAdi.Text);
                komut.Parameters.AddWithValue("@SOYAD", txtSoyadi.Text);
                komut.Parameters.AddWithValue("@ADRES", txtAdres.Text);
                komut.Parameters.AddWithValue("@TEL", mtxtTelefon.Text);
                komut.Parameters.AddWithValue("@BOLUM", perBolumID);
                komut.Parameters.AddWithValue("@AKTIFLIK", rdbAktif.Checked ? 1 : 0);
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            string TCKN = dgvPersonelListesi.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show(TCKN+" kimlik numaralı personeli Silmek istediğinize eminmisiniz?","DİKKAT",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "DELETE FROM tblPersonel WHERE perTCKN=@TCKN"; // SQL TCKN ye göre Personel Silme Kodları
                    komut.Parameters.AddWithValue("@TCKN", dgvPersonelListesi.CurrentRow.Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
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
            if (txtAdi.Text != "" && txtSoyadi.Text != "" && mtxtTelefon.Text != "(   )    -  -" && mtxtTcNo.Text != "" && cmbBolum.Text != "" && txtAdres.Text != "")
            {
                if (sqlConnection.State == ConnectionState.Closed)
            {
                int perBolumID = 0;
                switch (cmbBolum.Text)
                {
                    case "Yönetici":
                        perBolumID = 5;
                        break;
                    case "Satınalma":
                        perBolumID = 4;
                        break;
                    case "Muhasebe":
                        perBolumID = 3;
                        break;
                    case "Personel":
                        perBolumID = 2;
                        break;
                    case "Teknik":
                        perBolumID = 1;
                        break;
                    default:
                        perBolumID = 0;
                        break;
                }

                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "UPDATE tblPersonel SET perTCKN=@TCKN,perAd=@AD,perSoyad=@SOYAD,perAdres=@ADRES,perTel=@TEL,perBolumID=@BOLUM,perAktifmi=@AKTIFLIK WHERE perTCKN=@secilenTCKN";
                komut.Parameters.AddWithValue("@secilenTCKN", dgvPersonelListesi.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@TCKN", mtxtTcNo.Text); // SQL inputlardaki değerleri alıp önceki kaydı düzenler.
                komut.Parameters.AddWithValue("@AD", txtAdi.Text);
                komut.Parameters.AddWithValue("@SOYAD", txtSoyadi.Text);
                komut.Parameters.AddWithValue("@ADRES", txtAdres.Text);
                komut.Parameters.AddWithValue("@TEL", mtxtTelefon.Text);
                komut.Parameters.AddWithValue("@BOLUM", perBolumID);
                komut.Parameters.AddWithValue("@AKTIFLIK", rdbAktif.Checked ? true : false);
                komut.ExecuteNonQuery();
                komut.Parameters.Clear();
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

        private void dgvPersonelListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxtTcNo.Text = dgvPersonelListesi.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dgvPersonelListesi.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dgvPersonelListesi.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = dgvPersonelListesi.CurrentRow.Cells[3].Value.ToString();
            mtxtTelefon.Text = dgvPersonelListesi.CurrentRow.Cells[4].Value.ToString();
            switch (dgvPersonelListesi.CurrentRow.Cells[5].Value)
            {
                case 5:
                    cmbBolum.Text = "Yönetici";
                    break;
                case 4:
                    cmbBolum.Text = "Satınalma";
                    break;
                case 3:
                    cmbBolum.Text = "Muhasebe";
                    break;
                case 2:
                    cmbBolum.Text = "Personel";
                    break;
                case 1:
                    cmbBolum.Text = "Teknik";
                    break;
                default:
                    cmbBolum.Text = "";
                    break;
            }
            if ((Boolean)dgvPersonelListesi.CurrentRow.Cells[6].Value) { rdbAktif.Checked = true; } else { rdbPasif.Checked = true; }
        }

        private void txtAdi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 20)
                    e.Cancel = true;
        }

        private void txtSoyadi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 20)
                    e.Cancel = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTCKNbul_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTCKNbul.Text!="")
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "SELECT * FROM tblPersonel WHERE perTCKN LIKE '"+ txtTCKNbul.Text +"%' ORDER BY perTCKN";
                    komut.ExecuteNonQuery();// TCKN ye göre LIKE ile içeriğinde geçen değerleri buldur.
                    komut.Dispose();
                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tblPersonel");
                    dgvPersonelListesi.DataSource = ds.Tables["tblPersonel"];
                    sqlConnection.Close();
                    dgvPersonelListesi.Columns[0].HeaderText = "TCKN";
                    dgvPersonelListesi.Columns[1].HeaderText = "AD";
                    dgvPersonelListesi.Columns[2].HeaderText = "SOYAD";
                    dgvPersonelListesi.Columns[3].HeaderText = "ADRES";
                    dgvPersonelListesi.Columns[4].HeaderText = "TELEFON";
                    dgvPersonelListesi.Columns[5].HeaderText = "BÖLÜM";
                    dgvPersonelListesi.Columns[6].HeaderText = "AKTİFLİK";

                }

            }
            else
            {
                tabloGuncelle();
            }

        }

        private void txtTCKNbul_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null)
                if (e.NewValue.ToString().Length > 11) // 11den fazla değer girişini engelle
                    e.Cancel = true;
        }

        private void txtTCKNbul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // yalnızca rakam girişi
            }
        }
    }
}
