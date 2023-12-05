using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //int tractor = 60;
        //int recorrido = 250;

        //if (tractor < 50 && recorrido > 200 ) {
        //    Console.WriteLine(" las dos expresiones son verdaderas, tanquea el vehiculo");
        //}
        //else
        //{
        //    Console.WriteLine("las expresiones son falsas");
        //}
        //Console.ReadKey();


        //{
        //    bool lluvia = true;
        //    bool sol = true;

        //    if (lluvia == true || sol == false )
        //    {
        //        Console.WriteLine(" lleves sonbrilla");
        //    }
        //    else
        //    {
        //        Console.WriteLine("las expresiones son falsas");
        //    }
        //    Console.ReadKey();
        //}



        /* ------------------------- expresiones regulares &&
        int rangoInicio = 10;
        int rangoFin = 55;

        if (rangoInicio >= 10 && rangoFin <= 50)
        {
            Console.WriteLine("esta en el rango");
        }
        else
        {
            Console.WriteLine("no esta en el rango");
        }
        Console.ReadKey();
        */




        /* -------------------------- expresiones regulares IF ANIDADO
        int edad;
        bool permiso;
        string valor;

        Console.WriteLine("ingrese edad");
        valor = Console.ReadLine();
        edad = Convert.ToInt32(valor);


        if (edad >= 18)
        {
            Console.WriteLine("puede conducir");
        }
        else
        {
            Console.WriteLine("tiene permiso para conducir");
            valor = Console.ReadLine();
            permiso = Convert.ToBoolean(valor);
            if (edad > 15 && permiso == true)
            {
                Console.WriteLine("puede conducir");
            }
            else
            {
                Console.WriteLine("no puede conducir");
            }
        }
        Console.ReadKey(); 
        */




        /*--------------------//Estructura Switch OPERACIONES MATEMATICAS

        float a, b;
        float result = 0.0f;
        int option;

        Console.WriteLine("1. SUMA");
        Console.WriteLine("2. RESTA");
        Console.WriteLine("3. MULTI");
        Console.WriteLine("4. DIVI");
        Console.WriteLine("5. DIV RESUL");

        Console.WriteLine("escoge una opcion");
        option = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingresa un numero");
        a = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("ingresa un numero");
        b = Convert.ToSingle(Console.ReadLine());

        switch (option)
        {
            case 1:
                result = a + b; break;
            case 2:
                result = a - b; break;
            case 3:
                result = a * b; break;
            case 4:
                if(b != 0)
                {
                    result = a / b;
                }
                else
                {
                    Console.WriteLine("Divisor no es valido");
                }
                break;
            case 5:
                result = a % b; break; 

            default: Console.WriteLine("opcion erronea"); break;

        }
        Console.WriteLine("el resultado es: {0}",result);

        Console.ReadKey(); */





        /*----------------------------//--TRY CATCH usando 

        int n1, n2, result;
        try
        {
            Console.WriteLine("ingresa un numero");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingresa otro numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            result = n1 * n2;
            Console.WriteLine("el resultado es: {0}", result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        Console.ReadKey();
        */




        /*----------------- Ejemp CONJUNCION &&
        string boletos;
        int edad;

        Console.WriteLine("tienes boletos");
        boletos = Console.ReadLine();

        Console.WriteLine("ingresa la edad");
        edad = Convert.ToInt32(Console.ReadLine());

        if (boletos == "si" && edad >= 18)
        {
            Console.WriteLine(" ¡Bienvenido! Disfruta de la película.");
        }
        else
        {
            Console.WriteLine("Lo siento, no cumples los requisitos de acceso.");
        }


        Console.ReadKey();*/




        /*------------------ ejem DISYUNCION ||
        string comprasAntes;
        string cliente;

        Console.WriteLine("Es cliente nuevo");
        cliente = Console.ReadLine();

        Console.WriteLine("Ha compradon antes");
        comprasAntes = Console.ReadLine();

        if (cliente == "si" || comprasAntes == "si")
        {
            Console.WriteLine("Usted es elegible para un descuento en su compra..");
        }
        else
        {
            Console.WriteLine("No hay descuento disponible para esta compra.");
        }

        Console.ReadKey(); */


        /*----------------------------- Ejer Conjuncion &&
        float calificacion = 10;
        int diasAsistidos = 2;

        if (calificacion > 70 && diasAsistidos > 20)
        {
            if (calificacion < 100 && diasAsistidos < 30)
            {
                Console.WriteLine(" ¡Has aprobado el curso!");
            }
            else
            {
                Console.WriteLine("Ingresaste puntaje: (puntaje ingresado) y asistencia: (asistencia ingresada).");
            }

        }
        else
        {
            Console.WriteLine(" ¡Has reprobado el curso!");

           
        }


        Console.ReadKey();*/





        Console.WriteLine("0. Su factura es mayor de 100");
        Console.WriteLine("1. Si es cliente VIP");

        Console.WriteLine("Escoge una opción");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 0 || option == 1)
        {
            Console.WriteLine("Ingreso a la zona de clientes especiales");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }


    }


}
