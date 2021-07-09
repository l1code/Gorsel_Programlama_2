using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        SqlConnection baglanti = new SqlConnection("Data source=Server adı yaz; " +
            "initial catalog=Database adı yazılcak; integrated security=true");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydetKomutu = new SqlCommand();
            kaydetKomutu.CommandText = "Insert into Kisi(TCNO,Ad,Soyad,DogumYeri,DogumTarihi,Cinsiyet,Resim)" +
                "values(@TCNO,@Ad,@Soyad,@DogumYeri,@DogumTarihi,@Cinsiyet,@Resim)";
            kaydetKomutu.Parameters.AddWithValue("@TCNO", txtTCNO.Text);
            kaydetKomutu.Parameters.AddWithValue("@Ad", txtAd.Text);
            kaydetKomutu.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            kaydetKomutu.Parameters.AddWithValue("@DogumYeri", txtDogumYeri.Text);
            kaydetKomutu.Parameters.AddWithValue("@DogumTarihi", dtDogumTarihi.Value);
            kaydetKomutu.Parameters.AddWithValue("@Cinsiyet", rbKadin.Checked ? "Kadın" : "Erkek");
            //// resim ekleme ///
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                kaydetKomutu.Parameters.AddWithValue("@Resim", ms.ToArray());
            }
            /////////////////////
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
            SqlCommand listelemeKomutu = new SqlCommand();
            listelemeKomutu.CommandText = "Select * from Kisi";
            SqlDataAdapter adaptor = new SqlDataAdapter(listelemeKomutu);
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
            //TumKayitlariListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sorguKomutu = new SqlCommand();
            sorguKomutu.CommandText = "Select * from Kisi where TCNO=@TCNO";
            sorguKomutu.Parameters.AddWithValue("@TCNO", txtTCNO.Text);
            AlanlariTemizle();
            sorguKomutu.Connection = baglanti;
            baglanti.Open();
            SqlDataReader okuyucu = sorguKomutu.ExecuteReader();
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
            //datagridview deki verileri arayüzdeki diğer kontrollere aktarıyoruz
            lblKisiNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTCNO.Text = dataGridView1.CurrentRow.Cells["TCNO"].Value.ToString(); //TCNO yerine 1 de olur
            txtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); //3 yerine Soyad da olur
            txtDogumYeri.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtDogumTarihi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
            if (dataGridView1.CurrentRow.Cells["Cinsiyet"].Value.ToString() == "Kadın")
                rbKadin.Checked = true;
            else
                rbErkek.Checked = true;
            /// resim oluşturma ///
            if (dataGridView1.CurrentRow.Cells["Resim"].Value != null) //null değilse resim vardır
            {
                byte[] resimBytes = (byte[])dataGridView1.CurrentRow.Cells["Resim"].Value;
                MemoryStream ms = new MemoryStream(resimBytes);
                pictureBox1.Image = Image.FromStream(ms);
            }
            ///////////////////////

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelleKomutu = new SqlCommand();
            guncelleKomutu.CommandText = "Update Kisi Set TCNO=@TCNO,Ad=@Ad,Soyad=@Soyad,DogumYeri=@DogumYeri," +
                "DogumTarihi=@DogumTarihi,Cinsiyet=@Cinsiyet,Resim=@Resim where KisiID=@KisiID";
            guncelleKomutu.Parameters.AddWithValue("@TCNO", txtTCNO.Text);
            guncelleKomutu.Parameters.AddWithValue("@Ad", txtAd.Text);
            guncelleKomutu.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            guncelleKomutu.Parameters.AddWithValue("@DogumYeri", txtDogumYeri.Text);
            guncelleKomutu.Parameters.AddWithValue("@DogumTarihi", dtDogumTarihi.Value);
            guncelleKomutu.Parameters.AddWithValue("@Cinsiyet", rbKadin.Checked ? "Kadın" : "Erkek");
            //// resim ekleme ///
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                guncelleKomutu.Parameters.AddWithValue("@Resim", ms.ToArray());
            }
            /////////////////////
            guncelleKomutu.Parameters.AddWithValue("@KisiID", Convert.ToInt32(lblKisiNo.Text));
            guncelleKomutu.Connection = baglanti;
            baglanti.Open();
            int sonuc = guncelleKomutu.ExecuteNonQuery(); //komut çalıştırılıyor
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand silKomutu = new SqlCommand();
            silKomutu.CommandText = "Delete * from Kisi where KisiID=@KisiID";
            silKomutu.Parameters.AddWithValue("@KisiID", Convert.ToInt32(lblKisiNo.Text));
            silKomutu.Connection = baglanti;
            baglanti.Open();
            int sonuc = silKomutu.ExecuteNonQuery(); //komut çalıştırılıyor
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

        int SecilenKisiID;
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) //farenin sağ tuşu tıklandıysa
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1) //satır ve kolon indeksi -1 den büyükse tam hücre içi tıklanmıştır
                {
                    SecilenKisiID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["KisiID"].Value);
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SecilenKidiID yi sağ tıklayarak doldurduk. Silme işlemi yapalım
            SqlCommand silKomutu = new SqlCommand();
            silKomutu.CommandText = "Delete * from Kisi where KisiID=@KisiID";
            silKomutu.Parameters.AddWithValue("@KisiID", SecilenKisiID);
            silKomutu.Connection = baglanti;
            baglanti.Open();
            int sonuc = silKomutu.ExecuteNonQuery(); //komut çalıştırılıyor
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
    }
}
