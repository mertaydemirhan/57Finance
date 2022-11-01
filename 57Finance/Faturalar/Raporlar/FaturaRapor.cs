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

namespace _57Finance
{
    public partial class FaturaRapor : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        DataSet ds;
        Invoice Invoceinfo = new Invoice();
        //string FreeQuery = "";
        DataTable tablobg = new DataTable();
        public FaturaRapor()
        {
            InitializeComponent();
        }

        private void GetInvoiceType()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(1, "Alış Faturası");
            comboSource.Add(2, "Alıştan İade Faturası");
            comboSource.Add(3, "Satış Faturası");
            comboSource.Add(4, "Satıştan İade Faturası");
            comboSource.Add(5, "Masraf Faturası");

            cmbFaturaTuru.DataSource = new BindingSource(comboSource, null);
            cmbFaturaTuru.DisplayMember = "Value";
            cmbFaturaTuru.ValueMember = "Key";
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
        private void FaturaRapor_Load(object sender, EventArgs e)
        {
            ToList("");
            GetInvoiceType();
            BindDataDepartment();
        }

        private void ToList(string FilledQuery)
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablobeauty = new DataTable();
            tablobg = new DataTable();
            string querybeauty = "", querybg = "";
            tablobg.Clear();
            tablobeauty.Clear();
            ds = new DataSet();

            if (FilledQuery == "")   // Listeleme için gelen FilledQuery boş ise normal listele değil ise filtreyi bas....
            {
                querybeauty = $"SELECT * FROM [{DatabaseName}].dbo.InvoiceReportBeauty WHERE 1=1";
                querybg = $"Select * FROM [{DatabaseName}].dbo.InvoiceReportNormal WHERE 1=1  ";
            }
            else
            {
                querybeauty = $"SELECT * FROM [{DatabaseName}].dbo.InvoiceReportBeauty WHERE 1=1 and {FilledQuery}";
                querybg = $"Select * FROM [{DatabaseName}].dbo.InvoiceReportNormal WHERE 1=1 and {FilledQuery} ";
            }

            SqlDataAdapter adapterbeauty = new SqlDataAdapter(querybeauty, baglanti);
            SqlDataAdapter adapterbg = new SqlDataAdapter(querybg, baglanti);
            adapterbg.Fill(tablobg);
            adapterbeauty.Fill(tablobeauty);
            ds.Merge(tablobeauty);
            GridFaturalar.DataSource = tablobeauty;      /// Ekrana verilen Grid dışında arka tarafta bir grid daha döndürülüyor.. Veri çekebilmek adına

