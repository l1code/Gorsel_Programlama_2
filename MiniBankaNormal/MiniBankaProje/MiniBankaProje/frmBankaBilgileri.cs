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
    public partial class frmBankaBilgileri : Form
    {
        public frmBankaBilgileri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MiniBankaEntities vt = new MiniBankaEntities();
            if (banka != null)
            { //güncelleme
                banka = vt.Banka.SingleOrDefault(p => p.BankaID == banka.BankaID);
                banka.BankaAd = txtBankaAd.Text;
                banka.BankaKodu = txtBankaKod.Text;
                banka.Tel = txtTelefon.Text;
                banka.Faks = txtFaks.Text;
                banka.Adres = txtAdres.Text;
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                    MessageBox.Show("İşlem başarılı!");
                else
                    MessageBox.Show("İşlem başarısız!");
            }
            else
            { //yeni kayıt
                banka = new Banka();
                banka.BankaAd = txtBankaAd.Text;
                banka.BankaKodu = txtBankaKod.Text;
                banka.Tel = txtTelefon.Text;
                banka.Faks = txtFaks.Text;
                banka.Adres = txtAdres.Text;
                vt.Banka.Add(banka);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                    MessageBox.Show("İşlem başarılı!");
                else
                    MessageBox.Show("İşlem başarısız!");
            }
        }

        Banka banka = null;
        private void frmBankaBilgileri_Load(object sender, EventArgs e)
        {
            MiniBankaEntities vt = new MiniBankaEntities();
            banka = vt.Banka.SingleOrDefault();
            if (banka != null)
            {
                txtBankaAd.Text = banka.BankaAd;
                txtBankaKod.Text = banka.BankaKodu;
                txtTelefon.Text = banka.Tel;
                txtFaks.Text = banka.Faks;
                txtAdres.Text = banka.Adres;
            }
        }
    }
}
