using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace usuario
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			txtNombre.Text = "";
			txtApellido.Text = "";
			txtDireccion.Text = "";
			txtTelefono.Text = "";
			txtTipo_sangre.Text = "";
			txtEmergencia.Text = "";
	    Datos pusuarioAg = new Datos();
            pusuarioAg.nombre = txtNombre.Text.Trim();
            pusuarioAg.apellido = txtApellido.Text.Trim();
            pusuarioAg.direccion = txtDireccion.Text.Trim();
            pusuarioAg.telefono = txtTelefono.Text.Trim();
            pusuarioAg.tipo_sangre = txtTipo_sangre.Text.Trim();
            pusuarioAg.Emergencia = txtEmergencia.Text.Trim();
            pusuarioAg.fecha_ingreso = dtpFechaIngreso.Value.Year + "/" + dtpFechaIngreso.Value.Month + "/" + dtpFechaIngreso.Value.Day;
            pusuarioAg.fecha_final = dptFechaFinal.Value.Year + "/" + dtpFechaIngreso.Value.Month + "/" + dtpFechaIngreso.Value.Day;

            int resultado = usuarioAg.Agregar(pusuarioAg);
            if (resultado > 0)
            {
                MessageBox.Show(" Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar!!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
		}
		
		
	
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			 MostrarUsuario nuevo = new MostrarUsuario();
            nuevo.ShowDialog();
            this.Visible = false;
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			 OpenFileDialog newdialog = new OpenFileDialog();

            newdialog.Filter = "Jpg files  (*Jpg) | *.Jpg";
            newdialog.InitialDirectory = @"C:\";

            if (newdialog.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(newdialog.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnNuevoClick(object sender, EventArgs e)
		{
	     MainForm nuevo = new MainForm();
            nuevo.ShowDialog();
            this.Visible = true;
		}
	}
}
