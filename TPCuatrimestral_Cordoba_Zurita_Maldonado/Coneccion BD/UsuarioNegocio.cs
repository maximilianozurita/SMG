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
    }
}
