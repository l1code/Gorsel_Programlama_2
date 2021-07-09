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
    public partial class frmBankaSubeListesi : Form
    {
        public frmBankaSubeListesi()
        {
            InitializeComponent();
        }

        private void frmBankaSubeListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MiniBankaEntities vt = new MiniBankaEntities();
            dataGridView1.DataSource = vt.BankaSube.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiniBankaEntities vt = new MiniBankaEntities();
            List<BankaSube> orjinalSubeListesi = vt.BankaSube.ToList();
            List<BankaSube> griddekiSubeListesi=dataGridView1.DataSource as List<BankaSube>;
            foreach (var orjinalSube in orjinalSubeListesi)
            {
                foreach (var griddekiSube in griddekiSubeListesi)
                {
                    if(orjinalSube.BankaSubeID==griddekiSube.BankaSubeID)
                    {
                        orjinalSube.BankaSubeAd = griddekiSube.BankaSubeAd;
                        orjinalSube.BankaSubeKodu = griddekiSube.BankaSubeKodu;
                        orjinalSube.Tel = griddekiSube.Tel;
                        orjinalSube.Faks = griddekiSube.Faks;
                        orjinalSube.Adres = griddekiSube.Adres;                        
                    }
                }
            }
            int sonuc=vt.SaveChanges();
            if (sonuc > 0)
                MessageBox.Show("İşlem başarılı!");
            else
                MessageBox.Show("İşlem başarısız!");
        }
    }
}
