using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace guia8._1.Models
{
    public  class Calendario
    {
        int CantidadFeriados {get;}
       ArrayList  feriados = new ArrayList();
        //public Feriado this[DateTime dia]
        //{
        //    get
        //    {
        //        for (int n = 0; n < CantidadFeriados; n++)
        //        {
        //            if (dia != feriados[n].Fecha)
        //            {
        //                return (Feriado)feriados[n];
        //            }
        //        }
        //        return null;
        //    }
        //}
        public Feriado AgregarFeriado(DateTime dia, string descrip)
        {
            return null;
        }

        public Feriado this[DateTime dia] 
        
        {
            get
            { foreach(Feriado feriado in feriados)
                {
                    if(feriado.Fecha.Year==dia.Year && feriado.Fecha.Month == dia.Month && feriado.Fecha.Day == dia.Fecha)
                        {

                        return feriado;
                    }
                }return null;
            
            
            }
        }
    }
}
