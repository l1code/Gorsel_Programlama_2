using System;
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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void frmAnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        enum RolKod
        {
            SistemAdmin,
            BankaMuduru,
            SubeMuduru,
            GiseGorevlisi,
            OperasyonSorumlusu,
            MusteriHizmetleriSorumlusu
        }

        void TumMenuleriGizle()
        {
            menuSistemAdmin.Visible = false;
            menuGiseGorevlisi.Visible = false;
        }
        public frmAnaEkran(vKullanici kullanici)
        {
            InitializeComponent();

            TumMenuleriGizle();

            if (kullanici.KullaniciRolKod == RolKod.SistemAdmin.ToString())
                menuSistemAdmin.Visible = true;

            if (kullanici.KullaniciRolKod == RolKod.GiseGorevlisi.ToString())
                menuGiseGorevlisi.Visible = true;

        }

        private void bankaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaBilgileri bankaBilgileri = new frmBankaBilgileri();
            bankaBilgileri.MdiParent = this; //mdi container(taşıyıcı) olan frmAnaEkran içinde açılsın diye
            bankaBilgileri.Show();
        }

        private void yeniŞubeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaSubeEkleme bankaSubeEkleme = new frmBankaSubeEkleme();
            bankaSubeEkleme.MdiParent = this;
            bankaSubeEkleme.Show();
        }

        private void şubeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankaSubeListesi bankaSubeListesi = new frmBankaSubeListesi();
            bankaSubeListesi.MdiParent = this;
            bankaSubeListesi.Show();
        }

        private void yeniKullanıcıEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle kullanciEkle = new frmKullaniciEkle();
            kullanciEkle.MdiParent = this;
            kullanciEkle.Show();
        }

        private void kullanıcıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciEklemeListesi kullaniciListesi = new frmKullaniciEklemeListesi();
            kullaniciListesi.MdiParent = this;
            kullaniciListesi.Show();
        }

        private void yeniMüşteriOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriEkle musteriEkle = new frmMusteriEkle();
            musteriEkle.MdiParent = this;
            musteriEkle.Show();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriListesi musteriListesi = new frmMusteriListesi();
            musteriListesi.MdiParent = this;
            musteriListesi.Show();
        }

        private void yeniHesapOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesap yeniHesap = new frmHesap();
            yeniHesap.MdiParent = this;
            yeniHesap.Show();
        }

        private void paraYatırmaÇekmeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaYatirmaCekme cekmeYatirmaIslemleri = new frmParaYatirmaCekme();
            cekmeYatirmaIslemleri.MdiParent = this;
            cekmeYatirmaIslemleri.Show();
        }
    }
}
