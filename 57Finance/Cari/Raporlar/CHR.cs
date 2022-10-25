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
            btnClear_Click(sender, e);
        }

        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query =  $"SELECT * FROM [{DatabaseName}].dbo.TransactionsCSharp CHR WHERE 1=1";

            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridCHR.DataSource = tablo;
            GridCHR.Columns[0].Visible = false; //Cari ID
            GridCHR.Columns[1].HeaderText = "Cari Kodu";
            GridCHR.Columns[2].HeaderText = "Ticari Ünvanı";
            GridCHR.Columns[3].HeaderText = "Vergi Numarası";
            GridCHR.Columns[4].Visible = false; // ID CHR
            GridCHR.Columns[5].HeaderText = "Borç Tutarı";
            GridCHR.Columns[6].HeaderText = "Alacak Tutarı";
            GridCHR.Columns[7].HeaderText = "Bakiyesi";
            GridCHR.Columns[8].HeaderText = "İşlem Tarihi";
            GridCHR.Columns[9].HeaderText = "Evrak Numarası";
            GridCHR.Columns[10].HeaderText = "Evrak Türü";
            GridCHR.Columns[11].HeaderText = "Açıklama";
            GridCHR.Columns[12].HeaderText = "Departmanı";
            GridCHR.Columns[13].HeaderText = "KDV Oranı";
            GridCHR.Columns[14].HeaderText = "Ödeme Türü";
            GridCHR.Columns[15].HeaderText = "Dvz. Borç";
            GridCHR.Columns[16].HeaderText = "Dvz. Alacak";
            GridCHR.Columns[17].HeaderText = "Dvz.Bakiyesi";
            GridCHR.Columns[18].HeaderText = "Döviz Tipi";
            GridCHR.Columns[19].HeaderText = "Dolar Karşılığı";
            GridCHR.Columns[20].HeaderText = "Euro Karşılığı";
            GridCHR.Columns[21].HeaderText = "Stg Karşılığı";
            GridCHR.Columns[22].HeaderText = "TL Karşılığı";
            GridCHR.Columns[23].Visible = false;
            GridCHR.Columns[24].Visible = false;
            GridCHR.Columns[25].Visible = false;
            GridCHR.Columns[26].Visible = false;
            GridCHR.Columns[27].HeaderText = "Varsayılan Döviz";

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

        public void ara(string ara)
        {
            //MetroFramework.MetroMessageBox.Show(this,yer,"Harika");
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            if (ara.Trim() == "")
            {
                ToList();
            }
            else
            {
                DataTable tablo = new DataTable();
                tablo.Clear();
                ds = new DataSet();
                string query = $"SELECT * FROM [{DatabaseName}].dbo.TransactionsCSharp CHR WHERE 1=1";
                SqlDataAdapter adapter = new SqlDataAdapter();
                if (ara != "")
                    adapter = new SqlDataAdapter(query + FreeQuery, baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridCHR.DataSource = tablo;
            GridCHR.Columns[0].Visible = false; //Cari ID
            GridCHR.Columns[1].HeaderText = "Cari Kodu";
            GridCHR.Columns[2].HeaderText = "Ticari Ünvanı";
            GridCHR.Columns[3].HeaderText = "Vergi Numarası";
            GridCHR.Columns[4].Visible = false; // ID CHR
            GridCHR.Columns[5].HeaderText = "Borç Tutarı";
            GridCHR.Columns[6].HeaderText = "Alacak Tutarı";
            GridCHR.Columns[7].HeaderText = "Bakiyesi";
            GridCHR.Columns[8].HeaderText = "İşlem Tarihi";
            GridCHR.Columns[9].HeaderText = "Evrak Numarası";
            GridCHR.Columns[10].HeaderText = "Evrak Türü";
            GridCHR.Columns[11].HeaderText = "Açıklama";
            GridCHR.Columns[12].HeaderText = "Departmanı";
            GridCHR.Columns[13].HeaderText = "KDV Oranı";
            GridCHR.Columns[14].HeaderText = "Ödeme Türü";
            GridCHR.Columns[15].HeaderText = "Dvz. Borç";
            GridCHR.Columns[16].HeaderText = "Dvz. Alacak";
            GridCHR.Columns[17].HeaderText = "Dvz.Bakiyesi";
            GridCHR.Columns[18].HeaderText = "Döviz Tipi";
            GridCHR.Columns[19].HeaderText = "Dolar Karşılığı";
            GridCHR.Columns[20].HeaderText = "Euro Karşılığı";
            GridCHR.Columns[21].HeaderText = "Stg Karşılığı";
            GridCHR.Columns[22].HeaderText = "TL Karşılığı";
            GridCHR.Columns[23].Visible = false;
            GridCHR.Columns[24].Visible = false;
            GridCHR.Columns[25].Visible = false;
            GridCHR.Columns[26].Visible = false;
            GridCHR.Columns[27].HeaderText = "Varsayılan Döviz";
            }
        }
        private void txtCariKodu_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void txtTicariUnvani_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void txtVergiNo_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void txtMuhSatis_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            FreeQuery = "";
            if(cmbDepartman.SelectedIndex != -1)
            {
                string al = cmbDepartman.SelectedValue.ToString();
                FreeQuery = FreeQuery + $" AND CHR.DepartmentID={al}";
                btnFiltreCari_Click(sender, e);
            }

        }

        private void cmbIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            FreeQuery = "";
            if ( cmbIslemTuru.SelectedIndex != -1)
            {
                string al = cmbIslemTuru.SelectedItem.ToString();
                FreeQuery = FreeQuery + $" AND CHR.PaymentType='{al}'";
                btnFiltreCari_Click(sender, e);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            FreeQuery = "";
            txtCariKodu1.Text = "";
            txtTicariUnvani.Text = "";
            txtVergiNo.Text = "";
            cmbDepartman.SelectedIndex = -1;
            cmbIslemTuru.SelectedIndex = -1;
            ToList();


        }
        private void btnFiltrele_Click(object sender, EventArgs e)
        {            
            string bas = dtBaslangic.Value.ToString();
            string bit = dtBitisTarihi.Value.ToString();
            FreeQuery=  FreeQuery +$" AND CONVERT(date,CHR.Date,103)>=CONVERT(DATE,'{bas}',103) AND ";
            FreeQuery = FreeQuery +$"CONVERT(date,CHR.Date,103)<=CONVERT(DATE,'{bit}',103)";
            btnFiltreCari_Click(sender, e);

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
                if (transactionINFO.DocumentType == 1 && !string.IsNullOrEmpty(selectedRow.Cells["Credit"].Value.ToString()))
                    transactionINFO.Credit = Convert.ToDouble(selectedRow.Cells["Credit"].Value);
                if(transactionINFO.DocumentType != 1 && !string.IsNullOrEmpty(selectedRow.Cells["Debt"].Value.ToString()))
                    transactionINFO.Debt = Convert.ToDouble(selectedRow.Cells["Debt"].Value);
                transactionINFO.Date = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                transactionINFO.DocumentNo = Convert.ToUInt32(selectedRow.Cells["DocumentNo"].Value);
                transactionINFO.DocumentType = Convert.ToInt32(selectedRow.Cells["DocumentTypeID"].Value);
                transactionINFO.Explanation = selectedRow.Cells["Explanation"].Value.ToString();
                transactionINFO.DepartmentID = Convert.ToInt32(selectedRow.Cells["DepartmentID"].Value);
                if (!string.IsNullOrEmpty(selectedRow.Cells["VATRate"].Value.ToString()))
                    transactionINFO.VATRate = Convert.ToInt32(selectedRow.Cells["VATRate"].Value.ToString());
                transactionINFO.PaymentType = Convert.ToInt32(selectedRow.Cells["PaymentTypeID"].Value);
                if (transactionINFO.DocumentType == 1 && !string.IsNullOrEmpty(selectedRow.Cells["FCredit"].Value.ToString()))
                    transactionINFO.FCredit = Convert.ToDouble(selectedRow.Cells["FCredit"].Value);
                if (transactionINFO.DocumentType != 1 && !string.IsNullOrEmpty(selectedRow.Cells["FDebt"].Value.ToString()))
                    transactionINFO.FDebt = Convert.ToDouble(selectedRow.Cells["FDebt"].Value);
                transactionINFO.Forex = selectedRow.Cells["Forex"].Value.ToString();
                if (!string.IsNullOrEmpty(selectedRow.Cells["TLBalance"].Value.ToString()))
                    transactionINFO.Balance = Convert.ToDouble(selectedRow.Cells["TLBalance"].Value);
                transactionINFO.ForexUSD = Math.Round(Convert.ToDouble(selectedRow.Cells["ForexUSD"].Value),4);
                transactionINFO.ForexEUR = Math.Round(Convert.ToDouble(selectedRow.Cells["ForexEUR"].Value), 4);
                transactionINFO.ForexGBP = Math.Round(Convert.ToDouble(selectedRow.Cells["ForexGBP"].Value), 4);
                transactionINFO.ForexAZN = Math.Round(Convert.ToDouble(selectedRow.Cells["ForexAZN"].Value), 4);
                transactionINFO.ForexTL =  Math.Round(Convert.ToDouble(selectedRow.Cells["ForexTL"].Value), 4);
                transactionINFO.DefaultForex = selectedRow.Cells["DefaultForex"].Value.ToString();

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
            string bas = dtIslemTarihi.Value.ToString();
            FreeQuery = $" AND CONVERT(date,CHR.Date,103)=CONVERT(DATE,'{bas}',103)";
            btnFiltreCari_Click(sender, e);
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

        private void btnFiltreCari_Click(object sender, EventArgs e)
        {
            string CCode1 = txtCariKodu1.Text.Trim();
            string Ccode2 = txtCariKodu2.Text.Trim();
            string Ctitle = txtTicariUnvani.Text.Trim();
            string TaxNo = txtVergiNo.Text.Trim();
            FreeQuery = FreeQuery + $" AND ClientCode>='{CCode1}' AND ClientCode<='{Ccode2} '";
            FreeQuery = FreeQuery + $" AND CommercialTitle Like '%{Ctitle}%' AND TaxNo Like '%{TaxNo}%'";
            ara(FreeQuery);

        }

        private void txtEvrakNo_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
