using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia8._1.Models
{
    public class Feriado
    {

        string descripcion;
        DateTime fecha;
        public DateTime Fecha { get { return Fecha; } set { fecha = value; } }
        
        public string Descripcion { get { return Descripcion; } set { descripcion = value; } }
        
    
    
    public Feriado(DateTime fecha, string descripcion)
        {
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }


}
