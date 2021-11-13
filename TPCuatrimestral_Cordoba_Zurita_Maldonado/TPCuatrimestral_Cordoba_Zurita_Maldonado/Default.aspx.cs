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
    public partial class Default : System.Web.UI.Page
    {
        public List<VideoGame> ListaVideogames { get; set; }
        public List<VideoGame> VDestacados { get; set; }
        public List<VideoGame> NewVideoGames { get; set; }

        public List<VideoGame> VOfertas { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            VGameNegocio videoGame = new VGameNegocio();

            ListaVideogames = videoGame.Listar();


            //foreach (var item in ListaVideogames)
            //{
            //    if (item.Destacado == true)
            //    {
            //        VDestacados.Add(item);
            //    }

            //    if (item.Descuento != 0)
            //    {
            //        VOfertas.Add(item);
            //    }

            //    if(DateTime.Today.DayOfYear-item.LaunchDate.DayOfYear< 15 && item.LaunchDate.Year == DateTime.Today.Year)
            //    {
            //        NewVideoGames.Add(item);
            //    }
            //}

        }
    }
}