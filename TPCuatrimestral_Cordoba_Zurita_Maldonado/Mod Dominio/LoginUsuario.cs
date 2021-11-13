using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Dominio
{
    public enum TipoUsuario
    {
        Normal = 0,
        Admin = 1
    }
    public class LoginUsuario
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public LoginUsuario(string email, string pass, bool admin)
        {
            Email = email;
            Pass = pass;
            TipoUsuario = admin ? TipoUsuario.Normal : TipoUsuario.Admin;
        }
    }
}
