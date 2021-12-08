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
    public partial class CarritoFront : System.Web.UI.Page
    {
     
        public List<Carrito> ListaCarrito = new List<Carrito>() ;
        public List<VideoGame> ListaJuegos { get; set; } 

        protected void Page_Load(object sender, EventArgs e)
        {
            VGameNegocio auxcarNeg = new VGameNegocio();
            CarritoNegocio carNeg = new CarritoNegocio();
            int id_usu =Session["email"]!=null? ((LoginUsuario)Session["email"]).ID : -1;
            ListaCarrito = carNeg.Buscar_Xid(id_usu);
            foreach(var item in ListaCarrito)
            {
                ListaJuegos.Add(auxcarNeg.FindByPK(item.id_producto));
            }
          
        }

    }
}