using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Mod_Dominio;
namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{
    public partial class Carrito : System.Web.UI.Page
    {
      public VideoGame videogame = new VideoGame();
        public List<VideoGame> ListaVideogames { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            VGameNegocio vGame = new VGameNegocio();

          int ProductID = int.Parse(Request.QueryString["ID"]);

                      videogame = vGame.FindByPK(ProductID);
          

        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (((Session["email"]) != null && ((Mod_Dominio.LoginUsuario)Session["email"]).TipoUsuario == Mod_Dominio.TipoUsuario.Admin)) ; 
        }
    }
}