using System;
using System.Windows.Forms;
using PV_Autolavado.Entidates;
using System.Collections.Generic;
using PV_Autolavado.Administrador;
using PV_Autolavado.Objetos;


namespace PV_Autolavado
{
	public partial class MenuAdministrador : Form
	{
        private bool editar = false;

		public MenuAdministrador(String usuario)
		{
			InitializeComponent();
            this.lblUsuario.Text = usuario;
		}

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            this.llenarTablaEmpleados();
            this.llenarTablaServicios();
            this.cambiarCampos(false);
        }

        private void llenarTablaEmpleados()
        {
            this.dgvServicios.Rows.Clear();

            this.dgvEmpleados.Rows.Clear();
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
            Personal prs = new Personal(this.lblUsuario.Text);
            DialogResult res = prs.ShowDialog();

            if (res == DialogResult.OK)
            {
                this.llenarTablaEmpleados();
            }
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
            
            Personal prs = new Personal(this.lblUsuario.Text, emp);
            DialogResult res = prs.ShowDialog();

            if (res == DialogResult.OK)
            {
                this.llenarTablaEmpleados();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Seguro que desea eliminar ese empelado?");

            if (res == DialogResult.OK)
            {
                int id = int.Parse(this.dgvEmpleados.CurrentRow.Cells[0].Value.ToString());

                new query().eliminarRegistro("empleados", "id", id);
                this.llenarTablaEmpleados();
            }
        }

        private void llenarTablaServicios()
        {
            this.dgvServicios.Rows.Clear();

            List<Servicio> lst = new query().obtenerListaServicios();

            foreach (Servicio ser in lst)
            {
                this.dgvServicios.Rows.Add(
                    ser.idservicio,
                    ser.descripcion,
                    ser.costo);
            }
        }

        private void cambiarCampos(Boolean cambio)
        {
            ltxtDescripcion.Enabled = cambio;
            ptxtCosto.Enabled = cambio;
        }

        private void btnAgregaServicio_Click(object sender, EventArgs e)
        {
            this.lblID.Text = (new query().ultimoRegistro("servicio", "idservicio") + 1).ToString() ;
            this.cambiarCampos(true);
            this.btnAceptar.Visible = true;
            this.btnAgregar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(editar == false){
            ptxtCosto.Cantidad = double.Parse(this.ptxtCosto.Text);

            Servicio serv = new Servicio();

            serv.descripcion = this.ltxtDescripcion.Text;
            serv.costo = this.ptxtCosto.Cantidad;

            new query().guardarServicio(serv);

            this.btnAceptar.Visible = false;
            this.btnAgregar.Enabled = true;

            }else{
                ptxtCosto.Cantidad = double.Parse(this.ptxtCosto.Text);
                
                Servicio serv = new Servicio();

                serv.idservicio = int.Parse(this.lblID.Text);
                serv.descripcion = this.ltxtDescripcion.Text;
                serv.costo = this.ptxtCosto.Cantidad;

                new query().modificarServicio(serv);
            }

            this.llenarTablaServicios();
       
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            new query().eliminarRegistro("servicio", "idservicio", int.Parse(this.dgvServicios.CurrentRow.Cells[0].Value.ToString()));

            this.llenarTablaServicios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.cambiarCampos(true);
            this.btnAceptar.Visible = true;

            this.lblID.Text = this.dgvServicios.CurrentRow.Cells[0].Value.ToString();
            this.ltxtDescripcion.Text = this.dgvServicios.CurrentRow.Cells[1].Value.ToString();
            this.ptxtCosto.Text = this.dgvServicios.CurrentRow.Cells[2].Value.ToString();

            editar = true;
        }

        private void MenuAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Login().Visible = true;

        }
	}
}
