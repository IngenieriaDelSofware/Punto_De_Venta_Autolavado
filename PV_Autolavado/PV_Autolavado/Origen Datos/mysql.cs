/*
 * Comentarios sobre la clase:
 * 
 * se deben cambiar lo valores de userid y password 
 * con respecto a el servidor de cada quien.
 * 
 */
 
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PV_Autolavado
{
	public class mysql
	{
		private String server = "localhost";
		private String userid = "el_charco"; /*Modificar esta variable*/
		private String password = "12345Charco"; /*Modificar esta variable*/
		private String database = "punto_venta_autolavado";
		protected MySqlConnection conexion;
		
		public void conectarMySQL(){
			try{
		
			String cadenaConexion = ("server=" + server + "; database=" + database + "; Uid=" + userid + "; pwd=" + password + ";");
			
			conexion = new MySqlConnection(cadenaConexion);
			conexion.Open();
			}catch(MySqlException mysqle){
				MessageBox.Show(mysqle.ToString());
			}
		}
		
		public void desconectarMySQL(){
			
			conexion.Close();
			conexion = null;
			
		}
		
	}
}
