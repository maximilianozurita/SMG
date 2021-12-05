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
    public partial class Carrito : System.Web.UI.Page
    {
     
        public List<Imagen> ListaImagenes = new List<Imagen>() ;
        public List<VideoGame> LJuegosAgregados=new List<VideoGame>(); 

        protected void Page_Load(object sender, EventArgs e)
        {

            LJuegosAgregados = (List<>Session["JuegosAgregados"];
          
        }

    }
}