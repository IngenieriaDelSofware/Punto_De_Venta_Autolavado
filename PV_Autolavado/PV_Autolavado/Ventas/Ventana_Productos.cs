using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PV_Autolavado.Entidates;

namespace PV_Autolavado
{
	public partial class Ventana_Productos : Form
	{
		int x=3, y=3;
		private Pantalla_Ventas padre;
		
		public Ventana_Productos(Pantalla_Ventas par)
		{
			InitializeComponent();
			this.padre = par;
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Dispose(); 
		}
		
		void Ventana_ProductosLoad(object sender, EventArgs e)
		{
			List<Servicio> servicios = new query().obtenerListaServicios();
			
			foreach (Servicio serv in servicios){
				
				if(x <= 327){
					BotonServicio boton = new BotonServicio(serv, padre);
					boton.Location = new System.Drawing.Point(x, y);
					this.pnlServicios.Controls.Add(boton);
				
					x = x+81;
				}else{
					x = 3;
					
					BotonServicio boton = new BotonServicio(serv, padre);
					boton.Location = new System.Drawing.Point(x, y);
					this.pnlServicios.Controls.Add(boton);
					
					y = y+70;
				}
			
				
			}
		}
	}
}
