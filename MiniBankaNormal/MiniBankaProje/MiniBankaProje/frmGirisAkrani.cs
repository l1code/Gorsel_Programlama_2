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
    public partial class frmGirisAkrani : Form
    {
        public frmGirisAkrani()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGirisAd.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Giriş adı ve şifre boş olamaz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //giriş adı ve şifre boş değil. Login olmaya çalış
                string girisAd = txtGirisAd.Text;
                string sifre = txtSifre.Text;
                MiniBankaEntities vt = new MiniBankaEntities();
                vKullanici girisKullanici = vt.vKullanici.SingleOrDefault(p => p.GirisAd == girisAd && p.GirisSifre == sifre);
                if (girisKullanici == null)
                {  //giriş adı ve şifre sistemde kayıtlı değil
                    MessageBox.Show("Kullanıcı bilgisi bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {  //kullanıcı bulundu giriş yap
                    frmAnaEkran anaEkran = new frmAnaEkran(girisKullanici);
                    anaEkran.Show();
                    this.Hide();
                }
            }
        }
    }
}
