namespace _57Finance
{
    partial class AlisFaturasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlisFaturasi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpCari = new System.Windows.Forms.GroupBox();
            this.lblTaxOffice = new MetroFramework.Controls.MetroLabel();
            this.lblTaxNo = new MetroFramework.Controls.MetroLabel();
            this.lblCommercialTitle = new MetroFramework.Controls.MetroLabel();
            this.lblClientCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.rcAciklama = new System.Windows.Forms.RichTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtFaturaTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtFaturaNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbFaturaTur = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCariSec = new Bunifu.Framework.UI.BunifuTileButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grpHareket = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHrkSil = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHrkEkle = new Bunifu.Framework.UI.BunifuImageButton();
            this.GridHr = new MetroFramework.Controls.MetroGrid();
            this.grpCari.SuspendLayout();
            this.grpHareket.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHrkSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHrkEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHr)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCari
            // 
            this.grpCari.Controls.Add(this.lblTaxOffice);
            this.grpCari.Controls.Add(this.lblTaxNo);
            this.grpCari.Controls.Add(this.lblCommercialTitle);
            this.grpCari.Controls.Add(this.lblClientCode);
            this.grpCari.Controls.Add(this.metroLabel8);
            this.grpCari.Controls.Add(this.rcAciklama);
            this.grpCari.Controls.Add(this.metroLabel7);
            this.grpCari.Controls.Add(this.dtFaturaTarihi);
            this.grpCari.Controls.Add(this.txtFaturaNo);
            this.grpCari.Controls.Add(this.metroLabel6);
            this.grpCari.Controls.Add(this.metroLabel5);
            this.grpCari.Controls.Add(this.cmbFaturaTur);
            this.grpCari.Controls.Add(this.metroLabel4);
            this.grpCari.Controls.Add(this.metroLabel3);
            this.grpCari.Controls.Add(this.metroLabel2);
            this.grpCari.Controls.Add(this.btnCariSec);
            this.grpCari.Controls.Add(this.metroLabel1);
            this.grpCari.Location = new System.Drawing.Point(12, 12);
            this.grpCari.Name = "grpCari";
            this.grpCari.Size = new System.Drawing.Size(1155, 130);
            this.grpCari.TabIndex = 0;
            this.grpCari.TabStop = false;
            this.grpCari.Text = "Cari - Fatura Bilgileri";
            // 
            // lblTaxOffice
            // 
            this.lblTaxOffice.AutoSize = true;
            this.lblTaxOffice.Location = new System.Drawing.Point(102, 86);
            this.lblTaxOffice.Name = "lblTaxOffice";
            this.lblTaxOffice.Size = new System.Drawing.Size(16, 19);
            this.lblTaxOffice.TabIndex = 19;
            this.lblTaxOffice.Text = "0";
            this.lblTaxOffice.TextChanged += new System.EventHandler(this.lblTaxOffice_TextChanged);
            // 
            // lblTaxNo
            // 
            this.lblTaxNo.AutoSize = true;
            this.lblTaxNo.Location = new System.Drawing.Point(103, 65);
            this.lblTaxNo.Name = "lblTaxNo";
            this.lblTaxNo.Size = new System.Drawing.Size(16, 19);
            this.lblTaxNo.TabIndex = 18;
            this.lblTaxNo.Text = "0";
            this.lblTaxNo.TextChanged += new System.EventHandler(this.lblTaxNo_TextChanged);
            // 
            // lblCommercialTitle
            // 
            this.lblCommercialTitle.AutoSize = true;
            this.lblCommercialTitle.Location = new System.Drawing.Point(102, 43);
            this.lblCommercialTitle.Name = "lblCommercialTitle";
            this.lblCommercialTitle.Size = new System.Drawing.Size(16, 19);
            this.lblCommercialTitle.TabIndex = 17;
            this.lblCommercialTitle.Text = "0";
            this.lblCommercialTitle.TextChanged += new System.EventHandler(this.lblCommercialTitle_TextChanged);
            // 
            // lblClientCode
            // 
            this.lblClientCode.AutoSize = true;
            this.lblClientCode.Location = new System.Drawing.Point(102, 22);
            this.lblClientCode.Name = "lblClientCode";
            this.lblClientCode.Size = new System.Drawing.Size(16, 19);
            this.lblClientCode.TabIndex = 16;
            this.lblClientCode.Text = "0";
            this.lblClientCode.TextChanged += new System.EventHandler(this.lblClientCode_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(792, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(110, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Fatura Açıklaması";
            // 
            // rcAciklama
            // 
            this.rcAciklama.Location = new System.Drawing.Point(792, 44);
            this.rcAciklama.Name = "rcAciklama";
            this.rcAciklama.Size = new System.Drawing.Size(223, 69);
            this.rcAciklama.TabIndex = 14;
            this.rcAciklama.Text = "";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(426, 93);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Fatura Tarihi :";
            // 
            // dtFaturaTarihi
            // 
            this.dtFaturaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaturaTarihi.Location = new System.Drawing.Point(514, 93);
            this.dtFaturaTarihi.Name = "dtFaturaTarihi";
            this.dtFaturaTarihi.Size = new System.Drawing.Size(114, 20);
            this.dtFaturaTarihi.TabIndex = 12;
            // 
            // txtFaturaNo
            // 
            // 
            // 
            // 
            this.txtFaturaNo.CustomButton.Image = null;
            this.txtFaturaNo.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtFaturaNo.CustomButton.Name = "";
            this.txtFaturaNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFaturaNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFaturaNo.CustomButton.TabIndex = 1;
            this.txtFaturaNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFaturaNo.CustomButton.UseSelectable = true;
            this.txtFaturaNo.CustomButton.Visible = false;
            this.txtFaturaNo.Lines = new string[0];
            this.txtFaturaNo.Location = new System.Drawing.Point(514, 64);
            this.txtFaturaNo.MaxLength = 32767;
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.PasswordChar = '\0';
            this.txtFaturaNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFaturaNo.SelectedText = "";
            this.txtFaturaNo.SelectionLength = 0;
            this.txtFaturaNo.SelectionStart = 0;
            this.txtFaturaNo.ShortcutsEnabled = true;
            this.txtFaturaNo.Size = new System.Drawing.Size(206, 23);
            this.txtFaturaNo.TabIndex = 11;
            this.txtFaturaNo.UseSelectable = true;
            this.txtFaturaNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFaturaNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(429, 64);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Fatura No :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(429, 29);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Fatura Türü :";
            // 
            // cmbFaturaTur
            // 
            this.cmbFaturaTur.ItemHeight = 23;
            this.cmbFaturaTur.Items.AddRange(new object[] {
            "Seçiniz",
            "Alış Faturası",
            "Alıştan İade Faturası"});
            this.cmbFaturaTur.Location = new System.Drawing.Point(514, 24);
            this.cmbFaturaTur.Name = "cmbFaturaTur";
            this.cmbFaturaTur.Size = new System.Drawing.Size(206, 29);
            this.cmbFaturaTur.TabIndex = 8;
            this.cmbFaturaTur.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Vergi Dairesi :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Vergi No :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Ticari Ünvanı :";
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
            this.btnCariSec.Location = new System.Drawing.Point(1074, 12);
            this.btnCariSec.Margin = new System.Windows.Forms.Padding(6);
            this.btnCariSec.Name = "btnCariSec";
            this.btnCariSec.Size = new System.Drawing.Size(72, 109);
            this.btnCariSec.TabIndex = 5;
            this.btnCariSec.Click += new System.EventHandler(this.btnCariSec_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Cari Kodu :";
            // 
            // grpHareket
            // 
            this.grpHareket.Controls.Add(this.groupBox1);
            this.grpHareket.Controls.Add(this.GridHr);
            this.grpHareket.Location = new System.Drawing.Point(12, 169);
            this.grpHareket.Name = "grpHareket";
            this.grpHareket.Size = new System.Drawing.Size(1155, 340);
            this.grpHareket.TabIndex = 0;
            this.grpHareket.TabStop = false;
            this.grpHareket.Text = "Hareketler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHrkSil);
            this.groupBox1.Controls.Add(this.btnHrkEkle);
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(41, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnHrkSil
            // 
            this.btnHrkSil.BackColor = System.Drawing.Color.Transparent;
            this.btnHrkSil.Image = global::_57Finance.Properties.Resources.trash;
            this.btnHrkSil.ImageActive = null;
            this.btnHrkSil.Location = new System.Drawing.Point(9, 40);
            this.btnHrkSil.Name = "btnHrkSil";
            this.btnHrkSil.Size = new System.Drawing.Size(20, 24);
            this.btnHrkSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHrkSil.TabIndex = 1;
            this.btnHrkSil.TabStop = false;
            this.btnHrkSil.Zoom = 10;
            this.btnHrkSil.Click += new System.EventHandler(this.btnHrkSil_Click);
            // 
            // btnHrkEkle
            // 
            this.btnHrkEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnHrkEkle.Image = global::_57Finance.Properties.Resources.ServiceAdd;
            this.btnHrkEkle.ImageActive = null;
            this.btnHrkEkle.Location = new System.Drawing.Point(9, 14);
            this.btnHrkEkle.Name = "btnHrkEkle";
            this.btnHrkEkle.Size = new System.Drawing.Size(20, 20);
            this.btnHrkEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHrkEkle.TabIndex = 0;
            this.btnHrkEkle.TabStop = false;
            this.btnHrkEkle.Zoom = 10;
            this.btnHrkEkle.Click += new System.EventHandler(this.btnHrkEkle_Click);
            // 
            // GridHr
            // 
            this.GridHr.AllowUserToResizeRows = false;
            this.GridHr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridHr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridHr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridHr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridHr.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridHr.EnableHeadersVisualStyles = false;
            this.GridHr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridHr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridHr.Location = new System.Drawing.Point(50, 19);
            this.GridHr.MultiSelect = false;
            this.GridHr.Name = "GridHr";
            this.GridHr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHr.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridHr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridHr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridHr.Size = new System.Drawing.Size(1099, 306);
            this.GridHr.TabIndex = 3;
            // 
            // AlisFaturasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1177, 649);
            this.Controls.Add(this.grpHareket);
            this.Controls.Add(this.grpCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlisFaturasi";
            this.Text = "57College - Alış / Alıştan İade Faturası ";
            this.Load += new System.EventHandler(this.AlisFaturasi_Load);
            this.grpCari.ResumeLayout(false);
            this.grpCari.PerformLayout();
            this.grpHareket.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHrkSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHrkEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCari;
        private System.Windows.Forms.GroupBox grpHareket;
        private Bunifu.Framework.UI.BunifuTileButton btnCariSec;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.RichTextBox rcAciklama;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DateTimePicker dtFaturaTarihi;
        private MetroFramework.Controls.MetroTextBox txtFaturaNo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbFaturaTur;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid GridHr;
        private Bunifu.Framework.UI.BunifuImageButton btnHrkSil;
        private Bunifu.Framework.UI.BunifuImageButton btnHrkEkle;
        public MetroFramework.Controls.MetroLabel lblTaxOffice;
        public MetroFramework.Controls.MetroLabel lblTaxNo;
        public MetroFramework.Controls.MetroLabel lblCommercialTitle;
        public MetroFramework.Controls.MetroLabel lblClientCode;
    }
}