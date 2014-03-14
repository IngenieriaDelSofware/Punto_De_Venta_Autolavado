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
		
		}
		
		void BtnAgregarServicioClick(object sender, EventArgs e)
		{
			dgvVentas.Rows.Add(n, "Servicio 1", "$ 10.00", "$ 1.60", "$ 11.60");

			this.ptxtTotal.Sumar(11.60);
			n++;
		}
		
		void BtnTotalClick(object sender, EventArgs e)
		{
			MessageBox.Show("Usted debe un total de: \n" + this.ptxtTotal.Text + "\n Ahorro un putero");
			n=1;
			this.dgvVentas.RowCount = 1;

			this.ptxtTotal.Default();
		}
		
		void BtnOpcionesClick(object sender, EventArgs e)
		{
			MessageBox.Show("Aqui va un menu de Opciones \n En caso de existir");
		}

	}
}
