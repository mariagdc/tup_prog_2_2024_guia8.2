using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia8._1.Models
{
    internal class Cuota
    {

        public int Numero {  get; private set; }
        public double Monto { get; set; }
        public double PorcenVoluntario { get; set; }
        public double MontoVoluntario { get; private set; }
        public DateTime PrimerVencimiento { get; set; }
        public double MontoPrimerVenc {  get; private set; }
        public DateTime SegundoVencimiento { get; set; }
        public double MontoSegVencimiento { get; private set; }
        public double PorcenSegundoVencimiento  { get; set; }
        public double SobrecarfoMontoSegVencimiento { get;private set; }
    
        public double MontoSegundoVencimientoConSobre {  get; private set; }
    
      public Cuota()
        {

        }
    
    
    
    
    }



}
