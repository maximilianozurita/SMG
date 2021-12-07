using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;
namespace Conexion_BD
{
    //public class CarritoNegocio
    //{
    //    public int Agregar(VideoGame nuevo)
    //    {
    //        AccesoDatos datos = new AccesoDatos();

            //try
            //{
                //datos.SetearConsulta("insert into Carrito (idUsuario,idProducto,idventas) output inserted.ID values ('" + nuevo.Name + "','" + nuevo.Description + "','" + nuevo.Requerimentos + "'," + nuevo.Categoria.Id + "," + nuevo.Developer.ID + "," + nuevo.Price + "," + nuevo.Descuento + "," + BoolToInt(nuevo.Destacado) + "," + nuevo.ClasificaconPGI + ",'" + nuevo.LaunchDate.Year + "-" + nuevo.LaunchDate.Month + "-" + nuevo.LaunchDate.Day + "');");

                //datos.setearParametros("@Id", nuevo.ID);
                //datos.setearParametros("@Nombre", nuevo.Name);
                //datos.setearParametros("@Descripcion", nuevo.Description);
                //datos.setearParametros("@Requerimentos", nuevo.Requerimentos);
                //datos.setearParametros("@Precio", nuevo.Price);
                //datos.setearParametros("@Descuento", nuevo.Descuento);
                ////datos.setearParametros("@PDestacado", BoolToInt(nuevo.Destacado));
                //datos.setearParametros("@Clasificacon_PGI", nuevo.ClasificaconPGI);
                //datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                //datos.setearParametros("@IdDeveloper", nuevo.Developer.ID);
                //datos.setearParametros("@LaunchDate", nuevo.LaunchDate.Year + "-" + nuevo.LaunchDate.Month + "-" + nuevo.LaunchDate.Day);
                //datos.EjecutarLectura();
                //datos.Lector.Read();

    //            return (int)datos.Lector["ID"];

    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //        finally
    //        {
    //            datos.CerrarConexion();
    //        }
    //    }
    //}
}


