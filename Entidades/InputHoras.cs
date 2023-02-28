using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraHorasLaborales.Entidades
{
    public class InputHoras
    {
        TimeSpan Hora { get; set; }

        public TimeSpan ComprobarConvertir(string s1, string s2)
        {
            bool intento = false;
            int h = 0;
            int m = 0;
            while (!intento)
            {
                if (!(int.TryParse(s1, out h) && int.TryParse(s2, out m)))
                {
                    Console.WriteLine("Introduzca valores válidos (numeros).");
                }
                else if (h < 0 || h > 23 || m < 0 || m > 59)
                {
                    System.Console.WriteLine("Introduzca valores válidos (Hora [0 - 23], Minutos [0 - 59])");
                }
                else
                {
                    intento = true;
                }
            }

            return new TimeSpan(h, m, 0);
        }

        public TimeSpan Operacion(TimeSpan ts1, TimeSpan ts2)
        {
            Hora = ts2 - ts1;
            return Hora;
        }
    }
}