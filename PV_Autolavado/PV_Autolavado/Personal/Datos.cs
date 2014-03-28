using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Autolavado
{
	/// <summary>
	/// Description of Datos.
	/// </summary>
	public class Datos
	{
		//public Datos();
		
			public int Id { get; set; }
       public string nombre { get; set; }
       public string apellido { get; set; }
       public string fecha_ingreso { get; set; }
       public string fecha_final { get; set; }
       public string direccion { get; set; }
        public string telefono { get; set; }
        public string tipo_sangre { get; set; }
        public string Emergencia { get; set; }

       public Datos() { }

       public Datos(int pId, string pnombre, string papellido, string pfecha_ingreso, string pfecha_final,
                             string pdireccion, string ptelefono, string ptipo_sangre, string pEmergencia)

       {
           this.Id = pId;
           this.nombre = pnombre;
           this.apellido = papellido;
           this.fecha_ingreso = pfecha_ingreso;
           this.fecha_final = pfecha_final;
           this.direccion = pdireccion;
           this.telefono = ptelefono;
           this.tipo_sangre = ptipo_sangre;
           this.Emergencia = pEmergencia;
       }
    }
		}
	

