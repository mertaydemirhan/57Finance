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
using _57Finance.Model;

namespace _57Finance.Diger.Hizmet
{

    public partial class HizmetSec : Form
    {
        InvoiceTransactionINFO TrnInfo= new InvoiceTransactionINFO();
        readonly Setters setters =  new Setters();
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        DataSet ds;
        int typeForm = 0;

        Form AlFaturasi = Application.OpenForms["AlisFaturasi"];
        Form SatFaturasi = Application.OpenForms["SatisFaturasi"];
        public HizmetSec()
        {
            InitializeComponent();
        }
        public HizmetSec(int _type)
        {
            InitializeComponent();
            typeForm = _type;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = "SELECT ID,ServiceCode,ServiceName,Price,VATRate,Forex,FPrice from Services WHERE 1=1 ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridHizmet.DataSource = tablo;
            GridHizmet.Columns[0].Visible = false;
            GridHizmet.Columns[1].HeaderText = "Hizmet Kodu";
            GridHizmet.Columns[2].HeaderText = "Hizmet Adı";
            GridHizmet.Columns[3].HeaderText = "Fiyatı";
            GridHizmet.Columns[4].HeaderText = "KDV Oranı";
            GridHizmet.Columns[5].HeaderText = "Döviz Birimi";
            GridHizmet.Columns[6].HeaderText = "Döviz Fiyatı";


        }

        private void HizmetSec_Load(object sender, EventArgs e)
        {
            ToList();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string al = txtHizmetKodu.Text;
            string al1 = txtHizmetKodu2.Text;
            string Query = $"ServiceCode>='{al}' AND ServiceCode<='{al1}'";
            ara(null, Query);
        }

        private void ara(string ara, string yer)
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
                string query = "SELECT ID,ServiceCode,ServiceName,Price,VATRate,Forex,FPrice from Services WHERE 1=1 ";
                SqlDataAdapter adapter = new SqlDataAdapter();
                if (ara != null)
                    adapter = new SqlDataAdapter(query + " AND " + ara + " like '%" + yer + "%'", baglanti);
                else
                    adapter = new SqlDataAdapter(query + " AND " + yer, baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridHizmet.DataSource = tablo;
                GridHizmet.Columns[0].Visible = false;
                GridHizmet.Columns[1].HeaderText = "Hizmet Kodu";
                GridHizmet.Columns[2].HeaderText = "Hizmet Adı";
                GridHizmet.Columns[3].HeaderText = "Fiyatı";
                GridHizmet.Columns[4].HeaderText = "KDV Oranı";
                GridHizmet.Columns[5].HeaderText = "Döviz Birimi";
                GridHizmet.Columns[6].HeaderText = "Döviz Fiyatı";
            }
        }


