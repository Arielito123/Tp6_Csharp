using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cargar un vector de string con 5 palabras. Generar el vector longitud con la cantidad de
letras de cada palabra ingresada.*/

            string[] Palabra = new string[5];//cargamos las variables de tipo string 
            int[] longintud=new int [5];
          
            for (int i = 0; i < 5; i++)//ciclo de repeticion 
            {
                Console.WriteLine("Cargue la palabra "+(i+1)+" "+"Vector");
                Palabra[i] =Console.ReadLine();//guardamos la carga del vector parceamos
                longintud[i] = Palabra[i].Length;//decimos que longitud tome la cantidad de letras que tiene la palabra del vector
                
            }

            for(int i=0;i<5;i++) 
            {
                
                Console.WriteLine();
                Console.WriteLine("Palabra Ingresadas en el vector"+" "+(i+1)+ " "+Palabra[i]+" "+"Cantidad De Letras" + " " + longintud[i]);//Mostramos la cantidad de letras que tienen las palabras
            }

            Console.ReadKey();

        }
    }
}
