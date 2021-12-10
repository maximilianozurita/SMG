using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Dominio
{
    public class Venta
    {
        public int Id { get; set; }
        public int Id_user { get; set; }
        public DateTime FechaVenta { get; set; }
        public Usuario user { get; set; }
        public float Suma { get; set; }
    }
}
