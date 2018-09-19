using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAhorcadoCliente
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPalabraNueva_Click(object sender, EventArgs e)
        {
            using (WSReferencia.WSAhorcadoClient ws = new WSReferencia.WSAhorcadoClient()) {
                var palabra = ws.ObtenerPalabra();
                lblPalabraNueva.Text = palabra.nuevaPalabra;
                lblPalabraNuevaGuion.Text = palabra.nuevaPalabraGuion;
                lblMensaje.Text = palabra.mensaje;
                lblVidas.Text = palabra.vidasRestantes;
            }

            foreach (Control c in Page.Controls)
            {
                foreach (Control childc in c.Controls)
                {
                    if (childc is Button)
                    {
                        ((Button)childc).Enabled = true;
                    }
                }       
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            
            Button button = sender as Button;
            String[] urlImagen = { "~/Sources/images/hang0.jpg", "~/Sources/images/hang1.jpg", "~/Sources/images/hang2.jpg", "~/Sources/images/hang3.jpg", "~/Sources/images/hang4.jpg", "~/Sources/images/hang5.jpg", "~/Sources/images/hang6.jpg", "~/Sources/images/hang7.jpg" };

            using (WSReferencia.WSAhorcadoClient ws = new WSReferencia.WSAhorcadoClient())
            {

                var palabra = ws.ValidarLetra(button.Text.ToString(), lblPalabraNueva.Text, lblPalabraNuevaGuion.Text, lblVidas.Text);
                lblPalabraNuevaGuion.Text = palabra.nuevaPalabraGuion;
                lblVidas.Text = palabra.vidasRestantes;
                lblMensaje.Text = palabra.mensaje;

                Image1.ImageUrl = urlImagen[int.Parse(palabra.vidasRestantes)].ToString();
            }
            button.Enabled = false;
        }

      
    }
}