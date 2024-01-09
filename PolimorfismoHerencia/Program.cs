namespace PolimorfismoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Area(22, 5);

            Triangulo triangulo = new Triangulo();
            triangulo.Area(4, 10);

            Console.ReadKey();
        }
    }
}