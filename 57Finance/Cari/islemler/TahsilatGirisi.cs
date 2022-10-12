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

    public partial class TahsilatGirisi : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds;
        double USDtoTL= 0,EURtoTL= 0,GBPtoTL = 0,AZNtoTL = 0;
        public TahsilatGirisi()
        {
            InitializeComponent();
        }
        private void GetForexRates()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo1 = new DataTable();
            tablo1.Clear();
            ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter($"select * from DovizKurlari where CONVERT(date,Tarih,103)=CONVERT(date,GETDATE(),103)", baglanti);
            adapter.Fill(tablo1);
            ds.Merge(tablo1);
            DataRow[] filteredRows = tablo1.Select("Isim like '%ABD DOLARI%'");
            USDtoTL = Convert.ToDouble(filteredRows[0].ItemArray[5].ToString());
            filteredRows = null;
            filteredRows = tablo1.Select("Isim like '%EURO%'");
            EURtoTL = Convert.ToDouble(filteredRows[0].ItemArray[5].ToString());
            filteredRows = null;
            filteredRows = tablo1.Select("Isim like '%INGILIZ STERLINI%'");
            GBPtoTL = Convert.ToDouble(filteredRows[0].ItemArray[5].ToString());
            filteredRows = null;
            filteredRows = tablo1.Select("Isim like '%AZERBAYCAN YENI MANATI%'");
            AZNtoTL = Convert.ToDouble(filteredRows[0].ItemArray[5].ToString());

        }


        private void btnCariSec_Click(object sender, EventArgs e)
        {
            CariSec CariSec = new CariSec();
            CariSec.Show();
        }

        private void TahsilatGirisi_Load(object sender, EventArgs e)
        {
            grpIslem.Enabled = false;
            GetForexRates();
        }

        private void lblCariKod_TextChanged(object sender, EventArgs e)
        {
            if(lblCariKod.Text !="")
            {
                grpIslem.Enabled = true;
                rdTL.Checked = true;
            }
        }

        private void rdTL_CheckedChanged(object sender, EventArgs e)
        {
            grpTL.Enabled = true;
            grpDvz.Enabled = false;
            cmbDvzTuru.SelectedIndex = -1;
            txtDvzTutar.Text = "";

        }

        private void txtTLTutar_TextChanged(object sender, EventArgs e)
        {
            if(txtTLTutar.Text != "")
            {
                double tutar = Convert.ToDouble(txtTLTutar.Text);
                TLtoUSD.Text = "$ "+Convert.ToString(Math.Round(tutar / USDtoTL,4));
                TLtoEUR.Text = Convert.ToString(Math.Round(tutar / EURtoTL,4)) + " €";
                TLtoGBP.Text = Convert.ToString(Math.Round(tutar / GBPtoTL,4)) + " £";
                TLtoAZN.Text = Convert.ToString(Math.Round(tutar / AZNtoTL,4)) + " AZN";
                
            }
        }

        private void rdDoviz_CheckedChanged(object sender, EventArgs e)
        {
            grpTL.Enabled = false;
            grpDvz.Enabled = true;
            txtTLTutar.Text = "";
        }

        private void cmbDvzTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTLTutar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
