//Se desean ingresar 5 mediciones de
//temperaturas registradas a lo largo de un día
//Calcular el promedio de las mismas y luego
//informar cuáles fueron las temperaturas
//registradas que superaron el promedio.

using System;

namespace integrador1Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatura = new double[] { 10.3, 12, 14.2, 18, 9.5 };
            double promedio = 0;
            double total = 0;

            for (int i = 0; i < 5; i++)
            {
                total += temperatura[i];
                Console.WriteLine("La temperatura número " + (i+1) + " fue de: " + temperatura[i]);
            }

            promedio = total / 5;
            Console.WriteLine("La temperatura promedio fue: " + promedio);
            for (int i = 0; i < 5; i++)
            {
                if (temperatura[i] > promedio)
                {
                    Console.WriteLine("Temperatura mayor al promedio: " + temperatura[i]);
                }
            }
        }

    }
}
