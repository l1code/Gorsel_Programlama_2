
namespace MiniBankaProje
{
    partial class frmBankaSubeEkleme
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFaks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankaSubeKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankaSubeAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBanka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(97, 339);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(97, 171);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(443, 151);
            this.txtAdres.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adres:";
            // 
            // txtFaks
            // 
            this.txtFaks.Location = new System.Drawing.Point(97, 140);
            this.txtFaks.MaxLength = 11;
            this.txtFaks.Name = "txtFaks";
            this.txtFaks.Size = new System.Drawing.Size(175, 20);
            this.txtFaks.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Faks:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(97, 113);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(175, 20);
            this.txtTelefon.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefon:";
            // 
            // txtBankaSubeKod
            // 
            this.txtBankaSubeKod.Location = new System.Drawing.Point(97, 82);
            this.txtBankaSubeKod.MaxLength = 4;
            this.txtBankaSubeKod.Name = "txtBankaSubeKod";
            this.txtBankaSubeKod.Size = new System.Drawing.Size(175, 20);
            this.txtBankaSubeKod.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şube Kodu:";
            // 
            // txtBankaSubeAd
            // 
            this.txtBankaSubeAd.Location = new System.Drawing.Point(97, 56);
            this.txtBankaSubeAd.Name = "txtBankaSubeAd";
            this.txtBankaSubeAd.Size = new System.Drawing.Size(443, 20);
            this.txtBankaSubeAd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Şube Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Banka:";
            // 
            // cbBanka
            // 
            this.cbBanka.FormattingEnabled = true;
            this.cbBanka.Location = new System.Drawing.Point(97, 26);
            this.cbBanka.Name = "cbBanka";
            this.cbBanka.Size = new System.Drawing.Size(271, 21);
            this.cbBanka.TabIndex = 23;
            // 
            // frmBankaSubeEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 390);
            this.Controls.Add(this.cbBanka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFaks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBankaSubeKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBankaSubeAd);
            this.Controls.Add(this.label1);
            this.Name = "frmBankaSubeEkleme";
            this.Text = "Banka Şube Ekleme";
            this.Load += new System.EventHandler(this.frmBankaSubeEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFaks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankaSubeKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankaSubeAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBanka;
    }
}