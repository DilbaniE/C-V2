using Classes1;

namespace Classes1
{

    //clase  cubo 
    class Cubo
    {
        //declarar datos
        public int lado;
        public int area;
        public int volumen;

        //metodo calcular area
        public void CalcularArea()
        {
            area = (lado * lado) * 6;
        }

        public void CalcularVolumen()
        {
            volumen = lado * lado * lado;
        }
    }

    //clase Prisma
    class Prisma
    {
        //declaracion de datos
        private int alto, ancho, lado, espesor, volumen, area;
        

        //definiendo propiedades
        public int Ancho
        {
            get
            {
                return ancho;

            }
            set
            {
                if(value < 0)
                {
                    ancho = 1;
                }
                else
                {
                    ancho=value;
                }
            }
        }
        public int Alto
        {
            get
            {
                return alto;

            }
            set
            {
                if (value < 0)
                {
                    alto = 1;
                }
                else
                {
                    alto = value;
                }
            }
        }
        public int Espesor
        {
            get
            {
                return espesor;

            }
            set
            {
                if (value < 0)
                {
                    espesor = 1;
                }
                else
                {
                    espesor = value;
                }
            }
        }
        public int Area
        {
            get
            {
                return area;

            }
           
        }
        public int Volumen
        {
            get
            {
                return volumen;

            }
        }

        //Metodo constructor
        public Prisma()
        {
            Console.WriteLine("ingrese el ancho");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el alto");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el espesor");
            espesor = Convert.ToInt32(Console.ReadLine());
        }

        //metodo 
        public void CalcularVolumen()
        {
            volumen = ancho * alto * espesor;

        }

        // metodo
        public void CalcularArea()
        {
            int a1 = 0, a2 = 0, a3 = 0;
            a1 = 2 * CalcularRectangulo(ancho, alto);
            a2 = 2 * CalcularRectangulo(ancho, espesor);
            a3 = 2 * CalcularRectangulo(alto, espesor);

            area = a1 + a2 + a3;

        }

        private int CalcularRectangulo(int a, int b)
        {
            return (a * b);
        }

        //Convirtiendo los datos ingresados por el usuario a cadena
        public override string ToString()
        {
            String mensaje = "";
            mensaje += " Ancho " + ancho.ToString() + " Alto " + alto.ToString() + " Espesor " + espesor.ToString();
            mensaje += " Area " + area.ToString() + " Espesor " + espesor.ToString();
            return mensaje;
        }

        public void ImprimirResul()
        {
            Console.WriteLine("El area es {0}, volumen es {1}", area, volumen);
        }

    }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //creacion de objeto (instacioamos la clase cubo)
            Cubo micubo = new Cubo();
            Cubo cubo2 = new Cubo();

            Prisma miprisma = new Prisma();


            // asignacion de valor lado
            micubo.lado = 7;
            cubo2.lado = 8; 

            //invocar metodo
            micubo.CalcularArea();
            micubo.CalcularVolumen();
            cubo2.CalcularArea();
            cubo2.CalcularVolumen();

            miprisma.CalcularArea();
            miprisma.CalcularVolumen();

            //mostrar datos
            Console.WriteLine("area = {0}, volumen {1}", micubo.area, micubo.volumen);
            Console.WriteLine("area = {0}, volumen {1}", cubo2.area, cubo2.volumen);

            Console.WriteLine(miprisma.ToString());
            miprisma.ImprimirResul();
            Console.ReadKey();
        }
     }
