/*
 * Created by SharpDevelop.
 * User: lizbeth
 * Date: 20/03/2014
 * Time: 01:00 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace usuario
{
	partial class MostrarUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarUsuario));
			this.dgClientes = new System.Windows.Forms.DataGrid();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgClientes
			// 
			this.dgClientes.DataMember = "";
			this.dgClientes.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgClientes.Location = new System.Drawing.Point(12, 12);
			this.dgClientes.Name = "dgClientes";
			this.dgClientes.Size = new System.Drawing.Size(506, 195);
			this.dgClientes.TabIndex = 0;
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(55, 214);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(75, 36);
			this.btnMostrar.TabIndex = 1;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.BtnMostrarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
			this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(128)))));
			this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
			this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRegresar.Location = new System.Drawing.Point(443, 214);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 36);
			this.btnRegresar.TabIndex = 3;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(128)))));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(136, 214);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 36);
			this.button2.TabIndex = 4;
			this.button2.Text = "Modificar";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(128)))));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(217, 213);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 36);
			this.button3.TabIndex = 5;
			this.button3.Text = "Eliminar";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// MostrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 262);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.dgClientes);
			this.Name = "MostrarUsuario";
			this.Text = "MostrarUsuario";
			this.Load += new System.EventHandler(this.MostrarUsuarioLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.DataGrid dgClientes;
	}
}
