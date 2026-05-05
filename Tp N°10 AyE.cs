//Ejercicio 1
using System.Numerics;

try
{
    Console.WriteLine("Ingrese un número que tenga dos cifras: ");
    int num = Convert.ToInt16(Console.ReadLine());
    int unidades;
    int decenas;

    if (num >= 10 && num <= 99)
    {
        unidades = num / 10;
        decenas = num % 10;
        Console.WriteLine("La cifra de las unidades es: " + unidades);
        Console.WriteLine("La cifra de las decenas es: " + decenas);
    }
    else
    {
        Console.WriteLine("Error: Usted ingreso un número no pedido");
    }
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es muy grande");
}

//Ejercicio 2
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un número que tenga tres cifras: ");
    int num2 = Convert.ToInt16(Console.ReadLine());
    int medio;
    if (num2 >= 100 && num2 <= 999)
    {
        medio = (num2 / 10) % 10;
        Console.WriteLine("La cifra centarl es: " + medio);
    }
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es muy grande");
}

//Ejercicio 3
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un precio de la lista: ");
    float precio = Convert.ToSingle(Console.ReadLine());
    float precio_final;
    float descuento;

    if (precio > 0)
    {
        descuento = precio * 18 / 100;
        precio_final = precio - descuento;
        Console.WriteLine("El precio de la lista es: " + precio);
        Console.WriteLine("El descuento es un 18%");
        Console.WriteLine("El precio con descuento es:" + precio_final);
    }
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es muy grande");
}

//Ejercicio 4
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un número y le daremos su permutado: ");
    int num3 = Convert.ToInt16(Console.ReadLine());
    int permutado;

    if (num3 >= 0 && num3 <= 99)
    {
        permutado = (num3 % 10) * 10 + (num3 / 10);
        Console.WriteLine("La cifra original es: " + num3);
        Console.WriteLine("La cifra permutada es: " + permutado);
    }
    else
    {
        Console.WriteLine(" Ingreso un número incorrecto");
    }
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es muy grande");
}

//Ejercicio 5
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese una fecha en 6 digitos (Ej. 120326) ");
    int fecha = Convert.ToInt32(Console.ReadLine());
    int mes;
    if (fecha >= 100000 && fecha <= 999999)
    {
        Console.WriteLine("La fecha es:" + fecha);

        mes = (fecha / 100) % 100;

        if (mes >= 1 && mes <= 12)
        {
            Console.WriteLine("El mes es:" + mes);
        }
        else
        {
            Console.WriteLine(" error: Ingresó un mes erróneo");
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es muy grande");
}

//Ejercicio 6
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un lado de un cuadrado: ");
    int lado = Convert.ToInt16(Console.ReadLine());
    int perimetro;
    int superficie;

    if (lado > 0)
    {
        perimetro = lado * 4;
        superficie = lado * lado;
        Console.WriteLine("La perimetro es: " + perimetro);
        Console.WriteLine("La superficie es: " + superficie);
    }
    else
    {
        Console.WriteLine("Ingresó un lado negativo");
    }
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es superior");
}

//Ejercicio 7
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese su sueldo: ");
    int sueldo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de horas que trabajó: ");
    int horas = Convert.ToInt16(Console.ReadLine()); ;

    if (horas > 0 && horas <= 24)
    {
        sueldo = sueldo * horas;
        Console.WriteLine("El sueldo en bruto es: " + sueldo);
    }
    else
    {
        Console.WriteLine("Dato incorrecto");
    }
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es superior");
}

//Ejercicio 8
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese una temperatura en Fahrenheit: ");
    int Fah = Convert.ToInt16(Console.ReadLine());
    int Cel = (Fah - 32) * 5 / 9;
    Console.WriteLine("La temperatura a Celcius es: " + Cel + " °C");

}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es superior");
}

//Ejercicio 9
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese dos tiempos para buscar su intervalo: ");
    Console.WriteLine("Ingrese el primer tiempo: ");
    int Hora = Convert.ToInt16(Console.ReadLine());
    int Min = Convert.ToInt16(Console.ReadLine());
    int Seg = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Ahora ingrese el segundo tiempo");
    int Hora2 = Convert.ToInt16(Console.ReadLine());
    int Min2 = Convert.ToInt16(Console.ReadLine());
    int Seg2 = Convert.ToInt16(Console.ReadLine());

    int Total = Hora * 3600 + Min * 60 + Seg;
    int Total2 = Hora2 * 3600 + Min2 * 60 + Seg2;

    int Intervalo = Total2 - Total;

    Console.WriteLine("El intervalo es: " + Intervalo);
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es superior");
}

//Ejercicio 10
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un número que tenga tres cifras y determinaremos sus unidades, decenas y centenas: ");
    int num4 = Convert.ToInt16(Console.ReadLine());
    int unidades;
    int decenas;
    int centenas;

    if (num4 >= 100 && num4 <= 999)
    {
        unidades = num4 % 10;
        decenas = (num4 / 10) % 10;
        centenas = num4 / 100;
        Console.WriteLine("El número ingresado es: " + num4);
        Console.WriteLine("Su unidad es: " + unidades);
        Console.WriteLine("Su decena es: " + decenas);
        Console.WriteLine("Su centena es: " + centenas);
    }
    else
    {
        Console.WriteLine("El número es invalido");
    }
}
catch (FormatException)
{
    Console.WriteLine("No ingrese palabras");
}
catch (OverflowException)
{
    Console.WriteLine("El número es muy grande");
}
