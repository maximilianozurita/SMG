using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Dominio
{
    public class VideoGame
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Requerimentos { get; set; }
        public Categoria Categoria { get; set; }
        public Developers Developer { get; set; }
        public float Precio { get; set; }
      
        public float Descuento { get; set; }
        public bool Destacado { get; set; }
        public int Clasificacon_PGI { get; set; }
        public DateTime LaunchDate { get; set; }
        public bool Estado { get; set; }

    }
}
