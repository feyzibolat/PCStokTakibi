using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCStokTakibi
{
    public partial class frmAtikDepo : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmAtikDepo()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAtikDepo_Load(object sender, EventArgs e)
        {
            //yüklenince gereken datagrid ayarları
            dgvAtikListesi.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvAtikListesi.RowHeadersVisible = false;
            dgvAtikListesi.ReadOnly = true;
            dgvAtikListesi.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAtikListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAtikListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAtikListesi.MultiSelect = false;
            dgvAtikListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtikListesi.AllowUserToAddRows = false;
            tabloGuncelle();
            dgvAtikListesi.ClearSelection();
        }

        void tabloGuncelle() // her defasında çalışıcak olan tabloguncelle Metodu
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;

                string sorgu = "SELECT P.parcaID,P.parcaBarkod,P.parcaAd,P.parcaAciklama " + 
                    "FROM tblParca P INNER JOIN tblStok ST ON p.parcaID = ST.parcaID "+
                    "WHERE ST.urunAktifmi = 0 AND P.parcaBarkod LIKE '" + txtBarkodAra.Text.ToString() + "%'";

                if (chbKategorideAra.Checked)
                {
                    komut.CommandText = sorgu + " AND P.parcaKategoriID=" + (cmbKategorideAra.SelectedIndex + 1).ToString();
                }
                else
                {
                    komut.CommandText = sorgu;
                }

                komut.ExecuteNonQuery();
                komut.Dispose();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblParca");
                dgvAtikListesi.DataSource = ds.Tables["tblParca"]; //.Columns["pcAd"]
                sqlConnection.Close();

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = sqlConnection;

                string sorgu = "DELETE FROM tblParca WHERE parcaID="+dgvAtikListesi.CurrentRow.Cells[0].Value.ToString(); //parcaID sine göre silme işlemi
                komut.CommandText = sorgu;
                komut.ExecuteNonQuery();
                komut.Dispose();
                sqlConnection.Close();
                tabloGuncelle();

            }
        }

        private void chbKategorideAra_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKategorideAra.Checked) // eğer cb seçiliyse  cmbKategorideAra aktifle
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

        private void txtBarkodAra_EditValueChanged(object sender, EventArgs e)
        {
            tabloGuncelle(); // guncelle:);
        }
    }
}
