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
    public partial class frmHesap : Form
    {
        public frmHesap()
        {
            InitializeComponent();
        }

        private void frmHesap_Load(object sender, EventArgs e)
        {
            //cbHesapTur comboboxını dolduralım
            cbHesapTuru.DisplayMember = "HesapTurAd";
            cbHesapTuru.ValueMember = "HesapTurID";
            MiniBankaEntities vt = new MiniBankaEntities();
            cbHesapTuru.DataSource = vt.HesapTur.ToList();
        }

        vMusteri bankaMusteriBilgisi = null;
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string musteriNoVeyaTCNo = txtMusteriNoVeyaTCNo.Text;
            MiniBankaEntities vt = new MiniBankaEntities();
            bankaMusteriBilgisi = vt.vMusteri.Where(p => p.MusteriNo == musteriNoVeyaTCNo || p.TCNO == musteriNoVeyaTCNo).FirstOrDefault();
            if (bankaMusteriBilgisi != null)
            {
                lblMusteriAdSoyad.Text = bankaMusteriBilgisi.Ad + " " + bankaMusteriBilgisi.Soyad;
                btnOlustur.Enabled = true;
            }

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (bankaMusteriBilgisi != null)
            {
                string hesapNo = "";
                MiniBankaEntities vt = new MiniBankaEntities();
                List<Hesap> tumHesapListesi = vt.Hesap.OrderByDescending(p => p.HesapNo).ToList();
                if (tumHesapListesi == null || tumHesapListesi.Count == 0)
                { //sistemde kayıtlı henüz hiç hesap yok. İlk hesap noyu oluştur
                    hesapNo = "1000000000000001";
                }
                else
                { //sistemde hesaplar var. Son hesapNo yu al ve 1 artır. sıradaki hesap no olarak ver
                    decimal sayisalHesapNo = Convert.ToDecimal(tumHesapListesi[0].HesapNo);
                    sayisalHesapNo += 1;
                    hesapNo = sayisalHesapNo.ToString();
                }
                txtHesapNo.Text = hesapNo;


                //iban oluşturma kısmı

                string bankaKodu = bankaMusteriBilgisi.BankaKodu;

                string IBAN = "TR56" + bankaKodu + "0" + hesapNo;
                txtIBAN.Text = IBAN;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (bankaMusteriBilgisi != null)
            {
                using (MiniBankaEntities vt = new MiniBankaEntities())
                {
                    using (var transaction = vt.Database.BeginTransaction())
                    {
                        try
                        {
                            Hesap yeniHesap = new Hesap();
                            yeniHesap.BankaMusteriId = bankaMusteriBilgisi.BankaMusteriID;
                            yeniHesap.HesapTurId = Convert.ToInt32(cbHesapTuru.SelectedValue);
                            yeniHesap.HesapAd = txtHesapAd.Text;
                            yeniHesap.HesapNo = txtHesapNo.Text;
                            yeniHesap.IBAN = txtIBAN.Text;
                            yeniHesap.AcilisTarihi = DateTime.Now;
                            yeniHesap.KapanisTarihi = null;
                            yeniHesap.Aktif = true;
                            yeniHesap.Bakiye = Convert.ToDecimal(txtBakiye.Text);
                            vt.Hesap.Add(yeniHesap);
                            vt.SaveChanges();
                            int hesapID = yeniHesap.HesapID;

                            HesapHareket yeniHesapHareket = new HesapHareket();
                            yeniHesapHareket.HesapId = hesapID;
                            yeniHesapHareket.IslemTutari = yeniHesap.Bakiye;
                            yeniHesapHareket.IslemTurId = 1;  //Virman yani para yatırma
                            yeniHesapHareket.IslemYonu = "+";
                            yeniHesapHareket.IslemAciklamasi = lblMusteriAdSoyad.Text + " hesap açılması";
                            yeniHesapHareket.IslemTarihi = (DateTime)yeniHesap.AcilisTarihi;
                            vt.HesapHareket.Add(yeniHesapHareket);
                            int sonuc = vt.SaveChanges();
                            if (sonuc > 0)
                                MessageBox.Show("İşlem başarılı!");
                            else
                                MessageBox.Show("İşlem başarısız!");
                        }
                        catch (Exception hata)
                        {
                            transaction.Rollback();
                        }
                        finally
                        {
                            transaction.Commit();
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblMusteriAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriNoVeyaTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
