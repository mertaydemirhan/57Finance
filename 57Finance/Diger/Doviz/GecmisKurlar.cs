﻿using System;
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
    public partial class GecmisKurlar : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        DataSet ds;
        public GecmisKurlar()
        {
            InitializeComponent();
        }

        private void GecmisKurlar_Load(object sender, EventArgs e)
        {
            ToList();
        }

        private void ToList() {

            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            string query = $"SELECT * from DovizKurlari ORDER BY Tarih ASC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridForex.DataSource = tablo;

        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                DataTable tablo = new DataTable();
                tablo.Clear();
                ds = new DataSet();
                string query = $"Select * from DovizKurlari WHERE 1=1 ";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter = new SqlDataAdapter(query + " AND Isim like '%" + txtDoviz.Text.Trim() + $"%' AND Tarih=Convert(Date,CAST('{dtTarih.Value.ToString("yyyy-MM-dd")}' AS DATE),103)", baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridForex.DataSource = tablo;
        }

        private void copyAlltoClipboard()
        {
            GridForex.SelectAll();
            DataObject dataObj = GridForex.GetClipboardContent();
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
