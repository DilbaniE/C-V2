using System.Text;

namespace Structura
{
    internal class Program
    {
        public struct Direccion
        {
            public String calle;
            public int numero;

            public Direccion(String pCalle, int pNumero)
            {
                calle = pCalle;
                numero = pNumero;


            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Direccion: {0}, #{1}", calle, numero);
                return (sb.ToString());

            }
            
        }


        public struct Agenda
        {
            public String nombre;
            public String telefono;
            public int edad;
            //agregamos un campo de la estructura direccion a la estructura agenda
            public Direccion Domicilio;

            //metodo constructor de la estructura Agenda
            public Agenda(String pNombre, String pTelefono, int pEdad, String pCalle, int pNumero)
            {  
                //argumentos
                nombre = pNombre;
                telefono = pTelefono;
                edad = pEdad;

                // validacion 
                if (pTelefono.Length > 8) {
                    telefono = pTelefono;

                }
                else
                {
                    telefono = "telefono no valido, verificar";
                }

                Domicilio = new Direccion(pCalle, pNumero);
            }

            //metodo constructor de la estructura Agenda SOBRECARGA
            public Agenda(String pNombre, int pEdad)
            {
                nombre = pNombre;
                edad = pEdad;
                telefono = "sin telefono";
                Domicilio = new Direccion("sin direccion", 0);
            }

            //metodo constructor de la estructura Agenda SOBRECARGA
            public Agenda(String pNombre)
            {
                nombre = pNombre;

                Console.WriteLine("ingrese su edad");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese telefono");
                telefono = Console.ReadLine();

                if (telefono.Length > 8)
                {
                    telefono = telefono;

                }
                else
                {
                    telefono = "sin tellefono";
                }
                Domicilio = new Direccion("sin direccion",0);

            }

            //metodo constructor de la estructura Agenda SOBRECARGA
            public Agenda(int codigo)
            {
                Console.WriteLine("ingrese nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("ingrese su edad");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese telefono");
                telefono = Console.ReadLine();

                if (telefono.Length > 8)
                {
                    telefono = telefono;

                }
                else
                {
                    telefono = "sin tellefono";
                }

                Domicilio = new Direccion("SIN direccion",0);

            }


            //metodo predeterminado personalizar como se muestran los datos 
            public override string ToString() {
                //StringBuilder clase para construir la cadena de salida 
                StringBuilder sb = new StringBuilder();
                //Agrega  formateado al "StringBuilder" usando los argumentos proporcionados (nombre, número de teléfono y edad). 
                sb.AppendFormat("Nombre:{0}, Telefono:{1}, Edad: {2}", nombre, telefono, edad);
                //Adicionamos la cadena de domicilio
                sb.Append(Domicilio.ToString());

                // devuelve la representacion complet de la cadena
                return (sb.ToString());
            }
        }


        //punto de entrada para la ejecucion
        static void Main(string[] args)
        {
            //Agenda[] amigos = new Agenda[5];
            //amigos[0].edad = 21;
            //amigos[0].nombre = "Dil";
            //amigos[0].telefono = "(+57) 1234567890";

            //instacias con valores 
            Agenda amigos = new Agenda("ESS","(123)",34,"AV principal", 122);
            Agenda amigos1 = new Agenda("Caaaa", "(+57)222-2345", 23, "AV segunda", 123);
            Agenda amigos2 = new Agenda("jose", 23);
            Agenda amigos3 = new Agenda("Luisa");
            Agenda amigos4 = new Agenda(25);


            Console.WriteLine(amigos.ToString());
            Console.WriteLine(amigos1.ToString());
            Console.WriteLine(amigos2.ToString());
            Console.WriteLine(amigos3.ToString());
            Console.WriteLine(amigos4.ToString());
            Console.ReadKey();

        }
    }
}