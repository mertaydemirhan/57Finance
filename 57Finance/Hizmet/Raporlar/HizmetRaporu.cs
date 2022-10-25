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

namespace _57Finance.Hizmet.Raporlar
{

    public partial class HizmetRaporu : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        DataSet ds;
        public HizmetRaporu()
        {
            InitializeComponent();
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
                string query = "SELECT [ID],[ServiceName],[ServiceCode],[Price],[Forex],[FPrice],[VATRate],[Comment],[ServiceAccSale],[ServiceAccBuy] FROM [57Finance].[dbo].[Services] where 1=1 ";
                SqlDataAdapter adapter = new SqlDataAdapter(query + " AND " + ara + " like '%" + yer + "%'", baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridHizmet.DataSource = tablo;
                GridHizmet.Columns[0].Visible = false;
                GridHizmet.Columns[1].HeaderText = "Hizmet Adı";
                GridHizmet.Columns[2].HeaderText = "Hizmet Kodu";
                GridHizmet.Columns[3].HeaderText = "TL Fiyat";
                GridHizmet.Columns[4].HeaderText = "Döviz Birimi";
                GridHizmet.Columns[5].HeaderText = "Döviz Fiyat";
                GridHizmet.Columns[6].HeaderText = "KDV Oranı";
                GridHizmet.Columns[7].HeaderText = "Açıklama";
                GridHizmet.Columns[8].HeaderText = "Satış Muh. Kodu";
                GridHizmet.Columns[9].HeaderText = "Alış Muh. Kodu";
            }
        }

        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = "SELECT [ID],[ServiceName],[ServiceCode],[Price],[Forex],[FPrice],[VATRate],[Comment],[ServiceAccSale],[ServiceAccBuy] FROM [57Finance].[dbo].[Services] WHERE 1=1 ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridHizmet.DataSource = tablo;
            GridHizmet.Columns[0].Visible = false;
            GridHizmet.Columns[1].HeaderText = "Hizmet Adı";
            GridHizmet.Columns[2].HeaderText = "Hizmet Kodu";
            GridHizmet.Columns[3].HeaderText = "TL Fiyat";
            GridHizmet.Columns[4].HeaderText = "Döviz Birimi";
            GridHizmet.Columns[5].HeaderText = "Döviz Fiyat";
            GridHizmet.Columns[6].HeaderText = "KDV Oranı";
            GridHizmet.Columns[7].HeaderText = "Açıklama";
            GridHizmet.Columns[8].HeaderText = "Satış Muh. Kodu";
            GridHizmet.Columns[9].HeaderText = "Alış Muh. Kodu";
        }

        private void HizmetRaporu_Load(object sender, EventArgs e)
        {
            ToList();
        }
        private void txtHizmetKodu_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtHizmetKodu.Text;
            ara("ServiceCode", al);
        }
        private void txtHizmetAdi_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtHizmetAdi.Text;
            ara("ServiceName", al);
        }
        private void txtAciklama_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtAciklama.Text;
            ara("Comment", al);
        }
        private void txtMuhSatis_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtMuhSatis.Text;
            ara("ServiceAccSale", al);
        }
        private void copyAlltoClipboard()
        {
            GridHizmet.SelectAll();
            DataObject dataObj = GridHizmet.GetClipboardContent();
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

        private void btnKartAc_Click(object sender, EventArgs e)
        {
            int selectedrowindex = GridHizmet.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = GridHizmet.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);
            if (cellValue != "")
            {
                ServiceInfo SrvINFO = new ServiceInfo();
                SrvINFO.ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                SrvINFO.ServiceCode = selectedRow.Cells["ServiceCode"].Value.ToString();
                SrvINFO.ServiceName = selectedRow.Cells["ServiceName"].Value.ToString();
                SrvINFO.Price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                SrvINFO.VATRate = Convert.ToDouble(selectedRow.Cells["VATRate"].Value);
                SrvINFO.Comment = selectedRow.Cells["Comment"].Value.ToString();
                SrvINFO.ServiceAccSale = selectedRow.Cells["ServiceAccSale"].Value.ToString();
                SrvINFO.ServiceAccBuy = selectedRow.Cells["ServiceAccBuy"].Value.ToString();
                SrvINFO.FPrice = Convert.ToDouble(selectedRow.Cells["FPrice"].Value);
                SrvINFO.Forex = selectedRow.Cells["Forex"].Value.ToString();

                HizmetTanim Ht = new HizmetTanim(SrvINFO);
                Ht.Show();

            }
        }
    }

}
