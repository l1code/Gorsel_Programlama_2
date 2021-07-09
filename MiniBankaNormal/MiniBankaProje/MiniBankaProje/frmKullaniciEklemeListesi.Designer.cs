
namespace MiniBankaProje
{
    partial class frmKullaniciEklemeListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KullaniciTCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaSubeAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciRolAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KullaniciTCNO,
            this.KullaniciAd,
            this.KullaniciSoyad,
            this.BankaSubeAd,
            this.KullaniciRolAd,
            this.GirisAd,
            this.GirisSifre});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // KullaniciTCNO
            // 
            this.KullaniciTCNO.DataPropertyName = "KullaniciTCNO";
            this.KullaniciTCNO.HeaderText = "TC No";
            this.KullaniciTCNO.Name = "KullaniciTCNO";
            // 
            // KullaniciAd
            // 
            this.KullaniciAd.DataPropertyName = "KullaniciAd";
            this.KullaniciAd.HeaderText = "Adı";
            this.KullaniciAd.Name = "KullaniciAd";
            // 
            // KullaniciSoyad
            // 
            this.KullaniciSoyad.DataPropertyName = "KullaniciSoyad";
            this.KullaniciSoyad.HeaderText = "Soyadı";
            this.KullaniciSoyad.Name = "KullaniciSoyad";
            // 
            // BankaSubeAd
            // 
            this.BankaSubeAd.DataPropertyName = "BankaSubeAd";
            this.BankaSubeAd.HeaderText = "Görev Şubesi";
            this.BankaSubeAd.Name = "BankaSubeAd";
            // 
            // KullaniciRolAd
            // 
            this.KullaniciRolAd.DataPropertyName = "KullaniciRolAd";
            this.KullaniciRolAd.HeaderText = "Yetki Rolü";
            this.KullaniciRolAd.Name = "KullaniciRolAd";
            // 
            // GirisAd
            // 
            this.GirisAd.DataPropertyName = "GirisAd";
            this.GirisAd.HeaderText = "Giriş Adı";
            this.GirisAd.Name = "GirisAd";
            // 
            // GirisSifre
            // 
            this.GirisSifre.DataPropertyName = "GirisSifre";
            this.GirisSifre.HeaderText = "Giriş Şifresi";
            this.GirisSifre.Name = "GirisSifre";
            // 
            // frmKullaniciEklemeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 426);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKullaniciEklemeListesi";
            this.Text = "frmKullaniciEklemeListesi";
            this.Load += new System.EventHandler(this.frmKullaniciEklemeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciTCNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaSubeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciRolAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisSifre;
    }
}