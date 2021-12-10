using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.IO;
using System.Threading.Tasks;
using Mod_Dominio;


namespace Conexion_BD
{
    public class Helpers
    {

        public List<VideoGame> Filtro(string Search_query, string SP_query, string Category_query, CheckBoxList CheckBoxList)
        {

            List<VideoGame> ListaAux = new List<VideoGame>();
            List<VideoGame> ListaVideogames = new List<VideoGame>();
            VGameNegocio videoGame = new VGameNegocio();

            int i;
            if (Search_query != null)
            {
                //Listar videojuegos buscados
                ListaVideogames = videoGame.Search(Search_query);
            }
            else if (SP_query == "Oferta")
            {
                ListaVideogames = videoGame.Ofertas();
            }
            else if (SP_query == "NewLaunch")
            {
                ListaVideogames = videoGame.NewLaunch();
            }
            else if (Category_query != null)
            {
                //Listar videojuegos filtrados
                for (i = 0; i < CheckBoxList.Items.Count; i++)
                {
                    if (CheckBoxList.Items[i].Text == Category_query)
                    {
                        CheckBoxList.Items[i].Selected = true;
                    }
                }
            }
            else
            {
                //Listar videojuegos sin filtrar
                ListaVideogames = videoGame.Listar();
            }

            string chkbox = "";
            for (i = 0; i < CheckBoxList.Items.Count; i++)
            {
                if (CheckBoxList.Items[i].Selected)
                {
                    if (chkbox == "")
                    {
                        chkbox = CheckBoxList.Items[i].Text;
                    }
                    else
                    {
                        chkbox += "'" + "," + "'" + CheckBoxList.Items[i].Text;
                    }
                }
            }
            bool CheckSelected = false;
            if (chkbox != "")
            {
                CheckSelected = true;
                ListaAux = videoGame.Filter(chkbox);
            }

            if (CheckSelected)
            {
                ListaVideogames = ListaAux;
            }

            return ListaVideogames;
        }

        public int BoolToInt(bool value)
        {
            int OutValue = 0;
            if (value)
            {
                OutValue = 1;
            }
            return OutValue;
        }

        public void ModificarImagen(List<FileUpload> archivos, int ProductID)
        {

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Imagen imagen = new Imagen();
            int i = 0;
            foreach (var item in archivos)
            {
                if (item.HasFile)
                {
                    try
                    {

                        List<Imagen> OldListImagen = new List<Imagen>();
                        OldListImagen = imagenNegocio.FindByFk(ProductID);
                        imagen.idVdeoJuego = ProductID;

                        if (item.PostedFile.ContentType == "image/jpeg" || item.PostedFile.ContentType == "image/jpg" || item.PostedFile.ContentType == "image/png")
                        {
                            if (item.PostedFile.ContentLength < 3932160)
                            {
                                string filename = Path.GetRandomFileName();
                                string extension = Path.GetExtension(item.FileName);
                                item.SaveAs(System.Web.HttpContext.Current.Server.MapPath("~/images/product/") + filename + extension);
                                imagen.urlImagen = filename + extension;

                                string OldNameImagen =OldListImagen.Count>=i+1? OldListImagen[i].urlImagen: "";
                                string Rute = System.Web.HttpContext.Current.Server.MapPath("~/images/product/") + OldNameImagen;
                                if (File.Exists(Rute))
                                {
                                    File.Delete(Rute);
                                }

                                imagen.ID = OldListImagen.Count >= i + 1 ? OldListImagen[i].ID: 0;
                                if (imagen.ID == 0)
                                {
                                    imagenNegocio.Agregar(imagen);
                                }
                                else
                                {
                                    imagenNegocio.Modificar(imagen);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                i++;
            }
        }

        public void AgregarImagen(List<FileUpload> archivos, int IdInserted)
        {
            Imagen imagen = new Imagen();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            imagen.idVdeoJuego = IdInserted;

            foreach (var item in archivos)
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
                                item.SaveAs(System.Web.HttpContext.Current.Server.MapPath("~/images/product/") + filename + extension);
                                imagen.urlImagen = filename + extension;
                                imagenNegocio.Agregar(imagen);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

    }
}
