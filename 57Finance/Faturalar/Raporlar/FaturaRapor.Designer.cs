namespace _57Finance
{
    partial class FaturaRapor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaRapor));
            this.grpFaturalar = new System.Windows.Forms.GroupBox();
            this.GridFaturalar = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.grpAltToplam = new System.Windows.Forms.GroupBox();
            this.lblToplamDvz = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblToplamTL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelFiltre = new System.Windows.Forms.Panel();
            this.txtVergiNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTicariUnvani = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbDepartman = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbFaturaTuru = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFaturaNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFiltrele = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.grpFaturalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFaturalar)).BeginInit();
            this.grpAltToplam.SuspendLayout();
            this.PanelFiltre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFaturalar
            // 
            this.grpFaturalar.Controls.Add(this.GridFaturalar);
            this.grpFaturalar.Location = new System.Drawing.Point(12, 113);
            this.grpFaturalar.Name = "grpFaturalar";
            this.grpFaturalar.Size = new System.Drawing.Size(1359, 340);
            this.grpFaturalar.TabIndex = 1;
            this.grpFaturalar.TabStop = false;
            this.grpFaturalar.Text = "Faturalar";
            // 
            // GridFaturalar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridFaturalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridFaturalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridFaturalar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridFaturalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridFaturalar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFaturalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFaturalar.DoubleBuffered = true;
            this.GridFaturalar.EnableHeadersVisualStyles = false;
            this.GridFaturalar.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.GridFaturalar.HeaderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GridFaturalar.Location = new System.Drawing.Point(6, 24);
            this.GridFaturalar.MultiSelect = false;
            this.GridFaturalar.Name = "GridFaturalar";
            this.GridFaturalar.ReadOnly = true;
            this.GridFaturalar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridFaturalar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridFaturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFaturalar.Size = new System.Drawing.Size(1347, 310);
            this.GridFaturalar.TabIndex = 5;
            this.GridFaturalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFaturalar_CellDoubleClick);
            // 
            // grpAltToplam
            // 
            this.grpAltToplam.Controls.Add(this.lblToplamDvz);
            this.grpAltToplam.Controls.Add(this.lblToplamTL);
            this.grpAltToplam.Controls.Add(this.bunifuCustomLabel11);
            this.grpAltToplam.Controls.Add(this.bunifuCustomLabel10);
            this.grpAltToplam.Location = new System.Drawing.Point(12, 455);
            this.grpAltToplam.Name = "grpAltToplam";
            this.grpAltToplam.Size = new System.Drawing.Size(359, 69);
            this.grpAltToplam.TabIndex = 2;
            this.grpAltToplam.TabStop = false;
            this.grpAltToplam.Text = "Alt Toplamlar";
            // 
            // lblToplamDvz
            // 
            this.lblToplamDvz.AutoSize = true;
            this.lblToplamDvz.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamDvz.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblToplamDvz.Location = new System.Drawing.Point(234, 43);
            this.lblToplamDvz.Name = "lblToplamDvz";
            this.lblToplamDvz.Size = new System.Drawing.Size(43, 18);
            this.lblToplamDvz.TabIndex = 35;
            this.lblToplamDvz.Text = "0,00";
            // 
            // lblToplamTL
            // 
            this.lblToplamTL.AutoSize = true;
            this.lblToplamTL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamTL.Location = new System.Drawing.Point(233, 18);
            this.lblToplamTL.Name = "lblToplamTL";
            this.lblToplamTL.Size = new System.Drawing.Size(43, 18);
            this.lblToplamTL.TabIndex = 34;
            this.lblToplamTL.Text = "0,00";
            this.lblToplamTL.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(26, 18);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(207, 18);
            this.bunifuCustomLabel11.TabIndex = 32;
            this.bunifuCustomLabel11.Text = "KDV Dahil TL Toplam   :";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(32, 42);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(201, 18);
            this.bunifuCustomLabel10.TabIndex = 33;
            this.bunifuCustomLabel10.Text = "Dövizli Toplam Tutar  :";
            // 
            // btnExcel
            // 
            this.btnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.BorderRadius = 0;
            this.btnExcel.ButtonText = "Hareketleri Excele Aktar";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExcel.Iconimage")));
            this.btnExcel.Iconimage_right = null;
            this.btnExcel.Iconimage_right_Selected = null;
            this.btnExcel.Iconimage_Selected = null;
            this.btnExcel.IconMarginLeft = 0;
            this.btnExcel.IconMarginRight = 0;
            this.btnExcel.IconRightVisible = true;
            this.btnExcel.IconRightZoom = 0D;
            this.btnExcel.IconVisible = true;
            this.btnExcel.IconZoom = 90D;
            this.btnExcel.IsTab = false;
            this.btnExcel.Location = new System.Drawing.Point(1141, 463);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcel.selected = false;
            this.btnExcel.Size = new System.Drawing.Size(230, 60);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Hareketleri Excele Aktar";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Textcolor = System.Drawing.Color.White;
            this.btnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // PanelFiltre
            // 
            this.PanelFiltre.Controls.Add(this.txtVergiNo);
            this.PanelFiltre.Controls.Add(this.txtTicariUnvani);
            this.PanelFiltre.Controls.Add(this.bunifuCustomLabel3);
            this.PanelFiltre.Controls.Add(this.bunifuCustomLabel2);
            this.PanelFiltre.Controls.Add(this.cmbDepartman);
            this.PanelFiltre.Controls.Add(this.bunifuCustomLabel5);
            this.PanelFiltre.Controls.Add(this.cmbFaturaTuru);
            this.PanelFiltre.Controls.Add(this.groupBox2);
            this.PanelFiltre.Controls.Add(this.txtFaturaNo);
            this.PanelFiltre.Controls.Add(this.bunifuCustomLabel8);
            this.PanelFiltre.Controls.Add(this.bunifuCustomLabel6);
            this.PanelFiltre.Location = new System.Drawing.Point(18, 12);
            this.PanelFiltre.Name = "PanelFiltre";
            this.PanelFiltre.Size = new System.Drawing.Size(909, 95);
            this.PanelFiltre.TabIndex = 19;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtVergiNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVergiNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtVergiNo.BorderThickness = 3;
            this.txtVergiNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVergiNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVergiNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVergiNo.isPassword = false;
            this.txtVergiNo.Location = new System.Drawing.Point(338, 33);
            this.txtVergiNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(149, 25);
            this.txtVergiNo.TabIndex = 31;
            this.txtVergiNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTicariUnvani
            // 
            this.txtTicariUnvani.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTicariUnvani.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTicariUnvani.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTicariUnvani.BorderThickness = 3;
            this.txtTicariUnvani.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTicariUnvani.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTicariUnvani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTicariUnvani.isPassword = false;
            this.txtTicariUnvani.Location = new System.Drawing.Point(337, 6);
            this.txtTicariUnvani.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicariUnvani.Name = "txtTicariUnvani";
            this.txtTicariUnvani.Size = new System.Drawing.Size(150, 25);
            this.txtTicariUnvani.TabIndex = 30;
            this.txtTicariUnvani.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(219, 38);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 13);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "Vergi Numarası";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(218, 13);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 13);
            this.bunifuCustomLabel2.TabIndex = 28;
            this.bunifuCustomLabel2.Text = "Ticari Ünvanı";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DisplayMember = "DepartmentName";
            this.cmbDepartman.ItemHeight = 23;
            this.cmbDepartman.Items.AddRange(new object[] {
            " "});
            this.cmbDepartman.Location = new System.Drawing.Point(93, 47);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(117, 29);
            this.cmbDepartman.TabIndex = 27;
            this.cmbDepartman.UseSelectable = true;
            this.cmbDepartman.ValueMember = "id";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(7, 52);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(59, 13);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Departman";
            // 
            // cmbFaturaTuru
            // 
            this.cmbFaturaTuru.ItemHeight = 23;
            this.cmbFaturaTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Havale / EFT",
            "Mahsup",
            "Diğer"});
            this.cmbFaturaTuru.Location = new System.Drawing.Point(329, 61);
            this.cmbFaturaTuru.Name = "cmbFaturaTuru";
            this.cmbFaturaTuru.Size = new System.Drawing.Size(161, 29);
            this.cmbFaturaTuru.TabIndex = 25;
            this.cmbFaturaTuru.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtBitisTarihi);
            this.groupBox2.Controls.Add(this.dtBaslangic);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Location = new System.Drawing.Point(664, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 72);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İki Tarih Arası Sorgulama";
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitisTarihi.Location = new System.Drawing.Point(104, 43);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Size = new System.Drawing.Size(117, 21);
            this.dtBitisTarihi.TabIndex = 19;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(104, 18);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(117, 21);
            this.dtBaslangic.TabIndex = 17;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(16, 50);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(55, 13);
            this.bunifuCustomLabel9.TabIndex = 18;
            this.bunifuCustomLabel9.Text = "Bitiş Tarihi";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(16, 20);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(82, 13);
            this.bunifuCustomLabel7.TabIndex = 17;
            this.bunifuCustomLabel7.Text = "Başlangıç Tarihi";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFaturaNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFaturaNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFaturaNo.BorderThickness = 3;
            this.txtFaturaNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaturaNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFaturaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFaturaNo.isPassword = false;
            this.txtFaturaNo.Location = new System.Drawing.Point(94, 7);
            this.txtFaturaNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(117, 33);
            this.txtFaturaNo.TabIndex = 24;
            this.txtFaturaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(3, 16);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(84, 13);
            this.bunifuCustomLabel8.TabIndex = 22;
            this.bunifuCustomLabel8.Text = "Fatura Numarası";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(220, 69);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(90, 15);
            this.bunifuCustomLabel6.TabIndex = 23;
            this.bunifuCustomLabel6.Text = "Fatura Türü";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.ActiveBorderThickness = 1;
            this.btnFiltrele.ActiveCornerRadius = 20;
            this.btnFiltrele.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnFiltrele.ActiveForecolor = System.Drawing.Color.White;
            this.btnFiltrele.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFiltrele.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFiltrele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrele.BackgroundImage")));
            this.btnFiltrele.ButtonText = "Ara";
            this.btnFiltrele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrele.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFiltrele.IdleBorderThickness = 1;
            this.btnFiltrele.IdleCornerRadius = 20;
            this.btnFiltrele.IdleFillColor = System.Drawing.Color.White;
            this.btnFiltrele.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnFiltrele.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnFiltrele.Location = new System.Drawing.Point(935, 8);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(5);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(154, 46);
            this.btnFiltrele.TabIndex = 20;
            this.btnFiltrele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Tüm Filtreleri Temizle";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.Location = new System.Drawing.Point(935, 53);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 52);
            this.btnClear.TabIndex = 21;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FaturaRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1383, 535);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.PanelFiltre);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.grpAltToplam);
            this.Controls.Add(this.grpFaturalar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaturaRapor";
            this.Text = "57College -  Fatura Rapor";
            this.Load += new System.EventHandler(this.FaturaRapor_Load);
            this.grpFaturalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFaturalar)).EndInit();
            this.grpAltToplam.ResumeLayout(false);
            this.grpAltToplam.PerformLayout();
            this.PanelFiltre.ResumeLayout(false);
            this.PanelFiltre.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFaturalar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid GridFaturalar;
        private System.Windows.Forms.GroupBox grpAltToplam;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
        private System.Windows.Forms.Panel PanelFiltre;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFiltrele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private MetroFramework.Controls.MetroComboBox cmbFaturaTuru;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFaturaNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private MetroFramework.Controls.MetroComboBox cmbDepartman;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtVergiNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTicariUnvani;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToplamDvz;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToplamTL;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
    }
}