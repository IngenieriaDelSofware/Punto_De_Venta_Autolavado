using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PV_Autolavado.Objetos
{
    class LabelTextField : TextBox
    {
        public String texto { get; set; }

        public LabelTextField()
        {
            this.texto = "default";
            this.Text = texto;
            this.TextAlign = HorizontalAlignment.Center;
            this.Enter += new EventHandler(this.entraFoco);
            this.Leave += new EventHandler(this.saleFoco);
        }

        public LabelTextField(String txt)
        {
            this.texto = txt;
            this.Text = texto;
            this.TextAlign = HorizontalAlignment.Center;
            this.Enter += new EventHandler(this.entraFoco);
            this.Leave += new EventHandler(this.saleFoco);
        }

        void entraFoco(Object sender, EventArgs e)
        {
            if(this.Text == texto){
                this.Text = "";
            }
        }

        void saleFoco(Object sender, EventArgs e)
        {
            if(this.Text == ""){
                this.Text = texto;
            }
        }

        public void Default()
        {
            this.Text = texto;
        }

    }
}
