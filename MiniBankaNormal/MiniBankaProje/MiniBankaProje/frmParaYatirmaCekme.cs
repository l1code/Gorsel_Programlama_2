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
    public partial class frmParaYatirmaCekme : Form
    {
        public frmParaYatirmaCekme()
        {
            InitializeComponent();
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
                btnKaydet.Enabled = true;

                //bulunan müşteriye ait hesapları cbMusteriHesaplari comboboxına dolduralım
                cbMusteriHesaplari.Items.Clear();
                List<Hesap> musteriHesapListesi = vt.Hesap.Where(p => p.BankaMusteriId == bankaMusteriBilgisi.BankaMusteriID).ToList();
                if (musteriHesapListesi != null)
                    cbMusteriHesaplari.DataSource = musteriHesapListesi;
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
                            //ilk önce hesap hareketi tablosuna kayıt yapalım
                            HesapHareket yeniHesapHareketi = new HesapHareket();
                            yeniHesapHareketi.HesapId = Convert.ToInt32(cbMusteriHesaplari.SelectedValue);
                            yeniHesapHareketi.IslemTutari = Convert.ToDecimal(txtIslemTutari.Text);
                            yeniHesapHareketi.IslemTurId = Convert.ToInt32(cbIslemTuru.SelectedValue);
                            yeniHesapHareketi.IslemYonu = rbParaYatirma.Checked ? "+" : "-";
                            yeniHesapHareketi.IslemAciklamasi = txtIslemAciklamasi.Text;
                            yeniHesapHareketi.IslemTarihi = DateTime.Now;
                            vt.HesapHareket.Add(yeniHesapHareketi);
                            int sonuc=vt.SaveChanges();
                            if(sonuc>0)
                            {
                                //Hesap tablosunda ilgili hesabın bakiyesini güncelle
                                Hesap guncellenecekHesap = vt.Hesap.SingleOrDefault(p=>p.HesapID==yeniHesapHareketi.HesapId);
                                if (yeniHesapHareketi.IslemYonu == "+")
                                    guncellenecekHesap.Bakiye += yeniHesapHareketi.IslemTutari;
                                else
                                    guncellenecekHesap.Bakiye -= yeniHesapHareketi.IslemTutari;

                                sonuc = vt.SaveChanges();
                                if (sonuc > 0)
                                    MessageBox.Show("İşlem başarılı!");
                                else
                                    MessageBox.Show("İşlem başarısız!");
                            }
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

        private void frmParaYatirmaCekme_Load(object sender, EventArgs e)
        {
            cbMusteriHesaplari.Items.Clear();
            cbMusteriHesaplari.DisplayMember = "HesapAd";
            cbMusteriHesaplari.ValueMember = "HesapID";

            cbIslemTuru.DisplayMember = "IslemTurAd";
            cbIslemTuru.ValueMember = "IslemTurID";
            MiniBankaEntities vt = new MiniBankaEntities();
            cbIslemTuru.DataSource = vt.IslemTur.ToList();
        }
    }
}
