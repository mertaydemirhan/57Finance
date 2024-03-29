﻿using _57Finance.Cari.Raporlar;
using _57Finance.Diger.Doviz;
using _57Finance.Hizmet;
using _57Finance.Hizmet.Raporlar;
using _57Finance.Faturalar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _57Finance.Model;

namespace _57Finance
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cariTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariTanim Ct = new CariTanim(null);
            Ct.Show();
        }


        private void tahsilatGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TahsilatGirisi tahGiris = new TahsilatGirisi();
            tahGiris.Show();
        }

        private void tediyeGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TediyeGirisi tedGiris = new TediyeGirisi();
            tedGiris.Show();

        }

        private void CariListesiMenuStrip_Click(object sender, EventArgs e)
        {
            CariListesi CrList = new CariListesi();
            CrList.Show();

        }

        private void cariHareketRaporuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHR chr = new CHR();
            chr.Show();
        }

        private void dövizTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geçmişKurlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GecmisKurlar GcKurlar = new GecmisKurlar();
            GcKurlar.Show();
        }

        private void alisFaturasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlisFaturasi AlisFaturasi = new AlisFaturasi(); 
            AlisFaturasi.Show();
        }

        private void SatisFaturasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisFaturasi StFaturasi = new SatisFaturasi();
            StFaturasi.Show();
        }

        private void masrafFaturasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasrafFaturasi mfFaturasi = new MasrafFaturasi();
            mfFaturasi.Show();
        }




        private void faturaRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaRapor faturaRapor = new FaturaRapor();
            faturaRapor.Show();
        }
        private void btnMainClientDefinition_Click(object sender, EventArgs e)
        {
            CariTanim ct = new CariTanim(null);
            ct.Show();
        }

        private void btnMainClientReport_Click(object sender, EventArgs e)
        {
            CariListesi Cl = new CariListesi();
            Cl.Show();
        }

        private void btnMainCollection_Click(object sender, EventArgs e)
        {
            TahsilatGirisi TG = new TahsilatGirisi();
            TG.Show();
        }

        private void btnMainPayment_Click(object sender, EventArgs e)
        {
            TediyeGirisi TedGr = new TediyeGirisi();
            TedGr.Show();
        }

        private void btnMainTransactions_Click(object sender, EventArgs e)
        {
            CHR CHR = new CHR();
            CHR.Show();
        }


        private void btnMainForexRates_Click(object sender, EventArgs e)
        {
            GecmisKurlar GcKur = new GecmisKurlar();
            GcKur.Show();
        }

        private void btnMainPurchaseInvoice_Click(object sender, EventArgs e)
        {
            AlisFaturasi alfat = new AlisFaturasi();
            alfat.Show();
        }

        private void btnMainSaleInvoice_Click(object sender, EventArgs e)
        {
            SatisFaturasi satfat = new SatisFaturasi();
            satfat.Show();
        }

        private void btnMainExpenseInvoice_Click(object sender, EventArgs e)
        {
            MasrafFaturasi mfFat = new MasrafFaturasi();
            mfFat.Show();
        }


        private void btnMainInvoiceReport_Click(object sender, EventArgs e)
        {
            FaturaRapor FatRapor = new FaturaRapor();
            FatRapor.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Departmanlar Dept = new Departmanlar();
            Dept.Show();
        }

        private void btnBkyListesi_Click(object sender, EventArgs e)
        {
            BakiyelerListesi BkList = new BakiyelerListesi();
            BkList.Show();
        }

        private void bakiyelerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBkyListesi_Click(sender, e);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnHizmet_Click(object sender, EventArgs e)
        {
            HizmetTanim HzTanim = new HizmetTanim();
            HzTanim.Show();
        }

        private void btnHizmetList_Click(object sender, EventArgs e)
        {
            HizmetRaporu HzRapor = new HizmetRaporu();
            HzRapor.Show();
        }

        private void hizmetTanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnHizmet_Click(sender, e);
        }

        private void hizmetTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnHizmetList_Click(sender, e);
        }
    }
}
