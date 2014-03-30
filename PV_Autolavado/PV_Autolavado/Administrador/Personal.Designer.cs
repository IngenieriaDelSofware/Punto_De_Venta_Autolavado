namespace PV_Autolavado.Administrador
{
    partial class Personal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNacimineto = new System.Windows.Forms.DateTimePicker();
            this.ltxtNombre = new PV_Autolavado.Objetos.LabelTextField();
            this.ltxtCurp = new PV_Autolavado.Objetos.LabelTextField();
            this.ltxtPaterno = new PV_Autolavado.Objetos.LabelTextField();
            this.ltxtMaterno = new PV_Autolavado.Objetos.LabelTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ltxtEstado = new PV_Autolavado.Objetos.LabelTextField();
            this.ltxtMunicipio = new PV_Autolavado.Objetos.LabelTextField();
            this.ltxtColonia = new PV_Autolavado.Objetos.LabelTextField();
            this.lblDireccion = new PV_Autolavado.Objetos.LabelTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ltxtPass = new PV_Autolavado.Objetos.LabelTextField();
            this.ltxtUsario = new PV_Autolavado.Objetos.LabelTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.gtnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNacimineto);
            this.groupBox1.Controls.Add(this.ltxtNombre);
            this.groupBox1.Controls.Add(this.ltxtCurp);
            this.groupBox1.Controls.Add(this.ltxtPaterno);
            this.groupBox1.Controls.Add(this.ltxtMaterno);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(604, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nacimiento";
            // 
            // dtpNacimineto
            // 
            this.dtpNacimineto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimineto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimineto.Location = new System.Drawing.Point(394, 59);
            this.dtpNacimineto.Name = "dtpNacimineto";
            this.dtpNacimineto.Size = new System.Drawing.Size(118, 22);
            this.dtpNacimineto.TabIndex = 4;
            // 
            // ltxtNombre
            // 
            this.ltxtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtNombre.Location = new System.Drawing.Point(6, 27);
            this.ltxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ltxtNombre.Name = "ltxtNombre";
            this.ltxtNombre.Size = new System.Drawing.Size(194, 22);
            this.ltxtNombre.TabIndex = 0;
            this.ltxtNombre.Text = "Nombre";
            this.ltxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtNombre.texto = "default";
            // 
            // ltxtCurp
            // 
            this.ltxtCurp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtCurp.Location = new System.Drawing.Point(6, 61);
            this.ltxtCurp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ltxtCurp.Name = "ltxtCurp";
            this.ltxtCurp.Size = new System.Drawing.Size(258, 22);
            this.ltxtCurp.TabIndex = 3;
            this.ltxtCurp.Text = "CURP";
            this.ltxtCurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtCurp.texto = "CURP";
            // 
            // ltxtPaterno
            // 
            this.ltxtPaterno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtPaterno.Location = new System.Drawing.Point(206, 27);
            this.ltxtPaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ltxtPaterno.Name = "ltxtPaterno";
            this.ltxtPaterno.Size = new System.Drawing.Size(182, 22);
            this.ltxtPaterno.TabIndex = 1;
            this.ltxtPaterno.Text = "Paterno";
            this.ltxtPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtPaterno.texto = "Paterno";
            // 
            // ltxtMaterno
            // 
            this.ltxtMaterno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtMaterno.Location = new System.Drawing.Point(394, 27);
            this.ltxtMaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ltxtMaterno.Name = "ltxtMaterno";
            this.ltxtMaterno.Size = new System.Drawing.Size(204, 22);
            this.ltxtMaterno.TabIndex = 2;
            this.ltxtMaterno.Text = "Materno";
            this.ltxtMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtMaterno.texto = "Materno";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltxtEstado);
            this.groupBox2.Controls.Add(this.ltxtMunicipio);
            this.groupBox2.Controls.Add(this.ltxtColonia);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 99);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // ltxtEstado
            // 
            this.ltxtEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtEstado.Location = new System.Drawing.Point(407, 58);
            this.ltxtEstado.Name = "ltxtEstado";
            this.ltxtEstado.Size = new System.Drawing.Size(190, 22);
            this.ltxtEstado.TabIndex = 3;
            this.ltxtEstado.Text = "Estado";
            this.ltxtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtEstado.texto = "Estado";
            // 
            // ltxtMunicipio
            // 
            this.ltxtMunicipio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtMunicipio.Location = new System.Drawing.Point(234, 59);
            this.ltxtMunicipio.Name = "ltxtMunicipio";
            this.ltxtMunicipio.Size = new System.Drawing.Size(167, 22);
            this.ltxtMunicipio.TabIndex = 2;
            this.ltxtMunicipio.Text = "Municipio";
            this.ltxtMunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtMunicipio.texto = "Municipio";
            // 
            // ltxtColonia
            // 
            this.ltxtColonia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltxtColonia.Location = new System.Drawing.Point(6, 59);
            this.ltxtColonia.Name = "ltxtColonia";
            this.ltxtColonia.Size = new System.Drawing.Size(222, 22);
            this.ltxtColonia.TabIndex = 1;
            this.ltxtColonia.Text = "Colonia";
            this.ltxtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtColonia.texto = "Colonia";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(7, 26);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(591, 22);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblDireccion.texto = "Direccion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.ltxtPass);
            this.groupBox3.Controls.Add(this.ltxtUsario);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpIngreso);
            this.groupBox3.Controls.Add(this.cbPuesto);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 107);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Empresa";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 22);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Mostrar Contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ltxtPass
            // 
            this.ltxtPass.Location = new System.Drawing.Point(156, 25);
            this.ltxtPass.Name = "ltxtPass";
            this.ltxtPass.PasswordChar = '*';
            this.ltxtPass.Size = new System.Drawing.Size(164, 26);
            this.ltxtPass.TabIndex = 4;
            this.ltxtPass.Text = "Password";
            this.ltxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtPass.texto = "Password";
            // 
            // ltxtUsario
            // 
            this.ltxtUsario.Location = new System.Drawing.Point(6, 26);
            this.ltxtUsario.Name = "ltxtUsario";
            this.ltxtUsario.Size = new System.Drawing.Size(143, 26);
            this.ltxtUsario.TabIndex = 3;
            this.ltxtUsario.Text = "Usuario";
            this.ltxtUsario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltxtUsario.texto = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingreso";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(211, 64);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(109, 22);
            this.dtpIngreso.TabIndex = 1;
            // 
            // cbPuesto
            // 
            this.cbPuesto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "SysAdmin",
            "Cajero",
            "Lavador"});
            this.cbPuesto.Location = new System.Drawing.Point(6, 66);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(146, 24);
            this.cbPuesto.TabIndex = 0;
            this.cbPuesto.Text = "Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(45, 13);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 18);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "id";
            // 
            // gtnGuardar
            // 
            this.gtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.gtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("gtnGuardar.Image")));
            this.gtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gtnGuardar.Location = new System.Drawing.Point(545, 365);
            this.gtnGuardar.Name = "gtnGuardar";
            this.gtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.gtnGuardar.TabIndex = 9;
            this.gtnGuardar.Text = "Aceptar";
            this.gtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gtnGuardar.UseVisualStyleBackColor = true;
            this.gtnGuardar.Click += new System.EventHandler(this.gtnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(460, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gtnGuardar);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Personal";
            this.Text = "Administracion Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Objetos.LabelTextField ltxtNombre;
        private Objetos.LabelTextField ltxtPaterno;
        private Objetos.LabelTextField ltxtMaterno;
        private Objetos.LabelTextField ltxtCurp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNacimineto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Objetos.LabelTextField ltxtEstado;
        private Objetos.LabelTextField ltxtMunicipio;
        private Objetos.LabelTextField ltxtColonia;
        private Objetos.LabelTextField lblDireccion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblid;
        private Objetos.LabelTextField ltxtPass;
        private Objetos.LabelTextField ltxtUsario;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button gtnGuardar;
        private System.Windows.Forms.Button button1;

    }
}