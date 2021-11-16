using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mod_Dominio;
using Negocio;

namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{
    public partial class ProductCreate : System.Web.UI.Page
    {

        public List<Categoria> ListaCategoria { get; set; }
        public List<Developers> ListaDevelopers { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            DevelopersNegocio developers = new DevelopersNegocio();

            try
            {
                if (!IsPostBack)
                {
                    DropdCategoria.DataSource= categoria.Listar();
                    DropdCategoria.DataBind();

                    DropdDeveloper.DataSource = developers.Listar();
                    DropdDeveloper.DataBind();

                }
            }
            catch(Exception ex)
            {
                Session.Add("Error", ex);
            }


        }

        protected void btnCrearProducto_Click(object sender, EventArgs e)
        {
            VideoGame videogame = new VideoGame();
            VGameNegocio videoGameNegocio = new VGameNegocio();

            try
            {
                videogame.Name = inputNombre.Text;
                videogame.Description = inputDescripcion.Text;
                videogame.Requerimentos = inputRequerimiento.Text;
                videogame.ClasificaconPGI = int.Parse(inputClasificacion.Text);
                videogame.Price =(float)decimal.Parse(inputPrecio.Text);
                videogame.Descuento=(float)decimal.Parse(inputDescuento.Text);
                videogame.LaunchDate= DateTime.Parse(inputFechaLanzamiento.Text);
                //videogame.Categoria.Id = 1 ;
                //videogame.Developer.ID = 1;
                videogame.Destacado = CheckDestacado.Checked;

                videoGameNegocio.Agregar(videogame);
            }
            catch (Exception)
            {
                throw;
            }


        }





    }
}