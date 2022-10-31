using MetroFramework;
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


namespace _57Finance.Diger.Doviz
{
    public partial class Departmanlar : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        SqlCommand komut;

        public Departmanlar()
        {
            InitializeComponent();
        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {
            Duzenlenentext.Visible = false;
            lblID.Text = "";
            lblID.Visible = false;
            listele();
        }

        private void listele()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            baglanti.Open();
            DataTable table2 = new DataTable();
            sqlAdapter = new SqlDataAdapter($"select * from Departments WHERE DepartmentName is not null", baglanti);
            sqlAdapter.Fill(table2);
            gridDept.DataSource = table2;
            baglanti.Close();
            gridDept.Columns[0].Visible = false;
            gridDept.Columns[1].HeaderText = "Departman Adı";
        }

        private void btnDeptDuzenle_Click(object sender, EventArgs e)
        {
            if (gridDept.SelectedCells.Count > 0)
            {
                int selectedrowindex = gridDept.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridDept.Rows[selectedrowindex];
                string cellID = Convert.ToString(selectedRow.Cells["ID"].Value);
                string cellName = Convert.ToString(selectedRow.Cells["DepartmentName"].Value);
                if (cellID != "")
                {
                    lblID.Text = cellID;
                    Duzenlenentext.Visible = true;
                    lblID.Visible = true;
                    txtDepartman.Text = cellName;
                    btnKaydet.ButtonText = "Düzenlemeyi Bitir";

                }
            }
        }


        private void UpdateDept(int indexno)
        {

            if (btnKaydet.ButtonText == "Düzenlemeyi Bitir")
            {
                if (string.IsNullOrEmpty(txtDepartman.Text.Trim())) { MetroMessageBox.Show(this, "Departman Adı Boş olmamalıdır.", "Departman Adı Boş.", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                komut = new SqlCommand($"Update  Departments Set DepartmentName=N'{txtDepartman.Text.Trim()}' WHERE ID={indexno}", baglanti);
                komut.ExecuteScalar();
                baglanti.Close();
                //MetroMessageBox.Show(this,"isim soyisim alanı veya telefon alanı boş olmamalıdır...","t",MessageBoxIcon.Question);
                listele();
                btnKaydet.ButtonText = "Kaydet";
                lblID.Text = "";
                Duzenlenentext.Visible = false;
                lblID.Visible = false;
                txtDepartman.Text = "";
            }

        }
        private void AddUpdateDept()
        {
            if (btnKaydet.ButtonText == "Kaydet")
            {
                if(string.IsNullOrEmpty(txtDepartman.Text.Trim())) { MetroMessageBox.Show(this, "Departman Adı Boş olmamalıdır.", "Departman Adı Boş.", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                komut = new SqlCommand($"INSERT INTO Departments(DepartmentName) VALUES(N'{txtDepartman.Text.Trim()}')", baglanti);
                komut.ExecuteScalar();
                baglanti.Close();
                //MetroMessageBox.Show(this,"isim soyisim alanı veya telefon alanı boş olmamalıdır...","t",MessageBoxIcon.Question);
                listele();
                btnKaydet.ButtonText = "Kaydet";
                lblID.Text = "";
                Duzenlenentext.Visible = false;
                lblID.Visible = false;
                txtDepartman.Text = "";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            switch (lblID.Text)
            {
                case "":
                    AddUpdateDept();
                    break;
                default:
                    UpdateDept(Convert.ToInt32(lblID.Text));
                    break;
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (gridDept.SelectedCells.Count > 0)
            {
                int selectedrowindex = gridDept.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridDept.Rows[selectedrowindex];
                string cellID = Convert.ToString(selectedRow.Cells["ID"].Value);
                string cellName = Convert.ToString(selectedRow.Cells["DepartmentName"].Value);
                if (cellID != "")
                {
                    baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                    baglanti.Open();
                    string sql = "SELECT COUNT(CT.ID) FROM ClientTransactions CT JOIN Clients C on(C.ID = CT.ClientID) JOIN Departments D on(C.DepartmentID = D.ID) WHERE D.ID = 2";
                    SqlCommand cmd = new SqlCommand(sql, baglanti);
                    Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    if (count > 0) { MetroFramework.MetroMessageBox.Show(this, "Hareketleri olan departman silinememektedir. Lütfen Önce hareketleri siliniz ve ya değiştiriniz.", "Departman Silinemedi !!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    komut = new SqlCommand($"DELETE FROM Departments WHERE ID={cellID}", baglanti);
                    komut.ExecuteScalar();
                    baglanti.Close();
                    listele();

                }
            }

        }
    }
}
