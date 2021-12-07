using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mod_Dominio;
using Conexion_BD;

namespace TPCuatrimestral_Cordoba_Zurita_Maldonado
{
    public partial class ContraseñaOlvidada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioNegocio userNeg = new UsuarioNegocio();
            EmailService emailService = new EmailService();
            string nombre, apellido, contraseña;

            user = userNeg.Loguear(txtEmail.Text);

            if (user != null)
            {
                nombre = user.Nombre;
                apellido = user.Apellido;
                contraseña = user.Contraseña;

                emailService.CorreoContraseña(txtEmail.Text, contraseña, nombre, apellido);
                emailService.enviaremail();
            }
        }
    }
}