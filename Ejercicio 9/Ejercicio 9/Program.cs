using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9. Programar una aplicación a modo de juego donde el usuario visualice una provincia 
argentina de la cual tendrá que ingresar su capital. Al ingresar mal la respuesta 3 veces 
ya sea en forma consecutiva o alternada el jugador pierde. Suma 5 puntos (los cuales
deberán visualizarse por pantalla) por cada respuesta correcta. Gana el participante que 
mayor puntaje logre.*/


            string[] Provincias = new string[23] { "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego, Antártida e Islas del Atlántico Sur", "Tucumán" };
            string[] Capitales = new string[23] { "La Plata", "Catamarca", "Resistencia", "Rawson", "Córdoba", "Corrientes", "Paraná", "Formosa", "San Salvador de Jujuy", "Santa Rosa", "La Rioja", "Mendoza", "Posadas", "Neuquén", "Viedma", "Salta", "San Juan", "San Luis", "Río Gallegos", "Santa Fe", "Santiago del Estero", "Ushuaia", "	San Miguel de Tucumán" };
            string[] BuscaCapital = new string[23];
            bool GameOverPerro = false;
            int Puntuacion=0,cont=0,suma=5;

            for (int i = 0; i <23; i++) 
            {
                Console.WriteLine("Escriba La Capital  de: "+Provincias[i]);
                BuscaCapital[i] = Console.ReadLine();

                if (BuscaCapital[i] == Capitales[i])
                {

                    GameOverPerro = false;
                    Puntuacion = suma + Puntuacion;





                }
                else 
                {
                    cont++;
                }

                Console.WriteLine("Total De Puntos Acumulados Por Respuesta Correcta "+ Puntuacion);
            }

            if (GameOverPerro == true) 
            {
                if (cont > 3) 
                {
                    Console.WriteLine("Perdiste el juego");
                }
            }

            Console.ReadKey();
        }
    }
}
