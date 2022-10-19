using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using _57Finance.Diger.Cari;
using _57Finance.Model;
using MetroFramework;
using Newtonsoft.Json;
using IniParser;
using IniParser.Model;

namespace _57Finance
{

    public partial class TahsilatGirisi : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        SqlCommand komut;
        DataSet ds;
        Forexes Forex = new Forexes();
        TransactionINFO transactioninfo;

        public string ClientID;
        public TahsilatGirisi()
        {
            InitializeComponent();
            this.txtBelgeNo.Click += new EventHandler(txtBelgeNo_Click);
            this.txtDvzTutar.Click += new EventHandler(txtDvzTutar_Click);
            this.txtTLTutar.Click += new EventHandler(txtTLTutar_Click);

        }
        public TahsilatGirisi(TransactionINFO transaction)
        {
            InitializeComponent();
            transactioninfo = transaction;
            this.txtBelgeNo.Click += new EventHandler(txtBelgeNo_Click);
            this.txtDvzTutar.Click += new EventHandler(txtDvzTutar_Click);
            this.txtTLTutar.Click += new EventHandler(txtTLTutar_Click);
        }
        private void TahsilatGirisi_Load(object sender, EventArgs e)
        {
            if (transactioninfo == null)
                grpBForex.Visible = false;
            grpIslem.Enabled = false;
            Forex.USDtoTL = 0.0000; Forex.EURtoTL = 0.0000; Forex.GBPtoTL = 0.0000; Forex.AZNtoTL = 0.0000;
            Forex.EURUSDT = 0.0000; Forex.USDTEUR = 0.0000; Forex.GBPUSDT = 0.0000; Forex.USDTGBP = 0.0000; Forex.GBPEUR = 0.0000;
            GetForexRates();
            downloadForex();
            BindDataDepartment();
            if (transactioninfo != null)
            {
                GetValuesFromClient();
            }
        }
        private void CalculateForex()
        {
            if (txtDvzTutar.Text != "")
            {

                double tutar = Convert.ToDouble(txtDvzTutar.Text);
                lbldolar.Text = "$ " + Convert.ToString(Math.Round(tutar * Forex.SelectedUSD, 4));
                lblEuro.Text = Convert.ToString(Math.Round(tutar * Forex.SelectedEUR, 4)) + " €";
                lblgbp.Text = Convert.ToString(Math.Round(tutar * Forex.SelectedGBP, 4)) + " £";
                lblazn.Text = Convert.ToString(Math.Round(tutar * Forex.SelectedAZN, 4)) + " AZN";
                lblTL.Text = Convert.ToString(Math.Round(tutar * Forex.SelectedTL, 4)) + " ₺";
            }
        }

