
namespace MiniBankaProje
{
    partial class frmParaYatirmaCekme
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
            this.lblMusteriAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtMusteriNoVeyaTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMusteriHesaplari = new System.Windows.Forms.ComboBox();
            this.cbIslemTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbParaYatirma = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbParaCekme = new System.Windows.Forms.RadioButton();
            this.txtIslemTutari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIslemAciklamasi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMusteriAdSoyad
            // 
            this.lblMusteriAdSoyad.AutoSize = true;
            this.lblMusteriAdSoyad.Location = new System.Drawing.Point(129, 64);
            this.lblMusteriAdSoyad.Name = "lblMusteriAdSoyad";
            this.lblMusteriAdSoyad.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriAdSoyad.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Müşteri Adı Soyadı:";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(348, 23);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 23);
            this.btnSorgula.TabIndex = 7;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtMusteriNoVeyaTCNo
            // 
            this.txtMusteriNoVeyaTCNo.Location = new System.Drawing.Point(129, 23);
            this.txtMusteriNoVeyaTCNo.Name = "txtMusteriNoVeyaTCNo";
            this.txtMusteriNoVeyaTCNo.Size = new System.Drawing.Size(212, 20);
            this.txtMusteriNoVeyaTCNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri No/TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hesap:";
            // 
            // cbMusteriHesaplari
            // 
            this.cbMusteriHesaplari.FormattingEnabled = true;
            this.cbMusteriHesaplari.Location = new System.Drawing.Point(129, 92);
            this.cbMusteriHesaplari.Name = "cbMusteriHesaplari";
            this.cbMusteriHesaplari.Size = new System.Drawing.Size(294, 21);
            this.cbMusteriHesaplari.TabIndex = 11;
            // 
            // cbIslemTuru
            // 
            this.cbIslemTuru.FormattingEnabled = true;
            this.cbIslemTuru.Location = new System.Drawing.Point(129, 129);
            this.cbIslemTuru.Name = "cbIslemTuru";
            this.cbIslemTuru.Size = new System.Drawing.Size(294, 21);
            this.cbIslemTuru.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "İşlem Türü:";
            // 
            // rbParaYatirma
            // 
            this.rbParaYatirma.AutoSize = true;
            this.rbParaYatirma.Checked = true;
            this.rbParaYatirma.Location = new System.Drawing.Point(129, 173);
            this.rbParaYatirma.Name = "rbParaYatirma";
            this.rbParaYatirma.Size = new System.Drawing.Size(85, 17);
            this.rbParaYatirma.TabIndex = 14;
            this.rbParaYatirma.TabStop = true;
            this.rbParaYatirma.Text = "Para Yatırma";
            this.rbParaYatirma.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "İşlem Türü:";
            // 
            // rbParaCekme
            // 
            this.rbParaCekme.AutoSize = true;
            this.rbParaCekme.Location = new System.Drawing.Point(239, 173);
            this.rbParaCekme.Name = "rbParaCekme";
            this.rbParaCekme.Size = new System.Drawing.Size(83, 17);
            this.rbParaCekme.TabIndex = 16;
            this.rbParaCekme.Text = "Para Çekme";
            this.rbParaCekme.UseVisualStyleBackColor = true;
            // 
            // txtIslemTutari
            // 
            this.txtIslemTutari.Location = new System.Drawing.Point(129, 212);
            this.txtIslemTutari.Name = "txtIslemTutari";
            this.txtIslemTutari.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIslemTutari.Size = new System.Drawing.Size(212, 20);
            this.txtIslemTutari.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "İşlem Tutarı:";
            // 
            // txtIslemAciklamasi
            // 
            this.txtIslemAciklamasi.Location = new System.Drawing.Point(129, 254);
            this.txtIslemAciklamasi.Multiline = true;
            this.txtIslemAciklamasi.Name = "txtIslemAciklamasi";
            this.txtIslemAciklamasi.Size = new System.Drawing.Size(294, 67);
            this.txtIslemAciklamasi.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "İşlem Açıklaması:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(129, 340);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmParaYatirmaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIslemAciklamasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIslemTutari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbParaCekme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbParaYatirma);
            this.Controls.Add(this.cbIslemTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMusteriHesaplari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMusteriAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtMusteriNoVeyaTCNo);
            this.Controls.Add(this.label1);
            this.Name = "frmParaYatirmaCekme";
            this.Text = "Para Yatırma Çekme İşlemleri";
            this.Load += new System.EventHandler(this.frmParaYatirmaCekme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.TextBox txtMusteriNoVeyaTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMusteriHesaplari;
        private System.Windows.Forms.ComboBox cbIslemTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbParaYatirma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbParaCekme;
        private System.Windows.Forms.TextBox txtIslemTutari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIslemAciklamasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
    }
}