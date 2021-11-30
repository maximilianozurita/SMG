using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Dominio
{
    public class Imagen
    {
        public int ID { get; set; }
        public string urlImagen { get; set; }
        public int idVdeoJuego { get; set; }

        public bool Estado { get; set; }
    }
}
