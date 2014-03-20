/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 18/03/2014
 * Time: 11:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace usuarios
{
	/// <summary>
	/// Description of EliminarUsuario.
	/// </summary>
	public partial class EliminarUsuario : Form
	{
		public EliminarUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
	}
}
