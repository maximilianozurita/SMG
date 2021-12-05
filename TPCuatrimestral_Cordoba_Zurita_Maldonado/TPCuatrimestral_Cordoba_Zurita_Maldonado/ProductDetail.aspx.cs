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
        public List <Imagen> imagen = new List <Imagen>();
        public List<VideoGame> ListaVJuegos = new List<VideoGame>();
        int aux = 0;
        VGameNegocio vGame = new VGameNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

    
            int ProductoID = int.Parse(Request.QueryString["ID"]);
           /// if (
                videogame = vGame.FindByPK(ProductoID);
           
                ListaVJuegos.Add(videogame);

            if ( !(Session["JuegosAgregados"] != null )) 
            {
                ListaVJuegos.Add(videogame);

                Session.Add( "JuegosAgregados",ListaVJuegos);
            }

           
        }

        protected void BtnAgregarCarro_Click(object sender, EventArgs e)

        {
            ListaVJuegos.Add(videogame);

            Session.Add("JuegosAgregados", ListaVJuegos);
           
            Response.Redirect("Carrito.aspx",false);
        }
    }
}