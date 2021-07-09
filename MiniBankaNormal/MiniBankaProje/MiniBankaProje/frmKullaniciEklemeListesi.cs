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
    public partial class frmKullaniciEklemeListesi : Form
    {
        public frmKullaniciEklemeListesi()
        {
            InitializeComponent();
        }

        private void frmKullaniciEklemeListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MiniBankaEntities vt = new MiniBankaEntities();
            dataGridView1.DataSource = vt.vKullanici.ToList();
        }
    }
}
