namespace _57Finance.Hizmet.Raporlar
{
    partial class HizmetRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizmetRaporu));
            this.btnKartAc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.txtMuhSatis = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAciklama = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHizmetAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHizmetKodu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GridHizmet = new System.Windows.Forms.DataGridView();
            this.grpArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHizmet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKartAc
            // 
            this.btnKartAc.ActiveBorderThickness = 1;
            this.btnKartAc.ActiveCornerRadius = 20;
            this.btnKartAc.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKartAc.ActiveForecolor = System.Drawing.Color.White;
            this.btnKartAc.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKartAc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.btnKartAc.TabIndex = 7;
            this.btnKartAc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKartAc.Click += new System.EventHandler(this.btnKartAc_Click);
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
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Sayfayı Excel\'e Aktar";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Textcolor = System.Drawing.Color.White;
            this.btnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.txtMuhSatis);
            this.grpArama.Controls.Add(this.txtAciklama);
            this.grpArama.Controls.Add(this.txtHizmetAdi);
            this.grpArama.Controls.Add(this.txtHizmetKodu);
            this.grpArama.Controls.Add(this.bunifuCustomLabel4);
            this.grpArama.Controls.Add(this.bunifuCustomLabel3);
            this.grpArama.Controls.Add(this.bunifuCustomLabel2);
            this.grpArama.Controls.Add(this.bunifuCustomLabel1);
            this.grpArama.Location = new System.Drawing.Point(12, 12);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(558, 159);
            this.grpArama.TabIndex = 5;
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
            // txtAciklama
            // 
            this.txtAciklama.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAciklama.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAciklama.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAciklama.BorderThickness = 3;
            this.txtAciklama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAciklama.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAciklama.isPassword = false;
            this.txtAciklama.Location = new System.Drawing.Point(135, 85);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 25);
            this.txtAciklama.TabIndex = 9;
            this.txtAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAciklama.OnValueChanged += new System.EventHandler(this.txtAciklama_OnValueChanged);
            // 
            // txtHizmetAdi
            // 
            this.txtHizmetAdi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtHizmetAdi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHizmetAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtHizmetAdi.BorderThickness = 3;
            this.txtHizmetAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHizmetAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHizmetAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHizmetAdi.isPassword = false;
            this.txtHizmetAdi.Location = new System.Drawing.Point(135, 52);
            this.txtHizmetAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Size = new System.Drawing.Size(202, 25);
            this.txtHizmetAdi.TabIndex = 8;
            this.txtHizmetAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHizmetAdi.OnValueChanged += new System.EventHandler(this.txtHizmetAdi_OnValueChanged);
            // 
            // txtHizmetKodu
            // 
            this.txtHizmetKodu.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtHizmetKodu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHizmetKodu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtHizmetKodu.BorderThickness = 3;
            this.txtHizmetKodu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHizmetKodu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHizmetKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHizmetKodu.isPassword = false;
            this.txtHizmetKodu.Location = new System.Drawing.Point(135, 20);
            this.txtHizmetKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtHizmetKodu.Name = "txtHizmetKodu";
            this.txtHizmetKodu.Size = new System.Drawing.Size(144, 25);
            this.txtHizmetKodu.TabIndex = 7;
            this.txtHizmetKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHizmetKodu.OnValueChanged += new System.EventHandler(this.txtHizmetKodu_OnValueChanged);
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
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(50, 13);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Açıklama";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 59);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 13);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Hizmet Adı";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 26);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(70, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Hizmet Kodu ";
            // 
            // GridHizmet
            // 
            this.GridHizmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridHizmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHizmet.Location = new System.Drawing.Point(12, 177);
            this.GridHizmet.Name = "GridHizmet";
            this.GridHizmet.ReadOnly = true;
            this.GridHizmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridHizmet.Size = new System.Drawing.Size(805, 339);
            this.GridHizmet.TabIndex = 4;
            // 
            // HizmetRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(835, 534);
            this.Controls.Add(this.btnKartAc);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.GridHizmet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HizmetRaporu";
            this.Text = "Hizmet Raporu";
            this.Load += new System.EventHandler(this.HizmetRaporu_Load);
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHizmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnKartAc;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
        private System.Windows.Forms.GroupBox grpArama;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMuhSatis;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAciklama;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHizmetAdi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHizmetKodu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView GridHizmet;
    }
}