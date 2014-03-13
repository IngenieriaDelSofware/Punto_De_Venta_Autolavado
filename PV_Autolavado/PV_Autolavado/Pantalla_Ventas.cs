using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV_Autolavado
{

	public partial class Pantalla_Ventas : Form
	{
		public int n=1;
		public Pantalla_Ventas()
		{
			InitializeComponent();
		}
		
		void Pantalla_VentasLoad(object sender, EventArgs e)
		{
			this.Text = "Ventas " + "Usuario";
			this.txtSubtotal.Text = "$ 0.00";
			this.txtIVA.Text = "$ 0.00";
			this.txtTotal.Text = "$ 0.00";			
		}
		
		void BtnAgregarServicioClick(object sender, EventArgs e)
		{
			dgvVentas.Rows.Add();
		}
		
		void BtnTotalClick(object sender, EventArgs e)
		{
			MessageBox.Show("Usted a ahorrado un putero");
		}
		
		void BtnOpcionesClick(object sender, EventArgs e)
		{
			MessageBox.Show("Aqui va un menu de Opciones \n En caso de existir");
		}
		
	}
}
