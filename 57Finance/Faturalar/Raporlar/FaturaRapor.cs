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
            ToList();
            GetInvoiceType();
            BindDataDepartment();
        }

        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = $"SELECT * FROM [{DatabaseName}].dbo.InvoiceReport WHERE 1=1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridFaturalar.DataSource = tablo;
            GridFaturalar.Columns[0].Visible = false; //Fatura ID
            GridFaturalar.Columns[1].HeaderText = "Ticari Ünvanı";
            GridFaturalar.Columns[2].HeaderText = "Fatura Numarası";
            GridFaturalar.Columns[3].HeaderText = "Fatura Türü";
            GridFaturalar.Columns[4].HeaderText = "Fatura Tarihi";
            GridFaturalar.Columns[5].HeaderText = "Fatura Açıklaması";
            GridFaturalar.Columns[6].HeaderText = "KDV";
            GridFaturalar.Columns[7].HeaderText = "Tutar";
            GridFaturalar.Columns[8].HeaderText = "Departman";
            GridFaturalar.Columns[9].HeaderText = "KDV Matrahı";
            GridFaturalar.Columns[10].HeaderText = "KDV'Li Tutar";
            GridFaturalar.Columns[11].HeaderText = "Toplam Tutar";
            GridFaturalar.Columns[12].HeaderText = "Döviz Birimi";
            GridFaturalar.Columns[13].HeaderText = "Dvz. Tutarı";
            GridFaturalar.Columns[14].HeaderText = "Tpl.Döviz Tutar";
            //GridFaturalar.Columns[15].HeaderText = "Dvz. Borç";
            //GridFaturalar.Columns[16].HeaderText = "Dvz. Alacak";
            //GridFaturalar.Columns[17].HeaderText = "Dvz.Bakiyesi";
            //GridFaturalar.Columns[18].HeaderText = "Döviz Tipi";
            //GridFaturalar.Columns[19].HeaderText = "Dolar Karşılığı";
            //GridFaturalar.Columns[20].HeaderText = "Euro Karşılığı";
            //GridFaturalar.Columns[21].HeaderText = "Stg Karşılığı";
            //GridFaturalar.Columns[22].HeaderText = "TL Karşılığı";
            //GridFaturalar.Columns[23].Visible = false;
            //GridFaturalar.Columns[24].Visible = false;
            //GridFaturalar.Columns[25].Visible = false;
            //GridFaturalar.Columns[26].Visible = false;
            //GridFaturalar.Columns[27].HeaderText = "Varsayılan Döviz";
            CalculateTotalPrice();
            
        }

        private void GridFaturalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbFaturaTuru.SelectedItem = null;
            cmbDepartman.SelectedItem = null;
            txtFaturaNo.Text = null;

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

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }


        private void CalculateTotalPrice()
        {
            decimal FatAmountTL = 0,FatAmountForex=0;
            double BeforeTotalTL = 0, BeforeTotalF = 0;
            DataGridViewRow row = GridFaturalar.Rows[GridFaturalar.Rows.Count-1];
            if (row.Cells.Count > 10)
            {
                if (row.Cells[9].Value != null && row.Cells[10].Value != null)
                {
                    try
                    {
                        BeforeTotalF = GridFaturalar.Rows.Cast<DataGridViewRow>()
                            .Sum(t => Convert.ToDouble(t.Cells[14].Value));
                        BeforeTotalTL = GridFaturalar.Rows.Cast<DataGridViewRow>()
                            .Sum(t => Convert.ToDouble(t.Cells[10].Value));
                    }
                    catch (Exception)
                    {
                        return;
                    }

                }

            }
            
            FatAmountTL = Convert.ToDecimal(BeforeTotalTL);
            FatAmountForex = Convert.ToDecimal(BeforeTotalF);
            lblToplamTL.Text = String.Format("{0:C}", FatAmountTL);
            //(string.Format("{0:#.00}", Convert.ToDecimal(totalpriceTL) / 100));
            lblToplamDvz.Text = String.Format("{0:C}", FatAmountForex);
        }  // Grid işlemlerinde tekrar toplamayı yapan fonksiyon....

    }
}
