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
    public partial class VisorPersonal : Form
    {
        public VisorPersonal()
        {
            InitializeComponent();
        }

        private void VisorPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datos_Autolavado.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.datos_Autolavado.empleados);

            this.reportViewer1.RefreshReport();
        }
    }
}
