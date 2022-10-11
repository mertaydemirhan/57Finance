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
using System.Windows.Controls;
using System.Windows.Forms;
using _57Finance.Model;

namespace _57Finance
{
    public partial class CariTanim : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        SqlCommand komut;
        DataSet ds;
        ClientInfo info;
        public CariTanim()
        {
            InitializeComponent();
        }

        public CariTanim(ClientInfo INFO)
        {
            InitializeComponent();
            info = INFO;
        }
        private void CariTanim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnKaydet_Click(sender, e);
        }

        private void CariTanim_Load(object sender, EventArgs e)
        {
            if (info == null)
            {
                BindDataUlkesi();
                cmbUlkesi.SelectedValue = 223;
                BindData_ili();
                cmbili.SelectedValue = 3703;
                BindDataDepartment();
                chkKaraListe.Checked = false;
            }
            if (info != null)
            {
                lblID.Text = info.ID.ToString();
                BindDataUlkesi();
                BindDataDepartment();
                cmbUlkesi.SelectedIndex = cmbUlkesi.FindString(info.Country);
                BindData_ili();
                cmbili.SelectedIndex = cmbili.FindString(info.City);
                cmbDepartman.SelectedValue = info.DepartmentID;
                txtCariKodu.Text = info.ClientCode;
                txtAdres.Text = info.Adress;
                txtAlisMuhKodu.Text = info.ClientAccBuy;
                txtilcesi.Text = info.District;
                txtSatisMuhKodu.Text = info.ClientAccSale;
                txtTicariUnvani.Text = info.CommercialTitle;
                txtVergiDairesi.Text = info.TaxOffice;
                txtVergiNo.Text = info.TaxNo.ToString();
                chkKaraListe.Checked = info.IsBlackListed;

            }
        }

        private void cmbUlkesi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbUlkesi.SelectedValue.ToString()) && info == null)
            {
                cmbili.Enabled = true;
                BindData_ili();
            }
        }
        private void cmbili_TextChanged(object sender, EventArgs e)
        {
        }
        public void GetInfo()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo1 = new DataTable();
            tablo1.Clear();
            ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter($"select * from Clients where IsAktif=1 AND ID={lblID.Text.Trim()}", baglanti);
            adapter.Fill(tablo1);
            ds.Merge(tablo1);
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
        public void BindDataUlkesi()
        {

            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            baglanti.Open();
            DataTable table1 = new DataTable();
            sqlAdapter = new SqlDataAdapter("select name,id from countries", baglanti);
            sqlAdapter.Fill(table1);
            cmbUlkesi.DataSource = table1;
            baglanti.Close();

        }
        public void BindData_ili()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            baglanti.Open();
            DataTable table2 = new DataTable();
            sqlAdapter = new SqlDataAdapter($"select name,id from states where country_id={cmbUlkesi.SelectedValue}", baglanti);
            sqlAdapter.Fill(table2);
            cmbili.DataSource = table2;
            baglanti.Close();

        }
 
        public void CheckClientCode()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            /// will prepare.......
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            baglanti.Open();
            if(info == null)
                komut = new SqlCommand($"INSERT INTO Clients(ClientCode,CommercialTitle,Adress,Country,City,District,ClientAccSale,ClientAccBuy,DepartmentID,TaxNo,TaxOffice,IsBlackListed,IsActive) " +
                                                $"VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,1)", baglanti);
            if (info != null)
                komut = new SqlCommand($"UPDATE Clients SET ClientCode=@p1,CommercialTitle=@p2,Adress=@p3,Country=@p4,City=@p5,District=@p6,ClientAccSale=@p7,ClientAccBuy=@p8,DepartmentID=@p9," +
                                       $"TaxNo=@p10,TaxOffice=@p11,IsBlackListed=@p12 WHERE ID={lblID.Text}",baglanti);
            komut.Parameters.AddWithValue("@p1",  txtCariKodu.Text.Trim());
            komut.Parameters.AddWithValue("@p2",  txtTicariUnvani.Text.Trim());
            komut.Parameters.AddWithValue("@p3",  txtAdres.Text.Trim());
            komut.Parameters.AddWithValue("@p4",  cmbUlkesi.Text.Trim());
            komut.Parameters.AddWithValue("@p5",  cmbili.Text.Trim());
            komut.Parameters.AddWithValue("@p6",  txtilcesi.Text.Trim());
            komut.Parameters.AddWithValue("@p7",  txtSatisMuhKodu.Text.Trim());
            komut.Parameters.AddWithValue("@p8",  txtAlisMuhKodu.Text.Trim());
            komut.Parameters.AddWithValue("@p9",  cmbDepartman.SelectedValue);
            komut.Parameters.AddWithValue("@p10", txtVergiNo.Text.Trim());
            komut.Parameters.AddWithValue("@p11", txtVergiDairesi.Text.Trim());
            komut.Parameters.AddWithValue("@p12", chkKaraListe.Checked.ToString());
            komut.ExecuteScalar();
            baglanti.Close();
            if(info==null)
                MetroMessageBox.Show(this, "Ticari Unvanı :"+txtTicariUnvani.Text.Trim()+"\n Cari Kodu : "+txtCariKodu.Text.Trim()+"\n Kayıt başarıyla eklenmiştir.", "Kaydetme Başarılı ✓",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(info != null)
                MetroMessageBox.Show(this, "Ticari Unvanı :" + txtTicariUnvani.Text.Trim() + "\n Cari Kodu : " + txtCariKodu.Text.Trim() + "\n Kayıt başarıyla değiştirilmiştir..", " Değiştirme Başarılı ✓", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCariKodu.Text = null;
            txtTicariUnvani.Text = "";
            txtAdres.Text = "";
            cmbUlkesi.SelectedText = "";
            cmbili.SelectedText = "";
            txtilcesi.Text = "";
            txtSatisMuhKodu.Text = "";
            txtAlisMuhKodu.Text = "";
            cmbDepartman.SelectedText = "";
            txtVergiNo.Text = "";
            txtVergiDairesi.Text = "";
            chkKaraListe.Checked = false;
            
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "0")
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                komut = new SqlCommand($"Update Client SET IsActive=0 Where ID={lblID.Text.Trim()}", baglanti);
                komut.ExecuteScalar();
                baglanti.Close();
                MetroMessageBox.Show(this, "Ticari Unvanı :" + txtTicariUnvani.Text.Trim() + "\n Cari Kodu : " + txtCariKodu.Text.Trim() + "\n Kayıt başarıyla silindi.", "Başarılı ✓");
            }
            else
                MessageBox.Show("Cari sisteme kayıtlı görünmüyor. \nCari listesinden bu carinin olduğunu doğrulayınız...", "Veritabanı Sorgusu Boş !", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbUlkesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
