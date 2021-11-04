using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce_videojuegos
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }


    }
}