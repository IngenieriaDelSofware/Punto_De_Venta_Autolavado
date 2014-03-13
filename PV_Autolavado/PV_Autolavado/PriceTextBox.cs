using System;
using System.Windows.Forms;
	
namespace PV_Autolavado
{

	public class PriceTextBox : TextBox
	{
		private Double cantidad = 0.00;
		
		public PriceTextBox()
		{
			this.Text = "$" + (cantidad).ToString("N2");
			this.TextAlign = HorizontalAlignment.Right;
		}
		
		public PriceTextBox(Double cant){
			this.Text = "$" + (cant).ToString("N2");
			this.TextAlign = HorizontalAlignment.Right;
		}
		
		public void PonerCantidad(Double cant){
			this.Text = "$ " + (cant).ToString("N2");
		}
		
		public void Sumar(Double cant){
			this.cantidad = cantidad + cant;
			this.Text = "$" + (cantidad).ToString("N2");
		}
		
		public void Default(){
			this.cantidad = 0;
			this.Text = cantidad.ToString("N2");
		}
		
		public Double Cantidad{
			set{ this.cantidad = value; }
			get{ return this.cantidad; }
		}
	}
}
