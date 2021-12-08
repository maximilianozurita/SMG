using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Dominio
{
    public class Carrito
    {
        public int ID { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public float Precio { get; set; }
        public int IdVenta { get; set; }
    }
}
