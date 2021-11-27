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
            Usuario user = new Usuario();
            UsuarioNegocio userNeg = new UsuarioNegocio();

            string usuario = Session["NombreUsuario"] != null ? Session["NombreUsuario"].ToString() : "";

            user = userNeg.Loguear(usuario);

            if (usuario != "")
            {
                txtNombre.Text = user.Nombre;
                txtApellido.Text = user.Apellido;
                txtCelular.Text = user.Celular;
                txtEmail.Text = user.Email;
                txtContraseña.Text = user.Contraseña;
            }
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

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnSI_Click(object sender, EventArgs e)
        {

        }

        protected void btnNO_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}