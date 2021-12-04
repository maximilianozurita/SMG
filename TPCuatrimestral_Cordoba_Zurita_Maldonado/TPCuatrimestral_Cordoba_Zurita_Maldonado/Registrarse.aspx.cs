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
        private Usuario user = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioNegocio userNeg = new UsuarioNegocio();
            string usuario = Session["NombreUsuario"] != null ? Session["NombreUsuario"].ToString() : "";
            user = userNeg.Loguear(usuario);

            if (!IsPostBack)
            {
                if (usuario != "")
                {
                    txtNombre.Text = user.Nombre;
                    txtApellido.Text = user.Apellido;
                    txtCelular.Text = user.Celular;
                    txtNacimiento.Text = user.FechaNacimiento.ToString("yyyy-MM-dd");
                    txtEmail.Text = user.Email;
                    txtContraseña.Text = user.Contraseña;
                }
            } 
        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            UsuarioNegocio userNeg = new UsuarioNegocio();
            string usuario = Session["NombreUsuario"] != null ? Session["NombreUsuario"].ToString() : "";

            try
            {
                if (user == null)
                    user = new Usuario();

                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellido.Text;
                user.Celular = txtCelular.Text;
                user.FechaNacimiento = DateTime.Parse(txtNacimiento.Text);
                user.Contraseña = txtContraseña.Text;
                user.Email = txtEmail.Text;

                if (usuario == "")
                {
                    userNeg.Agregar(user);
                    LoginUsuario loginUsuario;
                    loginUsuario = new LoginUsuario(txtEmail.Text, txtContraseña.Text, true);
                    Session.Add("email",loginUsuario);
                    Session.Add("NombreUsuario", txtEmail.Text);
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    userNeg.ModificarUsuario(user);
                }

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

        protected void btnNO_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}