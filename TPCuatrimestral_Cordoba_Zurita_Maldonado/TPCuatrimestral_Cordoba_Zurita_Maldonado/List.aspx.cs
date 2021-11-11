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
        public List<VideoGame> ListaVideogames { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            VGameNegocio videoGame = new VGameNegocio();

            ListaVideogames = videoGame.Listar();

        }
    }
}