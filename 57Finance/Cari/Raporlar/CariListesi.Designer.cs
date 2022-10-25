namespace _57Finance.Cari.Raporlar
{
    partial class CariListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariListesi));
            this.GridCari = new System.Windows.Forms.DataGridView();
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.txtMuhSatis = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtVergiNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTicariUnvani = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCariKodu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKartAc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.GridCari)).BeginInit();
            this.grpArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridCari
            // 
            this.GridCari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCari.Location = new System.Drawing.Point(12, 177);
            this.GridCari.Name = "GridCari";
            this.GridCari.ReadOnly = true;
            this.GridCari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCari.Size = new System.Drawing.Size(805, 339);
            this.GridCari.TabIndex = 0;
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.txtMuhSatis);
            this.grpArama.Controls.Add(this.txtVergiNo);
            this.grpArama.Controls.Add(this.txtTicariUnvani);
            this.grpArama.Controls.Add(this.txtCariKodu);
            this.grpArama.Controls.Add(this.bunifuCustomLabel4);
            this.grpArama.Controls.Add(this.bunifuCustomLabel3);
            this.grpArama.Controls.Add(this.bunifuCustomLabel2);
            this.grpArama.Controls.Add(this.bunifuCustomLabel1);
            this.grpArama.Location = new System.Drawing.Point(12, 12);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(558, 159);
            this.grpArama.TabIndex = 1;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Arama Bölümü";
            // 
            // txtMuhSatis
            // 
            this.txtMuhSatis.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMuhSatis.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMuhSatis.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMuhSatis.BorderThickness = 3;
            this.txtMuhSatis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMuhSatis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMuhSatis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMuhSatis.isPassword = false;
            this.txtMuhSatis.Location = new System.Drawing.Point(135, 115);
            this.txtMuhSatis.Margin = new System.Windows.Forms.Padding(4);
            this.txtMuhSatis.Name = "txtMuhSatis";
            this.txtMuhSatis.Size = new System.Drawing.Size(144, 25);
            this.txtMuhSatis.TabIndex = 10;
            this.txtMuhSatis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMuhSatis.OnValueChanged += new System.EventHandler(this.txtMuhSatis_OnValueChanged);
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
            this.txtVergiNo.Location = new System.Drawing.Point(135, 85);
            this.txtVergiNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(144, 25);
            this.txtVergiNo.TabIndex = 9;
            this.txtVergiNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVergiNo.OnValueChanged += new System.EventHandler(this.txtVergiNo_OnValueChanged);
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
            this.txtTicariUnvani.Location = new System.Drawing.Point(135, 52);
            this.txtTicariUnvani.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicariUnvani.Name = "txtTicariUnvani";
            this.txtTicariUnvani.Size = new System.Drawing.Size(202, 25);
            this.txtTicariUnvani.TabIndex = 8;
            this.txtTicariUnvani.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTicariUnvani.OnValueChanged += new System.EventHandler(this.txtTicariUnvani_OnValueChanged);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCariKodu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCariKodu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCariKodu.BorderThickness = 3;
            this.txtCariKodu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariKodu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCariKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCariKodu.isPassword = false;
            this.txtCariKodu.Location = new System.Drawing.Point(135, 20);
            this.txtCariKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(144, 25);
            this.txtCariKodu.TabIndex = 7;
            this.txtCariKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCariKodu.OnValueChanged += new System.EventHandler(this.txtCariKodu_OnValueChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(16, 121);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(117, 13);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Muhasebe Kodu (Satış)";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(16, 90);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 13);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Vergi Numarası";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 59);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 13);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Ticari Ünvanı";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 26);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Cari Kodu ";
            // 
            // btnExcel
            // 
            this.btnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.BorderRadius = 0;
            this.btnExcel.ButtonText = "Sayfayı Excel\'e Aktar";
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
            this.btnExcel.Location = new System.Drawing.Point(576, 123);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcel.selected = false;
            this.btnExcel.Size = new System.Drawing.Size(241, 48);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Sayfayı Excel\'e Aktar";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Textcolor = System.Drawing.Color.White;
            this.btnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnKartAc
            // 
            this.btnKartAc.ActiveBorderThickness = 1;
            this.btnKartAc.ActiveCornerRadius = 20;
            this.btnKartAc.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKartAc.ActiveForecolor = System.Drawing.Color.White;
            this.btnKartAc.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKartAc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnKartAc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKartAc.BackgroundImage")));
            this.btnKartAc.ButtonText = "Seçili Kartı Aç";
            this.btnKartAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKartAc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKartAc.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKartAc.IdleBorderThickness = 1;
            this.btnKartAc.IdleCornerRadius = 20;
            this.btnKartAc.IdleFillColor = System.Drawing.Color.White;
            this.btnKartAc.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKartAc.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKartAc.Location = new System.Drawing.Point(578, 71);
            this.btnKartAc.Margin = new System.Windows.Forms.Padding(5);
            this.btnKartAc.Name = "btnKartAc";
            this.btnKartAc.Size = new System.Drawing.Size(237, 51);
            this.btnKartAc.TabIndex = 3;
            this.btnKartAc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKartAc.Click += new System.EventHandler(this.btnKartAc_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ActiveBorderThickness = 1;
            this.btnEkle.ActiveCornerRadius = 20;
            this.btnEkle.ActiveFillColor = System.Drawing.Color.LightSteelBlue;
            this.btnEkle.ActiveForecolor = System.Drawing.Color.Black;
            this.btnEkle.ActiveLineColor = System.Drawing.Color.LightSteelBlue;
            this.btnEkle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.ButtonText = "Yeni Kart Aç";
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.IdleBorderThickness = 1;
            this.btnEkle.IdleCornerRadius = 20;
            this.btnEkle.IdleFillColor = System.Drawing.Color.MediumTurquoise;
            this.btnEkle.IdleForecolor = System.Drawing.Color.MintCream;
            this.btnEkle.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnEkle.Location = new System.Drawing.Point(580, 14);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(237, 51);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // CariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(829, 528);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnKartAc);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.GridCari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CariListesi";
            this.Text = "57College -  Cari Listesi";
            this.Load += new System.EventHandler(this.CariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCari)).EndInit();
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCari;
        private System.Windows.Forms.GroupBox grpArama;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMuhSatis;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtVergiNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTicariUnvani;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCariKodu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKartAc;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEkle;
    }
}