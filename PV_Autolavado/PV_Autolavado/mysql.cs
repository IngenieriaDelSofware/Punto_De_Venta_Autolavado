/*
 * Comentarios sobre la clase:
 * 
 * se deben cambiar lo valores de userid y password 
 * con respecto a el servidor de cada quien.
 * 
 */
 
using System;
using MySql.Data.MySqlClient;

namespace PV_Autolavado
{
	public class mysql
	{
		private String server = "localhost";
		private String userid = "Modificar";
		private String password = "Modificar";
		private String database = "punto_venta_autolavado";
		private MySqlConnection conexion;
		
		public void conectarMySQL(){
		
			String cadenaConexion = ("server=" + server + "; database=" + database + "; Uid=" + userid + "; pwd=" + password + ";");
			
			conexion = new MySqlConnection(cadenaConexion);
			conexion.Open();
			
		}
		
		public void desconectarMySQL(){
			
			conexion.Close();
			conexion = null;
			
		}
		
	}
}
