using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mod_Dominio;
using Negocio;

namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioNegocio userNeg = new UsuarioNegocio();

            try
            {
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellido.Text;
                user.Contraseña = txtContraseña.Text;
                user.Email = txtEmail.Text;
                user.Celular = txtCelular.Text;

                userNeg.Agregar(user);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}