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
    
    public partial class DetalleVenta : System.Web.UI.Page
    {
        public List<VideoGame> ListaVideogames { get; set; }
        public VideoGame videogame = new VideoGame();
        public List<VideoGame> ListaVJuegos = new List<VideoGame>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //validacion de login--//
            if (!((Session["email"]) != null && ((LoginUsuario)Session["email"]).TipoUsuario == TipoUsuario.Admin))
            {
                Session.Add("Error", "Acceso denegado");
                Response.Redirect("Error.aspx", false);
            }
            

            //Listado
            CarritoNegocio carNeg = new CarritoNegocio();
            List<Carrito> carriList = new List<Carrito>();
            VGameNegocio vGame = new VGameNegocio();
                        
            int IdVenta= int.Parse(Request.QueryString["query"]);

            carriList = carNeg.DetalleDeArticulosVendidos(IdVenta);


            
            foreach (var item in carriList)
            {
                
                videogame = vGame.FindByPK(item.IdProducto);
                videogame.Price = item.Precio;
                ListaVJuegos.Add(videogame);
            }
            ListaVideogames = ListaVJuegos;


        }

    }
}