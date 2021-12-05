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

        public void Agregar(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into images (url_image, id_product) values ('" + nuevo.urlImagen + "' , " + nuevo.idVdeoJuego +");");
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

        public List<Imagen> FindByFk(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Imagen> lista = new List<Imagen>();
            Imagen aux = new Imagen();
            try
            {
                datos.SetearConsulta("Select i.id, i.url_image, i.Estado,i.id_product From images i where i.id_product=@Id ;");
                datos.setearParametros("@Id", ID);
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


        public void Eliminar(string Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Update images SET Estado=0 where id=@Id;");
                datos.setearParametros("@Id", Eliminar);
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
        public Imagen Asignacion(AccesoDatos datos)
        {

            try
            {
                Imagen aux = new Imagen();
                aux.ID = (int)datos.Lector["id"];
                aux.urlImagen = (string)datos.Lector["url_image"];
                aux.idVdeoJuego = (int)datos.Lector["id_product"];
                aux.Estado = (bool)datos.Lector["Estado"];
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
