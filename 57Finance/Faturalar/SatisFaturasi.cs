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
using _57Finance.Diger.Cari;
using _57Finance.Diger.Hizmet;
using MetroFramework;
using System.Windows.Controls;

namespace _57Finance
{
    public partial class SatisFaturasi : Form
    {
        public string ClientID, FaturaNo, ClientForex;
        Setters zetters = new Setters();
        Invoice invoice = null;
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        SqlCommand komut;
        DataSet ds;
        public int FatID = 0;
        private decimal FatAmountTL = 0, FatAmountForex = 0;
        public SatisFaturasi()
        {
            InitializeComponent();
        }


        public SatisFaturasi(Invoice Inv)
        {
            InitializeComponent();
            invoice = Inv;
        }
        private void GetInvoiceType()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(3, "Satış Faturası");
            comboSource.Add(4, "Satıştan İade Faturası");

            cmbFaturaTur.DataSource = new BindingSource(comboSource, null);
            cmbFaturaTur.DisplayMember = "Value";
            cmbFaturaTur.ValueMember = "Key";
            cmbFaturaTur.SelectedIndex = 0;
        }

        private void SatisFaturasi_Load(object sender, EventArgs e)
        {
            if (invoice == null)
            {
                FatID = Convert.ToInt32(zetters.GetInvoiceID());
                FaturaNo = zetters.GetDocNumber("SatisFaturasi", "SFKey");
                grpHareket.Enabled = false;
                lblClientCode.Visible = false;
                lblCommercialTitle.Visible = false;
                lblTaxNo.Visible = false;
                lblTaxOffice.Visible = false;
                BindDataDepartment();
                cmbDepartman.SelectedIndex = 4;
                cmbFatKDV.SelectedIndex = 18;
                cmbDepartman.SelectedIndex = 0;
                GetInvoiceType();
                txtFaturaNo.Text = FaturaNo;
            }
            else
            {
                FatID = invoice.InvoiceID;
                FaturaNo = invoice.InvoiceNo;
                txtFaturaNo.Text = invoice.InvoiceNo;
                ClientID = invoice.ClientID.ToString();
                lblClientCode.Text = invoice.ClientCode;
                lblCommercialTitle.Text = invoice.ClientCommercialTitle;
                lblTaxNo.Text = invoice.TaxNo;
                lblTaxOffice.Text = invoice.TaxOffice;
                GridHrCek();
            }
        }


