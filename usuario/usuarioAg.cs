using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace usuario
{
	/// <summary>
	/// Description of usuarioAg.
	/// </summary>
	public class usuarioAg
	{
		 public static int Agregar(Datos pusuarioAg)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into empleado (nombre, apellido,direccion , telefono , tipo_sangre , Emergencia , fecha_final , fecha_ingreso ) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}', '{7}')",
                pusuarioAg.nombre, pusuarioAg.apellido, pusuarioAg.direccion, pusuarioAg.telefono, pusuarioAg.tipo_sangre, pusuarioAg.Emergencia, pusuarioAg.fecha_ingreso, pusuarioAg.fecha_final), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
       
	}
}
