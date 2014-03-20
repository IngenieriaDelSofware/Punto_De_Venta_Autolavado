/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 20/03/2014
 * Time: 09:01 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace usuarios
{
	/// <summary>
	/// Description of quitarservicio.
	/// </summary>
	public partial class quitarservicio : Form
	{
		public quitarservicio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
DialogResult rs = MessageBox.Show("Desea Salir", "Mensaje", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                	
                }
		}
	}
}
