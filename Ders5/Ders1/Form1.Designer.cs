
namespace Ders1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.KisiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.TCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resim = new System.Windows.Forms.DataGridViewImageColumn();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKisiNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // txtTCNO
            // 
            this.txtTCNO.Location = new System.Drawing.Point(102, 45);
            this.txtTCNO.Name = "txtTCNO";
            this.txtTCNO.Size = new System.Drawing.Size(181, 20);
            this.txtTCNO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAd.Location = new System.Drawing.Point(102, 71);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(181, 20);
            this.txtAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(102, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(181, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Yeri:";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(102, 123);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(181, 20);
            this.txtDogumYeri.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(102, 149);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(181, 20);
            this.dtDogumTarihi.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Location = new System.Drawing.Point(20, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(201, 19);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 1;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Location = new System.Drawing.Point(91, 19);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 0;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 327);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(463, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Resim Yükle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(320, 74);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 23);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // KisiID
            // 
            this.KisiID.DataPropertyName = "KisiID";
            this.KisiID.HeaderText = "Kişi  No";
            this.KisiID.Name = "KisiID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TCNO
            // 
            this.TCNO.DataPropertyName = "TCNO";
            this.TCNO.HeaderText = "TC Kimlik No";
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
            // DogumYeri
            // 
            this.DogumYeri.DataPropertyName = "DogumYeri";
            this.DogumYeri.HeaderText = "Doğum Yeri";
            this.DogumYeri.Name = "DogumYeri";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarihi";
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DataPropertyName = "Cinsiyet";
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            // 
            // Resim
            // 
            this.Resim.DataPropertyName = "Resim";
            this.Resim.HeaderText = "Resim";
            this.Resim.Name = "Resim";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "TC No ya göre bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(320, 133);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kişi No:";
            // 
            // lblKisiNo
            // 
            this.lblKisiNo.AutoSize = true;
            this.lblKisiNo.ForeColor = System.Drawing.Color.Red;
            this.lblKisiNo.Location = new System.Drawing.Point(102, 16);
            this.lblKisiNo.Name = "lblKisiNo";
            this.lblKisiNo.Size = new System.Drawing.Size(0, 13);
            this.lblKisiNo.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(449, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 599);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.txtTCNO);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.lblKisiNo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtSoyad);
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtDogumYeri);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dtDogumTarihi);
            this.tabPage1.Controls.Add(this.btnKaydet);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişi Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maaş Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KisiID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewImageColumn Resim;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKisiNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
    }
}

