using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PV_Autolavado.Entidates;
using PV_Autolavado.Objetos;

namespace PV_Autolavado.Administrador
{
    public partial class Personal : Form
    {
        public Personal(String username)
        {
            InitializeComponent();
            this.Text = username + " | Nuevo Empleado";
            this.lblid.Text = (new query().ultimoRegistro("empleados", "id")+1).ToString();
        }

        public Personal(String username, Empleado personal)
        {
            InitializeComponent();
            this.Text = username + " | Editar Empleado";
            this.llenarCampos(personal);
        }

        private void desactivarCampos()
        {
            foreach (LabelTextField caja in this.Controls)
            {
                caja.Enabled = false;
            }
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            
        }

        private void llenarCampos(Empleado emp)
        {
           this.lblid.Text = emp.id.ToString();
           this.ltxtUsario.Text = emp.nom_usu;
           this.ltxtPass.Text = emp.contraseña; 
           this.ltxtCurp.Text = emp.curp;
           this.ltxtNombre.Text = emp.nombre;
           this.ltxtPaterno.Text = emp.paterno;
           this.ltxtMaterno.Text = emp.materno;
           this.dtpNacimineto.Value = DateTime.Parse(emp.fec_nacimiento);
           this.lblDireccion.Text = emp.direccion;
           this.ltxtColonia.Text = emp.colonia;
           this.ltxtMunicipio.Text = emp.municipio;
           this.ltxtEstado.Text = emp.estado;
           this.dtpIngreso.Value = DateTime.Parse(emp.fec_ingreso);
           this.cbPuesto.SelectedIndex = emp.puesto;
           
        }
    }
}
