using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randon = new Random(); //generacion de metodo ramdon

            string[,] Provincias = new string[,] { { "BUENOS AIRES", "LA PLATA" }, { "CATAMARCA", "SAN FERNANDO DEL VALLE DE CATAMARCA" }, { "TUCUMAN", "SAN MIGUEL DE TUCUMAN" }, { "SALTA", "SALTA" }, { "CHACO", "RESISTENCIA" }, { "CHUBUT", "RAWSON" }, { "CORDOBA", "CORDOBA" }, { "CORRIENTES", "CORRIENTES" }, { "ENTRE RIOS", "PARANA" }, { "FORMOSA", "FORMOSA" }, { "JUJUY", "SAN SALVADOR DE JUJUY" }, { "LA RIOJA", "LA RIOJA" }, { "MENDOZA", "MENDOZA" }, { "MISIONES", "POSADAS" }, { "NEUQUEN", "NEUQUEN" }, { "RIO NEGRO", "VIEDMA" }, { "SAN JUAN", "SAN JUAN" }, { "SAN LUIS", "SAN LUIS" }, { "SANTA CRUZ", "RIO GALLEGOS" }, { "SANTA FE", "SANTA FE DE LA VERA CRUZ" }, { "SANTIAGO DEL ESTERO", "SANTIAGO DEL ESTERO" }, { "TIERRA DEL FUEGO", "USHUAIA" }, { "LA PAMPA", "SANTA ROSA" } };
            
            //{ { "BUENOS AIRES", "LA PAMPA", "CHUBUT", "NEUQUEN", "RIO NEGRO", "SANTA CRUZ", "TIERRA DEL FUEGO", "LA RIOJA", "SAN JUAN", "SAN LUIS", "MENDOZA", "CATAMARCA", "TUCUMAN", "SALTA", "JUJUY", "CORRIENTES", "FORMOSA", "CHACO", "ENTRE RIOS", "MISIONES", "SANTIAGO DEL ESTERO", "CORDOBA", "SANTA FE" }, { "LA PLATA", "SANTA ROSA", "RAWSON", "NEUQUEN", "VIEDMA", "RIO GALLEGOS", "USHUAIA", "LA RIOJA", "SAN JUAN", "SAN LUIS", "MENDOZA", "SAN FERNANDO DEL VALLE DE CATAMARCA", "SAN MIGUEL DE TUCUMAN", "SALTA", "RESISTENCIA", "SAN SALVADOR DE JUJUY", "CORRIENTES", "FORMOSA", "PARANA", "POSADAS", "SANTIAGO DEL ESTERO", "CORDOBA", "SANTA FE DE LA VERA CRUZ" } };
            string respuesta;
             
            //int[] aleatorioc = new int[2];
            int f, c, cuentaerror = 0, suma = 5, Puntuacion = 0, MENU = 0;
            char SEGUIR;
            Console.WriteLine("BIENVENIDO AL JUEGO DE PROVINCIAS Y CAPITALES");
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Console.WriteLine("MENÚ DE OPCIONES");
            Console.WriteLine("1----------JUGAR");
            Console.WriteLine("2----------SALIR");
            MENU = int.Parse(Console.ReadLine());
            switch (MENU)
            {
                case 1:
                    {
                        for (f = 0; f < 22; f++)
                        {
                            for (c = 0; c < 2; c++)
                            {
                               
                                while (cuentaerror < 3)
                                {

                                   
                                    //aleatorioc[c] = randon.Next(Provincias.Length);


                                    int t = randon.Next(0,22);
                                    //int e = randon.Next(Provincias.Length);
                                    Console.WriteLine("Escriba La Capital  de " + Provincias[t,0]);
                                    c++;
                                    respuesta = Console.ReadLine();
                                    respuesta = respuesta.ToUpperInvariant();


                                    if (respuesta == Provincias[t,1])
                                    {
                                        Puntuacion = suma + Puntuacion;
                                        Console.Write("Respuesta correcta, sumaste 5 puntos.");
                                        Console.WriteLine("Tu puntaje acumulado es: " + Puntuacion);
                                    }
                                    else
                                    {
                                        cuentaerror++;
                                        Console.WriteLine("RESPUESTA INCORRECTA");

                                    }
                                  
                                }//CIERRO EL WHILE DE CONTADOR DE ERORRES
                                Console.WriteLine("Perdiste el juego, TE HAS QUEDADO SIN VIDAS.");
                                Console.ReadKey();
                                Console.WriteLine("¿QUIERE VOLVER A JUGAR? INGRESE [S] PARA SI, [N] PARA NO:");
                                SEGUIR = char.Parse(Console.ReadLine());
                                SEGUIR = char.ToUpper(SEGUIR);

                            }//CIERRO EL FOR DE C


                        }//CIERRO EL FOR DE F
                        break;
                    }//CIERRO CASO 1
                case 2:
                    { break; }
            }//CIERRO SWITCH
            Console.WriteLine("¿QUIERE VOLVER A JUGAR? INGRESE [S] PARA SI, [N] PARA NO:");
            SEGUIR = char.Parse(Console.ReadLine());
            SEGUIR = char.ToUpper(SEGUIR);
            while (SEGUIR !='S' || SEGUIR !='N')
            {
                Console.WriteLine(" INGRESE [S] PARA SI, [N] PARA NO:");
                SEGUIR = char.Parse(Console.ReadLine());
                SEGUIR = char.ToUpper(SEGUIR);
                
            }
            while (SEGUIR == 'S')
            {
                cuentaerror = 0;
                {
                    for (f = 0; f < 23; f++)
                    {
                        for (c = 0; c < 2; c++)
                        {
                            int Aleatorio = randon.Next(Provincias.Length);
                            while (cuentaerror < 3)
                            {

                               
                                //int aleatoriof[f, c] = randon.Next(Provincias.Length);
                                //aleatorioc[c] = randon.Next(Provincias.Length);


                                Console.WriteLine("Escriba La Capital  de " + Provincias[f, Aleatorio]);
                                c++;
                                respuesta = Console.ReadLine();
                                respuesta = respuesta.ToUpperInvariant();


                                if (respuesta == Provincias[c, f])
                                {
                                    Puntuacion = suma + Puntuacion;
                                    Console.Write("Respuesta correcta, sumaste 5 puntos.");
                                    Console.WriteLine("Tu puntaje acumulado es: " + Puntuacion);
                                }
                                else
                                {
                                    cuentaerror++;
                                    Console.WriteLine("RESPUESTA INCORRECTA");

                                }
                                
                            }//CIERRO EL WHILE DE CONTADOR DE ERORRES
                            Console.WriteLine("Perdiste el juego, TE HAS QUEDADO SIN VIDAS.");

                        }//CIERRO EL FOR DE C


                    }//CIERRO EL FOR DE F

                }
                Console.WriteLine("¿QUIERE VOLVER A JUGAR? INGRESE [S] PARA SI, [N] PARA NO:");


                Console.ReadKey();
        }
    }

 }
}