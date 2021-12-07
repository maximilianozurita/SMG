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
    public partial class ListOfProduct : System.Web.UI.Page
    {

        public List<Categoria> ListaCategorias { get; set; }
        public List<VideoGame> ListaVideogames { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            //validacion de login--//
            if (!((Session["email"]) != null && ((LoginUsuario)Session["email"]).TipoUsuario == TipoUsuario.Admin))
            {
                Session.Add("Error", "Acceso denegado");
                Response.Redirect("Error.aspx", false);
            }

            //Listar categorias
            CategoriaNegocio categoria = new CategoriaNegocio();
            if (!IsPostBack)
            {
                CheckBoxList.DataSource = categoria.Listar();
                CheckBoxList.DataTextField = "Name";
                CheckBoxList.DataValueField = "Id";
                CheckBoxList.DataBind();
            }

            ///----------------Filtrar---------------///////
            Helpers Helper = new Helpers();
            ListaVideogames = Helper.Filtro(null, null, null, CheckBoxList);

        }
    }
}