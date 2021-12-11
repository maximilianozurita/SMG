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
    public partial class Detalle_de_producto : System.Web.UI.Page
    {
        public VideoGame videogame = new VideoGame();
        public Image imagen = new Image();

        public List<VideoGame> ListaVJuegos = new List<VideoGame>();
        public List<Imagen> ListaImagenes { get; set; }

        VGameNegocio vGame = new VGameNegocio();



        protected void Page_Load(object sender, EventArgs e)
        {
            int ProductoID = int.Parse(Request.QueryString["ID"]);
            ImagenNegocio imagNeg = new ImagenNegocio();





            ListaImagenes = imagNeg.FindByFk(ProductoID); 

            videogame = vGame.FindByPK(ProductoID);
            //ListaVJuegos.Add(videogame);


            //if ( !(Session["JuegosAgregados"] != null )) 
            //{
            //    ListaVJuegos.Add(videogame);

            //    Session.Add( "JuegosAgregados",ListaVJuegos);
            //}           
        }

        protected void BtnAgregarCarro_Click(object sender, EventArgs e)
        {
            Carrito carri = new Carrito();
            CarritoNegocio carriNeg = new CarritoNegocio();
            Usuario user = new Usuario();
            UsuarioNegocio userNeg = new UsuarioNegocio();
            float precioTotal = 0;

            int ProductoID = int.Parse(Request.QueryString["ID"]);
            videogame = vGame.FindByPK(ProductoID);

            string usuario = Session["NombreUsuario"] != null ? Session["NombreUsuario"].ToString() : "";
            user = userNeg.Loguear(usuario);


            carri.IdProducto = videogame.ID;
            carri.IdUsuario = user.ID;
            carri.Precio = videogame.Price;

            precioTotal += videogame.Price;

            carriNeg.Agregar(carri);

            Response.Redirect("CarritoFront.aspx",false);
        }
    }
}