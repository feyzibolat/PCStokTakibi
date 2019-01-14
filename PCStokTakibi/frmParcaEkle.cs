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
    public partial class frmParcaEkle : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmParcaEkle()
        {
            InitializeComponent();
            
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

        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            if (txtParcaAciklama.Text != "" && txtParcaAdi.Text != "" && txtParcaBarkod.Text != "" && cmbAitOlduguPC.Text != "" && cmbParcaKategori.Text != "")
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
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

                    }// switch case ile parcaKategoriID belirle
                    sqlConnection.Open();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = sqlConnection;
                    komut.CommandText = "INSERT INTO tblParca VALUES((SELECT pcID FROM tblBilgisayar WHERE pcAd=@pcAd),@parcaKategoriID,@parcaBarkod,@parcaAdi,@parcaAciklama)";
                    komut.Parameters.AddWithValue("@parcaBarkod", txtParcaBarkod.Text);
                    komut.Parameters.AddWithValue("@parcaAdi", txtParcaAdi.Text);
                    komut.Parameters.AddWithValue("@parcaAciklama", txtParcaAciklama.Text);
                    komut.Parameters.AddWithValue("@pcAd", cmbAitOlduguPC.Text);
                    komut.Parameters.AddWithValue("@parcaKategoriID", parcaKategoriID);
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
                    komut.Dispose();
                    sqlConnection.Close();
                    MessageBox.Show("Ekleme Başarılı!");
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!");
            }
        }

        private void frmParcaEkle_Load(object sender, EventArgs e)
        {
            // yüklenince cmbAitOlduguPC yenile
            cmbAitOlduguPC_Yenile();
        }

        private void btnPCEkle_Click(object sender, EventArgs e)
        {
            //yeni yeniPCEkleFormu ac
            frmPCEkle yeniPCEkleFormu = new frmPCEkle();
            yeniPCEkleFormu.StartPosition = FormStartPosition.CenterScreen; 
            yeniPCEkleFormu.ShowDialog();

            cmbAitOlduguPC_Yenile();
        }
    }
}
