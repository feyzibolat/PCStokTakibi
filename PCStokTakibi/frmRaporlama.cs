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
    public partial class frmRaporlama : Form
    {
        SqlConnection sqlConnection = new SqlConnection(frmLogin.dbString);

        public frmRaporlama()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
