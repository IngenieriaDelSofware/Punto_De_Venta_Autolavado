using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PV_Autolavado.Entidates;

namespace PV_Autolavado
{

	public partial class Pantalla_Ventas : Form
	{
		private int n=1;
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
			if(this.validarCampos()){
				MessageBox.Show("Necesita agregar una nueva venta");
			}
			else{
			dgvVentas.Rows.Add(n, "12345", "Servicio 1", "10.00", "1.60", "11.60");

			this.ptxtTotal.Sumar(11.60);
			n++;
			}
		}
		
		void BtnTotalClick(object sender, EventArgs e)
		{
			if(dgvVentas.Rows.Count == 1){
				MessageBox.Show("Necesita agregar servicios");
			}
			else{
				MessageBox.Show("Usted debe un total de: \n" + this.ptxtTotal.Text + "\n Ahorro un putero");
				this.guardarTicket();
				this.reinciarPantalla();
			}
		}

		private void guardarTicket(){

			ticket t = new ticket();
			
			t.desglose = new List<detalle_ticket>();

			t.id_usuario = 1;
			t.id_lavador = 1;
			t.propietario = lblPropietario.Text;
			t.placas = lblPlacas.Text;
			t.marca = lblMarca.Text;
			t.modelo = lblModelo.Text;
			t.color = lblColor.Text;
			t.total = ptxtTotal.Cantidad;
			t.hora = DateTime.Now.TimeOfDay.ToString();
			t.fecha = DateTime.Now.Date.ToShortDateString();
			
			foreach (DataGridViewRow fila in dgvVentas.Rows){
				detalle_ticket dt = new detalle_ticket();
				
				dt.id_ticket = int.Parse(this.lblTicket.Text);
				dt.id_servicio = 1;/*int.Parse(fila.Cells[1].Value.ToString()) Linea Real*/;
				dt.promocion = true;
				dt.ahorro = double.Parse(fila.Cells[4].Value.ToString());
				
				t.desglose.Add(dt);
			}

			this.label3.Text = t.hora;
			this.label4.Text = t.fecha;
			
			query = new query();
			query.guardarTicket(t);

		}
		
		
		void ContadorRelojTick(object sender, EventArgs e)
		{
			this.Text = DateTime.Now.ToLongDateString() + "-" + DateTime.Now.ToLongTimeString();			
		}
		
		void BtnNuevoCobroClick(object sender, EventArgs e)
		{
			if(validarCampos()){
				NvoCobro vnt = new NvoCobro();
				DialogResult res = vnt.ShowDialog();
				
				if(res == DialogResult.OK){
					this.lblPropietario.Text = vnt.t.propietario;
					this.lblModelo.Text = vnt.t.modelo;
					this.lblMarca.Text = vnt.t.marca;
					this.lblColor.Text = vnt.t.color;
					this.lblPlacas.Text = vnt.t.placas;
				}
				
				vnt.Dispose();
			}
			else{
				MessageBox.Show("Debe finalizar el cobro actual primero");
			}
		}
		
		private void reinciarPantalla(){
			this.ptxtTotal.Default();
			
			this.lblPropietario.Text = "Propietario";
			this.lblModelo.Text = "Modelo";
			this.lblMarca.Text = "Marca";
			this.lblColor.Text = "Color";
			this.lblPlacas.Text = "Placas";
			
			n=1;
			this.dgvVentas.RowCount = 0;
			
			
			this.lblTicket.Text = (new query().ultimoRegistro("ticket", "id_ticket") + 1).ToString();
			
		}
		
		private Boolean validarCampos(){
			Boolean val = false;
				
				if (lblPropietario.Text == "Propietario"){
				val = true;
				}
					if (lblPlacas.Text == "Placas"){
						val = true;
					}
				
						if (lblColor.Text == "Color"){
							val = true;
						}
				
					if (lblMarca.Text == "Marca"){
						val = true;
					}
				
				if (lblModelo.Text == "Modelo"){
					val = true;
				}

			return val;
		}
	}
}
