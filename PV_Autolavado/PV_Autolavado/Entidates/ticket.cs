/*
 * Clase que representa la entidad "ticket"
 */
 
using System;
using System.Collections.Generic;
using MySql.Data.Types;

namespace PV_Autolavado.Entidates
{

	public class Ticket
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
		public string hora;
		public string fecha;
		public List<Detalle_ticket> desglose;
	}
}
