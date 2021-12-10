using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conexion_BD;
using Mod_Dominio;

namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{

    
    public partial class Historial_de_ventas : System.Web.UI.Page
    {

        public List<Venta> ListaVentas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //validacion de login--//
            if (!((Session["email"]) != null && ((LoginUsuario)Session["email"]).TipoUsuario == TipoUsuario.Admin))
            {
                Session.Add("Error", "Acceso denegado");
                Response.Redirect("Error.aspx", false);
            }

            VentaNegocio VentaNegocios = new VentaNegocio();

            

            ListaVentas = VentaNegocios.Listar();

        }
    }
}