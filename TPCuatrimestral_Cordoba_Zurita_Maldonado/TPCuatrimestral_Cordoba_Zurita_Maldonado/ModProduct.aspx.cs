using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mod_Dominio;
using Conexion_BD;

namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{
    public partial class ModProduct : System.Web.UI.Page
    {

        public List<Categoria> ListaCategoria { get; set; }
        public List<Developers> ListaDevelopers { get; set; }
        public List<Imagen> ListaImagenes { get; set; }

        public VideoGame videogame = new VideoGame();
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            DevelopersNegocio developers = new DevelopersNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            VGameNegocio vGame = new VGameNegocio();

            int ProductID = int.Parse(Request.QueryString["ID"]);

            videogame = vGame.FindByPK(ProductID);

            try
            {

                //validacion de login---------------------------------------------

                if (!((Session["email"]) != null && ((LoginUsuario)Session["email"]).TipoUsuario == TipoUsuario.Admin))
                {
                    Session.Add("Error", "Acceso denegado");
                    Response.Redirect("Error.aspx", false);
                }

                //Carga de info de producto en DB
                if (!IsPostBack)
                {
                    DropdCategoria.DataSource = categoria.Listar();
                    DropdCategoria.DataTextField = "Name";
                    DropdCategoria.DataValueField = "Id";
                    DropdCategoria.DataBind();

                    DropdDeveloper.DataSource = developers.Listar();
                    DropdDeveloper.DataTextField = "Name";
                    DropdDeveloper.DataValueField = "ID";
                    DropdDeveloper.DataBind();

                    inputNombre.Text = videogame.Name;
                    inputDescripcion.Text = videogame.Description;
                    inputRequerimiento.Text = videogame.Requerimentos;
                    inputClasificacion.Text = videogame.ClasificaconPGI.ToString();
                    inputPrecio.Text = videogame.Price.ToString();
                    inputDescuento.Text = videogame.Descuento.ToString();
                    inputFechaLanzamiento.Text = videogame.LaunchDate.ToString("yyyy-MM-dd");
                    CheckDestacado.Checked = videogame.Developer.Estado;

                    DropdDeveloper.SelectedIndex = -1;
                    string IDDev = videogame.Developer.ID.ToString();
                    DropdDeveloper.Items.FindByValue(IDDev).Selected = true;

                    DropdCategoria.SelectedIndex = -1;
                    string IDCateg = videogame.Categoria.Id.ToString();
                    DropdCategoria.Items.FindByValue(IDCateg).Selected = true;

                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
            }

        }

        protected void btnCrearProducto_Click(object sender, EventArgs e)
        {
            VideoGame videogame = new VideoGame();
            Helpers helpers = new Helpers();
            VGameNegocio videoGameNegocio = new VGameNegocio();
            int ProductID = int.Parse(Request.QueryString["ID"].ToString());

            try
            {
                videogame.ID = ProductID;
                videogame.Name = inputNombre.Text;
                videogame.Description = inputDescripcion.Text;
                videogame.Requerimentos = inputRequerimiento.Text;
                videogame.ClasificaconPGI = int.Parse(inputClasificacion.Text);
                videogame.Price = (float)decimal.Parse(inputPrecio.Text);
                videogame.Descuento = (float)decimal.Parse(inputDescuento.Text);
                videogame.LaunchDate = DateTime.Parse(inputFechaLanzamiento.Text);
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
                videoGameNegocio.Modificar(videogame);

                List<FileUpload> archivos = new List<FileUpload>();
                archivos.Add(FileUpload1);
                archivos.Add(FileUpload2);
                archivos.Add(FileUpload3);
                archivos.Add(FileUpload4);
                archivos.Add(FileUpload5);

                helpers.ModificarImagen(archivos, ProductID);

                Response.Redirect("ListOfProduct.aspx", false);
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            VGameNegocio videoGameNegocio = new VGameNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            string ProductID = Request.QueryString["ID"].ToString();

            try
            {
                imagenNegocio.Eliminar(ProductID);
                videoGameNegocio.Eliminar(ProductID);
                Response.Redirect("ListOfProduct.aspx", false);
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}