        private void GetValuesFromClient()
        {
            lblTicariUnvani.Text = transactioninfo.ClientCommercialTitle;
            lblCariKod.Text = transactioninfo.ClientCode;
            lblBUSD.Text = "$ " + transactioninfo.ForexUSD.ToString();
            lblBEUR.Text = transactioninfo.ForexEUR.ToString() + " €";
            lblBGBP.Text = transactioninfo.ForexGBP.ToString() + " £";
            lblBAZN.Text = transactioninfo.ForexAZN.ToString() + " AZN";
            lblBTL.Text = transactioninfo.ForexTL.ToString() + " ₺";
            dtIslemTarihi.Value = transactioninfo.Date;
            cmbDocumentType.SelectedIndex = transactioninfo.DocumentType;
            cmbDepartman.SelectedValue = transactioninfo.DepartmentID;
            if (transactioninfo.Forex != "")
            {
                rdDoviz.Checked = true;
            }
            else
                rdTL.Checked = true;
            rchAciklama.Text = transactioninfo.Explanation;
            txtBelgeNo.Text = transactioninfo.DocumentNo.ToString();
            txtTLTutar.Text = transactioninfo.Credit.ToString();
            txtDvzTutar.Text = transactioninfo.FCredit.ToString();
            cmbDvzTuru.SelectedIndex = cmbDvzTuru.Items.IndexOf(transactioninfo.Forex);
            CalculateForex();
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            CariSec CariSec = new CariSec(1);
            CariSec.Show();
        }
        public void BindDataDepartment()
        {

            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            baglanti.Open();
            DataTable table4 = new DataTable();
            sqlAdapter = new SqlDataAdapter("select DepartmentName,ID from Departments Order By DepartmentName ASC", baglanti);
            sqlAdapter.Fill(table4);
            cmbDepartman.DataSource = table4;
            baglanti.Close();

        }
        private void GetForexRates()
        {
            try
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                DataTable tablo1 = new DataTable();
                tablo1.Clear();
                ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter($"select * from DovizKurlari where CONVERT(date,Tarih,103)=CONVERT(date,GETDATE(),103)", baglanti);
                adapter.Fill(tablo1);
                ds.Merge(tablo1);
                DataRow[] filteredRows = tablo1.Select("Isim like '%ABD DOLARI%'");
                Forex.USDtoTL = Convert.ToDouble(filteredRows[0].ItemArray[5].ToString());
                filteredRows = null;
                filteredRows = tablo1.Select("Isim like '%EURO%'");
                Forex.EURtoTL = Convert.ToDouble(filteredRows[0].ItemArray[5].ToString());
                filteredRows = null;
                filteredRows = tablo1.Select("Isim like '%INGILIZ STERLINI%'");
                Forex.GBPtoTL = Convert.ToDouble(filteredRows[0].ItemArray[5].ToString());
                filteredRows = null;
                filteredRows = tablo1.Select("Isim like '%AZERBAYCAN YENI MANATI%'");
                Forex.AZNtoTL = Convert.ToDouble(filteredRows[0].ItemArray[5].ToString());
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bugünün kurları çekilmemiştir. Veya bulunamadı... ", "Kurlar veritabanında bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


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
                            Forex.EURUSDT = element.price;
                            Forex.USDTEUR = 1 / element.price;
                            break;
                        case "GBPUSDT":
                            Forex.GBPUSDT = element.price;
                            Forex.USDTGBP = 1 / element.price;
                            break;
                        case "SCRTUSDT":
                            Forex.GBPEUR = element.price;
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
        private void lblCariKod_TextChanged(object sender, EventArgs e)
        {
            if (lblCariKod.Text != "")
            {
                grpIslem.Enabled = true;
                rdTL.Checked = true;
                if (transactioninfo == null)
                    txtBelgeNo.Text = GetDocNumber("Tahsilat", "THKey");
            }
        }


        private string GetDocNumber(string Group, string Key)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            string useFullScreenStr = data[Group][Key];
            
            //parser.WriteFile("Configuration.ini", data);
            return useFullScreenStr;
        }

