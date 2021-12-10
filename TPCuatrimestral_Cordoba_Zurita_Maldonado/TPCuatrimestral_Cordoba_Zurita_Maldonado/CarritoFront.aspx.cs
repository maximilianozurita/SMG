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
        public bool producto = true;
        public List<Imagen> ListaImagenes = new List<Imagen>();
        public List<VideoGame> LJuegosAgregados = new List<VideoGame>();
        public CarritoNegocio carNeg = new CarritoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioNegocio userNeg = new UsuarioNegocio();
            Carrito carri = new Carrito();
            List<Carrito> carriList = new List<Carrito>();
            VGameNegocio vGame = new VGameNegocio();

            string usuario = Session["NombreUsuario"] != null ? Session["NombreUsuario"].ToString() : "";
            user = userNeg.Loguear(usuario);
            int IdUsuario = user.ID;

            if (!IsPostBack)
            {
                CheckBoxList.DataSource = carNeg.ListarCarrito(user.ID);
                CheckBoxList.DataValueField = "Id";
                CheckBoxList.DataBind();
            }


            carriList = carNeg.ListarCarrito(IdUsuario);

            foreach (var item in carriList)
            {
                LJuegosAgregados.Add(vGame.FindByPK(item.IdProducto));
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int i, id;

            for (i = 0; i < CheckBoxList.Items.Count; i++)
            {
                if (CheckBoxList.Items[i].Selected)
                {
                    id = int.Parse(CheckBoxList.Items[i].Value);
                    carNeg.EliminarProducto(id);
                }
            }
            Response.Redirect("CarritoFront.aspx");
        }
    }
}