        private void BindDataDepartment()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            baglanti.Open();
            DataTable table4 = new DataTable();
            sqlAdapter = new SqlDataAdapter("select DepartmentName,ID from Departments Order By DepartmentName ASC", baglanti);
            sqlAdapter.Fill(table4);
            cmbDepartman.DataSource = table4;
            baglanti.Close();
        }



        private void btnCariSec_Click(object sender, EventArgs e)
        {
            CariSec CariSec = new CariSec(4);
            CariSec.Show();
        }        

        private void lblClientCode_TextChanged(object sender, EventArgs e)
        {
            if (lblClientCode.Text != "0")
            {
                lblClientCode.Visible = true;
                grpHareket.Enabled = true;
                if(invoice == null)
                    GridHrCek();
            }
        }
        private void lblCommercialTitle_TextChanged(object sender, EventArgs e)
        {
            if (lblCommercialTitle.Text != "0")
                lblCommercialTitle.Visible = true;
        }
        private void lblTaxNo_TextChanged(object sender, EventArgs e)
        {
            if (lblTaxNo.Text != "0")
                lblTaxNo.Visible = true;
        }
        private void lblTaxOffice_TextChanged(object sender, EventArgs e)
        {
            if (lblTaxOffice.Text != "0")
                lblTaxOffice.Visible = true;
        }
        private void GridHrCek()    // Grid yaratıldıktan sonra çalışan kod bloğu....
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = "";
            if (invoice == null)
                query = $"SELECT ID,InvoiceID,ServiceCode,ServiceName,Qty,Price,Forex,ForexRateBuy,ForexRateSell,FPrice,PriceTotal FROM dbo.InvoiceTransactions WHERE 1=1 AND InvoiceID={FatID} ";
            else
                query = $"SELECT ID,InvoiceID,ServiceCode,ServiceName,Qty,Price,Forex,ForexRateBuy,ForexRateSell,FPrice,PriceTotal FROM dbo.InvoiceTransactions WHERE 1=1 AND InvoiceID={invoice.InvoiceID}";

            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridHr.DataSource = tablo;
            GridHr.Columns[0].Visible = false; //Cari ID
            GridHr.Columns[1].Visible = false; //Fatura ID
            GridHr.Columns[2].HeaderText = "Hizmet Kodu";
            GridHr.Columns[3].HeaderText = "Hizmet Adı";
            GridHr.Columns[4].HeaderText = "Miktarı";
            GridHr.Columns[5].HeaderText = "TL Fiyat";
            GridHr.Columns[6].HeaderText = "Dvz Birimi";
            GridHr.Columns[7].HeaderText = "Alış Kuru";
            GridHr.Columns[8].HeaderText = "Satış Kuru";
            GridHr.Columns[9].HeaderText = "Dvz. Tutarı";
            GridHr.Columns[10].HeaderText = "Toplam Fiyat";
        }
        private void btnHrkEkle_Click(object sender, EventArgs e)
        {
            HizmetSec HzSec = new HizmetSec(2);
            HzSec.Show();
        }
        private void btnHrkSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridHr.SelectedRows)
            {
                GridHr.Rows.Remove(row);
            }
        }
        private void GridHr_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotalPrice(e.RowIndex);
        }
        private void GridHr_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                double Qty = 0;
                double TLPrice = 0;
                double FPrice = 0;
                double FBuy = 0;

                DataGridViewRow row = GridHr.Rows[e.RowIndex];
                if (!string.IsNullOrEmpty(row.Cells[4].Value.ToString()))
                    Qty = Convert.ToDouble(row.Cells[4].Value);
                if (!string.IsNullOrEmpty(row.Cells[5].Value.ToString()))
                    TLPrice = Convert.ToDouble(row.Cells[5].Value);
                if (!string.IsNullOrEmpty(row.Cells[9].Value.ToString()))
                    FPrice = Convert.ToDouble(row.Cells[9].Value);
                if (!string.IsNullOrEmpty(row.Cells[7].Value.ToString()))
                    FBuy = Convert.ToDouble(row.Cells[7].Value);

                if (Qty > 0 && TLPrice > 0)
                    row.Cells[10].Value = Qty * TLPrice;
                if (Qty > 0 && FPrice > 0 && FBuy > 0)
                    row.Cells[10].Value = (FBuy * FPrice) * Qty;
                CalculateTotalPrice(e.RowIndex);
            }
        }
        private void CalculateTotalPrice(int rowindex)
        {
            double BeforeTotalTL = 0, BeforeTotalF = 0;
            DataGridViewRow row = GridHr.Rows[rowindex];
            if (row.Cells.Count > 10)
            {
                if (row.Cells[9].Value != null && row.Cells[10].Value != null)
                {
                    try
                    {
                        BeforeTotalF = GridHr.Rows.Cast<DataGridViewRow>()
                            .Sum(t => Convert.ToDouble(t.Cells[9].Value));
                        BeforeTotalTL = GridHr.Rows.Cast<DataGridViewRow>()
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
            
            //(string.Format("{0:#.00}", Convert.ToDecimal(totalpriceTL) / 100));
            if(invoice != null)
            {
                lblKDV.Text = String.Format("{0:C}", invoice.VAT);
                lblKDVsizToplam.Text = String.Format("{0:C}", invoice.Amount);
                lblToplamTL.Text = String.Format("{0:C}", invoice.AmountWithVAT);
                lblToplamDvz.Text = String.Format("{0:C}", BeforeTotalF);
            }                
            else
            {
                lblKDV.Text = String.Format("{0:C}",  ((FatAmountTL / 100) * Convert.ToInt16(cmbFatKDV.SelectedItem)));
                lblKDVsizToplam.Text = String.Format("{0:C}", FatAmountTL - ((FatAmountTL / 100) * Convert.ToInt16(cmbFatKDV.SelectedItem)));
                lblToplamTL.Text = String.Format("{0:C}", BeforeTotalTL);
                lblToplamDvz.Text = String.Format("{0:C}", BeforeTotalF);
            }

        }  // Grid işlemlerinde tekrar toplamayı yapan fonksiyon....
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroMessageBox.Show(this, "Silinsin mi?", "Ekranda gördüğünüz faturayı silmek istediğinizden emin misiniz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                komut = new SqlCommand($"DELETE FROM Invoices WHERE ID={FatID};  DELETE FROM InvoiceTransactions WHERE InvoiceID={FatID}", baglanti);
                komut.ExecuteScalar();
                baglanti.Close();
                MetroMessageBox.Show(this, "Kayıt başarı ile silindi...\nFatura Numarası : " + txtFaturaNo.Text.Trim(), "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                invoice = null;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void grpHareket_Enter(object sender, EventArgs e)
        {

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (GridHr.Rows.Count > 1)
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                decimal TotalAmount1 = ((FatAmountTL / 100) * Convert.ToInt16(cmbFatKDV.SelectedItem)) + FatAmountTL;
                if (invoice == null)
                    komut = new SqlCommand($"INSERT INTO Invoices(ClientID,InvoiceNo,InvoiceType,InvoiceDate,InvoiceDetail,VATRate,Amount,DepartmentID,AmountWithVAT,TotalAmount,VATBasis,Forex,ForexAmount,TotalAmountForex) " +
                                                    $"VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p12,@p13,@p14,@p15)", baglanti);
                if (invoice != null)
                    komut = new SqlCommand($"UPDATE Invoices SET ClientID=@p1,InvoiceNo=@p2,InvoiceType=@p3,InvoiceDate=@p4,InvoiceDetail=@p5,VATRate=@p6,Amount=@p7," +
                                           $"DepartmentID=@p8,AmountWithVAT=@p9,TotalAmount=@p10,VATBasis=@p12,Forex=@p13,ForexAmount=@p14,TotalAmountForex=@p15 WHERE ID={invoice.InvoiceID}", baglanti);
                komut.Parameters.AddWithValue("@p1", ClientID);
                komut.Parameters.AddWithValue("@p2", FaturaNo);
                komut.Parameters.AddWithValue("@p3", cmbFaturaTur.SelectedValue);  // Invoice Type (Fatura Türü) = Alış faturası =1 , Alıştan İade = 2, Satış faturası = 3, Satıştan iade = 4, Masraf = 5
                komut.Parameters.AddWithValue("@p4", dtFaturaTarihi.Value);
                komut.Parameters.AddWithValue("@p5", rcAciklama.Text.Trim());  // Tahsilat = 1, Tediye = 2, Alış fat =3, satış fat = 4, Masraf = 5, Alıştan iade = 6, satıştan iade =7
                komut.Parameters.AddWithValue("@p6", cmbFatKDV.SelectedItem.ToString().Trim());
                komut.Parameters.AddWithValue("@p7", FatAmountTL);
                komut.Parameters.AddWithValue("@p8", cmbDepartman.SelectedValue);
                komut.Parameters.AddWithValue("@p9", TotalAmount1);
                komut.Parameters.AddWithValue("@p10", TotalAmount1);
                komut.Parameters.AddWithValue("@p12", FatAmountTL);
                komut.Parameters.AddWithValue("@p13", ClientForex.ToString().Trim());
                komut.Parameters.AddWithValue("@p14", FatAmountForex);
                komut.Parameters.AddWithValue("@p15", FatAmountForex);
                komut.ExecuteScalar();
                checkRecords(FatID);    // Eklenen faturaya ait fatura hareketi var mıydı? eğer var ise tamamını sil ve gridtekileri database'ye bas işlemi....
                InsertInvoiceTransactions();  // Eklenen faturaya ait fatura hareketleri silindiğinde şu an gridde bulunanları ayrı fonksiyondan çekiyoruz...
                baglanti.Close();
                zetters.WriteDocNumber("SatisFaturasi", "SFKey");
                this.Close();
            }
            else
                MetroMessageBox.Show(this, "\nKaydedilecek fatura hareketi bulunamadı. \nbu sebeple fatura kaydedilemedi.", "Lütfen Fatura için hareket giriniz...", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
        }
        private void checkRecords(int InvID)
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = "";
            query = $"SELECT ID,InvoiceID,ServiceCode,ServiceName,Qty,Price,Forex,ForexRateBuy,ForexRateSell,FPrice,PriceTotal FROM dbo.InvoiceTransactions WHERE 1=1 AND InvoiceID={InvID}";

            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);

            if (ds.Tables[0].Rows.Count > 0)
            {
                SqlCommand sqlcmd = new SqlCommand($"DELETE FROM dbo.InvoiceTransactions where InvoiceID={InvID}", baglanti);
                komut.ExecuteScalar();
            }
        }
        private void InsertInvoiceTransactions()
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand($"INSERT INTO InvoiceTransactions(InvoiceID,ServiceCode,ServiceName,Qty,Price,Forex,ForexRateBuy,ForexRateSell,FPrice,PriceTotal) " +
                                    $"VALUES(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", baglanti);
            for (int i = 0; i < GridHr.Rows.Count; i++)
            {
                if (GridHr.Rows[i].Cells["ID"].Value != null)
                {
                    cmd.Parameters.AddWithValue("@a1", FatID);
                    cmd.Parameters.AddWithValue("@a2", GridHr.Rows[i].Cells["ServiceCode"].Value.ToString());
                    cmd.Parameters.AddWithValue("@a3", GridHr.Rows[i].Cells["ServiceName"].Value.ToString());
                    cmd.Parameters.AddWithValue("@a4", GridHr.Rows[i].Cells["Qty"].Value);
                    cmd.Parameters.AddWithValue("@a5", GridHr.Rows[i].Cells["Price"].Value);
                    cmd.Parameters.AddWithValue("@a6", GridHr.Rows[i].Cells["Forex"].Value.ToString());
                    cmd.Parameters.AddWithValue("@a7", GridHr.Rows[i].Cells["ForexRateBuy"].Value);
                    cmd.Parameters.AddWithValue("@a8", GridHr.Rows[i].Cells["ForexRateSell"].Value);
                    cmd.Parameters.AddWithValue("@a9", GridHr.Rows[i].Cells["FPrice"].Value);
                    cmd.Parameters.AddWithValue("@a10", GridHr.Rows[i].Cells["PriceTotal"].Value);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    cmd.Parameters.Clear();
                }
            }

        }
    }
}
