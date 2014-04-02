namespace PV_Autolavado.Reportes
{
    partial class VisorReportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_Autolavado = new PV_Autolavado.Datos_Autolavado();
            this.visorReporteVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ticketTableAdapter = new PV_Autolavado.Datos_AutolavadoTableAdapters.ticketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Autolavado)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.datos_Autolavado;
            // 
            // datos_Autolavado
            // 
            this.datos_Autolavado.DataSetName = "Datos_Autolavado";
            this.datos_Autolavado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visorReporteVentas
            // 
            this.visorReporteVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OrigenDatos";
            reportDataSource1.Value = this.ticketBindingSource;
            this.visorReporteVentas.LocalReport.DataSources.Add(reportDataSource1);
            this.visorReporteVentas.LocalReport.ReportEmbeddedResource = "PV_Autolavado.Reportes.ReporteVentas.rdlc";
            this.visorReporteVentas.Location = new System.Drawing.Point(0, 0);
            this.visorReporteVentas.Name = "visorReporteVentas";
            this.visorReporteVentas.Size = new System.Drawing.Size(448, 457);
            this.visorReporteVentas.TabIndex = 0;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // VisorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 457);
            this.Controls.Add(this.visorReporteVentas);
            this.Name = "VisorReportes";
            this.Text = "VisorReportes";
            this.Load += new System.EventHandler(this.VisorReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Autolavado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer visorReporteVentas;
        private Datos_Autolavado datos_Autolavado;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private Datos_AutolavadoTableAdapters.ticketTableAdapter ticketTableAdapter;
    }
}