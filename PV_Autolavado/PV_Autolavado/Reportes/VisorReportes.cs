using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PV_Autolavado.Reportes
{
    public partial class VisorReportes : Form
    {
        public string fecha;
        public VisorReportes()
        {
            InitializeComponent();
        }

        public VisorReportes(String fca)
        {
            InitializeComponent();
        }

        private void VisorReportes_Load(object sender, EventArgs e)
        {
            this.ticketTableAdapter.FillBy(this.datos_Autolavado.ticket, this.fecha);
            this.visorReporteVentas.RefreshReport();
        }
    }
}
