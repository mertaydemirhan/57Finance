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
using MetroFramework;

namespace _57Finance.Hizmet
{
    public partial class HizmetTanim : Form
    {
        Setters Setters = new Setters();
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlCommand komut;
        ServiceInfo SrvcInfo;
        public HizmetTanim()
        {
            InitializeComponent();
        }
        public HizmetTanim(ServiceInfo Info)
        {
            InitializeComponent();
            SrvcInfo = Info;
        }

        private void HizmetTanim_Load(object sender, EventArgs e)
        {
            cmbDvzTuru.Enabled = false;
            if(SrvcInfo != null)
            {
                txtHizmetAdi.Text = SrvcInfo.ServiceName;
                txtHizmetKodu.Text = SrvcInfo.ServiceCode;
                SrvcInfo.Forex = SrvcInfo.Forex.Trim();
                if (SrvcInfo.Forex != "")
                {
                    txtFiyat.Text = SrvcInfo.FPrice.ToString();
                    cmbDvzTuru.SelectedIndex = cmbDvzTuru.FindString(SrvcInfo.Forex);
                    cmbDvzTuru.Enabled = true;
                    rdDoviz.Checked = true;
                } else
                {
                    txtFiyat.Text = SrvcInfo.Price.ToString();
                    rdTL.Checked = true;
                    
                }
                txtMuhSatisKodu.Text = SrvcInfo.ServiceAccSale;
                txtAlisMuhKodu.Text = SrvcInfo.ServiceAccBuy;
                rchComment.Text = SrvcInfo.Comment;
                cmbKDV.SelectedIndex = cmbKDV.FindString(SrvcInfo.VATRate.ToString());


            }
            else
            {
                txtHizmetKodu.Text = Setters.GetDocNumber("HizmetTanim","HTKey");
                cmbKDV.SelectedIndex = 18;
            }
            
        }


        private void txtHizmetKodu_Click(object sender, EventArgs e)
        {

        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            baglanti.Open();
            if (SrvcInfo == null)
                komut = new SqlCommand($"INSERT INTO Services(ServiceCode,ServiceName,Price,VATRate,Comment,ServiceAccSale,ServiceAccBuy,FPrice,Forex) " +
                                                $"VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            if (SrvcInfo != null)
                komut = new SqlCommand($"UPDATE Services SET ServiceName=@p1,ServiceCode=@p2,Price=@p3,VATRate=@p4,Comment=@p5,ServiceAccSale=@p6,ServiceAccBuy=@p7,FPrice=@p8,Forex=@p9 WHERE ID={SrvcInfo.ID}", baglanti);
            komut.Parameters.AddWithValue("@p1", txtHizmetKodu.Text.Trim());
            komut.Parameters.AddWithValue("@p2", txtHizmetAdi.Text.Trim());
            if (!rdDoviz.Checked)
                komut.Parameters.AddWithValue("@p3", Convert.ToDouble(txtFiyat.Text.Trim()));
            else
                komut.Parameters.AddWithValue("@p3", 0.00);
            komut.Parameters.AddWithValue("@p4", Convert.ToInt32(cmbKDV.SelectedItem.ToString().Trim()));
            komut.Parameters.AddWithValue("@p5", rchComment.Text.Trim());
            komut.Parameters.AddWithValue("@p6", txtMuhSatisKodu.Text.Trim());
            komut.Parameters.AddWithValue("@p7", txtAlisMuhKodu.Text.Trim());
            if(!rdTL.Checked)
                komut.Parameters.AddWithValue("@p8", Convert.ToDouble(txtFiyat.Text.Trim()));
            else
                komut.Parameters.AddWithValue("@p8", 0.00);
            if (rdDoviz.Checked)
                komut.Parameters.AddWithValue("@p9", cmbDvzTuru.SelectedItem.ToString().Trim());
            else
                komut.Parameters.AddWithValue("@p9", "");
            komut.ExecuteScalar();
            Setters.WriteDocNumber("HizmetTanim", "HTKey");
            baglanti.Close();
            if (SrvcInfo == null)
                MetroMessageBox.Show(this, "Hizmet Kodu :" + txtHizmetKodu.Text.Trim() + "\n Hizmet Adı : " + txtHizmetAdi.Text.Trim() + "\n Kayıt başarıyla eklenmiştir.", "Kaydetme Başarılı ✓", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SrvcInfo != null)
                MetroMessageBox.Show(this, "Hizmet Kodu :" + txtHizmetKodu.Text.Trim() + "\n Hizmet Adı : " + txtHizmetAdi.Text.Trim() + "\n Kayıt başarıyla değiştirilmiştir..", " Değiştirme Başarılı ✓", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtHizmetKodu.Text = Setters.GetDocNumber("HizmetTanim", "HTKey");
            txtHizmetAdi.Text = "";
            txtFiyat.Text = "";
            cmbDvzTuru.SelectedText = "";
            cmbDvzTuru.Enabled = false;
            rdTL.Checked = false;
            rdDoviz.Checked = false;
            rchComment.Text = "";
            txtMuhSatisKodu.Text = "";
            txtAlisMuhKodu.Text = "";
            txtHizmetKodu.Text = Setters.GetDocNumber("HizmetTanim", "HTKey");
            cmbKDV.SelectedIndex = 18;

        }

        private void rdDoviz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDoviz.Checked)
                cmbDvzTuru.Enabled = true;
        }

        private void rdTL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTL.Checked)
                cmbDvzTuru.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SrvcInfo != null)
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                komut = new SqlCommand($"Update Client SET IsActive=0 Where ID={SrvcInfo.ID}", baglanti);
                komut.ExecuteScalar();
                baglanti.Close();
                MetroMessageBox.Show(this, "Hizmet Adı :" + SrvcInfo.ServiceName.Trim() + "\n Hizmet Kodu : " + SrvcInfo.ServiceCode.Trim() + "\n Kayıt başarıyla silindi.", "Başarılı ✓");
            }
            else
                MessageBox.Show("Hizmet sisteme kayıtlı görünmüyor. \n Hizmet listesinden bu hizmetin kayıtlı olduğunu doğrulayınız...", "Veritabanı Sorgusu Boş !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
