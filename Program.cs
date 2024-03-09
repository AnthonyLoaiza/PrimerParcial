using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PrimerParcial
{
    public class Program
    {
        static void Main(string[] args)
        {

            var ventasList = new List<double>();
            var comisionList = new List<double>();

            double v1, v2, v3,c1,c2,c3;
            var sueldoBase = 2000000;

            Console.WriteLine("Valor de venta numero 1");
            v1 = Convert.ToDouble(Console.ReadLine());
            ventasList.Add(v1); comisionList.Add(v1 * 0.10);

            Console.WriteLine("Valor de venta numero 2");
            v2 = Convert.ToDouble(Console.ReadLine());
            ventasList.Add(v2); comisionList.Add(v2 * 0.10);

            Console.WriteLine("Valor de venta numero 3");
            v3 = Convert.ToDouble(Console.ReadLine());
            ventasList.Add(v3); comisionList.Add(v3 * 0.10);
            Console.WriteLine();

            Console.WriteLine("la venta que le genero mas comision fue la del valor: " + ventasList.Max());
            Console.WriteLine();

            Thread.Sleep(1000);

            Console.WriteLine("El promedio de comisiones por cada venta fue de:  " + comisionList.Average());
            Console.WriteLine();

            Thread.Sleep(1000);

            Console.WriteLine("Gracias a tus 3 ventas recibiras una comision de: " + comisionList.Sum());
            Console.WriteLine();

            Thread.Sleep(1000);

            Console.WriteLine($"En total su sueldo Base mas Comisiones sera de : {sueldoBase + comisionList.Sum()}");
            Console.WriteLine();

            Thread.Sleep(1000);

            Thread.Sleep(1000);

            if (ventasList.Sum() > 1000000)
            {
                Console.WriteLine("te ganaste un bono de 100 lucas");
            }
            else
            {
                Console.WriteLine("el otro mes será. sigue intentando");
            }
        }
    }
}
