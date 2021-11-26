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
    public partial class List : System.Web.UI.Page
    {
        public List<Categoria> ListaCategorias { get; set; }
        public List<VideoGame> ListaVideogames { get; set; }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //Listar categorias
            CategoriaNegocio categoria = new CategoriaNegocio();
            ListaCategorias = categoria.Listar();

            //Listado de videojuegos
            VGameNegocio videoGame = new VGameNegocio();
            string Search_query = Request.QueryString["Search_query"];
            string Category_query = Request.QueryString["Category_query"];
            string SP_query = Request.QueryString["SP_query"];

            if (Search_query != null)
            {
                //Listar videojuegos buscados
                ListaVideogames = videoGame.Search(Search_query);
            }
            else if (Category_query != null)
            {
                //Listar videojuegos filtrados
                ListaVideogames = videoGame.Filter(Category_query);
            }
            else if (SP_query == "Oferta")
            {
                ListaVideogames = videoGame.Ofertas();
            }
            else if (SP_query == "NewLaunch")
            {
                ListaVideogames = videoGame.NewLaunch();
            }
            else
            {
                //Listar videojuegos sin filtrar
                ListaVideogames = videoGame.Listar();
            }
                  
        }
    }
}