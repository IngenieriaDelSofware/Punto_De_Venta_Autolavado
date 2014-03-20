/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 18/03/2014
 * Time: 10:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace usuarios
{
	/// <summary>
	/// Description of NuevoUsuario.
	/// </summary>
	public partial class NuevoUsuario : Form
	{
		public NuevoUsuario()
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
DialogResult rs = MessageBox.Show("Desea Salir", "Mensaje", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    Close();
                    menu m=new menu();
                    m.Show();
                }			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		this.conectarMySQL();
			string sql = ("INSERT INTO `punto_venta_autolavado`.`usuarios`" +
				" (`nom usu`,`contraseña`,`nombre`,`paterno`,`materno`,`fec nacimiento`,`fec ingreso`,`puesto`) " + 
				" VALUES (" +
				nombusu + "," +
				contraseña + ",'" +
				nombre + "','" +
				peterno + "','" +
				materno + "','" +
				fecnaciminento + "','" +
				fecingreso + "'," +
				puesto + ",'" +"');");

			this.ejecutarQuery(sql);
	this.desconectarMySQL();
		}
		
		
	}
}
