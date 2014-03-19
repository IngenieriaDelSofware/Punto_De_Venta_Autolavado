using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PV_Autolavado.Entidates;

namespace PV_Autolavado
{

	public partial class Pantalla_Ventas : Form
	{
		public int n=1;
		private query query;
		
		public Pantalla_Ventas()
		{
			InitializeComponent();
		}
		
		void Pantalla_VentasLoad(object sender, EventArgs e)
		{

			this.Text = DateTime.Now.ToLongDateString() + "-" + DateTime.Now.ToLongTimeString();
			query = new query();
			int t = query.ultimoRegistro("ticket", "id_ticket");
			this.lblTicket.Text = (t+1).ToString();
		
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
		
		private void guradarTicket(){
			
			ticket t = new ticket();
			
			t.desglose = new List<detalle_ticket>();

			t.id_usuario = 1;
			t.id_lavador = 1;
			t.propietario = lblPropietario.Text;
			t.placas = lblPlacas.Text;
			t.marca = lblMarca.Text;
			t.modelo = lblModelo.Text;
			t.color = "rojo";
			t.total = Double.Parse(ptxtTotal.Text);
			t.hora = DateTime.Today.TimeOfDay;
			t.fecha = DateTime.Today.Date;
			
			
			for(int i=0; i<=this.dgvVentas.Rows.Count; i++){
				/*public int id_detalle;
		public int id_ticket;
		public int id_servicio;
		public int promocion;
				 ahorro*/
				
				
			}
			
		}
		
		
		void ContadorRelojTick(object sender, EventArgs e)
		{
			this.Text = DateTime.Now.ToLongDateString() + "-" + DateTime.Now.ToLongTimeString();			
		}
		
		void BtnNuevoCobroClick(object sender, EventArgs e)
		{
			NvoCobro vnt = new NvoCobro();
			DialogResult res = vnt.ShowDialog();
			
			if(res == DialogResult.OK){
				this.lblPropietario.Text = vnt.t.propietario;
				this.lblModelo.Text = vnt.t.modelo;
				this.lblMarca.Text = vnt.t.marca;
				this.lblColor.Text = vnt.t.color;
				this.lblPlacas.Text = vnt.t.placas;
			}
		}
	}
}
