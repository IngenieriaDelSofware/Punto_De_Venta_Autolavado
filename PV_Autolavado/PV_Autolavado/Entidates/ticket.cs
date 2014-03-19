/*
 * Clase que representa la entidad "ticket"
 */
 
using System;
using System.Collections.Generic;

namespace PV_Autolavado.Entidates
{

	public class ticket
	{
		
		public int id_ticket;
		public int id_usuario;
		public int id_lavador;
		public string propietario;
		public string placas;
		public string marca;
		public string modelo;
		public string color;
		public double total;
		public TimeSpan hora;
		public DateTime fecha;
		public List<detalle_ticket> desglose;
		
	}
}
