using System.Numerics;
using System.Reflection.Metadata.Ecma335;

// Evaluacion AyE


//Ejercicio 1
try
{
    Console.WriteLine("Ingrese la cantidad de horas que trabajó");

    int horas = Convert.ToInt32(Console.ReadLine());
    int salario = 16;
    int hora = 3600;
    int valorExtra = 20;

    if (horas <= 40)
    {
        int horatotal = horas * hora;

        salario = salario + horatotal;

        Console.WriteLine("");
        Console.WriteLine("Su salario es: $" + salario);
    }
    else if (horas > 40)
    {
        int horatotal = horas * hora;
        int horaExtra = horas - 40;
        int horasExtras = horaExtra;
        int salarioextra = 0;
        int salarioTotal = 0;

        salario = salario * hora;

        if (horasExtras == 1)
        {
            salarioTotal = salario + hora;
        }
        else
        {
            horasExtras = horasExtras * hora;
            salarioextra = valorExtra + horasExtras;
            salarioTotal = salario + salarioextra;
        }
        Console.WriteLine("");
        Console.WriteLine("Su salario es: $" + salario);
        Console.WriteLine("Las horas extra que trabajo son: " + horaExtra);
        Console.WriteLine("Su salario total es: $" + salarioTotal);
    }
}
catch (FormatException)
{
    Console.WriteLine("Escriba un número, no una letra");
}

//Ejercicio 2
void ejercicio2()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese varios numeros hasta que escriba 0");
    try
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int contador = 0;

        while (num != 0)
        {
            contador += num;
            num = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("La suma de todos los numeros que escribio es: " + contador);
    }
    catch (FormatException)
    {
        Console.WriteLine("Escriba un número, no una letra");
    }
}

// Ejercicio 3
void ejercico3()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    string vocales = "aeiouAEIOU";
    int contador2 = 0;

    if (string.IsNullOrEmpty(palabra))
    {
        Console.WriteLine("");
        Console.WriteLine("No se acepta espacios en blanco");
    }

    foreach (char p in palabra)
    {
        foreach (char v in vocales)
        {
            if (p == v)
            {
                contador2++;
            }
        }
    }
    Console.WriteLine("las vocales que tiene esa palabra son: " + contador2);
}


//Ejercicio 4
void ejercico4()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese una palabra, luego veremos si es un palindromo");
    string palindromo = Console.ReadLine();
    string invertido = "";

    foreach (char p in palindromo)
    {
        invertido = p + invertido;
    }

    if (palindromo != invertido)
    {
        while (palindromo != invertido)
        {
            Console.WriteLine("");
            Console.WriteLine("La palabra " + palindromo + " no es un palindromo, intentelo de vuelta");
            palindromo = Console.ReadLine();
            string invertido2 = "";

            foreach (char p in palindromo)
            {
                invertido2 = p + invertido2;
            }

            if (palindromo == invertido2)
            {
                Console.WriteLine("");
                Console.WriteLine("La palabra " + palindromo + " es un palindromo");
                break;
            }
        }
    }

    if (palindromo == invertido)
    {
        Console.WriteLine("");
        Console.WriteLine("La palabra " + palindromo + " es un palindromo");
    }
}