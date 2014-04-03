using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using PV_Autolavado.Entidates;
using System.Windows.Forms;

namespace PV_Autolavado
{

	public class query : mysql
	{
		private MySqlDataReader scanner;
		private MySqlCommand comando;
		
		
		public void nuevoUsuario(Empleado user){
			
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
		
		public Empleado obtenerUsuario(string user){
			this.conectarMySQL();
			Empleado usuario = new Empleado();
			
			string cadena = "SELECT * FROM empleado WHERE nom usu = '" + user + "';";
			comando = new MySqlCommand(cadena, conexion);
			scanner = comando.ExecuteReader();
			
			while(scanner.Read()){
				usuario.nom_usu = scanner["nomusu"].ToString();
				usuario.puesto = int.Parse(scanner["puesto"].ToString());
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
				string cadena = ("SELECT 'nomusu' FROM empleados WHERE contraseña = '" + pass +"'");
				
				
				comando = new MySqlCommand(cadena, conexion);
				scanner = comando.ExecuteReader();
				
				while(scanner.Read()){
					usuario = scanner["nomusu"].ToString();
					
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
        public void crearpromocion(promocion promo)
        {
            this.conectarMySQL();
           
            string sql = ("INSERT INTO `punto_venta_autolavado`.`descuentos`" +
                " (`lgeneral`,`descservicio`,`descespecial`,`descripcion`) " +
                " VALUES (" +
                promo.pe + "," +
                promo.plg + "," +
                promo.ps + "," +
                promo.descrip + "," + "');");
            this.desconectarMySQL();

        }
		public void guardarTicket(Ticket nota){
			
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

        public void guardarEmpleado(Empleado emp)
        {
            this.conectarMySQL();
            string cadena = ( "INSERT INTO `punto_venta_autolavado`.`empleados`" +
                 "(`nomusu`,`contraseña`,`curp`,`nombre`,`paterno`,`materno`,`fec nacimiento`,`direccion`,`colonia`,`municipio`,`estado`,`fec ingreso`,`puesto`)" +
                " VALUES( '" +
                emp.nom_usu + "','" +
                emp.contraseña + "','" +
                emp.curp + "','" +
                emp.nombre + "','" +
                emp.paterno + "','" +
                emp.materno + "','" +
                emp.fec_nacimiento.ToString() + "','" +
                emp.direccion + "','" +
                emp.colonia + "','" +
                emp.municipio + "','" +
                emp.estado + "','" +
                emp.fec_ingreso.ToString() + "','" +
                emp.puesto + "');");

            this.ejecutarQuery(cadena);

            this.desconectarMySQL();
        }

        public void editarEmpleado(Empleado emp)
        {
            this.conectarMySQL();

            string cadena = ("UPDATE `punto_venta_autolavado`.`empleados`" +
                             "SET" +
                                "`nomusu` = '" + emp.nom_usu + "'," +
                                "`contraseña` = '" + emp.contraseña + "'," +
                                "`curp` = '" + emp.curp + "'," +
                                "`nombre` = '" + emp.nombre + "'," +
                                "`paterno` = '" + emp.paterno + "'," +
                                "`materno` = '" + emp.materno + "'," +
                                "`fec nacimiento` = '" + emp.fec_nacimiento.ToString() + "'," +
                                "`direccion` = '" + emp.direccion + "'," +
                                "`colonia` = '" + emp.colonia + "'," +
                                "`municipio` = '" + emp.municipio + "'," +
                                "`estado` = '" + emp.estado + "'," +
                                "`fec ingreso` = '" + emp.fec_ingreso.ToString() + "'," +
                                "`puesto` = " + emp.puesto + " " +
                                " WHERE `id` = " + emp.id + ";");

            this.ejecutarQuery(cadena);

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

        public void guardarServicio(Servicio serv)
        {
            this.conectarMySQL();
            string cadena = ("INSERT INTO servicio (descripcion, costo) values ('" + serv.descripcion + "', " + serv.costo + ");");

            this.ejecutarQuery(cadena);
            this.desconectarMySQL();
        }

        public void modificarServicio(Servicio serv)
        {
            this.conectarMySQL();

            string cadena = ("UPDATE servicio SET descripcion = '" + serv.descripcion + "', costo = " + serv.costo + " WHERE idservicio = " + serv.idservicio +";");

            this.ejecutarQuery(cadena);
            this.desconectarMySQL();
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

        public List<Empleado> obtenerListaEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            this.conectarMySQL();

            comando = new MySqlCommand(this.querySelect("empleados"), conexion);
            scanner = comando.ExecuteReader();

            while (scanner.Read())
            {
                Empleado emp = new Empleado();

                    emp.id = int.Parse(scanner["id"].ToString());
                    emp.nom_usu = scanner["nomusu"].ToString();
                    emp.contraseña = scanner["contraseña"].ToString();
                    emp.curp = scanner["curp"].ToString();
		            emp.nombre = scanner["nombre"].ToString();
		            emp.paterno = scanner["paterno"].ToString();
		            emp.materno = scanner["materno"].ToString();
		            emp.fec_nacimiento = scanner["fec nacimiento"].ToString();
                    emp.direccion = scanner["direccion"].ToString();
                    emp.colonia = scanner["colonia"].ToString();
                    emp.municipio = scanner["municipio"].ToString();
                    emp.estado = scanner["estado"].ToString(); 
		            emp.fec_ingreso = scanner["fec ingreso"].ToString();
		            emp.puesto = int.Parse(scanner["puesto"].ToString());
               

                lista.Add(emp);
            }

            this.desconectarMySQL();
            scanner.Close();
            scanner = null;
            comando.Dispose();
            comando = null;

            return lista;
        }

        public void eliminarRegistro(string tabla, string col, int id ) { 
            this.conectarMySQL();

            string cadena = ("delete from " + tabla + " where "+ col + " = "+ id +";" );

            this.ejecutarQuery(cadena);

            this.desconectarMySQL();
        }
        
        private string queryId(string id, string tabla){
			return "SELECT * from " + tabla +" where id='" + id + "'";
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
