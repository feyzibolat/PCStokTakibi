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
    public partial class frmLogin : Form
    {
        //Veritabanı Bağlantısı
        public static string dbString = "Data Source=DESKTOP-NA6JOAP\\SQLEXPRESS;Initial Catalog=dbPCStokTakip;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(dbString);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Closed) // eğer baglantı onceden kapalıysa ac
            {
                //
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;
                komut.CommandText = "SELECT * FROM tblKullanici";
                komut.ExecuteNonQuery();
                komut.Dispose();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblKullanici");

                bool girisYapildi = false;
                int kullsayisi = ds.Tables["tblKullanici"].Rows.Count;
                for (int i = 0; i < kullsayisi; i++)
                {
                    if(txtKullaniciAdi.Text == ds.Tables["tblKullanici"].Rows[i]["kullAdi"].ToString() && txtKullaniciSifre.Text == ds.Tables["tblKullanici"].Rows[i]["kullSifre"].ToString())
                    {//kullanıcı adı sifre eşleştirmesi
                        frmYonetim yoneticiFormu = new frmYonetim();
                        this.Hide();
                        yoneticiFormu.kullaniciAdi = txtKullaniciAdi.Text;
                        yoneticiFormu.sifre = txtKullaniciSifre.Text;
                        yoneticiFormu.kullYetkiID = int.Parse(ds.Tables["tblKullanici"].Rows[i]["rolID"].ToString());
                        yoneticiFormu.ShowDialog();
                        this.Show();
                        txtKullaniciAdi.Text = txtKullaniciSifre.Text = "";
                        girisYapildi = true;
                        break;
                    }
                }

                sqlConnection.Close();

                if (!girisYapildi)
                {//eşlesmediyse uyari ver
                    MessageBox.Show("Hatali Giriş Bilgisi!");
                }
            }
            }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close(); // button çıkışı
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus(); // açılınca odaklan
        }
    }
    }

