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
    public partial class FRoboValores : Form
    {
        public FRoboValores()
        {
            InitializeComponent();

        }

        

        private void FRoboValores_Load(object sender, EventArgs e)
        {
            Inicializar_dtp_Fechas();
        }

        #region Manejo de Mensajes
        struct ValorControl
        {
            public const string SA_Unica = "1";
            public const string SA_Individual = "2";
            public const string lbVentanilla = "3";

        }


        private void RutinaMensajes(string strParam)
        {
            string control = strParam;
            string mensaje = "";
            string titulo = "";

            switch (control)
            {
                case ValorControl.SA_Unica:
                    titulo = "SUMA UNICA PARA TODOS LOS LOCALES";
                    mensaje = "Cubre bajo una sola suma asegurada global, todos los locales del tomador";
                    mensaje += " que correspondan a la misma actividad\n\r";
                    mensaje += "Requiere:";
                    mensaje += "\n\r- Nominar la ubicación de los locales";
                    mensaje += "\n\r- Con o sin limitación de indemnización por local ";
                    break;
                case ValorControl.SA_Individual:
                    titulo = "SUMA INDIVIDUAL POR LOCAL";
                    mensaje = "Cubre 1 o mas locales del tomador con una SA asignada a cada uno,";
                    mensaje += " que correspondan a la misma actividad\n\r";
                    mensaje += "Requiere:";
                    mensaje += "\n\r- Nominar la ubicación de los locales";
                    mensaje += "\n\r- Establecer un valor por cada local ";
                    break;
                case ValorControl.lbVentanilla:
                    titulo = "VALORES EN VENTANILLA";
                    mensaje = "Para bancos y financieras que siguen las disposiciones del BCRA ";
                    mensaje += " se dispone de alternativas, el resto siempre es 100% de la suma ";
                    mensaje += "\n\rasegurada mientras el local se encuentre abierto en atención al público.";
                    mensaje += "\n\rLuego del cierre, los valores deben guardarse en CAJA FUERTE CERRADA";

                    break;

                default:
                    break;
            }

            lbMensaje.Text = titulo.ToUpper() + "\n\r " + mensaje;


        }

        private void Mensaje_MouseLeave(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                lbMensaje.Text = string.Empty;
            }

            if (sender is Label)
            {
                lbMensaje.Text = string.Empty;
            }
        }

        private void Mensaje_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is RadioButton)
            {
                if (((RadioButton)sender).Name == "Op_SAUnica")
                {
                    RutinaMensajes(ValorControl.SA_Unica);
                }

                if (((RadioButton)sender).Name == "Op_SAIndividual")
                {
                    RutinaMensajes(ValorControl.SA_Individual);
                }
            }

            if (sender is Label)
            {
                if (((Label)sender).Name == "lbVentanilla")
                {
                    RutinaMensajes(ValorControl.lbVentanilla);
                }

            }
        }



        #endregion

        #region Manejo de fechas 

        private void Inicializar_dtp_Fechas()
        {
            if (dtp_Desde.Value != null)
            {
                dtp_Hasta.Value = dtp_Desde.Value.AddDays(365);
                establecerDiasVigencia();
            }
            
        }
        

        private void establecerDiasVigencia()
        {
            try
            {
                if (dtp_Desde.Value !=null && dtp_Hasta.Value !=null)
                {
                    txVigencia.Value = (getDateDifference(dtp_Hasta.Value, dtp_Desde.Value)).Days;
                }
               
            }
            catch (Exception)
            {
                string mensaje = "Los dias de vigencia no pueden superior los 365/366";
                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_Hasta.Value = dtp_Desde.Value.AddDays(365);
                txVigencia.Value = 365;

            }

        }

        private TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1 - date2;

            return ts;
        }

        private void dtp_Hasta_Leave(object sender, EventArgs e)
        {
            establecerDiasVigencia();
        }

        private void dtp_Desde_Leave(object sender, EventArgs e)
        {
            dtp_Hasta.Value = dtp_Desde.Value.AddDays(365);
            establecerDiasVigencia();

        }

        private void txVigencia_Enter(object sender, EventArgs e)
        {
            txVigencia.Select(0, txVigencia.Text.Length);
        }

        private void txVigencia_Leave(object sender, EventArgs e)
        {
            dtp_Hasta.Value = dtp_Desde.Value.AddDays(Convert.ToInt32(txVigencia.Value));
        }

       

        private void chValores_Otros_CheckedChanged(object sender, EventArgs e)
        {
            string mensaje = "Cheques a la orden, dinero en monedas, moneda extranjera, giros bancarios y/o postales,";
            mensaje += " estampillas, titulos públicos, acciones, debentures al portador, otros títulos convertibles en dinero en moneda";
            mensaje += " corriente y/o extranjera, monedas de oro y plata, cupones de venta de tarjetas de crédito u otro concepto,";
            mensaje += " tickets, facturas de crédito y cualquier otro valor convertible en dinero";
            if (chValores_Otros.Checked)
            {
                txOtrosValores.Visible = true;
                txOtrosValores.Text = mensaje;
                txOtrosValores.Focus();
            }
            else
            {
                txOtrosValores.Visible = false;
                txOtrosValores.Text = string.Empty;
            }
        }

        private void txSAUnica_Enter(object sender, EventArgs e)
        {
            txSAUnica.Select(0, txSAUnica.Text.Length);
        }

        private void txSA_SIN_Interdiccion_Enter(object sender, EventArgs e)
        {
            txSA_SIN_Interdiccion.Select(0, txSA_SIN_Interdiccion.Text.Length);
        }

        private void txSA_SIN_Interdiccion_Leave(object sender, EventArgs e)
        {
            decimal SAsin = txSA_SIN_Interdiccion.Value;
            decimal SATotal = txSAUnica.Value;
            string mensaje = "La SUMA ASEGURADA TOTAL debe ser mayor a la SA sin acciones de interdicción";

            if (SATotal <= SAsin)
            {
                MessageBox.Show(mensaje, "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txSA_CON_Interdiccion.Value = 0;
                txSAUnica.Focus();

            }
            else
            {
                if (SAsin > 0)
                {
                    txSA_CON_Interdiccion.Value = SATotal - SAsin;
                }
            }

            

        }

        private void chDesglose_CheckStateChanged(object sender, EventArgs e)
        {
            if (txSAUnica.Value >0)
            {
                if (chDesglose.Checked)
                {

                    panelDesglose.Visible = true;
                    GpoSAUnica.Size = new System.Drawing.Size(929, 198);
                    panelDesglose.SendToBack();
                    txSA_SIN_Interdiccion.Focus();
                }
                else
                {
                    GpoSAUnica.Size = new System.Drawing.Size(929, 80);
                    panelDesglose.Visible = false;
                    txSA_CON_Interdiccion.Value = 0;
                    txSA_SIN_Interdiccion.Value = 0;
                }
            }
            else
            {
                string mensaje = "Debe indicarse una suma asegurada Unica, antes de desglozarla";
                MessageBox.Show(mensaje, "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chDesglose.Checked = false;
                txSAUnica.Focus();
            }
            
        }

        private void txLocalidad_Enter(object sender, EventArgs e)
        {
            txLocalidad.SelectAll();
        }

        private void txDireccion_Enter(object sender, EventArgs e)
        {
            txDireccion.SelectAll();
        }

        
    }
    #endregion
}
