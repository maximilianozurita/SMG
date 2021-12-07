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
    public partial class List : System.Web.UI.Page
    {
        public List<Categoria> ListaCategorias { get; set; }
        public List<VideoGame> ListaVideogames { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Listar categorias
            CategoriaNegocio categoria = new CategoriaNegocio();
            ListaCategorias = categoria.Listar();

            if (!IsPostBack)
            {
                CheckBoxList.DataSource = categoria.Listar();
                CheckBoxList.DataTextField = "Name";
                CheckBoxList.DataValueField = "Id";
                CheckBoxList.DataBind();
            }
            
            string Search_query = Request.QueryString["Search_query"];
            string Category_query = Request.QueryString["Category_query"];
            string SP_query = Request.QueryString["SP_query"];

            ///----------------Filtrar---------------///////
            Helpers Helper = new Helpers();
            ListaVideogames = Helper.Filtro(Search_query, SP_query, Category_query, CheckBoxList);

        }
    }
}