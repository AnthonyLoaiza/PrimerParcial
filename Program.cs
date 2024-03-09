using System;
using System.Threading;

namespace PrimerParcial
{
    public class Program
    {
        static void Main(string[] args)
        {

            double vTrenA = 80; //este sale a alas 10 80km/h
            double vTrenB = 100; // este sale a las 11 100km/h

            Console.WriteLine("El primer tren salio de la estacion a las 10:00 am");
            Console.WriteLine();

            Thread.Sleep(1000);

            Console.WriteLine("El segundo tren salio de la estacion a las 11:00 am");
            Console.WriteLine();

            double velocidadRelativa = vTrenB - vTrenA;
            double tiempoParaAlcanzarlo = vTrenA / velocidadRelativa;

            Console.WriteLine($"El segundo tren alcanza el primero a las {tiempoParaAlcanzarlo} Horas de haber salido de la estacion \n  a las 3:00 PM ");

        }
    }
    
}
