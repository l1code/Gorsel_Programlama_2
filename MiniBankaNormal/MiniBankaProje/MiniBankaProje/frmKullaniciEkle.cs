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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            //cbKullaniciRol ve cbGorevSube comboboxlarını dolduralım
            MiniBankaEntities vt = new MiniBankaEntities();
            cbKullaniciRol.DisplayMember = "KullaniciRolAd";
            cbKullaniciRol.ValueMember = "KullaniciRolID";
            cbKullaniciRol.DataSource = vt.KullaniciRol.ToList();
            cbGorevliSube.DisplayMember = "BankaSubeAd";
            cbGorevliSube.ValueMember = "BankaSubeID";
            cbGorevliSube.DataSource = vt.BankaSube.ToList();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciTCNO = txtTCNo.Text;
            kullanici.KullaniciAd = txtAd.Text;
            kullanici.KullaniciSoyad = txtSoyad.Text;
            kullanici.KullaniciRolId = Convert.ToInt32(cbKullaniciRol.SelectedValue);
            kullanici.GirisAd = txtGirisAd.Text;
            kullanici.GirisSifre = txtGirisSifre.Text;
            kullanici.BankaSubeId = Convert.ToInt32(cbGorevliSube.SelectedValue);
            kullanici.Gorev = txtGorev.Text;
            MiniBankaEntities vt = new MiniBankaEntities();
            vt.Kullanici.Add(kullanici);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
                MessageBox.Show("İşlem başarılı!");
            else
                MessageBox.Show("İşlem başarısız!");
        }
    }
}
