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
    public partial class frmZimmet : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmZimmet()
        {
            InitializeComponent();
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void frmZimmet_Load(object sender, EventArgs e)
        { 

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
