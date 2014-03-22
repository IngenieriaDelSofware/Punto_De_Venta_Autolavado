using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PV_Autolavado.Entidates;
using System.Windows.Forms;

namespace PV_Autolavado
{

	public class query : mysql
	{
		private MySqlDataReader scanner;
		private MySqlCommand comando;
		
		
		public void nuevoUsuario(usuario user){
			
			this.conectarMySQL();
			string sql = ("INSERT INTO `punto_venta_autolavado`.`usuarios`" +
				" (`nom usu`, `contraseña`, `nombre`,`paterno`,`materno`,`fec nacimiento`,`fec ingreso`,`puesto`) " + 
				" VALUES (" +
				user.nom_usu + "," +
				user.contraseña + ",'" +
				user.nombre + "','" +
				user.paterno + "','" +
				user.materno + "','" +
				user.fec_nacimiento + "','" +
				user.fec_ingreso + "'," +
				user.puesto + "');");

			this.ejecutarQuery(sql);
			this.desconectarMySQL();
		}
		
		public usuario obtenerUsuario(string user){
			this.conectarMySQL();
			usuario usuario = new usuario();
			
			string cadena = "SELECT * FROM usuarios WHERE nomusu = '" + user + "';";
			comando = new MySqlCommand(cadena, conexion);
			scanner = comando.ExecuteReader();
			
			while(scanner.Read()){
				usuario.nom_usu = scanner["nomusu"].ToString();
				usuario.puesto = scanner["puesto"].ToString();
			}
			
			scanner.Close();
			scanner = null;
			comando.Dispose();
			comando = null;
			this.desconectarMySQL();
			
			return usuario;
			
		}
		
		public Boolean validarUsuario(string user, string pass){
			bool val = false;
			string usuario = null;
			
				this.conectarMySQL();
				string cadena = ("SELECT nomusu FROM usuarios WHERE contraseña = '" + pass +"'");
				
				
				comando = new MySqlCommand(cadena, conexion);
				scanner = comando.ExecuteReader();
				
				while(scanner.Read()){
					usuario = scanner["nomusu"].ToString();
					MessageBox.Show("Bienvenido \n" + usuario);
					
				}
				
				scanner.Close();
				scanner = null;
				comando.Dispose();
				comando = null;
				this.desconectarMySQL();
				
				if(usuario == user){
					val = true;
				}
				
				else val = false;
			
			return val;
		}
		
		public void guardarTicket(ticket nota){
			
			this.conectarMySQL();
			string sql = ("INSERT INTO `punto_venta_autolavado`.`ticket`" +
				" (`id_usuario`,`id_lavador`,`propietario`,`placas`,`marca`,`modelo`,`color`,`total`,`hora`,`fecha`) " + 
				" VALUES (" +
				nota.id_usuario + "," +
				nota.id_lavador + ",'" +
				nota.propietario + "','" +
				nota.placas + "','" +
				nota.marca + "','" +
				nota.modelo + "','" +
				nota.color + "'," +
				nota.total + ",'" +
				nota.hora + "','" +
				nota.fecha + "');");
			
			this.ejecutarQuery(sql);
			
			for (int i=0; i<=nota.desglose.Count-1; i++){
				
			sql = ("INSERT INTO `punto_venta_autolavado`.`detalle_ticket`(`id_ticket`,`id_servicio`,`promocion`, `ahorro`)" + 
						"VALUES (" +
						nota.desglose[i].id_ticket + "," +
						nota.desglose[i].id_servicio + "," +
						nota.desglose[i].promocion + "," +
						nota.desglose[i].ahorro + ");");
			
			this.ejecutarQuery(sql);
			
			}
			this.desconectarMySQL();
		}
		
		public List<Servicio> obtenerListaServicios(){
			List<Servicio> lista = new List<Servicio>();
			this.conectarMySQL();
	
			comando = new MySqlCommand(this.querySelect("servicio"), conexion);
			scanner = comando.ExecuteReader();
			
			while(scanner.Read()){
				Servicio serv = new Servicio();
				
				
				serv.idservicio = int.Parse(scanner["idservicio"].ToString());
				serv.descripcion = scanner["descripcion"].ToString();
				serv.costo = double.Parse(scanner["costo"].ToString());
				
				lista.Add(serv);
			}
			
			this.desconectarMySQL();
			scanner.Close();
			scanner = null;
			comando.Dispose();
			comando = null;
			
			return lista;
		}
		
		public int ultimoRegistro(string tabla, string columna){
			
			this.conectarMySQL();
			
			string cadena = "select max(" + columna + ") as max from " + tabla + "";
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
	           	" FROM " + tabla;
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
