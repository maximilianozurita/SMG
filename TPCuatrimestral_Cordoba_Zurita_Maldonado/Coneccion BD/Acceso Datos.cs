using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Coneccion_BD
{
    public class Acceso_Datos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public Acceso_Datos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS;database= SMG; integrated security=true");
            comando = new SqlCommand();

        }
    }
}
