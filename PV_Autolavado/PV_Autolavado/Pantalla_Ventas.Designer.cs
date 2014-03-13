namespace PV_Autolavado
{
	partial class Pantalla_Ventas
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
			this.btnAgregarServicio = new System.Windows.Forms.Button();
			this.btnTotal = new System.Windows.Forms.Button();
			this.btnOpciones = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ptxtSubtotal = new PV_Autolavado.PriceTextBox();
			this.ptxtIVA = new PV_Autolavado.PriceTextBox();
			this.ptxtTotal = new PV_Autolavado.PriceTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.numero_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pboxLogo = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "SubTotal";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "IVA";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Total";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAgregarServicio
			// 
			this.btnAgregarServicio.Location = new System.Drawing.Point(12, 13);
			this.btnAgregarServicio.Name = "btnAgregarServicio";
			this.btnAgregarServicio.Size = new System.Drawing.Size(75, 49);
			this.btnAgregarServicio.TabIndex = 1;
			this.btnAgregarServicio.Text = "Agregar Servicio";
			this.btnAgregarServicio.UseVisualStyleBackColor = true;
			this.btnAgregarServicio.Click += new System.EventHandler(this.BtnAgregarServicioClick);
			// 
			// btnTotal
			// 
			this.btnTotal.Location = new System.Drawing.Point(94, 13);
			this.btnTotal.Name = "btnTotal";
			this.btnTotal.Size = new System.Drawing.Size(75, 49);
			this.btnTotal.TabIndex = 9;
			this.btnTotal.Text = "Totalizar";
			this.btnTotal.UseVisualStyleBackColor = true;
			this.btnTotal.Click += new System.EventHandler(this.BtnTotalClick);
			// 
			// btnOpciones
			// 
			this.btnOpciones.Location = new System.Drawing.Point(797, 13);
			this.btnOpciones.Name = "btnOpciones";
			this.btnOpciones.Size = new System.Drawing.Size(75, 23);
			this.btnOpciones.TabIndex = 10;
			this.btnOpciones.Text = "Opciones";
			this.btnOpciones.UseVisualStyleBackColor = true;
			this.btnOpciones.Click += new System.EventHandler(this.BtnOpcionesClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ptxtSubtotal);
			this.groupBox1.Controls.Add(this.ptxtIVA);
			this.groupBox1.Controls.Add(this.ptxtTotal);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(532, 496);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(340, 247);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TOTAL";
			// 
			// ptxtSubtotal
			// 
			this.ptxtSubtotal.BackColor = System.Drawing.Color.Black;
			this.ptxtSubtotal.Cantidad = 0D;
			this.ptxtSubtotal.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ptxtSubtotal.ForeColor = System.Drawing.Color.Lime;
			this.ptxtSubtotal.Location = new System.Drawing.Point(112, 19);
			this.ptxtSubtotal.Name = "ptxtSubtotal";
			this.ptxtSubtotal.Size = new System.Drawing.Size(222, 63);
			this.ptxtSubtotal.TabIndex = 10;
			this.ptxtSubtotal.Text = "$0.00";
			this.ptxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ptxtIVA
			// 
			this.ptxtIVA.BackColor = System.Drawing.Color.Black;
			this.ptxtIVA.Cantidad = 0D;
			this.ptxtIVA.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ptxtIVA.ForeColor = System.Drawing.Color.Lime;
			this.ptxtIVA.Location = new System.Drawing.Point(112, 88);
			this.ptxtIVA.Name = "ptxtIVA";
			this.ptxtIVA.Size = new System.Drawing.Size(222, 63);
			this.ptxtIVA.TabIndex = 9;
			this.ptxtIVA.Text = "$0.00";
			this.ptxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ptxtTotal
			// 
			this.ptxtTotal.BackColor = System.Drawing.Color.Black;
			this.ptxtTotal.Cantidad = 0D;
			this.ptxtTotal.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ptxtTotal.ForeColor = System.Drawing.Color.Lime;
			this.ptxtTotal.Location = new System.Drawing.Point(112, 157);
			this.ptxtTotal.Name = "ptxtTotal";
			this.ptxtTotal.Size = new System.Drawing.Size(222, 76);
			this.ptxtTotal.TabIndex = 8;
			this.ptxtTotal.Text = "$0.00";
			this.ptxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.dgvVentas);
			this.panel1.Location = new System.Drawing.Point(12, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(860, 421);
			this.panel1.TabIndex = 14;
			// 
			// dgvVentas
			// 
			this.dgvVentas.AllowUserToDeleteRows = false;
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.numero_servicio,
									this.Descripcion,
									this.Costo,
									this.IVA,
									this.Total});
			this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvVentas.Location = new System.Drawing.Point(0, 0);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.ReadOnly = true;
			this.dgvVentas.Size = new System.Drawing.Size(860, 421);
			this.dgvVentas.TabIndex = 0;
			// 
			// numero_servicio
			// 
			this.numero_servicio.HeaderText = "N°";
			this.numero_servicio.Name = "numero_servicio";
			this.numero_servicio.ReadOnly = true;
			this.numero_servicio.Width = 50;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Width = 300;
			// 
			// Costo
			// 
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			// 
			// IVA
			// 
			this.IVA.HeaderText = "IVA";
			this.IVA.Name = "IVA";
			this.IVA.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// pboxLogo
			// 
			this.pboxLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pboxLogo.InitialImage = null;
			this.pboxLogo.Location = new System.Drawing.Point(12, 497);
			this.pboxLogo.Name = "pboxLogo";
			this.pboxLogo.Size = new System.Drawing.Size(514, 237);
			this.pboxLogo.TabIndex = 15;
			this.pboxLogo.TabStop = false;
			// 
			// Pantalla_Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 742);
			this.Controls.Add(this.pboxLogo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOpciones);
			this.Controls.Add(this.btnTotal);
			this.Controls.Add(this.btnAgregarServicio);
			this.Name = "Pantalla_Ventas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.Pantalla_VentasLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
			this.ResumeLayout(false);
		}
		private PV_Autolavado.PriceTextBox ptxtTotal;
		private PV_Autolavado.PriceTextBox ptxtIVA;
		private PV_Autolavado.PriceTextBox ptxtSubtotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn numero_servicio;
		private System.Windows.Forms.DataGridView dgvVentas;
		private System.Windows.Forms.PictureBox pboxLogo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnOpciones;
		private System.Windows.Forms.Button btnTotal;
		private System.Windows.Forms.Button btnAgregarServicio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
