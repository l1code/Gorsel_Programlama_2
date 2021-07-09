using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class KisileriRaporla : Form
    {
        public KisileriRaporla()
        {
            InitializeComponent();
        }

        public KisileriRaporla(List<Kisi> kisiListesi)
        {
            InitializeComponent();
            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "Ders1.KisilerRaporu.rdlc"; // bind reportviewer with .rdlc            
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetKisi", kisiListesi); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
        }

        private void KisileriRaporla_Load(object sender, EventArgs e)
        {

        }
    }
}
