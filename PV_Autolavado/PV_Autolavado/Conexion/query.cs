using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PV_Autolavado.Entidates;

namespace PV_Autolavado
{

	public class query : mysql
	{
		private MySqlDataReader scanner;
		private MySqlCommand comando;
		
		
		public void guardarTicket(ticket nota){
			
			this.conectarMySQL();
			string sql = ("INSERT INTO `punto_venta_autolavado`.`ticket`" +
				" (`id_usuario`,`id_lavador`,`propietario`,`placas`,`marca`,`modelo`,`color`,`total`,`hora`,`fecha`) " + 
				" VALUES (" +
				nota.id_usuario + "," +
				nota.id_lavador + "," +
				nota.propietario + "," +
				nota.placas + "," +
				nota.marca + "," +
				nota.modelo + "," +
				nota.color + "," +
				nota.total + "," +
				nota.hora + "," +
				nota.fecha + ");");
			
			this.ejecutarQuery(sql);
			
			for (int i=0; i<=nota.desglose.Count; i++){
				
			sql = ("INSERT INTO `punto_venta_autolavado`.`detalle_ticket`(`id_ticket`,`id_servicio`,`id_tamano`,`promocion`)" + 
						"VALUES (" +
						nota.desglose[i].id_ticket + "," +
						nota.desglose[i].id_servicio + "," +
						nota.desglose[i].id_tamano + "," +
						nota.desglose[i].promocion + ");");
			
			this.ejecutarQuery(sql);
			
			}
			this.desconectarMySQL();
		}
		
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
