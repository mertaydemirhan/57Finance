using IniParser;
using IniParser.Model;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57Finance.Model
{
    public class Setters
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlCommand SQLCommand;
        DataSet ds;
        Forexes Forex = new Forexes();
        public string GetDocNumber(string Group, string Key)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            string useFullScreenStr = data[Group][Key];

            //parser.WriteFile("Configuration.ini", data);
            return useFullScreenStr;
        }
        public void WriteDocNumber(string Group, string Key)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("Configuration.ini");
            string DocumentNo = GetDocNumber(Group, Key);
            string docStart = DocumentNo.Substring(0, 2);
            DocumentNo = DocumentNo.Substring(2, DocumentNo.Length - 2);
            string GetFileNumber = Convert.ToString(Convert.ToDouble(DocumentNo) + 1).PadLeft(5, Convert.ToChar("0"));
            if (Group == "AlisFaturasi")
            {
                string InvoiceID = GetDocNumber(Group, "FatID");
                InvoiceID = Convert.ToString(Convert.ToInt32(InvoiceID) + 1);
                data[Group]["FatID"] = InvoiceID;
                parser.WriteFile("Configuration.ini", data);
            }
            data[Group][Key] = docStart + GetFileNumber;
            parser.WriteFile("Configuration.ini", data);
        }

        public string GetInvoiceID()
        {
            try
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                string query = "SELECT IDENT_CURRENT('invoices') + 1";
                SQLCommand = new SqlCommand(query,baglanti);
                //SQLCommand.Parameters.Add("USUsername", SqlDbType.VarChar).Value = CUSER;
                baglanti.Open();
                var USRole = SQLCommand.ExecuteScalar();
                baglanti.Close();

                return USRole.ToString();

            }
            catch (Exception)
            {                
                return "-1";
            }
        }


        public DataTable SendForexes(DateTime dt)
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo1 = new DataTable();
            tablo1.Clear();
            ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter($"select dovizAlis,DovizSatis,Currency from DovizKurlari where Currency IN('USD','EUR','GBP','AZN') AND CONVERT(date,Tarih,103)=CAST('{dt.ToString("yyyy-MM-dd")}' AS DATE)", baglanti);
            adapter.Fill(tablo1);
            ds.Merge(tablo1);            
           /* DataRow[] filteredRows = tablo1.Select("Isim like '%ABD DOLARI%'");
             forexes.Add(filteredRows[0].ItemArray[5].ToString());
            filteredRows = null;
            filteredRows = tablo1.Select("Isim like '%EURO%'");
            forexes.Add(filteredRows[0].ItemArray[5].ToString());
            filteredRows = null;
            filteredRows = tablo1.Select("Isim like '%INGILIZ STERLINI%'");
            forexes.Add(filteredRows[0].ItemArray[5].ToString());
            filteredRows = null;
            filteredRows = tablo1.Select("Isim like '%AZERBAYCAN YENI MANATI%'");*/

            return tablo1;
        }
    }
}
