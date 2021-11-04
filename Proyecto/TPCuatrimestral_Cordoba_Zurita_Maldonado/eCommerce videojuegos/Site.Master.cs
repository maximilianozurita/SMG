using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerce_videojuegos
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CategoriaNegocio Categorias = new CategoriaNegocio();

            try
            {
                if (!IsPostBack)
                {
                    IdCategorias.DataSource = Categorias.listar();
                    IdCategorias.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
            }




        }
    }
}