            GridFaturalar.Columns[0].Visible = false; //Fatura ID
            GridFaturalar.Columns[1].HeaderText = "Cari Kodu";
            GridFaturalar.Columns[2].HeaderText = "Ticari Ünvanı";
            GridFaturalar.Columns[3].HeaderText = "Fatura Numarası";
            GridFaturalar.Columns[4].HeaderText = "Fatura Türü";
            GridFaturalar.Columns[5].HeaderText = "Fatura Tarihi";
            GridFaturalar.Columns[6].HeaderText = "Fatura Açıklaması";
            GridFaturalar.Columns[7].HeaderText = "KDV";
            GridFaturalar.Columns[8].HeaderText = "Tutar";
            GridFaturalar.Columns[9].HeaderText = "Departman";
            GridFaturalar.Columns[10].HeaderText = "KDV Matrahı";
            GridFaturalar.Columns[11].HeaderText = "KDV'Li Tutar";
            GridFaturalar.Columns[12].HeaderText = "Toplam Tutar";
            GridFaturalar.Columns[13].HeaderText = "Döviz Birimi";
            GridFaturalar.Columns[14].HeaderText = "Dvz. Tutarı";
            GridFaturalar.Columns[15].HeaderText = "Tpl.Döviz Tutar";
            GridFaturalar.Columns[16].HeaderText = "Vergi Numarası";
            CalculateTableTotalPrice(tablobg);

        }

        private void GridFaturalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbFaturaTuru.SelectedItem = null;
            cmbDepartman.SelectedItem = null;
            txtFaturaNo.Text = null;
            ToList("");

        }
        private void copyAlltoClipboard()
        {
            GridFaturalar.SelectAll();
            DataObject dataObj = GridFaturalar.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            // Query prepare  part
            string PreparedQuery = "";

            PreparedQuery = $" InvoiceDate >= CONVERT(DATE,'{dtBaslangic.Value}',103) AND ";
            PreparedQuery = PreparedQuery + $" InvoiceDate <= CONVERT(DATE,'{dtBitisTarihi.Value}',103) ";

            if (!string.IsNullOrEmpty(txtFaturaNo.Text))
                PreparedQuery = PreparedQuery + $" AND InvoiceNo Like '{txtFaturaNo.Text.Trim()}'";
            if (cmbDepartman.Text.Trim() != "")
                PreparedQuery = PreparedQuery + $" AND DepartmentName Like '{cmbDepartman.SelectedText}'";
            if (!string.IsNullOrEmpty(txtTicariUnvani.Text))
                PreparedQuery = PreparedQuery + $" AND CommercialTitle Like '{txtTicariUnvani.Text.Trim()}'";
            if (!string.IsNullOrEmpty(txtVergiNo.Text))
                PreparedQuery = PreparedQuery + $" AND TaxNo Like '{txtVergiNo.Text.Trim()}'";
            if (cmbFaturaTuru.Text.Trim() != "")
                PreparedQuery = PreparedQuery + $" AND FaturaTuru Like '{cmbFaturaTuru.Text.Trim()}'";

            ToList(PreparedQuery);
        }


        private void CalculateTableTotalPrice(DataTable dt)
        {
            decimal FatAmountTL = 0, FatAmountForex = 0;
            double BeforeTotalTL = 0, BeforeTotalF = 0;

            BeforeTotalF = dt.Rows.Cast<DataRow>()
                            .Sum(t => Convert.ToDouble(t.ItemArray[16].ToString()));   // Oluşturulan InvoiceReportNormal Viewİ içerisinden satır.. ÇEKİLİYOR.. Her yeni satırda değiştirilmesi gerekir.... 
            BeforeTotalTL = dt.Rows.Cast<DataRow>()
                .Sum(t => Convert.ToDouble(t.ItemArray[12].ToString()));

            FatAmountTL = Convert.ToDecimal(BeforeTotalTL);
            FatAmountForex = Convert.ToDecimal(BeforeTotalF);
            lblToplamTL.Text = String.Format("{0:C}", FatAmountTL);
            lblToplamDvz.Text = String.Format("{0:C}", FatAmountForex);
        }

        private void btnKaydiAc_Click(object sender, EventArgs e)
        {
            if (GridFaturalar.Rows.Count <= 1) { MessageBox.Show("Ekranda fatura görüntülenemedi, bu sebeple açılacak kayıt yok...", "O.o Fatura var mı ekranda ?", MessageBoxButtons.OK, MessageBoxIcon.Question); return; }
            int selectedrowindex = GridFaturalar.SelectedCells[0].RowIndex;
            DataRow selectedRow = tablobg.Rows[selectedrowindex];
            Invoceinfo.InvoiceID = Convert.ToInt32(selectedRow["ID"].ToString());
            Invoceinfo.ClientID = Convert.ToInt32(selectedRow["ClientID"].ToString());
            Invoceinfo.ClientCode = selectedRow["ClientCode"].ToString();
            Invoceinfo.ClientCommercialTitle = selectedRow["CommercialTitle"].ToString();
            Invoceinfo.VATRate = Convert.ToDecimal(selectedRow["VATRate"]);
            Invoceinfo.InvoiceNo = selectedRow["InvoiceNo"].ToString();
            Invoceinfo.InvoiceDate = Convert.ToDateTime(selectedRow["InvoiceDate"]);
            Invoceinfo.InvoiceDetails = selectedRow["InvoiceDetail"].ToString();
            Invoceinfo.InvoiceType = selectedRow["FaturaTuru"].ToString();
            Invoceinfo.Amount = Convert.ToDecimal(selectedRow["Amount"]);
            Invoceinfo.DepartmentName = selectedRow["DepartmentName"].ToString();
            Invoceinfo.VATBasis = Convert.ToDecimal(selectedRow["VATBasis"]);
            Invoceinfo.AmountWithVAT = Convert.ToDecimal(selectedRow["AmountWithVAT"]);
            Invoceinfo.TotalAmount = Convert.ToDecimal(selectedRow["TotalAmount"]);
            Invoceinfo.Forex = selectedRow["Forex"].ToString();
            Invoceinfo.ForexAmount = Convert.ToDecimal(selectedRow["ForexAmount"]);
            Invoceinfo.TotalAmountForex = Convert.ToDecimal(selectedRow["TotalAmountForex"]);
            Invoceinfo.TaxNo = selectedRow["TaxNo"].ToString();
            Invoceinfo.TaxOffice = selectedRow["TaxOffice"].ToString();
            Invoceinfo.VAT = ((Invoceinfo.Amount / 100) * Invoceinfo.VATRate);


            /// will create  to open form which is type 
            /// 1 = Alış faturası 
            /// 2 = Alıştan iade
            /// 3 = Satış
            /// 4 = satıştan iade
            /// 5 = masraf     

            if (Invoceinfo.InvoiceType == "Alis Faturasi" || Invoceinfo.InvoiceType == "Alistan iade Faturasi")
            {
                AlisFaturasi Alisft = new AlisFaturasi(Invoceinfo);
                Alisft.Show();
            }
            else if (Invoceinfo.InvoiceType == "Satis Faturasi" || Invoceinfo.InvoiceType == "Satistan iade Faturasi")
            {
                SatisFaturasi Satft = new SatisFaturasi(Invoceinfo);
                Satft.Show();
            }

            //MetroFramework.MetroMessageBox.Show(this, "Lütfen sayfadan işlem yapılacak faturayı belirleyiniz..", "Lütfen Kayıt seçiniz", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);


        }
    }
}
