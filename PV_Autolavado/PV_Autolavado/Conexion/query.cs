using System;
using MySql.Data.MySqlClient;

namespace PV_Autolavado
{

	public class query : mysql
	{
		private MySqlDataReader scanner;
		private MySqlCommand comando;
		
		public int ultimoRegistro(string tabla, string columna){
			
			this.conectarMySQL();
			
			String cadena = "select max(" + columna + ") as max from " + tabla + "";
			comando = new MySqlCommand(cadena, conexion);
			scanner = comando.ExecuteReader();
			int max = 0;
			
			while(scanner.Read()){
				max = (int)scanner["max"];
			}
			
			scanner.Close();
			scanner = null;
			comando.Dispose();
			comando = null;
			this.desconectarMySQL();
			
			return max;
			
		}
		
		private string queryId(string id){
			return "SELECT * from tabla1 where id='" + id + "'";
		}
		
		private string querySelect(string tabla){
			return "SELECT * " +
	           	"FROM" + tabla;
		}
	
		private int ejecutarQuery(string query){
			
			comando = new MySqlCommand(query,this.conexion);
			int afectadas = comando.ExecuteNonQuery();
			comando.Dispose();
			comando = null;
			
			return afectadas;
		}	

	}
}
