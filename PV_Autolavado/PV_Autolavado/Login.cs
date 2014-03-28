using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PV_Autolavado.Entidates;

namespace PV_Autolavado
{
	
	public partial class Login : Form
	{
		public Login()
		{
			
			InitializeComponent();
			
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void TabPage1Click(object sender, EventArgs e)
		{

		

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.validarLogin();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
		
		public void validarLogin(){
			
			if(new query().validarUsuario(this.txtUser.Text, this.txtPass.Text)){
				Empleado user  = new query().obtenerUsuario(this.txtUser.Text);
				
				if(user.puesto == 1){
					new MenuAdministrador(user.nom_usu).Show();
					this.Hide();
				}
				
				if(user.puesto == 2){
					new Pantalla_Ventas(user.nom_usu).Show();
					this.Hide();
				}
			}
			else MessageBox.Show("no mames estas mal");
		}
	}
}
