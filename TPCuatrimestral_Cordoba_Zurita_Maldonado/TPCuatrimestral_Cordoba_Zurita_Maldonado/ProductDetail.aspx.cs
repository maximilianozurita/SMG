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
    public partial class Detalle_de_producto : System.Web.UI.Page
    {
        public VideoGame videogame = new VideoGame();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            VGameNegocio vGame = new VGameNegocio();

            int ProductID = int.Parse(Request.QueryString["ID"]);

            videogame = vGame.FindByPK(ProductID);


        }
    }
}