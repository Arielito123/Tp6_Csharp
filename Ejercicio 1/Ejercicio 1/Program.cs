using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que permita a un usuario cargar datos a una matriz de enteros, 
cuadrada, de 4 x 4 e informarla indicando filas y columnas.*/

            int[,] Entero = new int[4, 4];
            int F, C;

            Console.WriteLine("Cargar datos a la Matrix de 4*4");
          
            for (F = 0; F < 4; F++) 
            {
                for (C = 0; C < 4; C++) 
                {
                    Entero[F, C] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine(" Datos De Filas Y columnas de la matrix");

            for (F = 0; F < 4; F++) 
            {
                for (C = 0; C < 4; C++) 
                {
                    Console.Write(Entero[F, C]+"  ");
                    
                }
                
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        
    }
}
