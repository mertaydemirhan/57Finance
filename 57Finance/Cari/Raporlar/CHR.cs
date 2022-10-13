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

namespace _57Finance
{
    public partial class CHR : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds;
        public CHR()
        {
            InitializeComponent();
        }

        private void CHR_Load(object sender, EventArgs e)
        {
            ToList();
        }

        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = "SELECT CHR.ID,ClientCode,CommercialTitle,TaxNo,CHR.* from ClientTransactions CHR JOIN Clients C ON(CHR.ClientID = C.ID) WHERE C.isActive=1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridCHR.DataSource = tablo;
            GridCHR.Columns[0].Visible = false;
            //GridCHR.Columns[1].HeaderText = "Cari Kodu";
            //GridCHR.Columns[2].HeaderText = "Ticari Ünvanı";
            //GridCHR.Columns[3].HeaderText = "Vergi Numarası";
            //GridCHR.Columns[4].HeaderText = "Kara Listede";
        }

        public void ara(string ara, string yer)
        {
            //MetroFramework.MetroMessageBox.Show(this,yer,"Harika");
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            if (yer.Trim() == "")
            {
                ToList();
            }
            else
            {
                DataTable tablo = new DataTable();
                tablo.Clear();
                ds = new DataSet();
                string query = "SELECT CHR.ID,ClientCode,CommercialTitle,TaxNo,CHR.* from ClientTransactions CHR JOIN Clients C ON(CHR.ClientID = C.ID) WHERE C.isActive=1";
                SqlDataAdapter adapter = new SqlDataAdapter(query + " AND " + ara + " like '%" + yer + "%'", baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridCHR.DataSource = tablo;
                GridCHR.Columns[0].Visible = false;
                //GridCHR.Columns[1].HeaderText = "Cari Kodu";
                //GridCHR.Columns[2].HeaderText = "Ticari Ünvanı";
                //GridCHR.Columns[3].HeaderText = "Vergi Numarası";
                //GridCHR.Columns[4].HeaderText = "Kara Listede";
            }
        }



        private void txtCariKodu_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtCariKodu.Text;
            ara("ClientCode", al);
        }
        private void txtTicariUnvani_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtTicariUnvani.Text;
            ara("CommercialTitle", al);
        }
        private void txtVergiNo_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtVergiNo.Text;
            ara("TaxNo", al);
        }
        private void txtMuhSatis_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtMuhSatis.Text;
            ara("ClientAccSale", al);
        }
    }
}
