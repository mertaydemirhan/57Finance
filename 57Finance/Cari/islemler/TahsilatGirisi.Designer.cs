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
            this.grpCariSec.SuspendLayout();
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
            this.grpIslem.Location = new System.Drawing.Point(12, 122);
            this.grpIslem.Name = "grpIslem";
            this.grpIslem.Size = new System.Drawing.Size(619, 172);
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
            this.btnKaydet.Location = new System.Drawing.Point(14, 302);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(177, 52);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TahsilatGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpIslem);
            this.Controls.Add(this.grpCariSec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TahsilatGirisi";
            this.Text = "57College - Tahsilat Girişi";
            this.Load += new System.EventHandler(this.TahsilatGirisi_Load);
            this.grpCariSec.ResumeLayout(false);
            this.grpCariSec.PerformLayout();
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
    }
}