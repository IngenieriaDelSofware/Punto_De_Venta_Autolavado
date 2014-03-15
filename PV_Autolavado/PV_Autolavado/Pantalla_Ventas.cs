﻿using System;
using System.Drawing;
using System.Windows.Forms;
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
			this.Text = "Usuario: " + "Aqui va el nombre del usuario, " + "Ventas";
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
			
		/*public List<detalle_ticket> desglose;*/
			
			t.id_usuario = 1;
			t.id_lavador = 1;
			t.propietario = lblPropietario.Text;
			t.placas = lblPlacas.Text;
			t.marca = lblMarca.Text;
			t.modelo = lblModelo.Text;
			t.color = 1;
			t.total = ptxtTotal.Text;
			t.hora = DateTime.Today.TimeOfDay;
			t.fecha = DateTime.Today.Date;
			
			
			for(int i=0; i<=this.dgvVentas.Rows.Count; i++){
				/*public int id_detalle;
		public int id_ticket;
		public int id_servicio;
		public int id_tamano;
		public int promocion;*/
			}
			
		}
		
		private void reiniciaPantalla(){
			
		}

	}
}
