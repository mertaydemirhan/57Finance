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
using _57Finance.Model;
using _57Finance.Diger.Hizmet;

namespace _57Finance
{
    public partial class AlisFaturasi : Form
    {
        public string ClientID;
        Setters Setters = new Setters();
        Invoice invoice = new Invoice();
        InvoiceTransactionINFO trnInfo;

        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        SqlCommand komut;
        DataSet ds;

        public int FatID = 0;
        public AlisFaturasi()
        {
            InitializeComponent();
        }
        public AlisFaturasi(Invoice Inv)
        {
            InitializeComponent();
            invoice = Inv;
        }

        private void AlisFaturasi_Load(object sender, EventArgs e)
        {
            FatID=Convert.ToInt32(Setters.GetDocNumber("AlisFaturasi", "FatID"));
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
            {
                lblClientCode.Visible = true;
                grpHareket.Enabled = true;
                GridHrCek();
            }
               
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

        private void GridHrCek()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = "";
            if (invoice ==null)
                query = $"SELECT ID,InvoiceID,ServiceCode,ServiceName,Qty,Price,Forex,ForexRateBuy,ForexRateSell,FPrice,PriceTotal FROM dbo.InvoiceTransactions WHERE 1=1 ";
            else 
                query = $"SELECT ID,InvoiceID,ServiceCode,ServiceName,Qty,Price,Forex,ForexRateBuy,ForexRateSell,FPrice,PriceTotal FROM dbo.InvoiceTransactions WHERE 1=1 AND InvoiceID={invoice.InvoiceID}";

            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridHr.DataSource = tablo;
            GridHr.Columns[0].Visible = false; //Cari ID
            GridHr.Columns[1].Visible = false; //Fatura ID
            GridHr.Columns[2].HeaderText = "Hizmet Kodu";
            GridHr.Columns[3].HeaderText = "Hizmet Adı";
            GridHr.Columns[4].HeaderText = "Miktarı";
            GridHr.Columns[5].HeaderText = "TL Fiyat";
            GridHr.Columns[6].HeaderText = "Dvz Birimi";
            GridHr.Columns[7].HeaderText = "Alış Kuru";
            GridHr.Columns[8].HeaderText = "Satış Kuru";
            GridHr.Columns[9].HeaderText = "Dvz. Tutarı";
            GridHr.Columns[10].HeaderText = "Toplam Fiyat";
        }


        private void btnHrkEkle_Click(object sender, EventArgs e)
        {
            // Hareket ekleme  işlemelri buraya gelecek
            HizmetSec HzSec = new HizmetSec(1);
            HzSec.Show();

            

        }

        private void btnHrkSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridHr.SelectedRows)
            {
                GridHr.Rows.Remove(row);
            }
        }

        private void grpHareket_EnabledChanged(object sender, EventArgs e)
        {
            if (grpHareket.Enabled)
            {

            }
        }

        private void GridHr_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double totalpriceTL = 0, totalPriceDvz = 0;
            for (int index = e.RowIndex; index <= e.RowIndex + e.RowCount - 1; index++)
            {
                DataGridViewRow row = GridHr.Rows[index];
                if (row.Cells.Count >=11)
                {                    
                    totalPriceDvz = totalPriceDvz + Convert.ToDouble(row.Cells[9].Value);                    
                    totalpriceTL = totalpriceTL + Convert.ToDouble(row.Cells[10].Value);
                }
                // Do something with the added row here
                // Raise a custom RowAdded event if you want that passes individual rows.
            }
            lblToplamTL.Text = Convert.ToString(Math.Round(totalpriceTL, 2));
            lblToplamDvz.Text = Convert.ToString(Math.Round(totalPriceDvz, 2));
        }

        private void CalculateTotalPrice()
        {

        }
    }
}
