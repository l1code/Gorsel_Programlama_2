﻿
namespace MiniBankaProje
{
    partial class frmMusteriListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BankaSubeAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvAdresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankaSubeAd,
            this.MusteriNo,
            this.TCNO,
            this.Ad,
            this.Soyad,
            this.DogumTarihi,
            this.EvAdresi,
            this.Telefon,
            this.IslemTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // BankaSubeAd
            // 
            this.BankaSubeAd.DataPropertyName = "BankaSubeAd";
            this.BankaSubeAd.HeaderText = "Şube Adı";
            this.BankaSubeAd.Name = "BankaSubeAd";
            // 
            // MusteriNo
            // 
            this.MusteriNo.DataPropertyName = "MusteriNo";
            this.MusteriNo.HeaderText = "Müşteri No";
            this.MusteriNo.Name = "MusteriNo";
            // 
            // TCNO
            // 
            this.TCNO.DataPropertyName = "TCNO";
            this.TCNO.HeaderText = "TC No";
            this.TCNO.Name = "TCNO";
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarihi";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.DogumTarihi.DefaultCellStyle = dataGridViewCellStyle1;
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // EvAdresi
            // 
            this.EvAdresi.DataPropertyName = "EvAdresi";
            this.EvAdresi.HeaderText = "Ev Adresi";
            this.EvAdresi.Name = "EvAdresi";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // IslemTarihi
            // 
            this.IslemTarihi.DataPropertyName = "IslemTarihi";
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            this.IslemTarihi.DefaultCellStyle = dataGridViewCellStyle2;
            this.IslemTarihi.HeaderText = "İşlem Tarihi";
            this.IslemTarihi.Name = "IslemTarihi";
            this.IslemTarihi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IslemTarihi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 409);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMusteriListesi";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.frmMusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaSubeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvAdresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTarihi;
    }
}