using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PV_Autolavado
{
	
	public class conexion
	{
		//public conexion();
		
			 public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=punta_venta_autolavado; Uid=root; pwd=12345Charco;");

            conectar.Open();
            return conectar;
			 }
		}
}
	
