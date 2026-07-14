using System.Linq.Expressions;

Console.WriteLine("---Recuperatorio---");

Ejercicio1();
Ejercicio2();
Ejercicio3();
Ejercicio4();

void Ejercicio1()
{
    Console.WriteLine("");
    Console.WriteLine("---Ejercicio1---");
    Console.WriteLine("Ingrese la cantidad de horas que usted trabajó");

    
    int hora = 0
    try()
    {
        hora = Convert.ToInt16(Console.ReadLine());
    }
    catch()
    {
        Console.WriteLine("No se permite caracteres");
    }

    int acum = 0;
    int valor = 16;

    ejercicio1(hora);

    int ejercicio1(int horas)
    {
        if (horas <= 40)
        {
            acum = valor * horas;
            int salario = acum;

            Console.WriteLine($"Su salario es: ${salario}");
           
        }
        else if(horas > 40)
        {
            acum = valor * 40;
            int horasExtra = horas - 40;
            int valorExtra = horasExtra * 20;
            int salario = acum + valorExtra;

            Console.WriteLine($"Horas extras: {horasExtra} hora/horas");
            Console.WriteLine($"Su salario es: ${salario}");
        }
            
        return horas;
    }
}
int Ejercicio2()
{
    Console.WriteLine("");
    Console.WriteLine("---Ejercicio2---");
    Console.WriteLine("Ingrese números hasta que escriba 0");

    int num = 0;
    int acum = 0;

    try
    {
        num = Convert.ToInt16(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permite caracteres");
    }

    while (num > 0)
    {
        acum += num;
        num = Convert.ToInt16(Console.ReadLine());
    }
    Console.WriteLine("");
    Console.WriteLine($"La suma de todos los números es: {acum}");

    return num;
}
string Ejercicio3()
{
    Console.WriteLine("");
    Console.WriteLine("---Ejercicio3---");
    Console.WriteLine("Ingrese una palabra y contaremos cuantas vocales tiene");

    string palabra = Console.ReadLine();
    string vocales = "aeiouAEIOU";
    int acum = 0;

    foreach (char p in palabra)
    {
        foreach (char v in vocales)
        {
            if (p == v)
            {
                acum++;
            }
        }
    }

    Console.WriteLine("");
    Console.WriteLine($"La cantidad de vocales que tiene son {acum}");

    return palabra;
}
string Ejercicio4()
{
    Console.WriteLine("");
    Console.WriteLine("---Ejercicio4---");
    Console.WriteLine("Ingrese una palabra y veremos si es un palindromo");

    string palindromo = Console.ReadLine();
    string invertido = "";

    foreach (char j in palindromo)
    {
        invertido = j + invertido;
    }
    if (palindromo == invertido)
    {
        Console.WriteLine("");
        Console.WriteLine("La palabra '" + palindromo + "' es un palindromo");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("La palabra '" + palindromo + "' NO es un palindromo");
    }
    return palindromo;
}