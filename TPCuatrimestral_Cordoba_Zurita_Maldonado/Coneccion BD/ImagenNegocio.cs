using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;
namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> Listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            Imagen aux = new Imagen();
            try
            {
                datos.SetearConsulta("Select i.id, i.url_image, i.Estado,i.id_product From videoGames V, images i where i.id_product= V.id ");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    aux = Asignacion(datos);

                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }
        public Imagen Asignacion(AccesoDatos datos)
        {

            try
            {
                Imagen aux = new Imagen();
                aux.ID = (int)datos.Lector["id"];
                aux.urlImagen = (string)datos.Lector["url_image"];
                aux.idVdeoJuego= new VideoGame();
                aux.idVdeoJuego.ID = (int)datos.Lector["id_product"];
                aux.Estado = (bool)datos.Lector["Estado"];
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Agregar(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into images (id, url_image, id_product, Estado) values (" + nuevo.ID + ",'" + nuevo.urlImagen + "' , " + nuevo.idVdeoJuego + ", " + nuevo.Estado + ");");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
