using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _57Finance.Model;
using MetroFramework;

namespace _57Finance.Cari.Raporlar
{
    public partial class CariListesi : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        DataSet ds;
        public CariListesi()
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
                string query = "SELECT C.ID,ClientCode,CommercialTitle,Adress,Country,City,District,ClientAccSale,ClientAccBuy,D.DepartmentName,TaxNo,TaxOffice,IsBlackListed,IsActive,D.ID as DeptID from Clients C JOIN Departments D ON(C.DepartmentID = D.ID) Where isActive=1";
                SqlDataAdapter adapter = new SqlDataAdapter(query + " AND " + ara + " like '%" + yer + "%'", baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridCari.DataSource = tablo;
                GridCari.Columns[0].Visible = false;
                GridCari.Columns[1].HeaderText = "Cari Kodu";
                GridCari.Columns[2].HeaderText = "Ticari Ünvanı";
                GridCari.Columns[3].HeaderText = "Adres";
                GridCari.Columns[4].HeaderText = "Ülkesi";
                GridCari.Columns[5].HeaderText = "İli";
                GridCari.Columns[6].HeaderText = "İlçesi";
                GridCari.Columns[7].HeaderText = "Satış Muh. Kodu";
                GridCari.Columns[8].HeaderText = "Alış Muh. Kodu";
                GridCari.Columns[9].HeaderText = "Departmanı";
                GridCari.Columns[10].HeaderText = "Vergi Numarası";
                GridCari.Columns[11].HeaderText = "Vergi Dairesi";
                GridCari.Columns[12].HeaderText = "Kara Listede";
                GridCari.Columns[13].HeaderText = "Aktif";
                GridCari.Columns[14].Visible = false;
            }
        }

        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = "SELECT C.ID,ClientCode,CommercialTitle,Adress,Country,City,District,ClientAccSale,ClientAccBuy,D.DepartmentName,TaxNo,TaxOffice,IsBlackListed,IsActive,D.ID as DeptID from Clients C JOIN Departments D ON(C.DepartmentID = D.ID) WHERE isActive=1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridCari.DataSource = tablo;
            GridCari.Columns[0].Visible = false;
            GridCari.Columns[1].HeaderText = "Cari Kodu";
            GridCari.Columns[2].HeaderText = "Ticari Ünvanı";
            GridCari.Columns[3].HeaderText = "Adres";
            GridCari.Columns[4].HeaderText = "Ülkesi";
            GridCari.Columns[5].HeaderText = "İli";
            GridCari.Columns[6].HeaderText = "İlçesi";
            GridCari.Columns[7].HeaderText = "Satış Muh. Kodu";
            GridCari.Columns[8].HeaderText = "Alış Muh. Kodu";
            GridCari.Columns[9].HeaderText = "Departmanı";
            GridCari.Columns[10].HeaderText = "Vergi Numarası";
            GridCari.Columns[11].HeaderText = "Vergi Dairesi";
            GridCari.Columns[12].HeaderText = "Kara Listede";
            GridCari.Columns[13].HeaderText = "Aktif";
            GridCari.Columns[14].Visible = false;
        }
        private void CariListesi_Load(object sender, EventArgs e)
        {
            ToList();
            //MetroMessageBox.Show(this, "Excell dosyanız kaydedilmiştir. Dosya adı :  " + savefile.FileName, "Başarıyla Kaydedildi !", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnKartAc_Click(object sender, EventArgs e)
        {
            int selectedrowindex = GridCari.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = GridCari.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);
            if (cellValue != "")
            {
                ClientInfo Cl = new ClientInfo();
                Cl.ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                Cl.ClientCode = selectedRow.Cells["ClientCode"].Value.ToString();
                Cl.CommercialTitle = selectedRow.Cells["CommercialTitle"].Value.ToString();
                Cl.Adress = selectedRow.Cells["Adress"].Value.ToString();
                Cl.Country = selectedRow.Cells["Country"].Value.ToString();
                Cl.City = selectedRow.Cells["City"].Value.ToString();
                Cl.District = selectedRow.Cells["District"].Value.ToString();
                Cl.ClientAccSale = selectedRow.Cells["ClientAccSale"].Value.ToString();
                Cl.ClientAccBuy = selectedRow.Cells["ClientAccBuy"].Value.ToString();
                Cl.DepartmentID = Convert.ToInt32(selectedRow.Cells["DeptID"].Value);
                Cl.TaxNo = Convert.ToInt64(selectedRow.Cells["TaxNo"].Value);
                Cl.TaxOffice = selectedRow.Cells["TaxOffice"].Value.ToString();
                Cl.IsBlackListed = Convert.ToBoolean(selectedRow.Cells["IsBlackListed"].Value);
                Cl.IsActive = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);

                CariTanim ct = new CariTanim(Cl);
                ct.Show();

            }

        }

        private void txtCariKodu_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtCariKodu.Text;
            ara("ClientCode", al);
        }
        private void txtTicariUnvani_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtTicariUnvani.Text;
            ara("CommercialTitle", al);
        }
        private void txtVergiNo_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtVergiNo.Text;
            ara("TaxNo", al);
        }
        private void txtMuhSatis_OnValueChanged(object sender, EventArgs e)
        {
            string al = txtMuhSatis.Text;
            ara("ClientAccSale", al);
        }


        private void copyAlltoClipboard()
        {
            GridCari.SelectAll();
            DataObject dataObj = GridCari.GetClipboardContent();
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
