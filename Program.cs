using System;
using static System.Console;
using CalculadoraHorasLaborales.Entidades;

namespace CalculadoraHorasLaborales
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHoras inputHoras = new InputHoras();
            Console.WriteLine("Introduzca la hora inicial");
            Console.WriteLine("Hora: ");
            string h = Console.ReadLine();
            Console.WriteLine("Minutos: ");
            string m = Console.ReadLine();
            TimeSpan hora1 = inputHoras.ComprobarConvertir(h, m);

            Console.WriteLine("Introduzca la hora final");
            Console.WriteLine("Hora: ");
            h = Console.ReadLine();
            Console.WriteLine("Minutos: ");
            m = Console.ReadLine();
            TimeSpan hora2 = inputHoras.ComprobarConvertir(h, m);

            TimeSpan resultado = inputHoras.Operacion(hora1, hora2);

            Console.WriteLine($"El total de horas trabajadas es {resultado.ToString()}");
        }
    }
}