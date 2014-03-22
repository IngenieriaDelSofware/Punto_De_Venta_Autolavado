using System;
using System.Drawing;
using System.Windows.Forms;
using PV_Autolavado.Entidates;


namespace PV_Autolavado
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
			usuario user = new usuario();
			
			user.fec_nacimiento = this.fecnacimiento.Value.ToShortDateString();
			user.puesto = this.puesto.SelectedValue.ToString();
			user.fec_ingreso = this.fecingreso.Value.ToShortDateString();
			user.materno = this.materno.Text;
			user.paterno = this.paterno.Text;
			user.nombre = this.nombre.Text;
			user.contraseña = this.contraseña.Text;
			user.nom_usu = this.nombusu.Text;	
		
			new query().nuevoUsuario(user);
		}
		
		
	}
}
