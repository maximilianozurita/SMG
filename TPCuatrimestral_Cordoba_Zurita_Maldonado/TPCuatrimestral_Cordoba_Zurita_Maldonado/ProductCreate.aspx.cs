using System;
using System.Collections.Generic;
using System.IO;
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
            //listado de dropList---------------------------------------------
            CategoriaNegocio categoria = new CategoriaNegocio();
            DevelopersNegocio developers = new DevelopersNegocio();

            try
            {
                //validacion de login---------------------------------------------

                if (!((Session["email"]) != null && ((LoginUsuario)Session["email"]).TipoUsuario == TipoUsuario.Admin))
                {
                    Session.Add("Error", "No tenes permiso para ingresar a esta pantalla");
                    Response.Redirect("Error.aspx", false);
                }
                    //listado de dropList---------------------------------------------

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
            VGameNegocio videoGameNegocio = new VGameNegocio();

            try
            {
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

                int IdInserted = videoGameNegocio.Agregar(videogame);

                Imagen imagen = new Imagen();
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                imagen.idVdeoJuego = IdInserted;
                List<FileUpload> archivos = new List<FileUpload>();

                archivos.Add(FileUpload1);
                archivos.Add(FileUpload2);
                archivos.Add(FileUpload3);
                archivos.Add(FileUpload4);
                archivos.Add(FileUpload5);

                //File.Exists("~/images/product/")
                //    File.Delete

                foreach(var item in archivos)
                {
                    if (item.HasFile)
                    {
                        try
                        {
                            if (item.PostedFile.ContentType == "image/jpeg" || item.PostedFile.ContentType == "image/jpg" || item.PostedFile.ContentType == "image/png")
                            {
                                if (item.PostedFile.ContentLength < 3932160)
                                {
                                    string filename = Path.GetRandomFileName();
                                    string extension = Path.GetExtension(item.FileName);
                                    item.SaveAs(Server.MapPath("~/images/product/") + filename + extension);
                                    imagen.urlImagen = filename + extension;
                                    imagenNegocio.Agregar(imagen);
                                }
                                else
                                {
                                    //string AlertText = "Upload status: The file has to be less than 30 MB!";
                                }
                            }
                            else
                            {
                                //string AlertText = "Upload status: Only JPEG files are accepted!";
                            }
                        }
                        catch (Exception ex)
                        {
                            //string AlertText = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                        }
                    }
                }

                Response.Redirect("ListOfProduct.aspx", false);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    
}