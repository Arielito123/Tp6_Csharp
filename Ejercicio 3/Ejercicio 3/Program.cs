using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cargar una matriz de enteros de 5 x 5 y generar las salidas que se muestran a 
continuación con los datos que se encuentran en las posiciones indicadas.*/


            int[,] Entero = new int[5, 5];
            int F,C;

            for (F = 0; F < 5; F++) 
            {
                for (C = 0; C < 5; C++) 
                {
                    Console.WriteLine("Carga de matrix fila n° "+(F+1)+" columna "+(C+1));
                    Entero[F, C] = int.Parse(Console.ReadLine());

                   }
            }

            for (F = 0; F < 5; F++) 
            {
                for (C = 0; C < 5; C++)
                {
                    if (F == C) 
                    {
                        Console.Write(Entero[F, C]);
                    }
                }
                Console.Write("\n");
            }

            Console.WriteLine("Caso 2");
            
            Console.ReadKey();
        }
    }
}
