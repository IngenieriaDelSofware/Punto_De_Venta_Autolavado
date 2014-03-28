
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace PV_Autolavado
{
	
	public partial class MostrarUsuario : Form
		
		
	{
		
		public MySqlConnection cn;
		
		
		
		
		public MostrarUsuario()
		{
			
			InitializeComponent();
			
		}
		
		
		void MostrarUsuarioLoad(object sender, EventArgs e)
		{
			cn=new MySqlConnection("server=127.0.0.1; database punto_venta_autolavado=; Uid=root; pwd=12345Charco; ");
}
		
		void BtnMostrarClick(object sender, EventArgs e)
		{
			cn.Open();
                      MySqlDataAdapter dac=new MySqlDataAdapter("select * from empleado",cn);
                      DataTable dtc=new DataTable();
dac.Fill(dtc);
this.dgClientes.DataSource=dtc;
cn.Close();
		}
		
		
		
	
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
	    MainForm regresar = new MainForm();
            regresar.ShowDialog();
            this.Visible = true;
		}
}
}
	

