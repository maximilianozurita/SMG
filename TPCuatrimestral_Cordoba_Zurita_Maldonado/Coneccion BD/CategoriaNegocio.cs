using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Conexion_BD
{
    public class CategoriaNegocio
    {

       public List<Categoria> Listar()
       {
           List<Categoria> lista = new List<Categoria>();
           AccesoDatos datos = new AccesoDatos();
           Categoria aux = new Categoria();
           try
           {
               datos.SetearConsulta("Select id, name, Estado  from categories;");
               datos.EjecutarLectura();
               while (datos.Lector.Read())
               {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)datos.Lector["id"];
                    categoria.Name = (string)datos.Lector["name"];

                    lista.Add(categoria);
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
       public void Agregar(Categoria nuevo)
       {
           AccesoDatos datos = new AccesoDatos();

           try
           {
               datos.SetearConsulta("insert into Categorias (name, Estado) values ('" + nuevo.Name + "','" + nuevo.Estado + "')");
               datos.setearParametros("@Id", nuevo.Id);
               datos.setearParametros("@Descripcion", nuevo.Name);
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
       public void Modificar(Categoria Modificar)
       {
           AccesoDatos datos = new AccesoDatos();
           try
           {
               datos.SetearConsulta("update Categoria set name=@Nombre, Estado=@Estado where Id=@Id");
               datos.setearParametros("@Id", Modificar.Id);
               datos.setearParametros("@Descripcion", Modificar.Name);
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
       public void Eliminar(Categoria Eliminar)
       {
           AccesoDatos datos = new AccesoDatos();

           try
           {
               datos.SetearConsulta("Update developers SET Estado=0 where id=@Id;");
               datos.setearParametros("@Id", Eliminar.Id);
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
