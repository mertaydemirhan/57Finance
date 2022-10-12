namespace _57Finance
{
    partial class TahsilatGirisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahsilatGirisi));
            this.grpCariSec = new System.Windows.Forms.GroupBox();
            this.btnCariSec = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblTicariUnvani = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblCariKod = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpIslem = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtIslemTarihi = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTLTutar = new System.Windows.Forms.MaskedTextBox();
            this.grpDvz = new System.Windows.Forms.GroupBox();
            this.grpTL = new System.Windows.Forms.GroupBox();
            this.grpTur = new System.Windows.Forms.GroupBox();
            this.rdTL = new MetroFramework.Controls.MetroRadioButton();
            this.rdDoviz = new MetroFramework.Controls.MetroRadioButton();
            this.cmbDvzTuru = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDvzTutar = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.grpDvzBilgi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblazn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblgbp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TLtoAZN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TLtoGBP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TLtoEUR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TLtoUSD = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpCariSec.SuspendLayout();
            this.grpIslem.SuspendLayout();
            this.grpDvz.SuspendLayout();
            this.grpTL.SuspendLayout();
            this.grpTur.SuspendLayout();
            this.grpDvzBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCariSec
            // 
            this.grpCariSec.Controls.Add(this.btnCariSec);
            this.grpCariSec.Controls.Add(this.lblTicariUnvani);
            this.grpCariSec.Controls.Add(this.metroLabel2);
            this.grpCariSec.Controls.Add(this.lblCariKod);
            this.grpCariSec.Controls.Add(this.metroLabel1);
            this.grpCariSec.Location = new System.Drawing.Point(12, 12);
            this.grpCariSec.Name = "grpCariSec";
            this.grpCariSec.Size = new System.Drawing.Size(619, 104);
            this.grpCariSec.TabIndex = 0;
            this.grpCariSec.TabStop = false;
            this.grpCariSec.Text = "Cari Seçimi";
            // 
            // btnCariSec
            // 
            this.btnCariSec.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCariSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCariSec.color = System.Drawing.Color.SeaGreen;
            this.btnCariSec.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCariSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariSec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariSec.ForeColor = System.Drawing.Color.White;
            this.btnCariSec.Image = ((System.Drawing.Image)(resources.GetObject("btnCariSec.Image")));
            this.btnCariSec.ImagePosition = 16;
            this.btnCariSec.ImageZoom = 50;
            this.btnCariSec.LabelPosition = 32;
            this.btnCariSec.LabelText = "Cari Seç";
            this.btnCariSec.Location = new System.Drawing.Point(543, 9);
            this.btnCariSec.Margin = new System.Windows.Forms.Padding(6);
            this.btnCariSec.Name = "btnCariSec";
            this.btnCariSec.Size = new System.Drawing.Size(72, 92);
            this.btnCariSec.TabIndex = 4;
            this.btnCariSec.Click += new System.EventHandler(this.btnCariSec_Click);
            // 
            // lblTicariUnvani
            // 
            this.lblTicariUnvani.AutoSize = true;
            this.lblTicariUnvani.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTicariUnvani.Location = new System.Drawing.Point(97, 39);
            this.lblTicariUnvani.Name = "lblTicariUnvani";
            this.lblTicariUnvani.Size = new System.Drawing.Size(0, 13);
            this.lblTicariUnvani.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Ticari Ünvanı :";
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCariKod.Location = new System.Drawing.Point(87, 19);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(0, 13);
            this.lblCariKod.TabIndex = 1;
            this.lblCariKod.TextChanged += new System.EventHandler(this.lblCariKod_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cari Kodu :";
            // 
            // grpIslem
            // 
            this.grpIslem.Controls.Add(this.grpTur);
            this.grpIslem.Controls.Add(this.grpTL);
            this.grpIslem.Controls.Add(this.grpDvz);
            this.grpIslem.Controls.Add(this.richTextBox1);
            this.grpIslem.Controls.Add(this.metroLabel4);
            this.grpIslem.Controls.Add(this.dtIslemTarihi);
            this.grpIslem.Controls.Add(this.metroLabel3);
            this.grpIslem.Location = new System.Drawing.Point(12, 122);
            this.grpIslem.Name = "grpIslem";
            this.grpIslem.Size = new System.Drawing.Size(619, 251);
            this.grpIslem.TabIndex = 5;
            this.grpIslem.TabStop = false;
            this.grpIslem.Text = "İşlem";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveBorderThickness = 1;
            this.btnKaydet.ActiveCornerRadius = 20;
            this.btnKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.ButtonText = "Kaydet";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.IdleBorderThickness = 1;
            this.btnKaydet.IdleCornerRadius = 20;
            this.btnKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.Location = new System.Drawing.Point(12, 381);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(177, 52);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "İşlem Tarihi ";
            // 
            // dtIslemTarihi
            // 
            this.dtIslemTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIslemTarihi.Location = new System.Drawing.Point(100, 19);
            this.dtIslemTarihi.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtIslemTarihi.Name = "dtIslemTarihi";
            this.dtIslemTarihi.Size = new System.Drawing.Size(117, 29);
            this.dtIslemTarihi.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(307, 26);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Açıklama";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(375, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 57);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Tutar";
            // 
            // txtTLTutar
            // 
            this.txtTLTutar.Location = new System.Drawing.Point(48, 19);
            this.txtTLTutar.Mask = "0000000000";
            this.txtTLTutar.Name = "txtTLTutar";
            this.txtTLTutar.PromptChar = ' ';
            this.txtTLTutar.Size = new System.Drawing.Size(107, 20);
            this.txtTLTutar.TabIndex = 10;
            this.txtTLTutar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTLTutar_MaskInputRejected);
            this.txtTLTutar.TextChanged += new System.EventHandler(this.txtTLTutar_TextChanged);
            // 
            // grpDvz
            // 
            this.grpDvz.Controls.Add(this.grpDvzBilgi);
            this.grpDvz.Controls.Add(this.txtDvzTutar);
            this.grpDvz.Controls.Add(this.metroLabel7);
            this.grpDvz.Controls.Add(this.metroLabel6);
            this.grpDvz.Controls.Add(this.cmbDvzTuru);
            this.grpDvz.Location = new System.Drawing.Point(307, 120);
            this.grpDvz.Name = "grpDvz";
            this.grpDvz.Size = new System.Drawing.Size(308, 123);
            this.grpDvz.TabIndex = 11;
            this.grpDvz.TabStop = false;
            this.grpDvz.Text = "Dövizli İşlem";
            // 
            // grpTL
            // 
            this.grpTL.Controls.Add(this.groupBox1);
            this.grpTL.Controls.Add(this.txtTLTutar);
            this.grpTL.Controls.Add(this.metroLabel5);
            this.grpTL.Location = new System.Drawing.Point(18, 120);
            this.grpTL.Name = "grpTL";
            this.grpTL.Size = new System.Drawing.Size(283, 103);
            this.grpTL.TabIndex = 12;
            this.grpTL.TabStop = false;
            this.grpTL.Text = "TL İşlem";
            // 
            // grpTur
            // 
            this.grpTur.Controls.Add(this.rdDoviz);
            this.grpTur.Controls.Add(this.rdTL);
            this.grpTur.Location = new System.Drawing.Point(124, 80);
            this.grpTur.Name = "grpTur";
            this.grpTur.Size = new System.Drawing.Size(245, 41);
            this.grpTur.TabIndex = 13;
            this.grpTur.TabStop = false;
            this.grpTur.Text = "İşlem Türü";
            // 
            // rdTL
            // 
            this.rdTL.AutoSize = true;
            this.rdTL.Location = new System.Drawing.Point(12, 19);
            this.rdTL.Name = "rdTL";
            this.rdTL.Size = new System.Drawing.Size(69, 15);
            this.rdTL.TabIndex = 0;
            this.rdTL.Text = "TL işlemi";
            this.rdTL.UseSelectable = true;
            this.rdTL.CheckedChanged += new System.EventHandler(this.rdTL_CheckedChanged);
            // 
            // rdDoviz
            // 
            this.rdDoviz.AutoSize = true;
            this.rdDoviz.Location = new System.Drawing.Point(91, 19);
            this.rdDoviz.Name = "rdDoviz";
            this.rdDoviz.Size = new System.Drawing.Size(86, 15);
            this.rdDoviz.TabIndex = 1;
            this.rdDoviz.Text = "Döviz İşlemi";
            this.rdDoviz.UseSelectable = true;
            this.rdDoviz.CheckedChanged += new System.EventHandler(this.rdDoviz_CheckedChanged);
            // 
            // cmbDvzTuru
            // 
            this.cmbDvzTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDvzTuru.FormattingEnabled = true;
            this.cmbDvzTuru.Items.AddRange(new object[] {
            "AZN",
            "USD",
            "EUR",
            "GBP"});
            this.cmbDvzTuru.Location = new System.Drawing.Point(78, 17);
            this.cmbDvzTuru.Name = "cmbDvzTuru";
            this.cmbDvzTuru.Size = new System.Drawing.Size(54, 21);
            this.cmbDvzTuru.TabIndex = 0;
            this.cmbDvzTuru.SelectedIndexChanged += new System.EventHandler(this.cmbDvzTuru_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 18);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Döviz Türü";
            // 
            // txtDvzTutar
            // 
            this.txtDvzTutar.Location = new System.Drawing.Point(183, 17);
            this.txtDvzTutar.Mask = "00000000000";
            this.txtDvzTutar.Name = "txtDvzTutar";
            this.txtDvzTutar.PromptChar = ' ';
            this.txtDvzTutar.ResetOnPrompt = false;
            this.txtDvzTutar.Size = new System.Drawing.Size(107, 20);
            this.txtDvzTutar.TabIndex = 12;
            this.txtDvzTutar.TextChanged += new System.EventHandler(this.txtDvzTutar_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(143, 17);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Tutar";
            // 
            // grpDvzBilgi
            // 
            this.grpDvzBilgi.Controls.Add(this.lblTL);
            this.grpDvzBilgi.Controls.Add(this.label5);
            this.grpDvzBilgi.Controls.Add(this.lblazn);
            this.grpDvzBilgi.Controls.Add(this.label6);
            this.grpDvzBilgi.Controls.Add(this.lblgbp);
            this.grpDvzBilgi.Controls.Add(this.label8);
            this.grpDvzBilgi.Controls.Add(this.lblEuro);
            this.grpDvzBilgi.Controls.Add(this.label4);
            this.grpDvzBilgi.Controls.Add(this.lbldolar);
            this.grpDvzBilgi.Controls.Add(this.label1);
            this.grpDvzBilgi.Location = new System.Drawing.Point(7, 46);
            this.grpDvzBilgi.Name = "grpDvzBilgi";
            this.grpDvzBilgi.Size = new System.Drawing.Size(295, 71);
            this.grpDvzBilgi.TabIndex = 14;
            this.grpDvzBilgi.TabStop = false;
            this.grpDvzBilgi.Text = "Döviz Karşılığı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "USD";
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolar.ForeColor = System.Drawing.Color.Green;
            this.lbldolar.Location = new System.Drawing.Point(49, 16);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(38, 14);
            this.lbldolar.TabIndex = 1;
            this.lbldolar.Text = "$0,00";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.ForeColor = System.Drawing.Color.Olive;
            this.lblEuro.Location = new System.Drawing.Point(49, 30);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(42, 14);
            this.lblEuro.TabIndex = 3;
            this.lblEuro.Text = "0,00 €";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "EURO";
            // 
            // lblazn
            // 
            this.lblazn.AutoSize = true;
            this.lblazn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblazn.ForeColor = System.Drawing.Color.DimGray;
            this.lblazn.Location = new System.Drawing.Point(173, 30);
            this.lblazn.Name = "lblazn";
            this.lblazn.Size = new System.Drawing.Size(57, 14);
            this.lblazn.TabIndex = 7;
            this.lblazn.Text = "0,00 AZN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(130, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "AZN";
            // 
            // lblgbp
            // 
            this.lblgbp.AutoSize = true;
            this.lblgbp.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgbp.ForeColor = System.Drawing.Color.LightCoral;
            this.lblgbp.Location = new System.Drawing.Point(173, 15);
            this.lblgbp.Name = "lblgbp";
            this.lblgbp.Size = new System.Drawing.Size(41, 14);
            this.lblgbp.TabIndex = 5;
            this.lblgbp.Text = "0,00 £";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.Location = new System.Drawing.Point(130, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "GBP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TLtoAZN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TLtoGBP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TLtoEUR);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TLtoUSD);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(6, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 51);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Döviz Karşılığı";
            // 
            // TLtoAZN
            // 
            this.TLtoAZN.AutoSize = true;
            this.TLtoAZN.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLtoAZN.ForeColor = System.Drawing.Color.DimGray;
            this.TLtoAZN.Location = new System.Drawing.Point(173, 30);
            this.TLtoAZN.Name = "TLtoAZN";
            this.TLtoAZN.Size = new System.Drawing.Size(57, 14);
            this.TLtoAZN.TabIndex = 7;
            this.TLtoAZN.Text = "0,00 AZN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(130, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "AZN";
            // 
            // TLtoGBP
            // 
            this.TLtoGBP.AutoSize = true;
            this.TLtoGBP.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLtoGBP.ForeColor = System.Drawing.Color.LightCoral;
            this.TLtoGBP.Location = new System.Drawing.Point(173, 15);
            this.TLtoGBP.Name = "TLtoGBP";
            this.TLtoGBP.Size = new System.Drawing.Size(41, 14);
            this.TLtoGBP.TabIndex = 5;
            this.TLtoGBP.Text = "0,00 £";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightCoral;
            this.label7.Location = new System.Drawing.Point(130, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "GBP";
            // 
            // TLtoEUR
            // 
            this.TLtoEUR.AutoSize = true;
            this.TLtoEUR.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLtoEUR.ForeColor = System.Drawing.Color.Olive;
            this.TLtoEUR.Location = new System.Drawing.Point(49, 30);
            this.TLtoEUR.Name = "TLtoEUR";
            this.TLtoEUR.Size = new System.Drawing.Size(42, 14);
            this.TLtoEUR.TabIndex = 3;
            this.TLtoEUR.Text = "0,00 €";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "EURO";
            // 
            // TLtoUSD
            // 
            this.TLtoUSD.AutoSize = true;
            this.TLtoUSD.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLtoUSD.ForeColor = System.Drawing.Color.Green;
            this.TLtoUSD.Location = new System.Drawing.Point(49, 16);
            this.TLtoUSD.Name = "TLtoUSD";
            this.TLtoUSD.Size = new System.Drawing.Size(38, 14);
            this.TLtoUSD.TabIndex = 1;
            this.TLtoUSD.Text = "$0,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "USD";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.ForeColor = System.Drawing.Color.DimGray;
            this.lblTL.Location = new System.Drawing.Point(92, 48);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(49, 14);
            this.lblTL.TabIndex = 9;
            this.lblTL.Text = "0,00 TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(68, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "TL";
            // 
            // TahsilatGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpIslem);
            this.Controls.Add(this.grpCariSec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TahsilatGirisi";
            this.Text = "57College - Tahsilat Girişi";
            this.Load += new System.EventHandler(this.TahsilatGirisi_Load);
            this.grpCariSec.ResumeLayout(false);
            this.grpCariSec.PerformLayout();
            this.grpIslem.ResumeLayout(false);
            this.grpIslem.PerformLayout();
            this.grpDvz.ResumeLayout(false);
            this.grpDvz.PerformLayout();
            this.grpTL.ResumeLayout(false);
            this.grpTL.PerformLayout();
            this.grpTur.ResumeLayout(false);
            this.grpTur.PerformLayout();
            this.grpDvzBilgi.ResumeLayout(false);
            this.grpDvzBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCariSec;
        private Bunifu.Framework.UI.BunifuTileButton btnCariSec;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpIslem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydet;
        public Bunifu.Framework.UI.BunifuCustomLabel lblTicariUnvani;
        public Bunifu.Framework.UI.BunifuCustomLabel lblCariKod;
        private System.Windows.Forms.GroupBox grpTur;
        private MetroFramework.Controls.MetroRadioButton rdDoviz;
        private MetroFramework.Controls.MetroRadioButton rdTL;
        private System.Windows.Forms.GroupBox grpTL;
        private System.Windows.Forms.MaskedTextBox txtTLTutar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox grpDvz;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dtIslemTarihi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox grpDvzBilgi;
        private System.Windows.Forms.Label lblazn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblgbp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDvzTutar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ComboBox cmbDvzTuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TLtoAZN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TLtoGBP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TLtoEUR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TLtoUSD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label label5;
    }
}