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

            if (!IsPostBack)
            {
                CheckBoxList.DataSource = categoria.Listar();
                CheckBoxList.DataTextField = "Name";
                CheckBoxList.DataValueField = "Id";
                CheckBoxList.DataBind();
            }

            List<VideoGame> ListaAux = new List<VideoGame>();
            int i;
            string Search_query = Request.QueryString["Search_query"];
            string Category_query = Request.QueryString["Category_query"];
            string SP_query = Request.QueryString["SP_query"];
            if (Search_query != null)
            {
                //Listar videojuegos buscados
                ListaVideogames = videoGame.Search(Search_query);
            }
            else if (SP_query == "Oferta")
            {
                ListaVideogames = videoGame.Ofertas();
            }
            else if (SP_query == "NewLaunch")
            {
                ListaVideogames = videoGame.NewLaunch();
            }
            else if (Category_query != null)
            {
                //Listar videojuegos filtrados
                for (i = 0; i < CheckBoxList.Items.Count; i++)
                {
                    if (CheckBoxList.Items[i].Text == Category_query)
                    {
                        CheckBoxList.Items[i].Selected = true;
                    }
                }
            }
            else
            {
                //Listar videojuegos sin filtrar
                ListaVideogames = videoGame.Listar();
            }

            string chkbox = "";
            for (i = 0; i < CheckBoxList.Items.Count; i++)
            {
                if (CheckBoxList.Items[i].Selected)
                {
                    if (chkbox == "")
                    {
                        chkbox = CheckBoxList.Items[i].Text;
                    }
                    else
                    {
                        chkbox += "'" + "," + "'" + CheckBoxList.Items[i].Text;
                    }
                }
            }
            bool CheckSelected = false;
            if (chkbox != "")
            {
                CheckSelected = true;
                ListaAux = videoGame.Filter(chkbox);
            }

            if (CheckSelected)
            {
                ListaVideogames = ListaAux;
            }


        }
    }
}