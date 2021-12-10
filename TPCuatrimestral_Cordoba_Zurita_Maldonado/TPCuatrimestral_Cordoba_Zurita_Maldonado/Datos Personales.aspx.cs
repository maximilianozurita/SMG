using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mod_Dominio;
using Conexion_BD;

namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{
    public partial class Datos_Personales : System.Web.UI.Page
    {
        public List<Imagen> ListaImagenes = new List<Imagen>();
        public List<VideoGame> LJuegosAgregados = new List<VideoGame>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioNegocio userNeg = new UsuarioNegocio();
            Carrito carri = new Carrito();
            CarritoNegocio carNeg = new CarritoNegocio();
            List<Carrito> carriList = new List<Carrito>();
            VGameNegocio vGame = new VGameNegocio();

            string usuario = Session["NombreUsuario"] != null ? Session["NombreUsuario"].ToString() : "";
            user = userNeg.Loguear(usuario);
            int IdUsuario = user.ID;

            carriList = carNeg.ListarCarrito(IdUsuario);

            foreach (var item in carriList)
            {
                LJuegosAgregados.Add(vGame.FindByPK(item.IdProducto));
            }
        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            int IdVenta;
            Usuario user = new Usuario();
            UsuarioNegocio userNeg = new UsuarioNegocio();
            Venta vent = new Venta();
            VentaNegocio ventNeg = new VentaNegocio();
            string usuario = Session["NombreUsuario"] != null ? Session["NombreUsuario"].ToString() : "";
            user = userNeg.Loguear(usuario);
            int IdUsuario = user.ID;
            float suma = 0;

            vent.Id_user = IdUsuario;
            vent.Suma = suma;

            IdVenta = ventNeg.Agregar(vent);

            Carrito carri = new Carrito();
            CarritoNegocio carriNeg = new CarritoNegocio();

            carriNeg.Modificar(IdVenta, IdUsuario);



            Response.Redirect("Default.aspx");
        }
    }
}