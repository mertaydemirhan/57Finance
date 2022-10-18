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
    public partial class CHR : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        DataSet ds;
        TransactionINFO transactionINFO = new TransactionINFO();
        string FreeQuery="";
        public CHR()
        {
            InitializeComponent();
        }

        private void CHR_Load(object sender, EventArgs e)
        {
            ToList();
            BindDataDepartment();
        }

        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query =  $"SELECT C.ID ClientID,ClientCode,CommercialTitle,TaxNo,CHR.ID,CHR.Amount,CHR.Date, CHR.DocumentNo," +
                            $"CASE WHEN CHR.DocumentType = 1 THEN 'Tahsilat' WHEN CHR.DocumentNo=2 THEN 'Tediye' END DocumentType," +
                            $"CHR.Explanation, D.DepartmentName,CHR.VATRate," +
                            $"CASE WHEN CHR.PaymentType = 0 THEN 'Nakit' WHEN CHR.PaymentType=1 THEN 'Kredi Kartı' WHEN CHR.PaymentType=2 THEN 'Havale / EFT' " +
                            $"WHEN CHR.PaymentType=3 THEN 'Mahsup' WHEN CHR.PaymentType=4 THEN 'Diğer' END PaymentType," +
                            $"CHR.ForexAmount, CHR.Forex, CHR.Balance,CHR.ForexUSD,CHR.ForexEUR,CHR.ForexGBP,CHR.ForexAZN,CHR.ForexTL,CHR.DocumentNo DocumentTypeID,CHR.DepartmentID,CHR.PaymentType PaymentTypeID" +
                            $" from ClientTransactions AS CHR " +
                            $"JOIN Clients C ON(CHR.ClientID = C.ID) JOIN Departments D ON(CHR.DepartmentID = D.ID)" +
                            $"WHERE C.isActive=1";

            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridCHR.DataSource = tablo;
            GridCHR.Columns[0].Visible = false; //Cari ID
            GridCHR.Columns[1].HeaderText = "Cari Kodu";
            GridCHR.Columns[2].HeaderText = "Ticari Ünvanı";
            GridCHR.Columns[3].HeaderText = "Vergi Numarası";
            GridCHR.Columns[4].Visible = false; // ID CHR
            GridCHR.Columns[5].HeaderText = "Tutar";
            GridCHR.Columns[6].HeaderText = "İşlem Tarihi";
            GridCHR.Columns[7].HeaderText = "Evrak Numarası";
            GridCHR.Columns[8].HeaderText = "Evrak Türü";
            GridCHR.Columns[9].HeaderText = "Açıklama";
            GridCHR.Columns[10].HeaderText = "Departmanı";
            GridCHR.Columns[11].HeaderText = "KDV Oranı";
            GridCHR.Columns[12].HeaderText = "Ödeme Türü";
            GridCHR.Columns[13].HeaderText = "Döviz Tutarı";
            GridCHR.Columns[14].HeaderText = "Döviz Tipi";
            GridCHR.Columns[15].HeaderText = "Bakiyesi";
            GridCHR.Columns[16].HeaderText = "Dolar Karşılığı";
            GridCHR.Columns[17].HeaderText = "Euro Karşılığı";
            GridCHR.Columns[18].HeaderText = "Stg Karşılığı";
            GridCHR.Columns[19].HeaderText = "TL Karşılığı";
            GridCHR.Columns[20].Visible = false;
            GridCHR.Columns[21].Visible = false;
            GridCHR.Columns[22].Visible = false;

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
                string query =  $"SELECT C.ID ClientID,ClientCode,CommercialTitle,TaxNo,CHR.ID,CHR.Amount,CHR.Date, CHR.DocumentNo," +
                                $"CASE WHEN CHR.DocumentType = 1 THEN 'Tahsilat' WHEN CHR.DocumentType=2 THEN 'Tediye' END DocumentType," +
                                $"CHR.Explanation, D.DepartmentName,CHR.VATRate," +
                                $"CASE WHEN CHR.PaymentType = 0 THEN 'Nakit' WHEN CHR.PaymentType=1 THEN 'Kredi Kartı' WHEN CHR.PaymentType=2 THEN 'Havale / EFT' " +
                                $"WHEN CHR.PaymentType=3 THEN 'Mahsup' WHEN CHR.PaymentType=4 THEN 'Diğer' END PaymentType," +
                                $"CHR.ForexAmount, CHR.Forex, CHR.Balance,CHR.ForexUSD,CHR.ForexEUR,CHR.ForexGBP,CHR.ForexAZN,CHR.ForexTL,CHR.DocumentType DocumentTypeID,CHR.DepartmentID,CHR.PaymentType PaymentTypeID" +
                                $" from ClientTransactions CHR " +
                                $"JOIN Clients C ON(CHR.ClientID = C.ID) JOIN Departments D ON(CHR.DepartmentID = D.ID)" +
                                $"WHERE C.isActive=1";
                SqlDataAdapter adapter = new SqlDataAdapter();
                if (ara != "")
                    adapter = new SqlDataAdapter(query + " AND " + ara + " like '%" + yer + "%'", baglanti);
                else
                   adapter = new SqlDataAdapter(query +" AND "+ yer, baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridCHR.DataSource = tablo;
                GridCHR.Columns[0].Visible = false; //Cari ID
                GridCHR.Columns[1].HeaderText = "Cari Kodu";
                GridCHR.Columns[2].HeaderText = "Ticari Ünvanı";
                GridCHR.Columns[3].HeaderText = "Vergi Numarası";
                GridCHR.Columns[4].Visible = false; // ID CHR
                GridCHR.Columns[5].HeaderText = "Tutar";
                GridCHR.Columns[6].HeaderText = "İşlem Tarihi";
                GridCHR.Columns[7].HeaderText = "Evrak Numarası";
                GridCHR.Columns[8].HeaderText = "Evrak Türü";
                GridCHR.Columns[9].HeaderText = "Açıklama";
                GridCHR.Columns[10].HeaderText = "Departmanı";
                GridCHR.Columns[11].HeaderText = "KDV Oranı";
                GridCHR.Columns[12].HeaderText = "Ödeme Türü";
                GridCHR.Columns[13].HeaderText = "Döviz Tutarı";
                GridCHR.Columns[14].HeaderText = "Döviz Tipi";
                GridCHR.Columns[15].HeaderText = "Bakiyesi";
                GridCHR.Columns[16].HeaderText = "Dolar Karşılığı";
                GridCHR.Columns[17].HeaderText = "Euro Karşılığı";
                GridCHR.Columns[18].HeaderText = "Stg Karşılığı";
                GridCHR.Columns[19].HeaderText = "TL Karşılığı";
                GridCHR.Columns[20].Visible = false;
                GridCHR.Columns[21].Visible = false;
                GridCHR.Columns[22].Visible = false;
            }
        }
        private void txtCariKodu_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtCariKodu.Text;
            ara("C.ClientCode", al);
        }
        private void txtTicariUnvani_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtTicariUnvani.Text;
            ara("C.CommercialTitle", al);
        }
        private void txtVergiNo_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtVergiNo.Text;
            ara("C.TaxNo", al);
        }
        private void txtMuhSatis_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtMuhSatis.Text;
            ara("C.ClientAccSale", al);
        }
        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDepartman.SelectedIndex != -1)
            {
                string al = cmbDepartman.SelectedValue.ToString();
                ara("CHR.DepartmentID", al);
            }

        }

        private void cmbIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cmbIslemTuru.SelectedIndex != -1)
            {
                string al = cmbIslemTuru.SelectedItem.ToString();
                ara("CHR.PaymentType", al);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCariKodu.Text = "";
            txtTicariUnvani.Text = "";
            txtVergiNo.Text = "";
            txtMuhSatis.Text = "";
            cmbDepartman.SelectedIndex = -1;
            cmbIslemTuru.SelectedIndex = -1;
            ToList();


        }
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            FreeQuery = "";
            string bas = dtBaslangic.Value.ToString();
            string bit = dtBitisTarihi.Value.ToString();
            FreeQuery=$"CONVERT(date,CHR.Date,103)>=CONVERT(DATE,'{bas}',103) AND ";
            FreeQuery = FreeQuery +$"CONVERT(date,CHR.Date,103)<=CONVERT(DATE,'{bit}',103)";
            ara("", FreeQuery);

        }

        private void KaydiAc()
        {
            int selectedrowindex = GridCHR.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = GridCHR.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);
            if (cellValue != "")
            {
                transactionINFO.ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                transactionINFO.ClientID = Convert.ToInt32(selectedRow.Cells["ClientID"].Value);
                transactionINFO.ClientCode = selectedRow.Cells["ClientCode"].Value.ToString();
                transactionINFO.ClientCommercialTitle = selectedRow.Cells["CommercialTitle"].Value.ToString();
                transactionINFO.Amount = Convert.ToDouble(selectedRow.Cells["Amount"].Value);
                transactionINFO.Date = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                transactionINFO.DocumentNo = Convert.ToUInt32(selectedRow.Cells["DocumentNo"].Value);
                transactionINFO.DocumentType = Convert.ToInt32(selectedRow.Cells["DocumentTypeID"].Value);
                transactionINFO.Explanation = selectedRow.Cells["Explanation"].Value.ToString();
                transactionINFO.DepartmentID = Convert.ToInt32(selectedRow.Cells["DepartmentID"].Value);
                if (!string.IsNullOrEmpty(selectedRow.Cells["VATRate"].Value.ToString()))
                    transactionINFO.VATRate = Convert.ToInt32(selectedRow.Cells["VATRate"].Value.ToString());
                transactionINFO.PaymentType = Convert.ToInt32(selectedRow.Cells["PaymentTypeID"].Value);
                transactionINFO.ForexAmount = Convert.ToDouble(selectedRow.Cells["ForexAmount"].Value);
                transactionINFO.Forex = selectedRow.Cells["Forex"].Value.ToString();
                if (!string.IsNullOrEmpty(selectedRow.Cells["Balance"].Value.ToString()))
                    transactionINFO.Balance = Convert.ToDouble(selectedRow.Cells["Balance"].Value);
                transactionINFO.ForexUSD = Math.Round(Convert.ToDouble(selectedRow.Cells["ForexUSD"].Value),4);
                transactionINFO.ForexEUR = Math.Round(Convert.ToDouble(selectedRow.Cells["ForexEUR"].Value), 4);
                transactionINFO.ForexGBP = Math.Round(Convert.ToDouble(selectedRow.Cells["ForexGBP"].Value), 4);
                transactionINFO.ForexAZN = Math.Round(Convert.ToDouble(selectedRow.Cells["ForexAZN"].Value), 4);
                transactionINFO.ForexTL =  Math.Round(Convert.ToDouble(selectedRow.Cells["ForexTL"].Value), 4);

                /// will create  to open form which is type 
                if(transactionINFO.DocumentType == 1)
                {
                    TahsilatGirisi thgiris = new TahsilatGirisi(transactionINFO);
                    thgiris.Show();
                }
                else if(transactionINFO.DocumentType == 2)
                {
                    TediyeGirisi TdGiris = new TediyeGirisi(transactionINFO);
                    TdGiris.Show();
                }

            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Lütfen sayfadan işlem yapılacak hareketi belirleyiniz..", "Lütfen Kayıt seçiniz", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
        }
        private void btnKaydiAc_Click(object sender, EventArgs e)
        {
            KaydiAc();
        }

        private void GridCHR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KaydiAc();
        }

        private void dtIslemTarihi_ValueChanged(object sender, EventArgs e)
        {
            FreeQuery = "";
            string bas = dtIslemTarihi.Value.ToString();
            FreeQuery = $"CONVERT(date,CHR.Date,103)=CONVERT(DATE,'{bas}',103)";
            ara("", FreeQuery);
        }
        private void copyAlltoClipboard()
        {
            GridCHR.SelectAll();
            DataObject dataObj = GridCHR.GetClipboardContent();
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
    }
}
