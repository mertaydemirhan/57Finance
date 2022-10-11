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

namespace _57Finance.Diger.Cari
{
    public partial class CariSec : Form
    {
        Form TahsilatGiris = Application.OpenForms["TahsilatGirisi"];
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds;
        public CariSec()
        {
            InitializeComponent();
        }
        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = "SELECT C.ID,ClientCode,CommercialTitle,TaxNo,IsBlackListed from Clients C JOIN Departments D ON(C.DepartmentID = D.ID) WHERE isActive=1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridCari.DataSource = tablo;
            GridCari.Columns[0].Visible = false;
            GridCari.Columns[1].HeaderText = "Cari Kodu";
            GridCari.Columns[2].HeaderText = "Ticari Ünvanı";
            GridCari.Columns[3].HeaderText = "Vergi Numarası";
            GridCari.Columns[4].HeaderText = "Kara Listede";
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
                string query = "SELECT C.ID,ClientCode,CommercialTitle,TaxNo,IsBlackListed from Clients C JOIN Departments D ON(C.DepartmentID = D.ID) Where isActive=1";
                SqlDataAdapter adapter = new SqlDataAdapter(query + " AND " + ara + " like '%" + yer + "%'", baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridCari.DataSource = tablo;
                GridCari.Columns[0].Visible = false;
                GridCari.Columns[1].HeaderText = "Cari Kodu";
                GridCari.Columns[2].HeaderText = "Ticari Ünvanı";
                GridCari.Columns[3].HeaderText = "Vergi Numarası";
                GridCari.Columns[4].HeaderText = "Kara Listede";
            }
        }

        private void CariSec_Load(object sender, EventArgs e)
        {
            ToList();

        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            int selectedrowindex = GridCari.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = GridCari.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);
            if (cellValue != "")
            {
                ((TahsilatGirisi)TahsilatGiris).lblTicariUnvani.Text = selectedRow.Cells["CommercialTitle"].Value.ToString();
                ((TahsilatGirisi)TahsilatGiris).lblCariKod.Text = selectedRow.Cells["ClientCode"].Value.ToString();
                this.Close();
            }
            else
                MetroFramework.MetroMessageBox.Show(this,"Lütfen sayfadan işlem yapılacak cariyi belirleyiniz..", "Lütfen Kayıt seçiniz",MessageBoxButtons.RetryCancel,MessageBoxIcon.Hand);
            
        }
    }
}
