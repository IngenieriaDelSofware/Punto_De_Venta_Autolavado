using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PV_Autolavado.Entidates;

namespace PV_Autolavado
{

	public partial class Pantalla_Ventas : Form
	{
		private query query;
		private int n=1;
		private double ahrr=0;
		
		public Pantalla_Ventas(String user)
		{
			InitializeComponent();
            this.lblUsuario.Text = user;
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
				new Ventana_Productos(this).ShowDialog();
			}
		}
		
		void BtnTotalClick(object sender, EventArgs e)
		{
			if(dgvVentas.Rows.Count == 0){
				MessageBox.Show("Necesita agregar servicios");
			}
			else{
				MessageBox.Show(
					"Usted debe un total de: \n" + 
					this.ptxtTotal.Text + "\n Usted Ahorro: " + 
					this.ahrr.ToString());
				
				this.guardarTicket();
				this.reinciarPantalla();
			}
		}

		private void guardarTicket(){

			Ticket t = new Ticket();
			
			t.desglose = new List<Detalle_ticket>();

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
				Detalle_ticket dt = new Detalle_ticket();
				
				dt.id_ticket = int.Parse(this.lblTicket.Text);
				dt.id_servicio = 1;/*int.Parse(fila.Cells[1].Value.ToString()) Linea Real*/;
				dt.promocion = true;
				dt.ahorro = double.Parse(fila.Cells[4].Value.ToString());
				
				t.desglose.Add(dt);
			}

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
			
			this.dgvVentas.RowCount = 0;
			this.n = 1;
			
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
		
		public void agregarFilas(Servicio servicio){
			this.dgvVentas.Rows.Add(
				n,/*no Producto*/ 
				servicio.idservicio.ToString(), /*Codigo*/
				servicio.descripcion, /*descripcion*/
				servicio.costo.ToString(),
				-1.30,
				(servicio.costo - 1.30));/*Costo*/
				
			
			this.ptxtTotal.Sumar(servicio.costo - 1.30);
			this.ahrr = ahrr + (-1.30);
			n++;
		}

        private void Pantalla_Ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Login().Visible = true;
        }
	}
}
