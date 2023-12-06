namespace EstructuraLogica
    
{
using System.Threading;
internal class Program
    {
        static void Main(string[] args)
        {

            /*------- funcion del FOR
            // for
            int n;
            int contador = 0;
            int acumulador = 0;
            Console.WriteLine("antes del ciclo");

            for (n = 1; n <= 12; n++) 
            {
                contador = contador + 1;
                acumulador = acumulador + contador;
                Console.WriteLine("{0},{1}", contador, acumulador);
            }
            Console.ReadKey(); */



            /*-------------------------------//ciclo for notas de estudiantes
            int n, cantidad;
            float calif;
            float suma = 0.0f;
            float promedio = 0.0f;

            Console.WriteLine("cantidad de alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (n = 1; n <= cantidad; n++)
            {
                Console.WriteLine("calificaciones de alumnos");
                calif = Convert.ToInt32(Console.ReadLine());

                suma += calif;
            }
            promedio = suma / cantidad;
            Console.WriteLine("promedio de calificacion de los alumnos {0}", promedio);*/




            /*-------------------------------//ciclo for calculando el FACTORIAL
            int n, numero;
            int factor = 1;


            Console.WriteLine("Ingrese nuemero a calcular factor");

             numero = Convert.ToInt32(Console.ReadLine());
            for(n = numero; n >= 1; n--) {
                factor *= n;            
            }
            Console.WriteLine("el factorial es {0} es {1}", numero, factor); */


            /*-----------------------------// estructura de FOREACH
            string name = "academy";

            foreach (char letra in name) {
                
                Console.Write(" {0}", letra);
            }
            Console.ReadKey();*/


            /*---------------- ciclo While  probando la temperatura
            int temperatura;

            Console.WriteLine("ingrese temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());

            while (temperatura > 20) {
                temperatura--;
                Console.WriteLine("la temperatura {0}", temperatura);
            }

            Console.WriteLine("la temperatura final {0}", temperatura);
            Console.ReadKey();*/




            /*----------------------------- cliclo DO WHILE
            float pies, pulgadas, centimetros;
            string respuesta;
            do
            {
                Console.WriteLine("Ingrese de pies");
                pies = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese las pulgada");
                pulgadas = Convert.ToSingle(Console.ReadLine());

                centimetros = ((pies * 12) + pulgadas) * 2.54f;
                Console.WriteLine("son {0} centimetros", centimetros);

                Console.WriteLine("Deseas hacer otra conversion");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");

            Console.ReadKey();
            */



            /*----------------- for anidado con BREAK 
            int id;

            for (id = 1; id <= 20; id++) {
                Thread.Sleep(500);
                Console.WriteLine(id);
                if(id == 9) {
                    break;
                }

            }
            Console.ReadKey();*/




            /*----------------- for anidado con CONTINUE 
            for (int id = 1; id <= 20; id++)
            {
                Thread.Sleep(500);
                Console.WriteLine(id);
                if (id == 9)
                {
                    Console.WriteLine("");
                    continue;
                }

            }
            Console.ReadKey();*/



            /*------------- // for anidado utilizando Continue and GOTO 
             for (int id = 1; id <= 20; id++)
             {
                 Thread.Sleep(500);

                 if (id == 9)
                 {
                     Console.WriteLine("");

                     if (id == 9)
                     {
                         continue;
                     }

                     goto retirados;
                 }
                 Console.WriteLine(id);

             }
             retirados:
             Console.WriteLine("el afiliado 9 se retiro");
             Console.ReadKey();*/

            float a, b, resul = 0;
            int option;

            do
            {
                Console.WriteLine("1. suma");
                Console.WriteLine("2. resta");
                Console.WriteLine("3. multiplicación");
                Console.WriteLine("4. división");
                Console.WriteLine("5. salir");

                Console.WriteLine("Elige una opción");
                option = Convert.ToInt32(Console.ReadLine());

                if (option >= 1 && option <= 4)
                {
                    Console.WriteLine("Ingresa el primer número:");
                    a = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Ingresa el segundo número:");
                    b = Convert.ToSingle(Console.ReadLine());
                }
                else if (option == 5)
                {
                    break; // Salir del bucle si la opción es 5
                }
                else
                {
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    continue; // Volver al inicio del bucle si la opción no es válida
                }

                switch (option)
                {
                    case 1:
                        resul = a + b;
                        break;
                    case 2:
                        resul = a - b;
                        break;
                    case 3:
                        resul = a * b;
                        break;
                    case 4:
                        if (b != 0)
                        {
                            resul = a / b;
                        }
                        else
                        {
                            Console.WriteLine("La división por cero no está permitida.");
                            continue; // Volver al inicio del bucle si hay división por cero
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("El resultado es: " + resul);

            } while (option != 5);



        }
    }
}