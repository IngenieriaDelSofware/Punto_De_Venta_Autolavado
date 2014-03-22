/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 18/03/2014
 * Time: 10:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_Autolavado
{
	partial class NuevoUsuario
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.nombusu = new System.Windows.Forms.TextBox();
			this.contraseña = new System.Windows.Forms.TextBox();
			this.nombre = new System.Windows.Forms.TextBox();
			this.paterno = new System.Windows.Forms.TextBox();
			this.materno = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.puesto = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.fecnacimiento = new System.Windows.Forms.DateTimePicker();
			this.fecingreso = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre Usuario:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(12, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(12, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Apellido paterno:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(12, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Apellido materno:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(254, 99);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(138, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Fecha de ingreso:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(322, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "Puesto:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nombusu
			// 
			this.nombusu.Location = new System.Drawing.Point(148, 10);
			this.nombusu.Name = "nombusu";
			this.nombusu.Size = new System.Drawing.Size(100, 20);
			this.nombusu.TabIndex = 8;
			// 
			// contraseña
			// 
			this.contraseña.Location = new System.Drawing.Point(148, 37);
			this.contraseña.Name = "contraseña";
			this.contraseña.Size = new System.Drawing.Size(100, 20);
			this.contraseña.TabIndex = 9;
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(148, 106);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(100, 20);
			this.nombre.TabIndex = 10;
			// 
			// paterno
			// 
			this.paterno.Location = new System.Drawing.Point(148, 132);
			this.paterno.Name = "paterno";
			this.paterno.Size = new System.Drawing.Size(100, 20);
			this.paterno.TabIndex = 11;
			// 
			// materno
			// 
			this.materno.Location = new System.Drawing.Point(148, 158);
			this.materno.Name = "materno";
			this.materno.Size = new System.Drawing.Size(100, 20);
			this.materno.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(12, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(159, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Fecha de nacimiento:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// puesto
			// 
			this.puesto.FormattingEnabled = true;
			this.puesto.Items.AddRange(new object[] {
									"Ayudante General",
									"Laba autos",
									"Cajero",
									"Gerente de sucursal",
									"Administrativo"});
			this.puesto.Location = new System.Drawing.Point(398, 133);
			this.puesto.Name = "puesto";
			this.puesto.Size = new System.Drawing.Size(121, 21);
			this.puesto.TabIndex = 15;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(398, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(317, 228);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Salir";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// fecnacimiento
			// 
			this.fecnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.fecnacimiento.Location = new System.Drawing.Point(178, 185);
			this.fecnacimiento.Name = "fecnacimiento";
			this.fecnacimiento.Size = new System.Drawing.Size(97, 20);
			this.fecnacimiento.TabIndex = 18;
			// 
			// fecingreso
			// 
			this.fecingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.fecingreso.Location = new System.Drawing.Point(399, 105);
			this.fecingreso.Name = "fecingreso";
			this.fecingreso.Size = new System.Drawing.Size(120, 20);
			this.fecingreso.TabIndex = 19;
			// 
			// NuevoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(533, 278);
			this.Controls.Add(this.fecingreso);
			this.Controls.Add(this.fecnacimiento);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.puesto);
			this.Controls.Add(this.materno);
			this.Controls.Add(this.paterno);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.contraseña);
			this.Controls.Add(this.nombusu);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "NuevoUsuario";
			this.Text = "NuevoUsuario";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker fecingreso;
		private System.Windows.Forms.DateTimePicker fecnacimiento;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox puesto;
		private System.Windows.Forms.TextBox materno;
		private System.Windows.Forms.TextBox paterno;
		private System.Windows.Forms.TextBox nombre;
		private System.Windows.Forms.TextBox contraseña;
		private System.Windows.Forms.TextBox nombusu;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
