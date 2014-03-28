/*
 * clase que representa a la tentidad "detalle_ticket"
 */
 
using System;

namespace PV_Autolavado.Entidates
{
	
	public class Detalle_ticket
	{
		public int id_detalle;
		public int id_ticket;
		public int id_servicio;
		public bool promocion;
		public double ahorro;

	}
}
