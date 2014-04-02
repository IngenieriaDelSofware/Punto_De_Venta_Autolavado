using System;
using System.Windows.Forms;
using PV_Autolavado.Entidates;

namespace PV_Autolavado
{

	public class BotonServicio : Button
	{
		private Servicio servicio;
		private Pantalla_Ventas padre;
		
		public BotonServicio()
		{
			this.Click += new EventHandler(this.eventoClick);
			this.Size = new System.Drawing.Size(75,64);	
			this.Text = (
				"id \n" +
				"descripcion \n" +
				"$ 0.00 \n");			
		}
		
		public BotonServicio(Servicio serv, Pantalla_Ventas pnt_vnt){
			this.servicio = serv;
			this.padre = pnt_vnt;
			this.Click += new EventHandler(this.eventoClick);
			
			this.Text = (
				servicio.idservicio + "\n" +
				servicio.descripcion + "\n" +
				"$ " + servicio.costo + "\n");
			
			this.Size = new System.Drawing.Size(75,64);
		}
	
		void eventoClick(object sender, EventArgs e){
			this.padre.agregarFilas(this.servicio);
            this.Enabled = false;
		}
	
	}
}
