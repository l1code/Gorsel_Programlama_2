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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            //cbBankaSube combobox dolduralım
            MiniBankaEntities vt = new MiniBankaEntities();
            cbBankaSube.DisplayMember = "BankaSubeAd";
            cbBankaSube.ValueMember = "BankaSubeID";
            cbBankaSube.DataSource = vt.BankaSube.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MiniBankaEntities vt=new MiniBankaEntities())
            {
                using(var transaction=vt.Database.BeginTransaction())
                {
                    try
                    {
                        //ilk tablonun bilgileri
                        Musteri musteri = new Musteri();
                        musteri.MusteriNo = txtMusteriNo.Text;
                        musteri.TCNO = txtTCNo.Text;
                        musteri.Ad = txtAd.Text;
                        musteri.Soyad = txtSoyad.Text;
                        musteri.DogumYeri = txtDogumYeri.Text;
                        musteri.DogumTarihi = dtDogumTarihi.Value;
                        musteri.EvAdresi = txtEvAdresi.Text;
                        musteri.IsAdresi = txtIsAdresi.Text;
                        musteri.Telefon = txtTelefon.Text;
                        vt.Musteri.Add(musteri);
                        vt.SaveChanges();
                        int musteriID = musteri.MusteriID; //kaydedilen MusteriID sini döndürür

                        //elde edilen MusteriId ile BankaMusteri Tablosuna kayıt
                        BankaMusteri bankaMusteri = new BankaMusteri();
                        bankaMusteri.BankaSubeId = Convert.ToInt32(cbBankaSube.SelectedValue);
                        bankaMusteri.MusteriId = musteriID;
                        bankaMusteri.IslemTarihi = DateTime.Now;
                        vt.BankaMusteri.Add(bankaMusteri);
                        int sonuc=vt.SaveChanges();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("İşlem başarılı!");
                            //transaction.commit i burada da çağırabilirsiniz
                        }
                        else
                            MessageBox.Show("İşlem başarısız!");

                    }
                    catch (Exception hata)
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        //hiç hata yoksa transactionı onayla
                        transaction.Commit(); //onayla
                    }
                }
            }
            
            
        }
    }
}
