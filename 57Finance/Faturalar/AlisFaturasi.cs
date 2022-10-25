using _57Finance.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _57Finance.Diger.Cari;

namespace _57Finance
{
    public partial class AlisFaturasi : Form
    {
        public string ClientID;
        Setters Setters = new Setters();
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        SqlCommand komut;
        DataSet ds;
        public AlisFaturasi()
        {
            InitializeComponent();
        }

        private void AlisFaturasi_Load(object sender, EventArgs e)
        {
            grpHareket.Enabled = false;
            lblClientCode.Visible = false;
            lblCommercialTitle.Visible = false;
            lblTaxNo.Visible = false;
            lblTaxOffice.Visible = false;
        }
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            CariSec CariSec = new CariSec(3);
            CariSec.Show();
        }
        private void lblClientCode_TextChanged(object sender, EventArgs e)
        {
            if (lblClientCode.Text != "0")
                lblClientCode.Visible = true;
        }
        private void lblCommercialTitle_TextChanged(object sender, EventArgs e)
        {
            if (lblCommercialTitle.Text != "0")
                lblCommercialTitle.Visible = true;
        }
        private void lblTaxNo_TextChanged(object sender, EventArgs e)
        {
            if (lblTaxNo.Text != "0")
                lblTaxNo.Visible = true;
        }
        private void lblTaxOffice_TextChanged(object sender, EventArgs e)
        {
            if (lblTaxOffice.Text != "0")
                lblTaxOffice.Visible = true;
        }







        private void btnHrkEkle_Click(object sender, EventArgs e)
        {
            // Hareket ekleme  işlemelri buraya gelecek
        }

        private void btnHrkSil_Click(object sender, EventArgs e)
        {
            //Hareket Silme işlemleri buraya gelecek...
        }
    }
}
