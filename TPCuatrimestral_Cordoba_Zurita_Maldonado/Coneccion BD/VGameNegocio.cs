using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Negocio
{
    public class VGameNegocio
    {

        public List<VideoGame> listar()
        {
            List<VideoGame> lista = new List<VideoGame>();
            AccesoDatos datos = new AccesoDatos();
            VideoGame aux = new VideoGame();
            try
            {
                datos.SetearConsulta("Select V.name, V.Description, V.Requerimientos, d.name as developer_name, d.information as developer_info, c.name as category_name , i.url_image as imageUrl,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d, images i where v.id=i.id_product and v.Id_category=c.id and v.Id_developer=d.id");
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
        public void Agregar(VideoGame nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into videoGames (name, Description,Requerimientos,Id_category,Id_developer,Price,Descuento,Destacado,Clasificacion_PIG,Launch_Date) values ('"+ nuevo.Nombre+"','" + nuevo.Descripcion + "','"+nuevo.Requerimentos+"',"+nuevo.Categoria.Id+","+nuevo.Developer.ID+","+nuevo.Precio+","+nuevo.Descuento+","+nuevo.Destacado+","+nuevo.Clasificacon_PGI+","+nuevo.LaunchDate+");");
                datos.setearParametros("@Id", nuevo.ID);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@Requerimentos", nuevo.Requerimentos);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.setearParametros("@Descuento", nuevo.Descuento);
                datos.setearParametros("@PDestacado", nuevo.Destacado);
                datos.setearParametros("@Clasificacon_PGI", nuevo.Clasificacon_PGI);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@IdDeveloper", nuevo.Developer.ID);
                datos.setearParametros("@IdDeveloper", nuevo.LaunchDate);
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
        public void Modificar(VideoGame Modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update videoGames set name=@Nombre, Description=@Descripcion,Requerimientos=@Requerimientos,Precio=@Precio,Descuento=@Descuento, Destacado=@Destacado, Clasificacion_PIG=@Clasificacion_PGI, Id_category=@IdCategoria, Id_developer=@IdDeveloper where Id=@Id");
                datos.setearParametros("@Id", Modificar.ID);
                datos.setearParametros("@Nombre", Modificar.Nombre);
                datos.setearParametros("@Descripcion", Modificar.Descripcion);
                datos.setearParametros("@Requerimentos", Modificar.Requerimentos);
                datos.setearParametros("@Precio", Modificar.Precio);
                datos.setearParametros("@Descuento", Modificar.Descuento);
                datos.setearParametros("@PDestacado", Modificar.Destacado);
                datos.setearParametros("@Clasificacon_PGI", Modificar.Clasificacon_PGI);
                datos.setearParametros("@IdCategoria", Modificar.Categoria.Id);
                datos.setearParametros("@IdDeveloper", Modificar.Developer.ID);
                datos.setearParametros("@IdDeveloper", Modificar.LaunchDate);
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
        public void Eliminar(VideoGame Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("DELETE FROM videoGames WHERE Id=@Id");
                datos.setearParametros("@Id", Eliminar.ID);
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
        public VideoGame Asignacion(AccesoDatos datos)
        {

            try
            {
                VideoGame aux = new VideoGame();
                aux.ID = (int)datos.Lector["Id"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Descripcion = (string)datos.Lector["Descripcion"];
                aux.Requerimentos = (string)datos.Lector["Requerimientos"];
                aux.Clasificacon_PGI = (int)datos.Lector["Clasificacion_PGI"];
                aux.Descuento = (int)datos.Lector["Descuento"];
                aux.Destacado = (bool)datos.Lector["Destacado"];
                aux.LaunchDate = (DateTime)datos.Lector["LaunchDate"];
                    
                aux.Categoria = new Categoria
                {
                    name = (string)datos.Lector["Categorias"]
                };
                aux.Categoria.Id = (int)datos.Lector["IdCategoria"];

                aux.Developer = new Developers
                {
                    Nombre = (string)datos.Lector["Nombre"]
                };
                aux.Developer.ID = (int)datos.Lector["IdDeveloper"];

                if (!(datos.Lector["Precio"] is DBNull))
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
