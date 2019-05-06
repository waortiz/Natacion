using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Natacion
{
    public partial class ReporteDeportistas : Form
    {
        public ReporteDeportistas()
        {
            InitializeComponent();
        }

        private void ReporteDeportistas_Load(object sender, EventArgs e)
        {
            ControlDeportista control = new ControlDeportista();
            DataTable dsDeportistas = control.ConsultarDeportistas();

            /*var source = new ReportDataSource("dsDeportistas", dsDeportistas);
            rvReporteDeportistas.LocalReport.DataSources.Clear();
            rvReporteDeportistas.LocalReport.DataSources.Add(source);
            rvReporteDeportistas.LocalReport.Refresh();

            rvReporteDeportistas.Visible = true;
            rvReporteDeportistas.RefreshReport();*/
        }
    }
}
