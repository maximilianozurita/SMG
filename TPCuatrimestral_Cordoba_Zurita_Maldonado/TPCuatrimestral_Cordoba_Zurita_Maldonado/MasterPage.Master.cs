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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public List<Categoria> ListaCategoria { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            CategoriaNegocio categoria = new CategoriaNegocio();

            ListaCategoria = categoria.Listar();


        }
    }
}