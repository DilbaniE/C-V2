int option;

Console.WriteLine("1.suma");
Console.WriteLine("2.resta");
Console.WriteLine("3.multi");
Console.WriteLine("4.divi");

Console.WriteLine("escoge una option");
option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
{
    Suma();
}

if (option == 2)
{
    float resul = 0;
    resul = Resta();
    Console.WriteLine("el resultado {o}", resul);

}

if (option == 3)
{
    float n1 = 0;
    float n2 = 0;

    Console.WriteLine("Ingrese numero 1");
    n1 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Ingrese numeo 2");
    n2 = Convert.ToSingle(Console.ReadLine());
    Multi(n1, n2);
}

if (option == 4)
{
    float n1, n2;
    float resul = 0.0f;

    Console.WriteLine("Ingrese numero 1");
    n1 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Ingrese numeo 2");
    n2 = Convert.ToSingle(Console.ReadLine());

    resul = Divi(n1, n2);
    Console.WriteLine("el resultado {o}", resul);
}




// metodos Ejecucion solo de codigo
static void Suma()
{
    float a, b;
    float r = 0.0f;

    Console.WriteLine("Ingrese numero 1");
    a = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Ingrese numeo 2");
    b = Convert.ToSingle(Console.ReadLine());

    r = a + b;
    Console.WriteLine("el resultado {o}", r);

}


// metodos Ejecucion de parametros
static float Resta()
{
    float a, b;
    float r = 0.0f;

    Console.WriteLine("Ingrese numero 1");
    a = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Ingrese numeo 2");
    b = Convert.ToSingle(Console.ReadLine());

    r = a - b;

    return r;


}

// metodos Ejecucion regresa valores
static void Multi(float a, float b)
{

    float r;
    r = a * b;
    Console.WriteLine("el resultado {o}", r);

}


// metodos Ejecucion valores y parametros
static float Divi(float a, float b)
{

    float r = 0.0f;

    if (b == 0)
    {
        Console.WriteLine("No es ´posible dividir entre cero");
        return 0.0f;
    }
    else
    {
        r = a / b;
        return r;
    }


}
