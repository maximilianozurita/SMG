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

        public List<VideoGame> Listar()
        {
            List<VideoGame> lista = new List<VideoGame>();
            AccesoDatos datos = new AccesoDatos();
            VideoGame aux = new VideoGame();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos, d.name as developer_name, d.information as developer_info, c.name as category_name , i.url_image as imageUrl,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d, images i where v.id=i.id_product and v.Id_category=c.id and v.Id_developer=d.id");
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
                datos.SetearConsulta("insert into videoGames (name, Description,Requerimientos,Id_category,Id_developer,Price,Descuento,Destacado,Clasificacion_PIG,Launch_Date) values ('"+ nuevo.Name +"','" + nuevo.Description + "','"+nuevo.Requerimentos+"',"+nuevo.Categoria.Id+","+nuevo.Developer.ID+","+nuevo.Price+","+nuevo.Descuento+","+nuevo.Destacado+","+nuevo.ClasificaconPGI+","+nuevo.LaunchDate+");");
                datos.setearParametros("@Id", nuevo.ID);
                datos.setearParametros("@Nombre", nuevo.Name);
                datos.setearParametros("@Descripcion", nuevo.Description);
                datos.setearParametros("@Requerimentos", nuevo.Requerimentos);
                datos.setearParametros("@Precio", nuevo.Price);
                datos.setearParametros("@Descuento", nuevo.Descuento);
                datos.setearParametros("@PDestacado", nuevo.Destacado);
                datos.setearParametros("@Clasificacon_PGI", nuevo.ClasificaconPGI);
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
                datos.setearParametros("@Nombre", Modificar.Name);
                datos.setearParametros("@Descripcion", Modificar.Description);
                datos.setearParametros("@Requerimentos", Modificar.Requerimentos);
                datos.setearParametros("@Precio", Modificar.Price);
                datos.setearParametros("@Descuento", Modificar.Descuento);
                datos.setearParametros("@PDestacado", Modificar.Destacado);
                datos.setearParametros("@Clasificacon_PGI", Modificar.ClasificaconPGI);
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
                aux.Name = (string)datos.Lector["name"];
                aux.Description = (string)datos.Lector["description"];
                aux.Requerimentos = (string)datos.Lector["Requerimientos"];
                aux.ClasificaconPGI = (int)datos.Lector["Clasificacion_PIG"];

                if (!(datos.Lector["Descuento"] is DBNull))
                    aux.Descuento = (float)(decimal)datos.Lector["Descuento"];


                aux.Destacado = (bool)datos.Lector["Destacado"];
                aux.LaunchDate = (DateTime)datos.Lector["Launch_Date"];
                if (!(datos.Lector["Price"] is DBNull))
                    aux.Price = (float)(decimal)datos.Lector["Price"];

                aux.Categoria = new Categoria
                {
                    Name = (string)datos.Lector["name"]
                };
                aux.Categoria.Id = (int)datos.Lector["id"];

                aux.Developer = new Developers
                {
                    Name = (string)datos.Lector["name"],
                };
                aux.Developer.ID = (int)datos.Lector["id"];

                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
