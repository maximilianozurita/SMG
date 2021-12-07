using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod_Dominio;

namespace Conexion_BD
{
    public class LoginUsuarioNegocio
    {
        public bool Loguear(LoginUsuario loginUsuario)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT id, isAdmin FROM users where email = @email AND password = @password");
                datos.setearParametros("@email", loginUsuario.Email);
                datos.setearParametros("@password", loginUsuario.Pass);

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    loginUsuario.ID = (int)datos.Lector["id"];
                    loginUsuario.TipoUsuario = (bool)datos.Lector["IsAdmin"] == false ? TipoUsuario.Normal : TipoUsuario.Admin;
                    return true;
                }
                return false;
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
