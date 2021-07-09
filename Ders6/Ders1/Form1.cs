using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kisi k1 = new Kisi();
                k1.TCNO = txtTCNO.Text;
                k1.Ad = txtAd.Text;
                k1.Soyad = txtSoyad.Text;
                k1.DogumYeri = txtDogumYeri.Text;
                k1.DogumTarihi = dtDogumTarihi.Value;
                k1.Cinsiyet = rbKadin.Checked ? "Kadın" : "Erkek";
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    k1.Resim = ms.ToArray();
                }
                DersGunduzEntities vt = new DersGunduzEntities();
                vt.Kisi.Add(k1);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TumKayitlariListele();
                    AlanlariTemizle();
                }
                else
                    MessageBox.Show("İşlem başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu! Hata metni:" + hata);
            }
        }

        void TumKayitlariListele()
        {
            DersGunduzEntities vt = new DersGunduzEntities();
            dataGridView1.DataSource = vt.Kisi.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TumKayitlariListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TumKayitlariListele();

            // maas donem comboboxı nı form açılırken dolduralım
            DersGunduzEntities vt = new DersGunduzEntities();
            cbDonem.DataSource = vt.Donem.ToList();


            //başlangıçta maaş bilgisi tabpage pasif yapalım
            (tabMaasBilgisi as Control).Enabled = false;


            //otomatik kolon eklemesn diye
            dataGridMaas.AutoGenerateColumns = false;           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgulanacakTCNO = txtTCNO.Text;
                DersGunduzEntities vt = new DersGunduzEntities();
                Kisi k1 = vt.Kisi.SingleOrDefault(p => p.TCNO == sorgulanacakTCNO);
                AlanlariTemizle();
                if (k1 != null)
                {
                    lblKisiNo.Text = k1.KisiID.ToString();
                    txtTCNO.Text = k1.TCNO;
                    txtAd.Text = k1.Ad;
                    txtSoyad.Text = k1.Soyad;
                    txtDogumYeri.Text = k1.DogumYeri;
                    dtDogumTarihi.Value = Convert.ToDateTime(k1.DogumTarihi);
                    if (k1.Cinsiyet == "Kadın")
                        rbKadin.Checked = true;
                    else
                        rbErkek.Checked = true;
                    if (k1.Resim != null)
                    {
                        MemoryStream ms = new MemoryStream(k1.Resim);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu! Hata metni:" + hata);
            }
        }

        void AlanlariTemizle()
        {
            lblKisiNo.Text = "";
            txtTCNO.Text = "";
            txtAd.Text = string.Empty;
            txtSoyad.Clear();
            txtDogumYeri.Text = "";
            dtDogumTarihi.Value = DateTime.Now;
            rbKadin.Checked = true;
            pictureBox1.Image = null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlanlariTemizle();
            Kisi k1 = (Kisi)dataGridView1.CurrentRow.DataBoundItem;
            lblKisiNo.Text = k1.KisiID.ToString();
            txtTCNO.Text = k1.TCNO;
            txtAd.Text = k1.Ad;
            txtSoyad.Text = k1.Soyad;
            txtDogumYeri.Text = k1.DogumYeri;
            dtDogumTarihi.Value = Convert.ToDateTime(k1.DogumTarihi);
            if (k1.Cinsiyet == "Kadın")
                rbKadin.Checked = true;
            else
                rbErkek.Checked = true;
            if (k1.Resim != null)
            {
                MemoryStream ms = new MemoryStream(k1.Resim);
                pictureBox1.Image = Image.FromStream(ms);
            }


            (tabMaasBilgisi as Control).Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int guncellenecekKisiID = Convert.ToInt32(lblKisiNo.Text);
                DersGunduzEntities vt = new DersGunduzEntities();
                Kisi k1 = vt.Kisi.FirstOrDefault(p => p.KisiID == guncellenecekKisiID);
                k1.TCNO = txtTCNO.Text;
                k1.Ad = txtAd.Text;
                k1.Soyad = txtSoyad.Text;
                k1.DogumYeri = txtDogumYeri.Text;
                k1.DogumTarihi = dtDogumTarihi.Value;
                k1.Cinsiyet = rbKadin.Checked ? "Kadın" : "Erkek";
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    k1.Resim = ms.ToArray();
                }
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TumKayitlariListele();
                    AlanlariTemizle();
                }
                else
                    MessageBox.Show("İşlem başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu! Hata metni:" + hata);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int silinecekKisiID = Convert.ToInt32(lblKisiNo.Text);
                DersGunduzEntities vt = new DersGunduzEntities();
                Kisi k1 = vt.Kisi.FirstOrDefault(p => p.KisiID == silinecekKisiID);
                vt.Kisi.Remove(k1);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TumKayitlariListele();
                    AlanlariTemizle();
                }
                else
                    MessageBox.Show("İşlem başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu! Hata metni:" + hata);
            }
        }

        int SecilenKisiID;
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) //farenin sağ tuşu tıklandıysa
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1) //satır ve kolon indeksi -1 den büyükse tam hücre içi tıklanmıştır
                {
                    SecilenKisiID = (dataGridView1.Rows[e.RowIndex].DataBoundItem as Kisi).KisiID;
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg dosyası|*.jpg|Png dosyası|*.png";
            ofd.ShowDialog();
            if (ofd.FileName != "")//resim dosyası seçildiyse
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DersGunduzEntities vt = new DersGunduzEntities();
                Kisi k1 = vt.Kisi.FirstOrDefault(p => p.KisiID == SecilenKisiID);
                vt.Kisi.Remove(k1);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TumKayitlariListele();
                    AlanlariTemizle();
                }
                else
                    MessageBox.Show("İşlem başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu! Hata metni:" + hata);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name != "tabKisiBilgileri" && lblKisiNo.Text == "")
            {
                MessageBox.Show("Lütfen bir kişi seçiniz");
                tabControl1.SelectedTab = tabControl1.TabPages["tabKisiBilgileri"];//ilgili kişinin maaş bilgisini göster        
            }
            else
            {
                lblKisiBilgisi.Text = txtAd.Text + " " + txtSoyad.Text;

                //ilgili kişinin kayıtlı maaş bilgilerinin getirilmesi
          

                if (lblKisiNo.Text != "")
                {
                    int kisiID = Convert.ToInt32(lblKisiNo.Text);
                    dataGridMaas.DataSource = KisiMaasBilgisiDondur(kisiID);


                    //chart ta grafik olarak maaş bilgileri gösterme
                    chart1.DataSource = dataGridMaas.DataSource;
                    chart1.DataBind();
                    chart1.Series[0].XValueMember = "DonemAd";
                    chart1.Series[0].YValueMembers = "MaasTutar";                 
                }
            }
        }


        List<vMaas> KisiMaasBilgisiDondur(int pKisiID)
        {
            DersGunduzEntities vt = new DersGunduzEntities();
            return vt.vMaas.Where(p => p.KisiId == pKisiID).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Maas kisiMaas = new Maas();
                kisiMaas.KisiId = Convert.ToInt32(lblKisiNo.Text);
                kisiMaas.DonemId = Convert.ToInt32(cbDonem.SelectedValue);
                kisiMaas.MaasTutar = Convert.ToDecimal(txtMaas.Text);
                DersGunduzEntities vt = new DersGunduzEntities();
                vt.Maas.Add(kisiMaas);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("İşlem başarılı");
                    dataGridMaas.DataSource = KisiMaasBilgisiDondur(kisiMaas.KisiId);
                    //chart ta grafik olarak maaş bilgileri gösterme
                    chart1.DataSource = dataGridMaas.DataSource;
                    chart1.DataBind();
                    chart1.Series["Maas"].XValueMember = "DonemAd";
                    chart1.Series["Maas"].YValueMembers = "MaasTutar";
                }
                else
                {
                    MessageBox.Show("İşlem başarısız!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu! Hata metni:" + hata);
            }
        }
    }
}
