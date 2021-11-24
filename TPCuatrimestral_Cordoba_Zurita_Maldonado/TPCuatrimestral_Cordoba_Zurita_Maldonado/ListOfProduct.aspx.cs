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
    public partial class ListOfProduct : System.Web.UI.Page
    {

        public List<Categoria> ListaCategorias { get; set; }
        public List<VideoGame> ListaVideogames { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            //validacion de login---------------------------------------------

            if (!((Session["email"]) != null && ((LoginUsuario)Session["email"]).TipoUsuario == TipoUsuario.Admin))
            {
                Session.Add("Error", "Acceso denegado");
                Response.Redirect("Error.aspx", false);
            }

            //Listar videojuegos
            VGameNegocio videoGame = new VGameNegocio();

            ListaVideogames = videoGame.Listar();

            //Listar categorias
            CategoriaNegocio categoria = new CategoriaNegocio();
            ListaCategorias = categoria.Listar();


        }
    }
}