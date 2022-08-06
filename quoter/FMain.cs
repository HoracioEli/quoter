using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quoter
{
    public partial class FMain : Form
    {
        string Accion = string.Empty;

        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            personalizarDiseño();
        }

        private void personalizarDiseño()
        {
            panelSubrama.Visible = false;
        }

        private void Ocultar_SubMenu()
        {
            if (panelSubrama.Visible ==true)
            {
                panelSubrama.Visible = false;
            }
        }

        private void Mostrar_Ocultar_SubMenu(Panel subMenu)
        {
            //preguntamos si el submenu pasado por parámetro está abierto,
            if (subMenu.Visible==false)
            {
                //oculto todos los submenu y mestro el que me interesa
                Ocultar_SubMenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }

        struct ValorAccion
        {
            public const string btn_Valores = "1";
            public const string btn_Transito = "2";
        }


        private void RutinaControles(string strParam)
        {
            switch (strParam)
            {
                case ValorAccion.btn_Valores:
                    btnRoboValores.BackColor = System.Drawing.Color.Aqua;
                    btnRoboValores.ForeColor = System.Drawing.Color.Yellow;
                    btnRoboTransito.BackColor = System.Drawing.Color.Gray;
                    btnRoboTransito.ForeColor = System.Drawing.Color.White;
                    this.Text = "Cotizando ROBO DE VALORES";
                    break;
                case ValorAccion.btn_Transito:
                    btnRoboValores.BackColor = System.Drawing.Color.Gray;
                    btnRoboValores.ForeColor = System.Drawing.Color.White;
                    btnRoboTransito.BackColor = System.Drawing.Color.Aqua;
                    btnRoboTransito.ForeColor = System.Drawing.Color.Yellow;
                    this.Text = "Cotizando ROBO DE VALORES EN TRANSITO";
                    break;
                default:
                    break;

            }

        }

        private void btrnSubramas_Click(object sender, EventArgs e)
        {
            Mostrar_Ocultar_SubMenu(panelSubrama);
        }

        private void btnRoboValores_Click(object sender, EventArgs e)

        {
            Accion = ValorAccion.btn_Valores;
            abrilPanelHijo(new FRoboValores());
        }


        //abre los formularios hijos en el panelcontenedor 
        // establecemos una variable para el formulario activo
        private Form form_Activo = null;
        private void abrilPanelHijo(Form form_Hijo)
        {
            //si existe un formulario abierto (activo) lo cerramos
            if (form_Activo != null)
            {
                string mensaje = "Va a cambiar de subrama y se perderán los cambios \n\r¿Continuar?";
               if( MessageBox.Show(mensaje, "¡ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
                {
                    form_Activo.Close();
                    abrirForm(form_Hijo);
                    RutinaControles(Accion);

                }

            }
            else
            {
                abrirForm(form_Hijo);
                RutinaControles(Accion);
            }




        }

        private void abrirForm(Form form_Hijo)
        {
            //el form_activo será el form pasado por parámetro
            form_Activo = form_Hijo;
            //informamos que el formulario activo no es de nivel superior, es decir se comportará como un control
            form_Hijo.TopLevel = false;
            //le sacamos el borde al formulario
            form_Hijo.FormBorderStyle = FormBorderStyle.None;
            //establecemos la propiedad dock -> fill para que ocupe todo el espacio del contenedor
            form_Hijo.Dock = DockStyle.Fill;
            //agregamos el form_activo al panel contenedor
            PanelFormHijo.Controls.Add(form_Hijo);
            //asociacmos el formulario con el panel contenedor
            PanelFormHijo.Tag = form_Hijo;
            //traigo el formulario al frente
            form_Hijo.BringToFront();
            //mostramos el formulario hijo
            form_Hijo.Show();
            //el formulario hijo que vamos a abrir es conveniente que tenga el mismo size que el contener
            //para evitar que parpadee al abrir
        }

        private void btnRoboTransito_Click(object sender, EventArgs e)
        {
            Accion = ValorAccion.btn_Transito;
            
            RutinaControles(Accion); //es temporal, hasta crear el formulario para transito
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "La aplicación se cerrará y se borrarán los cambios \n\r¿Continuar?";

            if (MessageBox.Show(mensaje,"¡ATENCION!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
            {
                this.Close();

            }
            
           
        }
    }
}
