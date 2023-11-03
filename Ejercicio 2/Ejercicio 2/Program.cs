using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] Reales = new float[2, 4];
            int F, C;
            float NumMenor = 99999, NumMayor = 0, PosFMayor=0, PosCMayor = 0,PosFMenor=0,PosCMenor=0;

            for (F = 0; F < 2; F++) 
            {
                for (C = 0; C < 4; C++) 
                {
                    Console.WriteLine("Ingrese un Numero a la fila n° "+(F+1)+" "+" y Ingrese un numero a la columna n° "+(C+1));
                    Reales[F,C]=float.Parse(Console.ReadLine());

                    if (Reales[F, C]< NumMenor) 
                    {
                        NumMenor = Reales[F, C];
                        PosFMenor = (F + 1);
                        PosCMenor = (C + 1);
                    }

                    if (Reales[F, C]>NumMayor)
                    {
                        NumMayor = Reales[F, C];
                        PosFMayor = (F + 1);
                        PosCMayor = (C + 1);
                    }

                }

                
            }

            Console.WriteLine("El Numero menor de la matrix es: "+NumMenor+" "+"Y Su posicion en la fila es "+PosFMenor+" "+" y en la columna es"+" "+PosCMenor);
            Console.WriteLine("El Numero Mayor de la matrix es: " + NumMayor + " " + "Y Su posicion en la fila es " + PosFMayor + " " + " y en la columna es" + " " + PosCMayor);
            Console.ReadKey();


        }
    }
}
