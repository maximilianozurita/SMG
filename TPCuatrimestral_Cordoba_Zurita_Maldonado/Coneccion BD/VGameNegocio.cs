using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Conexion_BD
{
    public class VGameNegocio
    {
        ImagenNegocio imagenNegocio = new ImagenNegocio();
        Helpers helpers = new Helpers();

        public List<VideoGame> Listar()
        {
            List<VideoGame> lista = new List<VideoGame>();
            AccesoDatos datos = new AccesoDatos();
            VideoGame aux = new VideoGame();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos,v.Id_category,V.Id_developer, d.name as developer_name, d.information as developer_info, c.name as category_name,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d where v.Id_category=c.id and v.Id_developer=d.id and V.Estado=1;");
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

        public List<VideoGame> Ofertas()
        {
            List<VideoGame> lista = new List<VideoGame>();
            AccesoDatos datos = new AccesoDatos();
            VideoGame aux = new VideoGame();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos,v.Id_category,V.Id_developer, d.name as developer_name, d.information as developer_info, c.name as category_name,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d where v.Id_category=c.id and v.Id_developer=d.id and V.Descuento!=0 and V.Estado=1;");
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

        public List<VideoGame> NewLaunch()
        {
            List<VideoGame> lista = new List<VideoGame>();
            AccesoDatos datos = new AccesoDatos();
            VideoGame aux = new VideoGame();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos,v.Id_category,V.Id_developer, d.name as developer_name, d.information as developer_info, c.name as category_name,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d where v.Id_category=c.id and V.Estado=1 and v.Id_developer=d.id and DAY(GETDATE())-DAY(V.Launch_Date) < 15 and MONTH(GETDATE())=MONTH(V.Launch_Date) and YEAR(GETDATE()) = YEAR(V.Launch_Date);");
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

        public VideoGame FindByPK(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos,v.Id_category,V.Id_developer, d.name as developer_name, d.information as developer_info, c.name as category_name,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d where V.id=@Id and v.Id_category=c.id and v.Id_developer=d.id and V.Estado=1;");
                datos.setearParametros("@Id", ID);
                datos.EjecutarLectura();
                datos.Lector.Read();
                VideoGame aux = Asignacion(datos);

                return aux;

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

        public List<VideoGame> Search(string ItemToSeach)
        {
            List<VideoGame> SearchList = new List<VideoGame>();
            AccesoDatos datos = new AccesoDatos();
            VideoGame aux = new VideoGame();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos,v.Id_category,V.Id_developer, d.name as developer_name, d.information as developer_info, c.name as category_name,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d where v.name LIKE @buscar and v.Id_category=c.id and v.Id_developer=d.id and V.Estado=1;");
                datos.setearParametros("@buscar", '%' + ItemToSeach + '%');
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    aux = Asignacion(datos);

                    SearchList.Add(aux);
                }
                return SearchList;
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


        public List<VideoGame> Filter(string Filter)
        {
            List<VideoGame> FilteredSearch = new List<VideoGame>();
            AccesoDatos datos = new AccesoDatos();
            VideoGame aux = new VideoGame();
            try
            {
                datos.SetearConsulta("Select V.id, V.name, V.Description, V.Requerimientos,v.Id_category,V.Id_developer, d.name as developer_name, d.information as developer_info, c.name as category_name,V.Price,V.Descuento,V.Destacado,V.Clasificacion_PIG,V.Launch_Date,V.Estado From videoGames V, categories c, developers d where c.name in ('"+Filter+"') and v.Id_category=c.id and v.Id_developer=d.id and V.Estado=1;");
                datos.setearParametros("@Filtrar",Filter);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    aux = Asignacion(datos);

                    FilteredSearch.Add(aux);
                }
                return FilteredSearch;

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

        public int Agregar(VideoGame nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into videoGames (name, Description,Requerimientos,Id_category,Id_developer,Price,Descuento,Destacado,Clasificacion_PIG,Launch_Date) output inserted.ID values ('" + nuevo.Name +"','" + nuevo.Description + "','"+nuevo.Requerimentos+"',"+ nuevo.Categoria.Id + ","+ nuevo.Developer.ID + ","+nuevo.Price+","+nuevo.Descuento+","+ helpers.BoolToInt(nuevo.Destacado) + ","+nuevo.ClasificaconPGI+",'"+ nuevo.LaunchDate.Year + "-" + nuevo.LaunchDate.Month + "-" + nuevo.LaunchDate.Day + "');");

                datos.setearParametros("@Id", nuevo.ID);
                datos.setearParametros("@Nombre", nuevo.Name);
                datos.setearParametros("@Descripcion", nuevo.Description);
                datos.setearParametros("@Requerimentos", nuevo.Requerimentos);
                datos.setearParametros("@Precio", nuevo.Price);
                datos.setearParametros("@Descuento", nuevo.Descuento);
                datos.setearParametros("@PDestacado", helpers.BoolToInt(nuevo.Destacado));
                datos.setearParametros("@Clasificacon_PGI", nuevo.ClasificaconPGI);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@IdDeveloper", nuevo.Developer.ID);
                datos.setearParametros("@LaunchDate", nuevo.LaunchDate.Year+"-"+nuevo.LaunchDate.Month+"-"+ nuevo.LaunchDate.Day);
                datos.EjecutarLectura();
                datos.Lector.Read();

                return (int)datos.Lector["ID"];

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
                datos.SetearConsulta("update videoGames set name='"+ Modificar.Name+"', Description='"+ Modificar.Description+"', Requerimientos='"+ Modificar.Requerimentos + "', Price=" + Modificar.Price+",Descuento="+Modificar.Descuento+", Destacado="+ helpers.BoolToInt(Modificar.Destacado)+", Clasificacion_PIG="+Modificar.ClasificaconPGI+ ", Id_category ="+ Modificar.Categoria.Id+ ", Id_developer="+ Modificar.Developer.ID + ", Launch_Date = '" + Modificar.LaunchDate.Year + "-" + Modificar.LaunchDate.Month + "-" + Modificar.LaunchDate.Day+"' where Id=" + Modificar.ID);
                datos.setearParametros("@Id", Modificar.ID);
                datos.setearParametros("@name", Modificar.Name);
                datos.setearParametros("@Description", Modificar.Description);
                datos.setearParametros("@Requerimientos", Modificar.Requerimentos);
                datos.setearParametros("@Price", Modificar.Price);
                datos.setearParametros("@Descuento", Modificar.Descuento);
                datos.setearParametros("@PDestacado", helpers.BoolToInt(Modificar.Destacado) );
                datos.setearParametros("@Clasificacon_PGI", Modificar.ClasificaconPGI);
                datos.setearParametros("@IdCategoria", Modificar.Categoria.Id);
                datos.setearParametros("@IdDeveloper", Modificar.Developer.ID);
                datos.setearParametros("@Launch_Date", Modificar.LaunchDate.Year + "-" + Modificar.LaunchDate.Month + "-" + Modificar.LaunchDate.Day);
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
        public void Eliminar(string Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Update videoGames SET Estado=0 where id=@Id");
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
                    Name = (string)datos.Lector["category_name"]
                };
                aux.Categoria.Id = (int)datos.Lector["Id_category"];
                aux.Categoria.Estado = (bool)datos.Lector["Estado"];

                aux.Developer = new Developers
                {
                    Name = (string)datos.Lector["developer_name"],
                };
                aux.Developer.ID = (int)datos.Lector["Id_developer"];
                aux.Developer.Estado = (bool)datos.Lector["Estado"];
                
                aux.Imagen = imagenNegocio.FindByFk(aux.ID);

                
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
