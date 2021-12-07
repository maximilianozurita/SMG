using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Conexion_BD
{
    public class DevelopersNegocio
    {

        public List<Developers> Listar()
        {
            List<Developers> lista = new List<Developers>();
            AccesoDatos datos = new AccesoDatos();
            Developers aux = new Developers();
            try
            {
                datos.SetearConsulta("Select id, name, Information, Estado  from Developers;");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Developers Developer = new Developers();
                    Developer.ID = (int)datos.Lector["id"];
                    Developer.Name = (string)datos.Lector["name"];
                    Developer.Information = (string)datos.Lector["Information"];

                    lista.Add(Developer);
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
        public void Agregar(Developers nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into developers (name, Information, Estado) values ('" + nuevo.Name + "','" + nuevo.Information + "," + nuevo.Estado + "')");
                datos.setearParametros("@Id", nuevo.ID);
                datos.setearParametros("@Descripcion", nuevo.Name);
                datos.setearParametros("@Descripcion", nuevo.Information);
                datos.setearParametros("@Nombre", nuevo.Estado);
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
        public void Modificar(Developers Modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update developers set name=@Nombre, Information=@Information ,Estado=@Estado where Id=@Id");
                datos.setearParametros("@Id", Modificar.ID);
                datos.setearParametros("@Descripcion", Modificar.Name);
                datos.setearParametros("@Descripcion", Modificar.Information);
                datos.setearParametros("@Estado", Modificar.Estado);
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
        public void Eliminar(Developers Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Update developers SET Estado=0 where id=@Id;");
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
    }


}