        private void HizmetiAc()
        {
            int selectedrowindex = GridHizmet.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = GridHizmet.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);
            if (cellValue != "")
            {
                if (typeForm == 1) // Alış faturası ise eklenecek ürünü gönder....
                {

                    DateTime FtDate = ((AlisFaturasi)AlFaturasi).dtFaturaTarihi.Value;

                    TrnInfo.InvoiceID = ((AlisFaturasi)AlFaturasi).FatID;
                    TrnInfo.ServiceCode = selectedRow.Cells["ServiceCode"].Value.ToString();
                    TrnInfo.ServiceName = selectedRow.Cells["ServiceName"].Value.ToString();
                    TrnInfo.Qty = 1;
                    TrnInfo.Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                    TrnInfo.Forex = selectedRow.Cells["Forex"].Value.ToString().Trim();
                    TrnInfo.FPrice = Convert.ToDecimal(selectedRow.Cells["FPrice"].Value);
                    if(TrnInfo.Forex != "")  // Eğer gelen değerde döviz seçimi yapıldıysa.....
                    {
                        DataRow[] filteredRows = setters.SendForexes(FtDate).Select($"Currency like '%{TrnInfo.Forex}%'");
                        // FilteredRows 0 = Buying Rate, 1 = Selling Rate, 3 = Currency
                        TrnInfo.ForexRateBuy = Convert.ToDecimal(filteredRows[0].ItemArray[0].ToString());
                        TrnInfo.ForexRateSell = Convert.ToDecimal(filteredRows[0].ItemArray[1].ToString());
                        TrnInfo.Price = TrnInfo.ForexRateSell * TrnInfo.FPrice;

                    }

                    TrnInfo.PriceTotal = Convert.ToDecimal(TrnInfo.Qty * TrnInfo.Price);
                    DataTable dataTable = (DataTable)((AlisFaturasi)AlFaturasi).GridHr.DataSource;
                    DataRow drToAdd = dataTable.NewRow();

                    //drToAdd["ID"] = null;
                    drToAdd["InvoiceID"] = TrnInfo.InvoiceID;
                    drToAdd["ServiceCode"] = TrnInfo.ServiceCode;
                    drToAdd["ServiceName"] = TrnInfo.ServiceName;
                    drToAdd["Qty"] = TrnInfo.Qty;
                    drToAdd["Price"] = TrnInfo.Price;
                    drToAdd["Forex"] = TrnInfo.Forex;
                    drToAdd["FPrice"] = TrnInfo.FPrice;
                    drToAdd["ForexRateBuy"] = TrnInfo.ForexRateBuy;
                    drToAdd["ForexRateSell"] = TrnInfo.ForexRateSell;
                    drToAdd["PriceTotal"] = TrnInfo.PriceTotal.ToString("0.##");
                    dataTable.Rows.Add(drToAdd);
                    dataTable.AcceptChanges();

                }
                else if (typeForm == 2) // Satış faturası ise eklenecek ürünü gönder....
                {
                    DateTime FtDate = ((SatisFaturasi)SatFaturasi).dtFaturaTarihi.Value;

                    TrnInfo.InvoiceID = ((SatisFaturasi)SatFaturasi).FatID;
                    TrnInfo.ServiceCode = selectedRow.Cells["ServiceCode"].Value.ToString();
                    TrnInfo.ServiceName = selectedRow.Cells["ServiceName"].Value.ToString();
                    TrnInfo.Qty = 1;
                    TrnInfo.Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                    TrnInfo.Forex = selectedRow.Cells["Forex"].Value.ToString().Trim();
                    TrnInfo.FPrice = Convert.ToDecimal(selectedRow.Cells["FPrice"].Value);
                    if (TrnInfo.Forex != "")  // Eğer gelen değerde döviz seçimi yapıldıysa.....
                    {
                        DataRow[] filteredRows = setters.SendForexes(FtDate).Select($"Currency like '%{TrnInfo.Forex}%'");
                        // FilteredRows 0 = Buying Rate, 1 = Selling Rate, 3 = Currency
                        TrnInfo.ForexRateBuy = Convert.ToDecimal(filteredRows[0].ItemArray[0].ToString());
                        TrnInfo.ForexRateSell = Convert.ToDecimal(filteredRows[0].ItemArray[1].ToString());
                        TrnInfo.Price = TrnInfo.ForexRateSell * TrnInfo.FPrice;

                    }

                    TrnInfo.PriceTotal = Convert.ToDecimal(TrnInfo.Qty * TrnInfo.Price);
                    DataTable dataTable = (DataTable)((SatisFaturasi)SatFaturasi).GridHr.DataSource;
                    DataRow drToAdd = dataTable.NewRow();

                    //drToAdd["ID"] = null;
                    drToAdd["InvoiceID"] = TrnInfo.InvoiceID;
                    drToAdd["ServiceCode"] = TrnInfo.ServiceCode;
                    drToAdd["ServiceName"] = TrnInfo.ServiceName;
                    drToAdd["Qty"] = TrnInfo.Qty;
                    drToAdd["Price"] = TrnInfo.Price;
                    drToAdd["Forex"] = TrnInfo.Forex;
                    drToAdd["FPrice"] = TrnInfo.FPrice;
                    drToAdd["ForexRateBuy"] = TrnInfo.ForexRateBuy;
                    drToAdd["ForexRateSell"] = TrnInfo.ForexRateSell;
                    drToAdd["PriceTotal"] = TrnInfo.PriceTotal.ToString("0.##");
                    dataTable.Rows.Add(drToAdd);
                    dataTable.AcceptChanges();

                }
                else if (typeForm == 3)
                {
                    // Masraf faturasıysa bla bla bla

                }
                this.Close();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Lütfen sayfadan işlem yapılacak cariyi belirleyiniz..", "Lütfen Kayıt seçiniz", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHizmetSec_Click(object sender, EventArgs e)
        {
            HizmetiAc();
        }

        private void GridHizmet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HizmetiAc();
        }
    }
}
