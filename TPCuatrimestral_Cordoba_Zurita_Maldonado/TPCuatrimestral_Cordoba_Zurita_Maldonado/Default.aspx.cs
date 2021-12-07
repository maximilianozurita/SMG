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
    public partial class Default : System.Web.UI.Page
    {
        public List<VideoGame> ListaVideogames { get; set; }
        public List<VideoGame> VideoGamesOfertas { get; set; }
        public List<VideoGame> NewVideoGames { get; set; }

        public List<VideoGame> VOfertas { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            VGameNegocio videoGame = new VGameNegocio();

            ListaVideogames = videoGame.Listar();
            VideoGamesOfertas = videoGame.Ofertas();
            NewVideoGames = videoGame.NewLaunch();

        }
    }
}