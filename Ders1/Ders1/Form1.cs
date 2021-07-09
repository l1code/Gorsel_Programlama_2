using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " +
            "Data Source=" + Application.StartupPath + "\\veritabanim.accdb");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OleDbCommand kaydetKomutu = new OleDbCommand();
            kaydetKomutu.CommandText = "Insert into Kisi(TCNO,Ad,Soyad,DogumYeri,DogumTarihi,Cinsiyet)" +
                "values(@TCNO,@Ad,@Soyad,@DogumYeri,@DogumTarihi,@Cinsiyet)";
            kaydetKomutu.Parameters.AddWithValue("@TCNO", txtTCNO.Text);
            kaydetKomutu.Parameters.AddWithValue("@Ad", txtAd.Text);
            kaydetKomutu.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            kaydetKomutu.Parameters.AddWithValue("@DogumYeri", txtDogumYeri.Text);
            kaydetKomutu.Parameters.AddWithValue("@DogumTarihi", dtDogumTarihi.Value);
            kaydetKomutu.Parameters.AddWithValue("@Cinsiyet", rbKadin.Checked ? "Kadın" : "Erkek");
            kaydetKomutu.Connection = baglanti;
            baglanti.Open();
            int sonuc = kaydetKomutu.ExecuteNonQuery(); //komut çalıştırılıyor
            baglanti.Close();
            if (sonuc > 0)
            {
                MessageBox.Show("İşlem başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TumKayitlariListele();
                AlanlariTemizle();
            }
            else
                MessageBox.Show("İşlem başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void TumKayitlariListele()
        {
            OleDbCommand listelemeKomutu = new OleDbCommand();
            listelemeKomutu.CommandText = "Select * from Kisi";
            OleDbDataAdapter adaptor = new OleDbDataAdapter(listelemeKomutu);
            listelemeKomutu.Connection = baglanti;
            baglanti.Open();
            DataSet veriSetim = new DataSet();
            adaptor.Fill(veriSetim, "Kisi");
            dataGridView1.DataSource = veriSetim.Tables["Kisi"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TumKayitlariListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TumKayitlariListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand sorguKomutu = new OleDbCommand();
            sorguKomutu.CommandText = "Select * from Kisi where TCNO=@TCNO";
            sorguKomutu.Parameters.AddWithValue("@TCNO", txtTCNO.Text);
            AlanlariTemizle();
            sorguKomutu.Connection = baglanti;
            baglanti.Open();
            OleDbDataReader okuyucu = sorguKomutu.ExecuteReader();
            while (okuyucu.Read())
            {
                txtTCNO.Text = okuyucu["TCNO"].ToString();
                txtAd.Text = okuyucu["Ad"].ToString();
                txtSoyad.Text = okuyucu["Soyad"].ToString();
                txtDogumYeri.Text = okuyucu["DogumYeri"].ToString();
                dtDogumTarihi.Value = Convert.ToDateTime(okuyucu["DogumTarihi"].ToString());
                if (okuyucu["Cinsiyet"].ToString() == "Kadın")
                    rbKadin.Checked = true;
                else
                    rbErkek.Checked = true;
            }
            baglanti.Close();
        }

        void AlanlariTemizle()
        {
            txtTCNO.Text = "";
            txtAd.Text = string.Empty;
            txtSoyad.Clear();
            txtDogumYeri.Text = "";
            dtDogumTarihi.Value = DateTime.Now;
            rbKadin.Checked = true;
        }
    }
}
