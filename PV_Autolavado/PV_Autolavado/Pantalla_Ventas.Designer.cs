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
			this.btnAgregarServicio = new System.Windows.Forms.Button();
			this.btnTotal = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ptxtTotal = new PV_Autolavado.PriceTextBox();
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblTicket = new System.Windows.Forms.Label();
			this.lblPropietario = new System.Windows.Forms.Label();
			this.lblModelo = new System.Windows.Forms.Label();
			this.lblPlacas = new System.Windows.Forms.Label();
			this.numero_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ahorro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregarServicio
			// 
			this.btnAgregarServicio.Location = new System.Drawing.Point(12, 62);
			this.btnAgregarServicio.Name = "btnAgregarServicio";
			this.btnAgregarServicio.Size = new System.Drawing.Size(75, 81);
			this.btnAgregarServicio.TabIndex = 1;
			this.btnAgregarServicio.Text = "Agregar Servicio";
			this.btnAgregarServicio.UseVisualStyleBackColor = true;
			this.btnAgregarServicio.Click += new System.EventHandler(this.BtnAgregarServicioClick);
			// 
			// btnTotal
			// 
			this.btnTotal.Location = new System.Drawing.Point(93, 63);
			this.btnTotal.Name = "btnTotal";
			this.btnTotal.Size = new System.Drawing.Size(75, 80);
			this.btnTotal.TabIndex = 9;
			this.btnTotal.Text = "Totalizar";
			this.btnTotal.UseVisualStyleBackColor = true;
			this.btnTotal.Click += new System.EventHandler(this.BtnTotalClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ptxtTotal);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(455, 576);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox1.Size = new System.Drawing.Size(417, 154);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TOTAL";
			// 
			// ptxtTotal
			// 
			this.ptxtTotal.BackColor = System.Drawing.Color.Black;
			this.ptxtTotal.Cantidad = 0D;
			this.ptxtTotal.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ptxtTotal.ForeColor = System.Drawing.Color.Lime;
			this.ptxtTotal.Location = new System.Drawing.Point(6, 25);
			this.ptxtTotal.Name = "ptxtTotal";
			this.ptxtTotal.Size = new System.Drawing.Size(405, 118);
			this.ptxtTotal.TabIndex = 8;
			this.ptxtTotal.Text = "$0.00";
			this.ptxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dgvVentas
			// 
			this.dgvVentas.AllowUserToDeleteRows = false;
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.numero_servicio,
									this.id_Servicio,
									this.Descripcion,
									this.Costo,
									this.ahorro,
									this.Total});
			this.dgvVentas.Location = new System.Drawing.Point(12, 155);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.ReadOnly = true;
			this.dgvVentas.Size = new System.Drawing.Size(860, 415);
			this.dgvVentas.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblMarca);
			this.groupBox2.Controls.Add(this.lblPropietario);
			this.groupBox2.Controls.Add(this.lblModelo);
			this.groupBox2.Controls.Add(this.lblPlacas);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.groupBox2.Location = new System.Drawing.Point(449, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(423, 124);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos del Vehiculo";
			// 
			// lblMarca
			// 
			this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblMarca.Location = new System.Drawing.Point(6, 73);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(100, 23);
			this.lblMarca.TabIndex = 2;
			this.lblMarca.Text = "Marca";
			// 
			// lblTicket
			// 
			this.lblTicket.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTicket.ForeColor = System.Drawing.Color.Blue;
			this.lblTicket.Location = new System.Drawing.Point(105, 37);
			this.lblTicket.Name = "lblTicket";
			this.lblTicket.Size = new System.Drawing.Size(79, 23);
			this.lblTicket.TabIndex = 4;
			this.lblTicket.Text = "Ticket";
			// 
			// lblPropietario
			// 
			this.lblPropietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblPropietario.Location = new System.Drawing.Point(6, 27);
			this.lblPropietario.Name = "lblPropietario";
			this.lblPropietario.Size = new System.Drawing.Size(100, 23);
			this.lblPropietario.TabIndex = 1;
			this.lblPropietario.Text = "Propietario";
			// 
			// lblModelo
			// 
			this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblModelo.Location = new System.Drawing.Point(6, 96);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(100, 23);
			this.lblModelo.TabIndex = 5;
			this.lblModelo.Text = "Modelo";
			// 
			// lblPlacas
			// 
			this.lblPlacas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblPlacas.Location = new System.Drawing.Point(6, 50);
			this.lblPlacas.Name = "lblPlacas";
			this.lblPlacas.Size = new System.Drawing.Size(100, 23);
			this.lblPlacas.TabIndex = 0;
			this.lblPlacas.Text = "Placas";
			// 
			// numero_servicio
			// 
			this.numero_servicio.HeaderText = "N°";
			this.numero_servicio.Name = "numero_servicio";
			this.numero_servicio.ReadOnly = true;
			this.numero_servicio.Width = 50;
			// 
			// id_Servicio
			// 
			this.id_Servicio.HeaderText = "Codigo";
			this.id_Servicio.Name = "id_Servicio";
			this.id_Servicio.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Width = 365;
			// 
			// Costo
			// 
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			// 
			// ahorro
			// 
			this.ahorro.HeaderText = "Ahorro";
			this.ahorro.Name = "ahorro";
			this.ahorro.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(87, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Ticket No";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(87, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "Usuario";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(105, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 23);
			this.label3.TabIndex = 20;
			this.label3.Text = "Username";
			// 
			// Pantalla_Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 742);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblTicket);
			this.Controls.Add(this.dgvVentas);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnTotal);
			this.Controls.Add(this.btnAgregarServicio);
			this.Name = "Pantalla_Ventas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.Pantalla_VentasLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.DataGridViewTextBoxColumn ahorro;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_Servicio;
		private System.Windows.Forms.Label lblPlacas;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.Label lblPropietario;
		private System.Windows.Forms.Label lblTicket;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.GroupBox groupBox2;
		private PV_Autolavado.PriceTextBox ptxtTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn numero_servicio;
		private System.Windows.Forms.DataGridView dgvVentas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnTotal;
		private System.Windows.Forms.Button btnAgregarServicio;
	}
}
