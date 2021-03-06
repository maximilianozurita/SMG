using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mod_Dominio;
using Conexion_BD;

namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptarClick(object sender,EventArgs e)
        {
            LoginUsuario loginUsuario;
            LoginUsuarioNegocio negocio = new LoginUsuarioNegocio();
            Usuario user = new Usuario();

            try
            {
                loginUsuario = new LoginUsuario(txtEmail.Text, txtContraseña.Text, true);

                if (negocio.Loguear(loginUsuario))
                {
                    Session.Add("email", loginUsuario);
                    Session.Add("NombreUsuario", txtEmail.Text);
                    if ((Session["email"]) != null && ((LoginUsuario)Session["email"]).TipoUsuario == TipoUsuario.Admin)
                    {
                        Response.Redirect("Default.aspx", false);
                    }
                    else
                    {
                        Response.Redirect("Default.aspx", false);
                    }
                }
                else
                {
                    Session.Add("Error", "user o pass incorrectos");
                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void linkContraseñaOlvidada_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContraseñaOlvidada.aspx");
        }
    }
}