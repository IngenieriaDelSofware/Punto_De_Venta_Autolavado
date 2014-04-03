namespace PV_Autolavado.Administrador
{
    partial class promociones
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.preciopromo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.precioesp = new PV_Autolavado.Objetos.LabelTextField();
            this.precioserv = new PV_Autolavado.Objetos.LabelTextField();
            this.labelTextField2 = new PV_Autolavado.Objetos.LabelTextField();
            this.descrip = new PV_Autolavado.Objetos.LabelTextField();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio de promocion en lavado general";
            // 
            // preciopromo
            // 
            this.preciopromo.Location = new System.Drawing.Point(240, 36);
            this.preciopromo.Name = "preciopromo";
            this.preciopromo.Size = new System.Drawing.Size(100, 20);
            this.preciopromo.TabIndex = 2;
            this.preciopromo.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion de promocion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Promociones por servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Servicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Promociones especiales";
            // 
            // precioesp
            // 
            this.precioesp.Location = new System.Drawing.Point(194, 137);
            this.precioesp.Name = "precioesp";
            this.precioesp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.precioesp.Size = new System.Drawing.Size(100, 20);
            this.precioesp.TabIndex = 13;
            this.precioesp.Text = "$";
            this.precioesp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.precioesp.texto = "default";
            this.precioesp.UseWaitCursor = true;
            // 
            // precioserv
            // 
            this.precioserv.Location = new System.Drawing.Point(320, 91);
            this.precioserv.Name = "precioserv";
            this.precioserv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.precioserv.Size = new System.Drawing.Size(100, 20);
            this.precioserv.TabIndex = 9;
            this.precioserv.Text = "$";
            this.precioserv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.precioserv.texto = "default";
            // 
            // labelTextField2
            // 
            this.labelTextField2.Location = new System.Drawing.Point(194, 91);
            this.labelTextField2.Name = "labelTextField2";
            this.labelTextField2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTextField2.Size = new System.Drawing.Size(100, 20);
            this.labelTextField2.TabIndex = 7;
            this.labelTextField2.Text = "Servicio";
            this.labelTextField2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.labelTextField2.texto = "Servicio";
            // 
            // descrip
            // 
            this.descrip.AllowDrop = true;
            this.descrip.Location = new System.Drawing.Point(326, 195);
            this.descrip.Multiline = true;
            this.descrip.Name = "descrip";
            this.descrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descrip.Size = new System.Drawing.Size(377, 59);
            this.descrip.TabIndex = 6;
            this.descrip.Text = "Descripcion";
            this.descrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.descrip.texto = "Descripcion";
            // 
            // promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 321);
            this.Controls.Add(this.precioesp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precioserv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTextField2);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.preciopromo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "promociones";
            this.Text = "promociones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox preciopromo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private Objetos.LabelTextField descrip;
        private Objetos.LabelTextField labelTextField2;
        private System.Windows.Forms.Label label3;
        private Objetos.LabelTextField precioserv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Objetos.LabelTextField precioesp;
    }
}