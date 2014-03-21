/*
 * Created by SharpDevelop.
 * User: lizbeth
 * Date: 19/03/2014
 * Time: 11:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace usuario
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dptFechaFinal = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEmergencia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTipo_sangre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolsMenu = new System.Windows.Forms.ToolStrip();
			this.btnNuevo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnGuardar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnActualizar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnBuscar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCancelar = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolsMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Teal;
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.dptFechaFinal);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtEmergencia);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtTipo_sangre);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtTelefono);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtDireccion);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtpFechaIngreso);
			this.groupBox1.Controls.Add(this.txtApellido);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(585, 378);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Personales";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Silver;
			this.pictureBox1.Location = new System.Drawing.Point(25, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(143, 148);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(46, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 33);
			this.button1.TabIndex = 26;
			this.button1.Text = "FOTO";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dptFechaFinal
			// 
			this.dptFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dptFechaFinal.Location = new System.Drawing.Point(291, 322);
			this.dptFechaFinal.Name = "dptFechaFinal";
			this.dptFechaFinal.Size = new System.Drawing.Size(200, 20);
			this.dptFechaFinal.TabIndex = 24;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(359, 304);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 15);
			this.label8.TabIndex = 23;
			this.label8.Text = "Fecha Final:";
			// 
			// txtEmergencia
			// 
			this.txtEmergencia.Location = new System.Drawing.Point(348, 173);
			this.txtEmergencia.Name = "txtEmergencia";
			this.txtEmergencia.Size = new System.Drawing.Size(166, 22);
			this.txtEmergencia.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(245, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 23);
			this.label2.TabIndex = 21;
			this.label2.Text = "N^Emergencia:";
			// 
			// txtTipo_sangre
			// 
			this.txtTipo_sangre.Location = new System.Drawing.Point(348, 145);
			this.txtTipo_sangre.Name = "txtTipo_sangre";
			this.txtTipo_sangre.Size = new System.Drawing.Size(166, 22);
			this.txtTipo_sangre.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(265, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "tipo sangre:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(348, 117);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(166, 22);
			this.txtTelefono.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(283, 116);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Telefono:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(348, 88);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(166, 22);
			this.txtDireccion.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(279, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Direccion:";
			// 
			// dtpFechaIngreso
			// 
			this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaIngreso.Location = new System.Drawing.Point(25, 322);
			this.dtpFechaIngreso.Name = "dtpFechaIngreso";
			this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaIngreso.TabIndex = 7;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(348, 60);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(166, 22);
			this.txtApellido.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(283, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Apellidos:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(46, 304);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Fecha de Ingreso:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(348, 32);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(166, 22);
			this.txtNombre.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(291, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// toolsMenu
			// 
			this.toolsMenu.BackColor = System.Drawing.Color.Teal;
			this.toolsMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnNuevo,
									this.toolStripSeparator1,
									this.btnGuardar,
									this.toolStripSeparator2,
									this.btnActualizar,
									this.toolStripSeparator3,
									this.btnEliminar,
									this.toolStripSeparator4,
									this.btnBuscar,
									this.toolStripSeparator5,
									this.btnCancelar,
									this.toolStripButton1});
			this.toolsMenu.Location = new System.Drawing.Point(0, 401);
			this.toolsMenu.Name = "toolsMenu";
			this.toolsMenu.Size = new System.Drawing.Size(601, 25);
			this.toolsMenu.TabIndex = 9;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(48, 22);
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(56, 22);
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(66, 22);
			this.btnActualizar.Text = "&Actualizar";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(55, 22);
			this.btnEliminar.Text = "&Eliminar";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(48, 22);
			this.btnBuscar.Text = "&Buscar";
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(58, 22);
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(61, 22);
			this.toolStripButton1.Text = "&Regresar";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 426);
			this.Controls.Add(this.toolsMenu);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "usuario";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolsMenu.ResumeLayout(false);
			this.toolsMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton btnCancelar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton btnBuscar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnEliminar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnActualizar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnGuardar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnNuevo;
		private System.Windows.Forms.ToolStrip toolsMenu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTipo_sangre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmergencia;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dptFechaFinal;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
