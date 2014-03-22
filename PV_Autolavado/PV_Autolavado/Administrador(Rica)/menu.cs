/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 14/03/2014
 * Time: 07:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV_Autolavado
{
	/// <summary>
	/// Description of menu.
	/// </summary>
	public partial class menu : Form
	{
		public menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			DialogResult rs = MessageBox.Show("Desea Salir", "Mensaje", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    Close();
                    Login m=new Login();
					m.Show();
                }			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Close();
			NuevoUsuario n=new NuevoUsuario();
			n.Show();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Close();
			EliminarUsuario ele=new EliminarUsuario();
			ele.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			nuevo_servicio serv=new nuevo_servicio();
			serv.Show();
			Close();
		}
	}
}
