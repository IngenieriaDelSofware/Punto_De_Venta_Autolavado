/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 20/03/2014
 * Time: 08:54 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV_Autolavado
{
	/// <summary>
	/// Description of nuevo_servicio.
	/// </summary>
	public partial class nuevo_servicio : Form
	{
		public nuevo_servicio()
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
