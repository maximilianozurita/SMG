using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            Usuario aux = new Usuario();
            try
            {
                datos.SetearConsulta("Select id, name, lastname, email, cell, Fecha_nacimiento, Estado from users");
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
        public Usuario Asignacion(AccesoDatos datos)
        {

            Usuario aux = new Usuario();

            try
            {
                aux.ID = (int)datos.Lector["Id"];
                aux.Nombre = (string)datos.Lector["name"];
                aux.Apellido = (string)datos.Lector["lastname"];
                aux.Email = (string)datos.Lector["email"];
                aux.Celular = (string)datos.Lector["cell"];
                if(!(datos.Lector["Fecha_nacimiento"] is DBNull))
                aux.FechaNacimiento = (DateTime)datos.Lector["Fecha_nacimiento"];
                
                aux.Estado = (bool)datos.Lector["Estado"];
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Agregar(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into Users (name, lastName, email, password, cell) values ('" + nuevo.Nombre + "','" + nuevo.Apellido + "','" + nuevo.Email + "','" + nuevo.Contraseña + "','" + nuevo.Celular + "')");
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

        public Usuario Loguear(string nombreUsuario)
        {
            Usuario user = new Usuario();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT id, name, lastName, cell, email, password FROM users where email = @email");
                datos.setearParametros("@email", nombreUsuario);

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    user.ID = (int)datos.Lector["id"];
                    user.Nombre = (string)datos.Lector["name"];
                    user.Apellido = (string)datos.Lector["lastName"];
                    user.Celular = (string)datos.Lector["cell"];
                    user.Email = (string)datos.Lector["email"];
                    user.Contraseña = (string)datos.Lector["password"];

                    return user;
                }
                return null;
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
