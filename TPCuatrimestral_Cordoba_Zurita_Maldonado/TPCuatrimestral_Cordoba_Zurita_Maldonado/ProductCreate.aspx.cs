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
                    DropdCategoria.DataTextField = "Name";
                    DropdCategoria.DataValueField = "Id";
                    DropdCategoria.DataBind();

                    DropdDeveloper.DataSource = developers.Listar();
                    DropdDeveloper.DataTextField = "Name";
                    DropdDeveloper.DataValueField = "ID";
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

            Imagen imagen = new Imagen();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                videogame.Name = inputNombre.Text;
                videogame.Description = inputDescripcion.Text;
                videogame.Requerimentos = inputRequerimiento.Text;
                videogame.ClasificaconPGI = int.Parse(inputClasificacion.Text);
                videogame.Price =(float)decimal.Parse(inputPrecio.Text);
                videogame.Descuento=(float)decimal.Parse(inputDescuento.Text);
                videogame.LaunchDate= DateTime.Parse(inputFechaLanzamiento.Text);
                videogame.Destacado = CheckDestacado.Checked;

                videogame.Categoria = new Categoria
                {
                    Id = int.Parse(DropdCategoria.SelectedItem.Value),
                    Name = (string)DropdCategoria.SelectedItem.Text,
                };

                videogame.Developer = new Developers
                {
                    ID = int.Parse(DropdDeveloper.SelectedItem.Value),
                    Name = (string)DropdDeveloper.SelectedItem.Text,
                };


                videoGameNegocio.Agregar(videogame);

                Response.Redirect("ListOfProduct.aspx", false);

            }
            catch (Exception)
            {
                throw;
            }


        }





    }
}