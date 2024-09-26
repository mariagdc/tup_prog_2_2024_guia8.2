using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace guia8._1.Models
{
    public class Calendario
    {
        int CantidadFeriados { get; }
        ArrayList feriados = new ArrayList();
        public Feriado this[DateTime dia]
        {
            get
            {
                for (int i = 0; i < CantidadFeriados; i++)
                {

                    Feriado f = feriados[i] as Feriado;
                    if (f.Fecha.Year == dia.Year && f.Fecha.Month == dia.Month && f.Fecha.Day == dia.Day)
                    {
                        return f;
                    }
                    
                }
                return null;
            }
        }
        public Feriado AgregarFeriado(DateTime dia, string descrip)
        {
           Feriado f = new Feriado( dia, descrip);

            feriados.Add( f );
            return f;
        }




    }
}
