namespace _57Finance.Hizmet
{
    partial class HizmetTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizmetTanim));
            this.cmbKDV = new System.Windows.Forms.ComboBox();
            this.txtAlisMuhKodu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFiyat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHizmetAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMuhSatisKodu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDvzTuru = new System.Windows.Forms.ComboBox();
            this.grpTur = new System.Windows.Forms.GroupBox();
            this.rdDoviz = new MetroFramework.Controls.MetroRadioButton();
            this.rdTL = new MetroFramework.Controls.MetroRadioButton();
            this.rchComment = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtHizmetKodu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1.SuspendLayout();
            this.grpTur.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKDV
            // 
            this.cmbKDV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbKDV.DisplayMember = "name";
            this.cmbKDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKDV.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKDV.FormattingEnabled = true;
            this.cmbKDV.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cmbKDV.Location = new System.Drawing.Point(132, 197);
            this.cmbKDV.Name = "cmbKDV";
            this.cmbKDV.Size = new System.Drawing.Size(158, 23);
            this.cmbKDV.TabIndex = 48;
            this.cmbKDV.ValueMember = "ID";
            // 
            // txtAlisMuhKodu
            // 
            this.txtAlisMuhKodu.BorderColorFocused = System.Drawing.Color.Firebrick;
            this.txtAlisMuhKodu.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAlisMuhKodu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAlisMuhKodu.BorderThickness = 1;
            this.txtAlisMuhKodu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlisMuhKodu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAlisMuhKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlisMuhKodu.isPassword = false;
            this.txtAlisMuhKodu.Location = new System.Drawing.Point(132, 233);
            this.txtAlisMuhKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlisMuhKodu.Name = "txtAlisMuhKodu";
            this.txtAlisMuhKodu.Size = new System.Drawing.Size(248, 29);
            this.txtAlisMuhKodu.TabIndex = 46;
            this.txtAlisMuhKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BorderColorFocused = System.Drawing.Color.Firebrick;
            this.txtFiyat.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFiyat.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFiyat.BorderThickness = 1;
            this.txtFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiyat.isPassword = false;
            this.txtFiyat.Location = new System.Drawing.Point(132, 160);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(175, 29);
            this.txtFiyat.TabIndex = 45;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // txtHizmetAdi
            // 
            this.txtHizmetAdi.BorderColorFocused = System.Drawing.Color.Firebrick;
            this.txtHizmetAdi.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtHizmetAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtHizmetAdi.BorderThickness = 1;
            this.txtHizmetAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHizmetAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHizmetAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHizmetAdi.isPassword = false;
            this.txtHizmetAdi.Location = new System.Drawing.Point(132, 73);
            this.txtHizmetAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Size = new System.Drawing.Size(248, 32);
            this.txtHizmetAdi.TabIndex = 44;
            this.txtHizmetAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(4, 239);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(115, 20);
            this.bunifuCustomLabel9.TabIndex = 43;
            this.bunifuCustomLabel9.Text = "Alış Muh. Kodu";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(4, 202);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(82, 20);
            this.bunifuCustomLabel7.TabIndex = 42;
            this.bunifuCustomLabel7.Text = "Kdv Oranı";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(5, 166);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(42, 20);
            this.bunifuCustomLabel3.TabIndex = 41;
            this.bunifuCustomLabel3.Text = "Fiyat";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(4, 78);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(84, 20);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Hizmet Adı";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 20);
            this.bunifuCustomLabel1.TabIndex = 39;
            this.bunifuCustomLabel1.Text = "Hizmet Kodu ";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(5, 274);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(123, 20);
            this.bunifuCustomLabel4.TabIndex = 49;
            this.bunifuCustomLabel4.Text = "Satış Muh. Kodu";
            // 
            // txtMuhSatisKodu
            // 
            this.txtMuhSatisKodu.BorderColorFocused = System.Drawing.Color.Firebrick;
            this.txtMuhSatisKodu.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMuhSatisKodu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMuhSatisKodu.BorderThickness = 1;
            this.txtMuhSatisKodu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMuhSatisKodu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMuhSatisKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMuhSatisKodu.isPassword = false;
            this.txtMuhSatisKodu.Location = new System.Drawing.Point(132, 265);
            this.txtMuhSatisKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMuhSatisKodu.Name = "txtMuhSatisKodu";
            this.txtMuhSatisKodu.Size = new System.Drawing.Size(248, 29);
            this.txtMuhSatisKodu.TabIndex = 50;
            this.txtMuhSatisKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveBorderThickness = 1;
            this.btnKaydet.ActiveCornerRadius = 20;
            this.btnKaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.ButtonText = "Kaydet(F2)";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.IdleBorderThickness = 1;
            this.btnKaydet.IdleCornerRadius = 20;
            this.btnKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnKaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydet.Location = new System.Drawing.Point(12, 405);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 41);
            this.btnKaydet.TabIndex = 51;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ActiveBorderThickness = 1;
            this.btnSil.ActiveCornerRadius = 20;
            this.btnSil.ActiveFillColor = System.Drawing.Color.Brown;
            this.btnSil.ActiveForecolor = System.Drawing.Color.White;
            this.btnSil.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.ButtonText = "Kaydı Sil";
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSil.IdleBorderThickness = 1;
            this.btnSil.IdleCornerRadius = 20;
            this.btnSil.IdleFillColor = System.Drawing.Color.White;
            this.btnSil.IdleForecolor = System.Drawing.Color.DimGray;
            this.btnSil.IdleLineColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(226, 405);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(187, 41);
            this.btnSil.TabIndex = 52;
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHizmetKodu);
            this.groupBox1.Controls.Add(this.cmbDvzTuru);
            this.groupBox1.Controls.Add(this.grpTur);
            this.groupBox1.Controls.Add(this.rchComment);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.txtMuhSatisKodu);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox1.Controls.Add(this.cmbKDV);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox1.Controls.Add(this.txtHizmetAdi);
            this.groupBox1.Controls.Add(this.txtAlisMuhKodu);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 385);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hizmet Tanımı";
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
            this.cmbDvzTuru.Location = new System.Drawing.Point(264, 126);
            this.cmbDvzTuru.Name = "cmbDvzTuru";
            this.cmbDvzTuru.Size = new System.Drawing.Size(54, 21);
            this.cmbDvzTuru.TabIndex = 54;
            // 
            // grpTur
            // 
            this.grpTur.Controls.Add(this.rdDoviz);
            this.grpTur.Controls.Add(this.rdTL);
            this.grpTur.Location = new System.Drawing.Point(132, 113);
            this.grpTur.Name = "grpTur";
            this.grpTur.Size = new System.Drawing.Size(126, 40);
            this.grpTur.TabIndex = 53;
            this.grpTur.TabStop = false;
            this.grpTur.Text = "Fiyat Türü";
            // 
            // rdDoviz
            // 
            this.rdDoviz.AutoSize = true;
            this.rdDoviz.Location = new System.Drawing.Point(64, 19);
            this.rdDoviz.Name = "rdDoviz";
            this.rdDoviz.Size = new System.Drawing.Size(52, 15);
            this.rdDoviz.TabIndex = 1;
            this.rdDoviz.Text = "Döviz";
            this.rdDoviz.UseSelectable = true;
            this.rdDoviz.CheckedChanged += new System.EventHandler(this.rdDoviz_CheckedChanged);
            // 
            // rdTL
            // 
            this.rdTL.AutoSize = true;
            this.rdTL.Location = new System.Drawing.Point(12, 19);
            this.rdTL.Name = "rdTL";
            this.rdTL.Size = new System.Drawing.Size(35, 15);
            this.rdTL.TabIndex = 0;
            this.rdTL.Text = "TL";
            this.rdTL.UseSelectable = true;
            this.rdTL.CheckedChanged += new System.EventHandler(this.rdTL_CheckedChanged);
            // 
            // rchComment
            // 
            this.rchComment.Location = new System.Drawing.Point(79, 304);
            this.rchComment.Name = "rchComment";
            this.rchComment.Size = new System.Drawing.Size(301, 75);
            this.rchComment.TabIndex = 52;
            this.rchComment.Text = "";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(6, 304);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(53, 20);
            this.bunifuCustomLabel5.TabIndex = 51;
            this.bunifuCustomLabel5.Text = "Detay";
            // 
            // txtHizmetKodu
            // 
            this.txtHizmetKodu.BorderColorFocused = System.Drawing.Color.Firebrick;
            this.txtHizmetKodu.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtHizmetKodu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtHizmetKodu.BorderThickness = 1;
            this.txtHizmetKodu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHizmetKodu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHizmetKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHizmetKodu.isPassword = false;
            this.txtHizmetKodu.Location = new System.Drawing.Point(132, 17);
            this.txtHizmetKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtHizmetKodu.Name = "txtHizmetKodu";
            this.txtHizmetKodu.Size = new System.Drawing.Size(248, 32);
            this.txtHizmetKodu.TabIndex = 55;
            this.txtHizmetKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HizmetTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(437, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HizmetTanim";
            this.Text = "Hizmet Tanim";
            this.Load += new System.EventHandler(this.HizmetTanim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTur.ResumeLayout(false);
            this.grpTur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKDV;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAlisMuhKodu;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFiyat;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHizmetAdi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMuhSatisKodu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydet;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchComment;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.GroupBox grpTur;
        private MetroFramework.Controls.MetroRadioButton rdDoviz;
        private MetroFramework.Controls.MetroRadioButton rdTL;
        private System.Windows.Forms.ComboBox cmbDvzTuru;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHizmetKodu;
    }
}