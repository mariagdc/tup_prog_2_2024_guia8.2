using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia8._1.Models
{
    internal class Infractor
    {
       public int Dni {  get; set; }
       public string Nombre { get; set; }

        public Infractor (int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return ($"{Dni} --{Nombre}".ToString());
        }
    }
}
