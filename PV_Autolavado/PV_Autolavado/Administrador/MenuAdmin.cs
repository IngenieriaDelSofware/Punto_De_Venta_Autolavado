using System;
using System.Drawing;
using System.Windows.Forms;
using PV_Autolavado.Entidates;
using System.Collections.Generic;
using PV_Autolavado.Administrador;


namespace PV_Autolavado
{
	public partial class MenuAdministrador : Form
	{
		public MenuAdministrador(String usuario)
		{
			InitializeComponent();
            this.lblUsuario.Text = usuario;
		}

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            this.llenarTabla();
        }

        private void llenarTabla()
        {
            List<Empleado> lst = new query().obtenerListaEmpleados();

            foreach (Empleado emp in lst)
            {
                dgvEmpleados.Rows.Add(
                                emp.id,
                                emp.nom_usu,
                                emp.contraseña,
                                emp.curp,
                                emp.nombre,
                                emp.paterno,
                                emp.materno,
                                emp.fec_nacimiento,
                                emp.direccion,
                                emp.colonia,
                                emp.municipio,
                                emp.estado,
                                emp.fec_ingreso,
                                emp.puesto);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new Personal(this.lblUsuario.Text).ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

                emp.id = int.Parse(this.dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
                emp.nom_usu = this.dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                emp.contraseña = this.dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                emp.curp = this.dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                emp.nombre = this.dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                emp.paterno = this.dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                emp.materno = this.dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
                emp.fec_nacimiento = this.dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
                emp.direccion = this.dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
                emp.colonia = this.dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
                emp.municipio = this.dgvEmpleados.CurrentRow.Cells[10].Value.ToString();
                emp.estado = this.dgvEmpleados.CurrentRow.Cells[11].Value.ToString();
                emp.fec_ingreso = this.dgvEmpleados.CurrentRow.Cells[12].Value.ToString();
                emp.puesto = int.Parse(this.dgvEmpleados.CurrentRow.Cells[13].Value.ToString());
            
            new Personal(this.lblUsuario.Text, emp).ShowDialog();
        }
	}
}
