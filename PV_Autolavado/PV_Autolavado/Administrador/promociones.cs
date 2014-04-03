using PV_Autolavado.Entidates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PV_Autolavado.Administrador
{
    public partial class promociones : Form
    {
        public promociones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           promocion pr = new promocion();
           pr.plg = this.preciopromo.Text;
           pr.ps = this.precioserv.Text;
           pr.pe = this.precioesp.Text;
           pr.descrip = this.descrip.Text;

           new query().crearpromocion(pr);
        }
     }
}
