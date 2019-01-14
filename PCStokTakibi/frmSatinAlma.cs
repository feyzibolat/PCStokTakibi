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
    public partial class frmRapor : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmRapor()
        {
            InitializeComponent();
        }

        void cmbTedarikci_Yenile(string yenile)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "SELECT tedarikciAdi FROM tblTedarikci"; // Tüm Tedarikçi Tablosunu çek
                komut.ExecuteNonQuery();
                komut.Dispose();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblTedarikci");
                if (yenile=="ekle")
                {
                    cmbTedarikListesi.DataSource = ds.Tables["tblTedarikci"];
                    cmbTedarikListesi.ValueMember = "tedarikciAdi";
                }
                else if (yenile == "duzenle")
                {
                    cmbTdrkDuzenle.DataSource = ds.Tables["tblTedarikci"];
                    cmbTdrkDuzenle.ValueMember = "tedarikciAdi";
                }
                sqlConnection.Close();
            }
        }

        private void inputlariTemizle()
        {
            // Tüm inputları Temizle
            txtAlisFiyati.Text = dateAlisTarihi.Text = txtParcaAdedi.Text = cmbTedarikListesi.Text = "";
            txtDuzenleFiyat.Text = dateDuzenleTarih.Text = txtDuzenleAdedi.Text = cmbTdrkDuzenle.Text = "";
            txtParcaBarkod.Text = txtParcaAdi.Text = txtParcaAciklama.Text = cmbAitOlduguPC.Text = cmbParcaKategori.Text = "";


        }

        private void chbKategorideAra_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKategorideAra.Checked)
            {
                cmbKategorideAra.Enabled = true;
            }
            else
            {
                cmbKategorideAra.Enabled = false;
                cmbKategorideAra.Text = "Seçin";
                tabloGuncelle();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            if(txtAlisFiyati.Text!="" && cmbTedarikListesi.Text!="")
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {// sql baglantısı kapalıysa aç
                    sqlConnection.Open();
                    SqlCommand parcaSayisiKontrolKomut = new SqlCommand();
                    parcaSayisiKontrolKomut.Connection = sqlConnection;
                    parcaSayisiKontrolKomut.CommandText = "SELECT * FROM tblParca";
                    parcaSayisiKontrolKomut.ExecuteNonQuery();//tüm parçaları getir
                    parcaSayisiKontrolKomut.Dispose();
                    SqlDataAdapter adapterKontrol = new SqlDataAdapter(parcaSayisiKontrolKomut);
                    DataSet parcaSayisiDS = new DataSet();
                    adapterKontrol.Fill(parcaSayisiDS, "parcaSayisi");
                    int eskiKayitSayisi = parcaSayisiDS.Tables["parcaSayisi"].Rows.Count;

                    frmParcaEkle parcaEkleFormu = new frmParcaEkle();
                    parcaEkleFormu.StartPosition = FormStartPosition.CenterScreen;
                    parcaEkleFormu.ShowDialog();


                    SqlCommand yeniParcaSayisiKontrolKomut = new SqlCommand();
                    yeniParcaSayisiKontrolKomut.Connection = sqlConnection;
                    yeniParcaSayisiKontrolKomut.CommandText = "SELECT * FROM tblParca ORDER BY parcaID DESC";
                    yeniParcaSayisiKontrolKomut.ExecuteNonQuery();// parçaları ID ye göre tersten sırala
                    yeniParcaSayisiKontrolKomut.Dispose();
                    SqlDataAdapter yeniAdapterKontrol = new SqlDataAdapter(yeniParcaSayisiKontrolKomut);
                    DataSet yeniParcaSayisiDS = new DataSet();
                    yeniAdapterKontrol.Fill(yeniParcaSayisiDS, "yparcaSayisi");
                    int yeniKayitSayisi = yeniParcaSayisiDS.Tables["yparcaSayisi"].Rows.Count;


                    if (eskiKayitSayisi + 1 == yeniKayitSayisi)
                    {

                        SqlCommand komutStok = new SqlCommand();
                        komutStok.Connection = sqlConnection;// SQL Insert İşlemleri
                        komutStok.CommandText = "INSERT INTO tblStok VALUES(@eklenenSonParcaID,(SELECT aitOlduguPCID FROM tblParca WHERE parcaID=@eklenenSonParcaID),@aktiflik,@parcaAdedi)";
                        komutStok.Parameters.AddWithValue("@tedarikciAdi", cmbTedarikListesi.Text);
                        komutStok.Parameters.AddWithValue("@eklenenSonParcaID", yeniParcaSayisiDS.Tables["yparcaSayisi"].Rows[0]["parcaID"].ToString());
                        komutStok.Parameters.AddWithValue("@aktiflik", 1);
                        komutStok.Parameters.AddWithValue("@parcaAdedi", txtParcaAdedi.Text);
                        komutStok.ExecuteNonQuery();
                        komutStok.Dispose();

                        SqlCommand komutSatinAlma = new SqlCommand();
                        komutSatinAlma.Connection = sqlConnection;
                        komutSatinAlma.CommandText = "INSERT INTO tblSatinAlma VALUES((SELECT tedarikciID FROM tblTedarikci WHERE tedarikciAdi=@tedarikciAd),(SELECT stokID FROM tblStok WHERE parcaID=@eklenenSonParcaID),@alisTarihi,@alisFiyati)";
                        komutSatinAlma.Parameters.AddWithValue("@tedarikciAd", cmbTedarikListesi.Text);
                        komutSatinAlma.Parameters.AddWithValue("@eklenenSonParcaID", yeniParcaSayisiDS.Tables["yparcaSayisi"].Rows[0]["parcaID"].ToString());

                        string alisTarihi = dateAlisTarihi.Text;
                        string yil, ay, gun = "";
                        if (alisTarihi.Length == 9)//alisTarihi 9 uzunluktaysa
                        {
                            yil = alisTarihi.Substring(5, 4);
                            ay = alisTarihi.Substring(2, 2);
                            gun = alisTarihi.Substring(0, 1);
                        }
                        else
                        {
                            yil = alisTarihi.Substring(6, 4);
                            ay = alisTarihi.Substring(3, 2);
                            gun = alisTarihi.Substring(0, 2);

                        }
                        string editedTarih = yil + '-' + ay + '-' + gun;
                        komutSatinAlma.Parameters.AddWithValue("@alisTarihi", editedTarih);
                        komutSatinAlma.Parameters.AddWithValue("@alisFiyati", txtAlisFiyati.Text);
                        komutSatinAlma.ExecuteNonQuery(); // komutu çalıştır
                        komutSatinAlma.Dispose();

                    }
                    else
                    {
                        if (MessageBox.Show("Yeni ekleme işleminden vazgeçmek istediğinize eminmisiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            inputlariTemizle();

                        }
                    }

                    sqlConnection.Close(); //Bağlantıyı Kapat
                    tabloGuncelle(); // Tabloyu güncelle
                }
            }
            else
            {
                MessageBox.Show("Lütfen Değerleri Kontrol Ediniz!","UYARI");
            }
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {

            cmbAitOlduguPC_Yenile();
            dgvParcaListesi.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvParcaListesi.RowHeadersVisible = false;
            dgvParcaListesi.ReadOnly = true;
            dgvParcaListesi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvParcaListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParcaListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvParcaListesi.MultiSelect = false;
            dgvParcaListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcaListesi.AllowUserToAddRows = false;
            tabloGuncelle();
            dgvParcaListesi.ClearSelection();
        }

        void tabloGuncelle()
        { // dgvParcaListesi ' ne basılacak kayıtlar
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;

                        string sorgu = "SELECT SA.satinAlmaID,CONVERT(varchar, SA.alisTarihi, 104),SA.alisFiyati,ST.stokID,ST.parcaAdedi,ST.urunAktifmi,T.tedarikciAdi,T.tedarikciAdres,T.tedarikciTel,B.pcAd,B.pcAciklama,P.parcaBarkod,P.parcaAd,P.parcaAciklama,KT.kategoriAdi,P.parcaID " +
                                        "FROM tblSatinAlma SA "+
                                        "INNER JOIN tblTedarikci T ON T.tedarikciID = SA.tedarikciID "+
                                        "INNER JOIN tblStok ST ON ST.stokID = SA.stokID "+
                                        "INNER JOIN tblBilgisayar B ON B.pcID = ST.pcID "+
                                        "INNER JOIN tblParca P ON P.parcaID = ST.parcaID " +
                                        "INNER JOIN tblKategori KT ON KT.kategoriID = P.parcaKategoriID " +
                                        "WHERE P.aitOlduguPCID = B.pcID AND P.parcaBarkod LIKE '" + txtBarkodAra.Text.ToString() + "%' AND ST.urunAktifmi=1";

                if (chbKategorideAra.Checked)
                {
                    komut.CommandText = sorgu + " AND P.parcaKategoriID=" + (cmbKategorideAra.SelectedIndex + 1).ToString(); // eğer kategoride arama seçiliyse
                }
                else
                {
                    komut.CommandText = sorgu; // eğer kategoride arama seçili değilse
                }

                komut.ExecuteNonQuery();
                komut.Dispose();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblParca");
                dgvParcaListesi.DataSource = ds.Tables["tblParca"]; // dgvParcaListesi e bas
                sqlConnection.Close();
                dgvParcaListesi.Columns[0].HeaderText = "Satın Alma ID";
                dgvParcaListesi.Columns[0].Width = 40;

                dgvParcaListesi.Columns[1].HeaderText = "Satın Alma Tarihi";
                dgvParcaListesi.Columns[1].Width = 65;

                dgvParcaListesi.Columns[2].HeaderText = "Alış Fiyatı";
                dgvParcaListesi.Columns[2].Width = 80;

                dgvParcaListesi.Columns[3].HeaderText = "Stok ID";
                dgvParcaListesi.Columns[3].Width = 40;

                dgvParcaListesi.Columns[4].HeaderText = "Adet";
                dgvParcaListesi.Columns[4].Width = 40;

                dgvParcaListesi.Columns[5].HeaderText = "Aktiflik";
                dgvParcaListesi.Columns[5].Width = 40;

                dgvParcaListesi.Columns[6].HeaderText = "Tedarikçi Adı";
                dgvParcaListesi.Columns[6].Width = 80;

                dgvParcaListesi.Columns[7].HeaderText = "Tedarikçi Adresi";
                dgvParcaListesi.Columns[7].Width = 80;

                dgvParcaListesi.Columns[8].HeaderText = "Tedarikçi Tel";
                dgvParcaListesi.Columns[9].HeaderText = "PC Adı";
                dgvParcaListesi.Columns[10].HeaderText = "PC Açıklama";
                dgvParcaListesi.Columns[11].HeaderText = "Parça Barkod";
                dgvParcaListesi.Columns[12].HeaderText = "Parça Adı";
                dgvParcaListesi.Columns[13].HeaderText = "Parça Açıklaması";
                dgvParcaListesi.Columns[14].HeaderText = "Kategori";
                dgvParcaListesi.Columns[15].HeaderText = "Parça ID";
                dgvParcaListesi.Columns[15].Width = 30;
                // Header ve Width ayarları
            }

        }

        private void txtBarkodAra_EditValueChanged(object sender, EventArgs e)
        {
            tabloGuncelle();
        }

        private void cmbKategorideAra_EditValueChanged(object sender, EventArgs e)
        {
            tabloGuncelle();
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            txtDuzenleAdedi.Text = txtDuzenleFiyat.Text = txtDuzenleAdedi.Text = cmbTdrkDuzenle.Text = dateDuzenleTarih.Text = "";
            gbStokDuzenle.Enabled = false;
            frmTedarikciEkle yeniTedarikciEkleFormu = new frmTedarikciEkle();
            yeniTedarikciEkleFormu.StartPosition = FormStartPosition.CenterScreen;
            yeniTedarikciEkleFormu.ShowDialog();

            cmbTedarikci_Yenile("ekle");
        }

        private void dgvParcaListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dgvParcaListesi.CurrentRow!=null)
            { // inputlara değer bas
                gbStokDuzenle.Enabled = true;
                cmbTedarikci_Yenile("duzenle");
                cmbTdrkDuzenle.Text = dgvParcaListesi.CurrentRow.Cells[6].Value.ToString();
                dateDuzenleTarih.Text = dgvParcaListesi.CurrentRow.Cells[1].Value.ToString();
                txtDuzenleFiyat.Text = dgvParcaListesi.CurrentRow.Cells[2].Value.ToString();
                txtDuzenleAdedi.Text = dgvParcaListesi.CurrentRow.Cells[4].Value.ToString();


                txtParcaBarkod.Text = dgvParcaListesi.CurrentRow.Cells[11].Value.ToString();
                txtParcaAdi.Text = dgvParcaListesi.CurrentRow.Cells[12].Value.ToString();
                txtParcaAciklama.Text = dgvParcaListesi.CurrentRow.Cells[13].Value.ToString();
                cmbAitOlduguPC.Text = dgvParcaListesi.CurrentRow.Cells[9].Value.ToString();
                cmbParcaKategori.Text = dgvParcaListesi.CurrentRow.Cells[14].Value.ToString();
            }
            



        }

        private void btnParcaDuzenle_Click(object sender, EventArgs e)
        {
            if (cmbTdrkDuzenle.Text != "" && dateDuzenleTarih.Text != "" && txtDuzenleFiyat.Text != "" && txtDuzenleAdedi.Text != "" && txtParcaBarkod.Text != "" && txtParcaAdi.Text != "" && cmbParcaKategori.Text != "" && cmbAitOlduguPC.Text != "" && txtParcaAciklama.Text != "")
            {
                // input kontrolü
            
                if (sqlConnection.State == ConnectionState.Closed) // Bağlantı yoksa bağlantı aç.
                {
                    sqlConnection.Open();

                    int parcaKategoriID = 0;
                    switch (cmbParcaKategori.Text)
                    {
                        case "ANAKART":
                            parcaKategoriID = 1;
                            break;
                        case "CPU":
                            parcaKategoriID = 2;
                            break;
                        case "GPU":
                            parcaKategoriID = 3;
                            break;
                        case "HDD/SSD":
                            parcaKategoriID = 4;
                            break;
                        case "RAM":
                            parcaKategoriID = 5;
                            break;
                        case "SES KARTI":
                            parcaKategoriID = 6;
                            break;
                        case "KASA":
                            parcaKategoriID = 7;
                            break;
                        case "MONITOR":
                            parcaKategoriID = 8;
                            break;
                        case "KLAVYE":
                            parcaKategoriID = 9;
                            break;
                        case "FARE":
                            parcaKategoriID = 10;
                            break;
                        case "OPTIK SURUCU":
                            parcaKategoriID = 11;
                            break;
                        case "YAZICI":
                            parcaKategoriID = 12;
                            break;

                    }


                
                    SqlCommand komutParca = new SqlCommand();
                    komutParca.Connection = sqlConnection; // // SQL Parça Güncelle
                    komutParca.CommandText = "UPDATE tblParca SET aitOlduguPCID=(SELECT pcID FROM tblBilgisayar WHERE pcAd=@pcAd),parcaKategoriID=@parcaKategoriID,parcaBarkod=@parcaBarkod,parcaAd=@parcaAdi,parcaAciklama=@parcaAciklama WHERE parcaID=@parcaID";
                    komutParca.Parameters.AddWithValue("@parcaID", dgvParcaListesi.CurrentRow.Cells[15].Value.ToString());
                    komutParca.Parameters.AddWithValue("@parcaAd", dgvParcaListesi.CurrentRow.Cells[12].Value.ToString());
                    komutParca.Parameters.AddWithValue("@parcaBarkod", txtParcaBarkod.Text);
                    komutParca.Parameters.AddWithValue("@parcaAdi", txtParcaAdi.Text);
                    komutParca.Parameters.AddWithValue("@parcaAciklama", txtParcaAciklama.Text);
                    komutParca.Parameters.AddWithValue("@pcAd", cmbAitOlduguPC.Text);
                    komutParca.Parameters.AddWithValue("@parcaKategoriID", parcaKategoriID);
                    komutParca.ExecuteNonQuery();
                    komutParca.Parameters.Clear();
                    komutParca.Dispose();

                    SqlCommand komutStok = new SqlCommand();
                    komutStok.Connection = sqlConnection; // // SQL STOK Güncelle
                    komutStok.CommandText = "UPDATE tblStok SET pcID=(SELECT pcID FROM tblBilgisayar WHERE pcAd=@pcAd),urunAktifmi=@aktifMi,parcaAdedi=@parcaAdedi WHERE stokID=@secilenStokID";
                    komutStok.Parameters.AddWithValue("@pcAd", cmbAitOlduguPC.Text);
                    komutStok.Parameters.AddWithValue("@secilenStokID", dgvParcaListesi.CurrentRow.Cells[3].Value.ToString());
                    komutStok.Parameters.AddWithValue("@aktifMi", 1);
                    komutStok.Parameters.AddWithValue("@parcaAdedi", txtDuzenleAdedi.Text);
                    komutStok.ExecuteNonQuery();
                    komutStok.Parameters.Clear();
                    komutStok.Dispose();

                    SqlCommand komutSatinAlma = new SqlCommand();
                    komutSatinAlma.Connection = sqlConnection; // SQL SatinAlma Güncelle
                    komutSatinAlma.CommandText = "UPDATE tblSatinAlma SET tedarikciID=(SELECT tedarikciID FROM tblTedarikci WHERE tedarikciAdi=@yeniTed),alisTarihi=@yeniTarih,alisFiyati=@yeniFiyat WHERE satinAlmaID=@secilenID";
                    komutSatinAlma.Parameters.AddWithValue("@secilenID", dgvParcaListesi.CurrentRow.Cells[0].Value.ToString());
                    string alisTarihi = dateDuzenleTarih.Text;
                    string yil, ay, gun = "";
                    if (alisTarihi.Length == 9)
                    {
                        yil = alisTarihi.Substring(5, 4);
                        ay = alisTarihi.Substring(2, 2);
                        gun = alisTarihi.Substring(0, 1);
                    }
                    else
                    {
                        yil = alisTarihi.Substring(6, 4);
                        ay = alisTarihi.Substring(3, 2);
                        gun = alisTarihi.Substring(0, 2);

                    }
                    string editedTarih = yil + '-' + ay + '-' + gun;
                    komutSatinAlma.Parameters.AddWithValue("@yeniTarih", editedTarih);
                    komutSatinAlma.Parameters.AddWithValue("@yeniFiyat", int.Parse(txtDuzenleFiyat.Text));
                    komutSatinAlma.Parameters.AddWithValue("@yeniTed", cmbTdrkDuzenle.Text);
                    komutSatinAlma.ExecuteNonQuery();
                    komutSatinAlma.Parameters.Clear();
                    komutSatinAlma.Dispose();
                

                    sqlConnection.Close();
                    tabloGuncelle();
                    inputlariTemizle();

                    gbStokDuzenle.Enabled = false;
                    dgvParcaListesi.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!");
            }
        }

        private void btnPCEkle_Click(object sender, EventArgs e)
        {// yeni yeniPCEkleFormu aç
            frmPCEkle yeniPCEkleFormu = new frmPCEkle();
            yeniPCEkleFormu.StartPosition = FormStartPosition.CenterScreen;
            yeniPCEkleFormu.ShowDialog();

            cmbAitOlduguPC_Yenile();
        }

        void cmbAitOlduguPC_Yenile()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "SELECT pcAd FROM tblBilgisayar";
                komut.ExecuteNonQuery();
                komut.Dispose();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblBilgisayar");
                cmbAitOlduguPC.DataSource = ds.Tables["tblBilgisayar"];
                cmbAitOlduguPC.ValueMember = "pcAd";
                sqlConnection.Close();
            }
        }

        private void btnAtikGonder_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();

                SqlCommand komutParca = new SqlCommand();
                komutParca.Connection = sqlConnection;
                komutParca.CommandText = "UPDATE tblParca SET aitolduguPCID=0 WHERE parcaID=(SELECT parcaID FROM tblParca WHERE parcaAd=@parcaAd)"; //// SQL Parça Güncelle
                komutParca.Parameters.AddWithValue("@parcaAd", dgvParcaListesi.CurrentRow.Cells[12].Value.ToString());
                komutParca.ExecuteNonQuery();
                komutParca.Parameters.Clear();
                komutParca.Dispose();

                SqlCommand komutStok = new SqlCommand();
                komutStok.Connection = sqlConnection;
                komutStok.CommandText = "UPDATE tblStok SET pcID=0,urunAktifmi=0 WHERE stokID=@secilenStokID"; // SQL STOK Güncelle
                komutStok.Parameters.AddWithValue("@secilenStokID", dgvParcaListesi.CurrentRow.Cells[3].Value.ToString());
                komutStok.ExecuteNonQuery();
                komutStok.Parameters.Clear();
                komutStok.Dispose();

                sqlConnection.Close();
                tabloGuncelle();
                inputlariTemizle();
            }
        }

        private void cmbTedarikListesi_DropDown(object sender, EventArgs e)
        {
            cmbTedarikci_Yenile("ekle"); // combobaxi yenile

        }

        private void cmbTedarikListesi_DropDownClosed(object sender, EventArgs e)
        {

            dateAlisTarihi.Enabled = true; // alistarihi aktif et
            dateAlisTarihi.Focus();

        }

        private void dateAlisTarihi_EditValueChanged(object sender, EventArgs e)
        {
            if (dateAlisTarihi.Text != "")
            {
                txtAlisFiyati.Enabled = true;

            }
        }

        private void txtAlisFiyati_EditValueChanged(object sender, EventArgs e)
        {
            txtParcaAdedi.Enabled = true;
            btnParcaEkle.Enabled = true;

        }

        private void txtParcaAdedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // sadece rakam girişi
            {
                e.Handled = true;
            }
        }

        private void txtParcaAdedi_Leave(object sender, EventArgs e)
        {
            if (txtParcaAdedi.Text != "")
            {
                dateAlisTarihi.Enabled = true;
            }
            else
            {
                txtParcaAdedi.Value = 1;
            }
        }

        private void dateAlisTarihi_Enter(object sender, EventArgs e)
        {
            dateAlisTarihi.EditValue = DateTime.Now;
            txtAlisFiyati.Enabled = true;
        }
    }
}
