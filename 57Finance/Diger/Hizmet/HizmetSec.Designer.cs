namespace _57Finance.Diger.Hizmet
{
    partial class HizmetSec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizmetSec));
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.btnFiltrele = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHizmetKodu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHizmetKodu2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMuhSatis = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAciklama = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHizmetAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.GridHizmet = new MetroFramework.Controls.MetroGrid();
            this.btnHizmetSec = new System.Windows.Forms.Button();
            this.grpArama.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHizmet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.btnFiltrele);
            this.grpArama.Controls.Add(this.groupBox1);
            this.grpArama.Controls.Add(this.txtMuhSatis);
            this.grpArama.Controls.Add(this.txtAciklama);
            this.grpArama.Controls.Add(this.txtHizmetAdi);
            this.grpArama.Controls.Add(this.bunifuCustomLabel4);
            this.grpArama.Controls.Add(this.bunifuCustomLabel3);
            this.grpArama.Controls.Add(this.bunifuCustomLabel2);
            this.grpArama.Location = new System.Drawing.Point(5, 5);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(458, 170);
            this.grpArama.TabIndex = 7;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Arama Bölümü";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(344, 13);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(108, 151);
            this.btnFiltrele.TabIndex = 12;
            this.btnFiltrele.Text = "Filtrele(F2)";
            this.btnFiltrele.UseSelectable = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHizmetKodu);
            this.groupBox1.Controls.Add(this.txtHizmetKodu2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hizmet Kodu Arama";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.txtHizmetKodu.Location = new System.Drawing.Point(129, 7);
            this.txtHizmetKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtHizmetKodu.Name = "txtHizmetKodu";
            this.txtHizmetKodu.Size = new System.Drawing.Size(144, 25);
            this.txtHizmetKodu.TabIndex = 7;
            this.txtHizmetKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHizmetKodu2
            // 
            this.txtHizmetKodu2.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtHizmetKodu2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHizmetKodu2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtHizmetKodu2.BorderThickness = 3;
            this.txtHizmetKodu2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHizmetKodu2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHizmetKodu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHizmetKodu2.isPassword = false;
            this.txtHizmetKodu2.Location = new System.Drawing.Point(129, 35);
            this.txtHizmetKodu2.Margin = new System.Windows.Forms.Padding(4);
            this.txtHizmetKodu2.Name = "txtHizmetKodu2";
            this.txtHizmetKodu2.Size = new System.Drawing.Size(144, 25);
            this.txtHizmetKodu2.TabIndex = 11;
            this.txtHizmetKodu2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 31);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(70, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Hizmet Kodu ";
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
            this.txtMuhSatis.Location = new System.Drawing.Point(135, 139);
            this.txtMuhSatis.Margin = new System.Windows.Forms.Padding(4);
            this.txtMuhSatis.Name = "txtMuhSatis";
            this.txtMuhSatis.Size = new System.Drawing.Size(144, 25);
            this.txtMuhSatis.TabIndex = 10;
            this.txtMuhSatis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtAciklama.Location = new System.Drawing.Point(135, 109);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 25);
            this.txtAciklama.TabIndex = 9;
            this.txtAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtHizmetAdi.Location = new System.Drawing.Point(135, 81);
            this.txtHizmetAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Size = new System.Drawing.Size(202, 25);
            this.txtHizmetAdi.TabIndex = 8;
            this.txtHizmetAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(16, 145);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(117, 13);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Muhasebe Kodu (Satış)";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(16, 114);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(50, 13);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Açıklama";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 88);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 13);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Hizmet Adı";
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.btnKapat.Location = new System.Drawing.Point(230, 463);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(233, 40);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Seçmeden Çık";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // GridHizmet
            // 
            this.GridHizmet.AllowUserToResizeRows = false;
            this.GridHizmet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridHizmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHizmet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridHizmet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHizmet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridHizmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridHizmet.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridHizmet.EnableHeadersVisualStyles = false;
            this.GridHizmet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridHizmet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridHizmet.Location = new System.Drawing.Point(8, 181);
            this.GridHizmet.Name = "GridHizmet";
            this.GridHizmet.ReadOnly = true;
            this.GridHizmet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHizmet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridHizmet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridHizmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridHizmet.Size = new System.Drawing.Size(455, 276);
            this.GridHizmet.TabIndex = 5;
            this.GridHizmet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHizmet_CellDoubleClick);
            // 
            // btnHizmetSec
            // 
            this.btnHizmetSec.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHizmetSec.Image = ((System.Drawing.Image)(resources.GetObject("btnHizmetSec.Image")));
            this.btnHizmetSec.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHizmetSec.Location = new System.Drawing.Point(8, 463);
            this.btnHizmetSec.Name = "btnHizmetSec";
            this.btnHizmetSec.Size = new System.Drawing.Size(216, 40);
            this.btnHizmetSec.TabIndex = 4;
            this.btnHizmetSec.Text = "Hizmeti Seç";
            this.btnHizmetSec.UseVisualStyleBackColor = true;
            this.btnHizmetSec.Click += new System.EventHandler(this.btnHizmetSec_Click);
            // 
            // HizmetSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(471, 510);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.GridHizmet);
            this.Controls.Add(this.btnHizmetSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HizmetSec";
            this.Text = "Hizmet Seçim Ekranı";
            this.Load += new System.EventHandler(this.HizmetSec_Load);
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHizmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArama;
        private MetroFramework.Controls.MetroButton btnFiltrele;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHizmetKodu;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHizmetKodu2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMuhSatis;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAciklama;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHizmetAdi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button btnKapat;
        private MetroFramework.Controls.MetroGrid GridHizmet;
        private System.Windows.Forms.Button btnHizmetSec;
    }
}