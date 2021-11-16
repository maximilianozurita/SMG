using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_Dominio
{
   public class Developers
    {
        public int  ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public string Information { get; set; }

        public bool  Estado { get; set; }

    }
}