        private void WriteDocNumber(string Group, string Key)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            string GetFileNumber = Convert.ToString(Convert.ToDouble(GetDocNumber(Group, Key)) + 1);
            data[Group][Key] =GetFileNumber;
            parser.WriteFile("Configuration.ini", data);
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
            if (txtTLTutar.Text != "")
            {
                double tutar = Convert.ToDouble(txtTLTutar.Text);
                TLtoUSD.Text = "$ " + Convert.ToString(Math.Round(tutar / Forex.USDtoTL, 4));
                TLtoEUR.Text = Convert.ToString(Math.Round(tutar / Forex.EURtoTL, 4)) + " €";
                TLtoGBP.Text = Convert.ToString(Math.Round(tutar / Forex.GBPtoTL, 4)) + " £";
                TLtoAZN.Text = Convert.ToString(Math.Round(tutar / Forex.AZNtoTL, 4)) + " AZN";
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
            if (cmbDvzTuru.SelectedItem.ToString() == "USD")
            {
                lbldolar.Text = "$ 1,0000";
                lblEuro.Text = Convert.ToString(Math.Round(Forex.USDTEUR, 4)) + " €";
                lblgbp.Text = Convert.ToString(Math.Round(Forex.USDTGBP, 4)) + " £";
                lblazn.Text = "1,0000 AZN";
                lblTL.Text = Convert.ToString(Math.Round(Forex.USDtoTL, 4)) + " ₺";
                Forex.SelectedUSD = 1.0000;
                Forex.SelectedEUR = Math.Round(Forex.USDTEUR, 4);
                Forex.SelectedGBP = Math.Round(Forex.USDTGBP, 4);
                Forex.SelectedAZN = 1.0000;
                Forex.SelectedTL = Math.Round(Forex.USDtoTL, 4);
            }
            if (cmbDvzTuru.SelectedItem.ToString() == "EUR")
            {
                lbldolar.Text = "$ " + Convert.ToString(Math.Round(1 / Forex.EURUSDT, 4));
                lblEuro.Text = "1,0000 €";
                lblgbp.Text = "1,0000 £";
                lblazn.Text = "1,0000 AZN";
                lblTL.Text = Convert.ToString(Math.Round(Forex.EURtoTL)) + " ₺";
                Forex.SelectedUSD = Math.Round(Forex.EURUSDT);
                Forex.SelectedEUR = 1.0000;
                Forex.SelectedGBP = 1.0000;
                Forex.SelectedAZN = 1.0000;
                Forex.SelectedTL = Math.Round(Forex.EURtoTL);
            }
            if (cmbDvzTuru.SelectedItem.ToString() == "GBP")
            {
                lbldolar.Text = "$ " + Convert.ToString(Math.Round(Forex.GBPUSDT, 4));
                lblEuro.Text = Convert.ToString(Math.Round(Forex.GBPEUR, 4)) + " €";
                lblgbp.Text = "1,0000 £ ";
                lblazn.Text = "1,0000 AZN";
                lblTL.Text = Convert.ToString(Math.Round(Forex.GBPtoTL, 4)) + " ₺";
                Forex.SelectedUSD = Math.Round(Forex.GBPUSDT, 4);
                Forex.SelectedEUR = Math.Round(Forex.GBPEUR, 4);
                Forex.SelectedGBP = 1.0000;
                Forex.SelectedAZN = 1.0000;
                Forex.SelectedTL = Math.Round(Forex.GBPtoTL, 4);

            }
            if (cmbDvzTuru.SelectedItem.ToString() == "AZN")
            {
                lbldolar.Text = "$ 1,0000";
                lblEuro.Text = "1,0000 €";
                lblgbp.Text = "1,0000 £";
                lblazn.Text = "1,0000 AZN";
                lblTL.Text = Convert.ToString(Math.Round(Forex.AZNtoTL, 4)) + " ₺";
                Forex.SelectedUSD = 1.0000;
                Forex.SelectedEUR = 1.0000;
                Forex.SelectedGBP = 1.0000;
                Forex.SelectedAZN = 1.0000;
                Forex.SelectedTL = Math.Round(Forex.AZNtoTL, 4);
            }
        }
        private void txtDvzTutar_TextChanged(object sender, EventArgs e)
        {
            CalculateForex();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBelgeNo.Text.Trim())) { MetroMessageBox.Show(this, " Belge numarası boş olamaz. Lütfen Belge numarası giriniz.", "Belge numarası boş !", MessageBoxButtons.OK, MessageBoxIcon.Hand); return;  }
            try
            {

                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                double TLField = (txtTLTutar.Text != "") ? Convert.ToDouble(txtTLTutar.Text.Trim()) : 0;
                double FField = (txtDvzTutar.Text != "") ? Convert.ToDouble(txtDvzTutar.Text.Trim()) : 0;
                string FSign = (txtDvzTutar.Text != "") ? cmbDvzTuru.SelectedItem.ToString() : "";
                double FSelectedUSD, FSelectedEUR, FSelectedGBP, FSelectedAZN, FSelectedTL;
                if (rdTL.Checked)
                {
                    FSelectedUSD = Convert.ToDouble(txtTLTutar.Text) / Forex.USDtoTL;
                    FSelectedEUR = Convert.ToDouble(txtTLTutar.Text) / Forex.EURtoTL;
                    FSelectedGBP = Convert.ToDouble(txtTLTutar.Text) / Forex.GBPtoTL;
                    FSelectedAZN = Convert.ToDouble(txtTLTutar.Text) / Forex.AZNtoTL;
                    FSelectedTL = 1.00 * Convert.ToDouble(txtTLTutar.Text);
                }
                else
                {
                    FSelectedUSD = Forex.SelectedUSD * Convert.ToDouble(txtDvzTutar.Text);
                    FSelectedEUR = Forex.SelectedEUR * Convert.ToDouble(txtDvzTutar.Text);
                    FSelectedGBP = Forex.SelectedGBP * Convert.ToDouble(txtDvzTutar.Text);
                    FSelectedAZN = Forex.SelectedAZN * Convert.ToDouble(txtDvzTutar.Text);
                    FSelectedTL = Forex.SelectedTL * Convert.ToDouble(txtDvzTutar.Text);
                }
                if (transactioninfo == null)
                    komut = new SqlCommand($"INSERT INTO ClientTransactions(ClientID,Credit,Date,DocumentNo,DocumentType,Explanation,DepartmentID,PaymentType,FCredit,Forex,ForexUSD,ForexEUR,ForexGBP,ForexAZN,ForexTL) " +
                                                    $"VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p12,@p13,@p14,@p15,@p16)", baglanti);
                if (transactioninfo != null)
                    komut = new SqlCommand($"UPDATE ClientTransactions SET ClientID=@p1,Credit=@p2,Date=@p3,DocumentNo=@p4,DocumentType=@p5,Explanation=@p6,DepartmentID=@p7," +
                                           $"PaymentType=@p8,FCredit=@p9,Forex=@p10,ForexUSD=@p12,ForexEUR=@p13,ForexGBP=@p14,ForexAZN=@p15," +
                                           $"ForexTL=@p16 WHERE ID={transactioninfo.ID}", baglanti);
                komut.Parameters.AddWithValue("@p1", ClientID);
                komut.Parameters.AddWithValue("@p2", TLField);
                komut.Parameters.AddWithValue("@p3", dtIslemTarihi.Value);
                komut.Parameters.AddWithValue("@p4", txtBelgeNo.Text.Trim());
                komut.Parameters.AddWithValue("@p5", 1);  // Tahsilat = 1, Tediye = 2, Alış fat =3, satış fat = 4, Masraf = 5, Alıştan iade = 6, satıştan iade =7
                komut.Parameters.AddWithValue("@p6", rchAciklama.Text.Trim());
                komut.Parameters.AddWithValue("@p7", cmbDepartman.SelectedValue);
                komut.Parameters.AddWithValue("@p8", cmbDocumentType.SelectedIndex);
                komut.Parameters.AddWithValue("@p9", FField);
                komut.Parameters.AddWithValue("@p10", FSign);
                komut.Parameters.AddWithValue("@p12", Math.Round(FSelectedUSD, 4));
                komut.Parameters.AddWithValue("@p13", Math.Round(FSelectedEUR, 4));
                komut.Parameters.AddWithValue("@p14", Math.Round(FSelectedGBP, 4));
                komut.Parameters.AddWithValue("@p15", Math.Round(FSelectedAZN, 4));
                komut.Parameters.AddWithValue("@p16", Math.Round(FSelectedTL, 4));
                komut.ExecuteScalar();
                baglanti.Close();
                WriteDocNumber("Tahsilat", "THKey");
                this.Close();
                if (transactioninfo == null)
                    MetroMessageBox.Show(this, "Belge Numarası : " + txtBelgeNo.Text.Trim() + "\n Kayıt başarıyla eklenmiştir.", "Kaydetme Başarılı ✓", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (transactioninfo != null)
                    MetroMessageBox.Show(this, "Belge Numarası : " + txtBelgeNo.Text.Trim() + "\n Kayıt başarıyla değiştirilmiştir..", " Değiştirme Başarılı ✓", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Bir hata ile karşılaşıldı... Sebebi girilen veriler ile alakalı olabilir...", "Kayıt tamamlanamadı !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (transactioninfo != null)
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                komut = new SqlCommand($"DELETE FROM ClientTransactions Where ID={transactioninfo.ID}", baglanti);
                komut.ExecuteScalar();
                baglanti.Close();
                this.Close();
                MetroMessageBox.Show(this, "Evrak Numarası:" + txtBelgeNo.Text.Trim() + "\n Kayıt başarıyla silindi.", "Başarılı ✓");
            }
            else
                MessageBox.Show("Silmeye çalıştığınız hareket sisteme kayıtlı görünmüyor. \n Hareketin, Cari hareket raporunda olduğundan emin olunuz...", "Veritabanı Sorgusu Boş !", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void txtBelgeNo_Click(object sender, EventArgs e)
        {
            this.txtBelgeNo.Select(0, 0);
        }
        private void txtTLTutar_Click(object sender, EventArgs e)
        {
            this.txtTLTutar.Select(0, 0);
        }
        private void txtDvzTutar_Click(object sender, EventArgs e)
        {
            this.txtDvzTutar.Select(0, 0);
        }

    }
}
