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
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public string Description { get; set; }
        public string Requerimentos { get; set; }
        public Categoria Categoria { get; set; }
        public Developers Developer { get; set; }
        public float Price { get; set; }
        public List <Imagen> Imagen { get; set; }
        public float Descuento { get; set; }
        public bool Destacado { get; set; }
        public int ClasificaconPGI { get; set; }
        public DateTime LaunchDate { get; set; }
        public string LinkVideo { get; set; }
        public bool Estado { get; set; }

    }
}
