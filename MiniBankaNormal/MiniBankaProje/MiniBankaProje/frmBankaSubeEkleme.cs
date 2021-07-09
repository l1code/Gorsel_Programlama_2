﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBankaProje
{
    public partial class frmBankaSubeEkleme : Form
    {
        public frmBankaSubeEkleme()
        {
            InitializeComponent();
        }

        private void frmBankaSubeEkleme_Load(object sender, EventArgs e)
        {
            MiniBankaEntities vt = new MiniBankaEntities();
            cbBanka.DisplayMember = "BankaAd";
            cbBanka.ValueMember = "BankaID";
            cbBanka.DataSource = vt.Banka.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BankaSube bankaSube = new BankaSube();
            bankaSube.BankaId = Convert.ToInt32(cbBanka.SelectedValue);
            bankaSube.BankaSubeAd = txtBankaSubeAd.Text;
            bankaSube.BankaSubeKodu = txtBankaSubeKod.Text;
            bankaSube.Tel = txtTelefon.Text;
            bankaSube.Faks = txtFaks.Text;
            bankaSube.Adres = txtAdres.Text;
            MiniBankaEntities vt = new MiniBankaEntities();
            vt.BankaSube.Add(bankaSube);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
                MessageBox.Show("İşlem başarılı!");
            else
                MessageBox.Show("İşlem başarısız!");
        }
    }
}
