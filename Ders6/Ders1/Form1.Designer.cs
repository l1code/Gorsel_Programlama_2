﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.tabKisiBilgileri = new System.Windows.Forms.TabPage();
            this.tabMaasBilgisi = new System.Windows.Forms.TabPage();
            this.lblKisiBilgisi = new System.Windows.Forms.Label();
            this.dataGridMaas = new System.Windows.Forms.DataGridView();
            this.cbDonem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.DonemAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaasTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabKisiBilgileri.SuspendLayout();
            this.tabMaasBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabKisiBilgileri);
            this.tabControl1.Controls.Add(this.tabMaasBilgisi);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 599);
            this.tabControl1.TabIndex = 22;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabKisiBilgileri
            // 
            this.tabKisiBilgileri.Controls.Add(this.button2);
            this.tabKisiBilgileri.Controls.Add(this.label1);
            this.tabKisiBilgileri.Controls.Add(this.button4);
            this.tabKisiBilgileri.Controls.Add(this.txtTCNO);
            this.tabKisiBilgileri.Controls.Add(this.pictureBox1);
            this.tabKisiBilgileri.Controls.Add(this.label2);
            this.tabKisiBilgileri.Controls.Add(this.button3);
            this.tabKisiBilgileri.Controls.Add(this.txtAd);
            this.tabKisiBilgileri.Controls.Add(this.lblKisiNo);
            this.tabKisiBilgileri.Controls.Add(this.label3);
            this.tabKisiBilgileri.Controls.Add(this.label6);
            this.tabKisiBilgileri.Controls.Add(this.txtSoyad);
            this.tabKisiBilgileri.Controls.Add(this.btnGuncelle);
            this.tabKisiBilgileri.Controls.Add(this.label4);
            this.tabKisiBilgileri.Controls.Add(this.txtDogumYeri);
            this.tabKisiBilgileri.Controls.Add(this.button1);
            this.tabKisiBilgileri.Controls.Add(this.label5);
            this.tabKisiBilgileri.Controls.Add(this.dataGridView1);
            this.tabKisiBilgileri.Controls.Add(this.dtDogumTarihi);
            this.tabKisiBilgileri.Controls.Add(this.btnKaydet);
            this.tabKisiBilgileri.Controls.Add(this.groupBox1);
            this.tabKisiBilgileri.Location = new System.Drawing.Point(4, 22);
            this.tabKisiBilgileri.Name = "tabKisiBilgileri";
            this.tabKisiBilgileri.Padding = new System.Windows.Forms.Padding(3);
            this.tabKisiBilgileri.Size = new System.Drawing.Size(1022, 573);
            this.tabKisiBilgileri.TabIndex = 0;
            this.tabKisiBilgileri.Text = "Kişi Bilgileri";
            this.tabKisiBilgileri.UseVisualStyleBackColor = true;
            // 
            // tabMaasBilgisi
            // 
            this.tabMaasBilgisi.Controls.Add(this.chart1);
            this.tabMaasBilgisi.Controls.Add(this.button5);
            this.tabMaasBilgisi.Controls.Add(this.txtMaas);
            this.tabMaasBilgisi.Controls.Add(this.label8);
            this.tabMaasBilgisi.Controls.Add(this.label7);
            this.tabMaasBilgisi.Controls.Add(this.cbDonem);
            this.tabMaasBilgisi.Controls.Add(this.dataGridMaas);
            this.tabMaasBilgisi.Controls.Add(this.lblKisiBilgisi);
            this.tabMaasBilgisi.Location = new System.Drawing.Point(4, 22);
            this.tabMaasBilgisi.Name = "tabMaasBilgisi";
            this.tabMaasBilgisi.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaasBilgisi.Size = new System.Drawing.Size(1022, 573);
            this.tabMaasBilgisi.TabIndex = 1;
            this.tabMaasBilgisi.Text = "Maaş Bilgileri";
            this.tabMaasBilgisi.UseVisualStyleBackColor = true;
            // 
            // lblKisiBilgisi
            // 
            this.lblKisiBilgisi.AutoSize = true;
            this.lblKisiBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisiBilgisi.ForeColor = System.Drawing.Color.Red;
            this.lblKisiBilgisi.Location = new System.Drawing.Point(52, 30);
            this.lblKisiBilgisi.Name = "lblKisiBilgisi";
            this.lblKisiBilgisi.Size = new System.Drawing.Size(0, 24);
            this.lblKisiBilgisi.TabIndex = 0;
            // 
            // dataGridMaas
            // 
            this.dataGridMaas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonemAd,
            this.MaasTutar});
            this.dataGridMaas.Location = new System.Drawing.Point(56, 82);
            this.dataGridMaas.Name = "dataGridMaas";
            this.dataGridMaas.Size = new System.Drawing.Size(355, 283);
            this.dataGridMaas.TabIndex = 1;
            // 
            // cbDonem
            // 
            this.cbDonem.DisplayMember = "DonemAd";
            this.cbDonem.FormattingEnabled = true;
            this.cbDonem.Location = new System.Drawing.Point(524, 79);
            this.cbDonem.Name = "cbDonem";
            this.cbDonem.Size = new System.Drawing.Size(121, 21);
            this.cbDonem.TabIndex = 2;
            this.cbDonem.ValueMember = "DonemID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "İlgili Dönem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Maaş:";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(525, 117);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMaas.Size = new System.Drawing.Size(120, 20);
            this.txtMaas.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(525, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Kaydet";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DonemAd
            // 
            this.DonemAd.DataPropertyName = "DonemAd";
            this.DonemAd.HeaderText = "Dönem";
            this.DonemAd.Name = "DonemAd";
            // 
            // MaasTutar
            // 
            this.MaasTutar.DataPropertyName = "MaasTutar";
            this.MaasTutar.HeaderText = "Tutar";
            this.MaasTutar.Name = "MaasTutar";
            // 
            // chart1
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Red;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.BorderColor = System.Drawing.Color.Yellow;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(466, 223);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Maas";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(511, 300);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Maaş Grafiği";
            this.chart1.Titles.Add(title1);
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
            this.tabKisiBilgileri.ResumeLayout(false);
            this.tabKisiBilgileri.PerformLayout();
            this.tabMaasBilgisi.ResumeLayout(false);
            this.tabMaasBilgisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.TabPage tabKisiBilgileri;
        private System.Windows.Forms.TabPage tabMaasBilgisi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.Label lblKisiBilgisi;
        private System.Windows.Forms.DataGridView dataGridMaas;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDonem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonemAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaasTutar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

