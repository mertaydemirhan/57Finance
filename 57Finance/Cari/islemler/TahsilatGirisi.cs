using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _57Finance.Diger.Cari;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        double USDtoTL= 0.0000,EURtoTL= 0.0000,GBPtoTL = 0.0000,AZNtoTL = 0.0000;
        double EURUSDT = 0.0000, USDTEUR=0.0000, GBPUSDT=0.0000,USDTGBP=0.0000,GBPEUR=0.0000;
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


        private void downloadForex()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://api.binance.com/api/v1/ticker/allPrices");                
                dynamic Forexes = JsonConvert.DeserializeObject(json);
                var list = Forexes.ToObject<List<SelectableEnumItem>>();
                //"EURUSDT");
                //List<dynamic> list = new List<dynamic>();
                foreach (dynamic element in list)
                {
                    switch (element.symbol)
                    {
                        case "EURUSDT":
                            EURUSDT = element.price;
                            USDTEUR = 1 / element.price;
                            break;
                        case "GBPUSDT":
                            GBPUSDT = element.price;
                            USDTGBP = 1 / element.price;
                            break;
                        case "SCRTUSDT":
                            GBPEUR = element.price;
                            break;
                    }
                }

            }
        }

        public class SelectableEnumItem
        {
            public string symbol { get; set; }
            public double price { get; set; }
        }

        private void txtDvzTutar_TextChanged(object sender, EventArgs e)
        {
            if (txtDvzTutar.Text != "")
            {

                double tutar = Convert.ToDouble(txtDvzTutar.Text), convusd,conveur,convgbp,convazn,convtl;
                convusd = Convert.ToDouble(lbldolar.Text.Substring(1));
                conveur = Convert.ToDouble(lblEuro.Text.Substring(0, 4));
                convgbp = Convert.ToDouble(lblgbp.Text.Substring(0, 4));
                convazn = Convert.ToDouble(lblazn.Text.Substring(0, 4));
                convtl = Convert.ToDouble(lblTL.Text.Substring(0, 4));
                lbldolar.Text = "$ " + Convert.ToString(Math.Round(tutar * convusd, 4));
                lblEuro.Text = Convert.ToString(Math.Round(tutar * conveur, 4)) + " €";
                lblgbp.Text = Convert.ToString(Math.Round(tutar * convgbp, 4)) + " £";
                lblazn.Text = Convert.ToString(Math.Round(tutar * convazn, 4)) + " AZN";
                lblTL.Text = Convert.ToString(Math.Round(tutar * convtl, 4)) + " ₺";
            }

        }

        /* standart kod sonrası*/

        private void TahsilatGirisi_Load(object sender, EventArgs e)
        {
            grpIslem.Enabled = false;
            GetForexRates();
            downloadForex();
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
            if(cmbDvzTuru.SelectedItem == "USD")
            {
                lbldolar.Text = "$ 1,0000";
                lblEuro.Text = Convert.ToString(Math.Round(USDTEUR,4)) + " €";
                lblgbp.Text = Convert.ToString(Math.Round(USDTGBP,4)) + " £";
                lblazn.Text = "1,0000 AZN";
                lblTL.Text = Convert.ToString(Math.Round(1 / USDtoTL,4)) + " ₺";
            }
            if(cmbDvzTuru.SelectedItem == "EUR") 
            {
                lbldolar.Text = "$ "+Convert.ToString(Math.Round(EURUSDT));
                lblEuro.Text =  "1,0000 €";
                lblgbp.Text =   "1,0000 £";
                lblazn.Text =  "1,0000 AZN";
                lblTL.Text = Convert.ToString(Math.Round( 1 / EURtoTL)) + " ₺";
            }
            if(cmbDvzTuru.SelectedItem == "GBP")
            {
                lbldolar.Text = "$ " + Convert.ToString(Math.Round(GBPUSDT,4));
                lblEuro.Text = Convert.ToString(Math.Round(GBPEUR,4))+" €";
                lblgbp.Text = "1,0000 £ ";
                lblazn.Text = "1,0000 AZN";
                lblTL.Text = Convert.ToString(Math.Round(1 / GBPtoTL,4)) + " ₺";
            }
            if(cmbDvzTuru.SelectedItem == "AZN")
            {
                lbldolar.Text = "$ 1,0000";
                lblEuro.Text = "1,0000 €";
                lblgbp.Text = "1,0000 £";
                lblazn.Text = "1,0000 AZN";
                lblTL.Text = Convert.ToString(Math.Round(1 / AZNtoTL,4)) + " ₺";
            }
        }

        private void txtTLTutar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
