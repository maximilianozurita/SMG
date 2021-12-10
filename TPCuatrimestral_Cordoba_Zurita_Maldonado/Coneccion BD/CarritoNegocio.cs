using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;
namespace Conexion_BD
{
    public class CarritoNegocio
    {
        public void Agregar(Carrito nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into Carrito (Id_user,Id_Product, Price) values ('" + nuevo.IdUsuario + "','" + nuevo.IdProducto + "','" + nuevo.Precio + "')");
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

        public List<Carrito> ListarCarrito(int IdUser)
        {
            List<Carrito> ListaCarrito = new List<Carrito>();
            AccesoDatos datos = new AccesoDatos();
            Carrito carri = new Carrito();

            try
            {
                datos.SetearConsulta("select Id, Id_user, Id_Product,Price, Id_venta from carrito where Id_user=" + IdUser + " and Id_venta is null");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    carri = Asignacion(datos);

                    ListaCarrito.Add(carri);
                }

                return ListaCarrito;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Carrito> DetalleDeArticulosVendidos(int IdVenta)
        {
            List<Carrito> ListaCarrito = new List<Carrito>();
            AccesoDatos datos = new AccesoDatos();
            Carrito carri = new Carrito();

            try
            {
                datos.SetearConsulta("select Id, Id_user, Id_Product,Price, Id_venta from carrito where Id_venta=" + IdVenta + " and Id_venta is not null");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    carri = Asignacion(datos);
                    ListaCarrito.Add(carri);
                }
                return ListaCarrito;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Carrito Asignacion(AccesoDatos datos)
        {
            try
            {
                Carrito aux = new Carrito();
                aux.ID = (int)datos.Lector["Id"];
                aux.IdProducto = (int)datos.Lector["Id_Product"];
                aux.IdUsuario = (int)datos.Lector["Id_user"];
                aux.Precio = (float)(decimal)datos.Lector["Price"];


                if (!(datos.Lector["Id_venta"] is DBNull))
                {
                    aux.IdVenta = (int)datos.Lector["Id_venta"];
                }


                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarProducto(int IdCarrito)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("DELETE FROM carrito WHERE Id="+IdCarrito+" and Id_venta is null");
                datos.setearParametros("@Id", IdCarrito);
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

        public void Modificar(int IdVenta, int IdUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update carrito set Id_venta="+IdVenta+" where Id_user="+IdUsuario+" and Id_venta is null");
                //datos.setearParametros("@IdVenta", IdVenta);
                //datos.setearParametros("@IdUsuario", IdUsuario);
                
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


