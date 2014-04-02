/*
 * Creado por SharpDevelop.
 * Usuario: sdarkland
 * Fecha: 21/03/2014
 * Hora: 10:57 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PV_Autolavado
{
	partial class Ventana_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_Productos));
            this.pnlServicios = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlServicios
            // 
            this.pnlServicios.AutoScroll = true;
            this.pnlServicios.Location = new System.Drawing.Point(12, 12);
            this.pnlServicios.Name = "pnlServicios";
            this.pnlServicios.Size = new System.Drawing.Size(404, 347);
            this.pnlServicios.TabIndex = 1;
            this.pnlServicios.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlServicios_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(341, 365);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
            // 
            // Ventana_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 400);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlServicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventana_Productos";
            this.Text = "Seleccione Servicios";
            this.Load += new System.EventHandler(this.Ventana_ProductosLoad);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Panel pnlServicios;
	}
}
