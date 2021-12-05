using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Dominio
{
    public class Carrito
    {
        public int IdUsuario { get; set; }
        public VideoGame id_producto { get; set; }
        public Venta Id_venta { get; set; }

    }
}
