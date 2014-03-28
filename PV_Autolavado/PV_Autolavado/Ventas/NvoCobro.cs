using System;
using System.Drawing;
using System.Windows.Forms;
using PV_Autolavado.Entidates;

namespace PV_Autolavado
{
	public partial class NvoCobro : Form
	{
		public Ticket t;
		
		public NvoCobro()
		{
			InitializeComponent();
		}

		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			t = new Ticket();
			
			t.propietario = this.txtPropietario.Text;
			t.placas = this.txtPlacas.Text;
			t.modelo = this.txtModelo.Text;
			t.marca = this.txtMarca.Text;
			t.color = this.txtColor.Text;
		}

	}
}
