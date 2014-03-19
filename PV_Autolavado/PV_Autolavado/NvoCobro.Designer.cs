/*
 * Creado por SharpDevelop.
 * Usuario: sdarkland
 * Fecha: 18/03/2014
 * Hora: 09:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PV_Autolavado
{
	partial class NvoCobro
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
			this.txtPropietario = new System.Windows.Forms.TextBox();
			this.lblPropietario = new System.Windows.Forms.Label();
			this.lblPlacas = new System.Windows.Forms.Label();
			this.txtPlacas = new System.Windows.Forms.TextBox();
			this.lblMarca = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.lblModelo = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.lblColor = new System.Windows.Forms.Label();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPropietario
			// 
			this.txtPropietario.Location = new System.Drawing.Point(12, 38);
			this.txtPropietario.Name = "txtPropietario";
			this.txtPropietario.Size = new System.Drawing.Size(253, 20);
			this.txtPropietario.TabIndex = 0;
			// 
			// lblPropietario
			// 
			this.lblPropietario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPropietario.ForeColor = System.Drawing.Color.Blue;
			this.lblPropietario.Location = new System.Drawing.Point(12, 13);
			this.lblPropietario.Name = "lblPropietario";
			this.lblPropietario.Size = new System.Drawing.Size(100, 23);
			this.lblPropietario.TabIndex = 1;
			this.lblPropietario.Text = "Propietario";
			// 
			// lblPlacas
			// 
			this.lblPlacas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlacas.ForeColor = System.Drawing.Color.Blue;
			this.lblPlacas.Location = new System.Drawing.Point(13, 65);
			this.lblPlacas.Name = "lblPlacas";
			this.lblPlacas.Size = new System.Drawing.Size(100, 23);
			this.lblPlacas.TabIndex = 2;
			this.lblPlacas.Text = "Placas";
			// 
			// txtPlacas
			// 
			this.txtPlacas.Location = new System.Drawing.Point(13, 92);
			this.txtPlacas.Name = "txtPlacas";
			this.txtPlacas.Size = new System.Drawing.Size(100, 20);
			this.txtPlacas.TabIndex = 3;
			// 
			// lblMarca
			// 
			this.lblMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarca.ForeColor = System.Drawing.Color.Blue;
			this.lblMarca.Location = new System.Drawing.Point(12, 119);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(100, 23);
			this.lblMarca.TabIndex = 4;
			this.lblMarca.Text = "Marca";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(13, 146);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(100, 20);
			this.txtMarca.TabIndex = 5;
			// 
			// lblModelo
			// 
			this.lblModelo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModelo.ForeColor = System.Drawing.Color.Blue;
			this.lblModelo.Location = new System.Drawing.Point(13, 173);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(100, 23);
			this.lblModelo.TabIndex = 0;
			this.lblModelo.Text = "Modelo";
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(13, 200);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(100, 20);
			this.txtModelo.TabIndex = 0;
			// 
			// lblColor
			// 
			this.lblColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblColor.ForeColor = System.Drawing.Color.Blue;
			this.lblColor.Location = new System.Drawing.Point(120, 64);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(100, 23);
			this.lblColor.TabIndex = 6;
			this.lblColor.Text = "Color";
			// 
			// txtColor
			// 
			this.txtColor.Location = new System.Drawing.Point(120, 91);
			this.txtColor.Name = "txtColor";
			this.txtColor.Size = new System.Drawing.Size(100, 20);
			this.txtColor.TabIndex = 7;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(140, 196);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Location = new System.Drawing.Point(222, 196);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 9;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// NvoCobro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 236);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtColor);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.txtPlacas);
			this.Controls.Add(this.lblPlacas);
			this.Controls.Add(this.lblPropietario);
			this.Controls.Add(this.txtPropietario);
			this.Name = "NvoCobro";
			this.Text = "Nuevo Cobro";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtColor;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.TextBox txtPlacas;
		private System.Windows.Forms.Label lblPlacas;
		private System.Windows.Forms.Label lblPropietario;
		private System.Windows.Forms.TextBox txtPropietario;
	}
}
