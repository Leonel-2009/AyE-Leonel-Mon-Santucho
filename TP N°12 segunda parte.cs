using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;
Console.WriteLine("---TP N°12 Segunda parte---");
Console.WriteLine("Elija del 12 al 22");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 12:
        ejercicio12();
        break;
    case 13:
        ejercicio13();
        break;
    case 14:
        ejercicio14();
        break;
    case 15:
        ejercicio15();
        break;
    case 16:
        ejercicio16();
        break;
    case 17:
        ejercicio17();
        break;
    case 18:
        ejercicio18();
        break;
    case 19:
        ejercicio19();
        break;
    case 20:
        ejercicio20();
        break;
    case 21:
        ejercicio21();
        break;
    case 22:
        ejercicio22();
        break;
    default:
        Console.WriteLine("Opción invalida");
        break;
}
void ejercicio12()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°12");
    Console.WriteLine("");
    Console.WriteLine("Ingrese la figura geométrica que quiera calcular su área");
    Console.WriteLine("(Figuras Disponibles: Triángulo, Rectángulo, Circulo, Hexagono)");
    Console.Write("Ingrese la figura: ");

    string figura = Console.ReadLine().ToLower();

    if (figura.Any(char.IsDigit))
    {
        Console.WriteLine("No se permite números");
    }
    else if (figura.Any(c => !char.IsLetterOrDigit(c)))
    {
        Console.WriteLine("No se permite carácteres especiales");
    }
    else if (figura is not ("hexagono" or "circulo" or "rectangulo" or "triangulo"))
    {
        Console.WriteLine("No se encuentra disponible la figura geometrica");
    }

    switch (figura)
    {
        case "circulo":
            circulo();
            break;
        case "triangulo":
            triangulo();
            break;
        case "rectangulo":
            rectangulo();
            break;
        case "hexagono":
            hexagono();
            break;
    }

    void circulo()
    {
        try
        {
            Console.WriteLine("");
            Console.WriteLine("Usted quiere calcular el area de un circulo");
            Console.Write("Ingrese el radio del circulo: ");

            float radio = float.Parse(Console.ReadLine());
            float area = 3.14f * (radio * radio);

            Console.WriteLine($"El área del circulo es {area}");
        }
        catch (FormatException)
        {
            Console.WriteLine("No se permite escribir letras, carácteres especiales o espacios en blanco");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Número demasiado grande para el sistema");
        }
    }
    void rectangulo()
    {
        try
        {
            Console.WriteLine("");
            Console.WriteLine("Usted quiere calcular el area de un rectángulo");
            Console.Write("Ingrese la base del rectángulo: ");

            float Base = float.Parse(Console.ReadLine());

            Console.Write("Ahora ingrese la altura del rectángulo: ");

            float altura = float.Parse(Console.ReadLine());

            float area = Base * altura;

            Console.WriteLine($"El área del rectángulo es {area}");
        }
        catch (FormatException)
        {
            Console.WriteLine("No se permite escribir letras, carácteres especiales o espacios en blanco");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Número demasiado grande para el sistema");
        }
    }
    void triangulo()
    {
        try
        {
            Console.WriteLine("");
            Console.WriteLine("Usted quiere calcular el area de un triángulo");
            Console.Write("Ingrese la base del triángulo: ");

            float Base = float.Parse(Console.ReadLine());

            Console.Write("Ahora ingrese la altura del triángulo: ");

            float altura = float.Parse(Console.ReadLine());

            float area = (Base * altura) / 2;

            Console.WriteLine($"El área del triángulo es {area}");
        }
        catch (FormatException)
        {
            Console.WriteLine("No se permite escribir letras, carácteres especiales o espacios en blanco");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Número demasiado grande para el sistema");
        }
    }
    void hexagono()
    {
        try
        {
            Console.WriteLine("");
            Console.WriteLine("Usted quiere calcular el area de un rectángulo");
            Console.Write("Ingrese el lado del hexagono: ");

            float lado = float.Parse(Console.ReadLine());

            float perimetro = lado * 6;

            Console.WriteLine($"El perimetro es {perimetro}");
            Console.Write("Ahora ingrese la altura del rectángulo: ");

            float apotema = float.Parse(Console.ReadLine());

            float area = (perimetro * apotema) / 2;

            Console.WriteLine($"El área del rectángulo es {area}");
        }
        catch (FormatException)
        {
            Console.WriteLine("No se permite escribir letras, carácteres especiales o espacios en blanco");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Número demasiado grande para el sistema");
        }
    }
}
void ejercicio13()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°13");
    Console.WriteLine("");
    Console.WriteLine("Ingrese el valor de las entradas A y B y veremos si es AND o NOR");
    Console.Write("Ingrese el valor de la entrada A: ");

    char A = Convert.ToChar(Console.ReadLine().ToLower());

    if(A != 'v' && A != 'f')
    {
        Console.WriteLine("Entrada no valida, solo se permite v o f");
    }

    Console.Write("Ahora ingrese la entrada de B: ");

    char B = Convert.ToChar(Console.ReadLine().ToLower());

    if (B != 'v' && B != 'f')
    {
        Console.WriteLine("Entrada no valida, solo se permite v o f");
    }

    if(A == B)
    {
        Console.WriteLine("La compuerta lógica es AND");
    }
    else
    {
        Console.WriteLine("La compuerta lógica es NOR");
    }
}
void ejercicio14() 
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°14");
    Console.WriteLine("");
    Console.WriteLine("Ingrese la cantidad de camisetas que va a comprar: ");

    int compra_camisetas = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("¿Cuanto es el precio de las camisetas? ");

    int compra = Convert.ToInt32(Console.ReadLine());
    float descuento = 0;
    float Descuento = 0;

    if (compra_camisetas is (1 or 2 or 3 or 4))
    {
        descuento = 0.125f;
        Descuento = 12.5f;
    }
    else if(compra_camisetas is (5 or 6 or 7 or 8))
    {
        descuento = 0.20f;
        Descuento = 20;
    }
    else if(compra_camisetas > 8)
    {
        descuento = 0.315f;
        Descuento = 31.5f;
    }

    float compra_total = compra - (compra * descuento);

    Console.WriteLine($"Su compra es de ${compra}");
    Console.WriteLine($"El descuento es del {Descuento}%");
    Console.WriteLine($"La compra con el descuento es de ${compra_total}");
}
void ejercicio15()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°15");
    Console.WriteLine("");
    Console.Write("Ingrese un número entero del 1 al 10: ");

    int num = Convert.ToInt16(Console.ReadLine());

    if (num > 10 || num < 0)
    {
        Console.WriteLine("Número fuera de rango, ingrese los números que se le pidió boludo");
    }

    if (num is (2 or 3 or 5 or 7))
    {
        Console.WriteLine($"El número {num} es primo");
    }
    else if(num == 1)
    {
        Console.WriteLine($"El número {num} no es ni primo ni compuesto");
        Console.Write("Explicación: ");
        Console.WriteLine("No se considera un número primo ni compuesto porque solo tiene un divisor que es en si mismo");
    }
    else
    {
        Console.WriteLine($"El número {num} no es primo");
        Console.Write("Explicación: ");
        Console.WriteLine($"Los números primos son números naturales mayores que 1 que tiene exactamente dos divisores: el número 1 y en si mismo. El número {num} tiene otros divisores más, por lo que no es primo");
    }
}
void ejercicio16()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°16");
    Console.WriteLine("");
    Console.WriteLine("Tiene que ingresar un horario");
    Console.Write("Ingrese la hora: ");

    int hora = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese los minutos: ");

    int minuto = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese los segundos: ");

    int segundo = Convert.ToInt16(Console.ReadLine());

    Console.Write("¿pm o am?: ");

    string periodo = Console.ReadLine().ToLower();

    segundo += 10;

    if (segundo >= 60)
    {
        segundo -= 60;
        minuto++;

        if (minuto >= 60)
        {
            minuto = 0;
            hora++;

            if (hora == 12)
            {
                periodo = (periodo == "am") ? "pm" : "am";
            }
            else if (hora > 12)
            { 
                hora = 1;
            }
        }
    }

    if (hora == 12 && periodo == "am" && minuto == 0 && segundo < 10)
    {
        hora = 0;
    }

    Console.Write("Horario luego de los 10 segundos: ");
    Console.WriteLine($"{hora} {periodo}.: {minuto} min.: {segundo} seg.");
}
void ejercicio17()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°17");
    Console.WriteLine("");
    Console.WriteLine("Ecuaciones 2do grado:");
    Console.Write("Ingrese el primer parámetro: ");

    int a = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese el segundo parámetro: ");

    int b = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese el tercer parámetro: ");

    int c = Convert.ToInt16(Console.ReadLine());

    if (a == 0) 
    {
        Console.WriteLine("No es una ecuación de segundo grado porque a = 0");
    }
    else
    {
        double disc = b * b - 4 * a * c;

        if(disc < 0) 
        {
            Console.WriteLine("No es ecuación de segundo grado porque el discriminante es negativo");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
            double x2 = (-b - Math.Sqrt(disc)) / (2 * a);

            Console.WriteLine($"X1 = {x1}");
            Console.WriteLine($"X2 = {x2}");
        }
    }
}
void ejercicio18()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°18");
    Console.WriteLine("");
    Console.WriteLine("Conversor de Longitud:");
    Console.WriteLine("1- Metros");
    Console.WriteLine("2- Pies");
    Console.WriteLine("3- Centimetros");
    Console.WriteLine("4- Pulgadas");
    Console.Write("Ingrese que unidad de medida quiere usar: ");

    int medida = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese la unidad en la que quiere pasar: ");

    int pasaje = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese la medida: ");

    int num = Convert.ToInt16(Console.ReadLine());

    float metros = 0;
    float resultado = 0;

    switch (medida)
    {
        case 1:
            metros = num; 
            break;
        case 2:
            metros = num * 0.3048f;
            break;
        case 3:
            metros = num / 100;
            break;
        case 4:
            metros = num * 0.0254f;
            break;
        default:
            Console.WriteLine("Unidad no encontrada");
            break;
    }

    switch (pasaje)
    {
        case 1:
            resultado = metros;
            break;
        case 2:
            resultado = metros / 0.3048f;
            break;
        case 3:
            resultado = metros * 100;
            break;
        case 4:
            resultado = metros / 0.0254f;
            break;
        default:
            Console.WriteLine("Pasaje no encontrada");
            break;
    }

    Console.WriteLine($"El resultado es: {resultado}");
}
void ejercicio19() 
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°19");
    Console.WriteLine("");
    Console.WriteLine("Converción a número romano");
    Console.Write("Ingrese un número: ");

    int num = Convert.ToInt16(Console.ReadLine());
    string valorRomano = "";

    if (num < 1 || num > 3999)
    {
        Console.WriteLine("Numero natural no permitido");
    }
    else
    {
        while (num >= 1000)
        {
            valorRomano += "M";
            num -= 1000;
        }
        while (num >= 900)
        {
            valorRomano += "CD";
            num -= 900;
        }
        while (num >= 500)
        {
            valorRomano += "D";
            num -= 500;
        }
        while (num >= 400)
        {
            valorRomano += "CD";
            num -= 400;
        }
        while (num >= 100)
        {
            valorRomano += "C";
            num -= 100;
        }
        while (num >= 90)
        {
            valorRomano += "XC";
            num -= 90;
        }
        while (num >= 50)
        {
            valorRomano += "L";
            num -= 50;
        }
        while (num >= 40)
        {
            valorRomano += "XL";
            num -= 40;
        }
        while (num >= 10)
        {
            valorRomano += "X";
            num -= 10;
        }
        while (num >= 9)
        {
            valorRomano += "IX";
            num -= 9;
        }
        while (num >= 5)
        {
            valorRomano += "V";
            num -= 5;
        }
        while (num >= 4)
        {
            valorRomano += "IV";
            num -= 4;
        }
        while (num >= 1)
        {
            valorRomano += "I";
            num -= 1;
        }

        Console.WriteLine($"El resultado en romano es: {valorRomano}");
    }
}
void ejercicio20()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("Ejercicio N°20");
        Console.WriteLine("");
        Console.WriteLine("Prueba de equipo");
        Console.WriteLine("Ingrese los tres estados de los interruptores y veremos si funcionan o no");
        Console.Write("Ingrese el primer estado: ");
        int estado = Convert.ToInt16(Console.ReadLine());
        Console.Write("Ingrese el segundo estado: ");
        int estado2 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Ingrese el tercer estado: ");
        int estado3 = Convert.ToInt16(Console.ReadLine());

        if (estado > 1 || estado2 > 1 || estado3 > 1 || estado < 0 || estado2 < 0 || estado3 < 0)
        {
            Console.WriteLine("Solo mande las señales de abierto u cerrado (1 o 0)");
        }
        else
        {
            int contador = estado + estado2 + estado3;

            if (contador == 1)
            {
                Console.WriteLine("El equipo si funciona");
            }
            else
            {
                Console.WriteLine("El equipo no funciona");
            }
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Solo se permiten números");
    }
}
void ejercicio21()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°21");
    Console.WriteLine("");
    Console.WriteLine("Conjunto de números");
    try
    {
        int[] conjunto = new int[4];
        int[] conjunto2 = new int[4];
        bool intercepcion = false;

        for (int i = 0; i < conjunto.Length; i++)
        {
            Console.Write($"Ingrese el número n° {i + 1} del primer conjunto: ");
            conjunto[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("");
        for (int i = 0; i < conjunto2.Length; i++)
        {
            Console.Write($"Ingrese el número n° {i + 1} del segundo conjunto: ");
            conjunto2[i] = int.Parse(Console.ReadLine());
        }

        for (int f = 0; f < 4; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                if (conjunto[f] == conjunto2[c])
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Los numeros son interceptados en el n° {conjunto[f]}");
                    intercepcion = true;
                    break;
                }
            }
        }

        if (!intercepcion)
        {
            Console.WriteLine("No hay números que se interceptan entre sí");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Solo se permiten números");
    }
}
void ejercicio22()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°22");
    Console.WriteLine("");
    Console.WriteLine("Determinar triangulo");
    Console.WriteLine("Ingrese los tres lados de un triangulo y veremos que clasificación tiene:");
    Console.Write("Ingrese el primer lado: ");

    int lado = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese el segundo lado: ");

    int lado2 = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese el tercer lado: ");

    int lado3 = Convert.ToInt16(Console.ReadLine());

    if (lado == lado2 && lado2 == lado3 && lado3 == lado) 
    {
        Console.WriteLine("El triangulo es Equilatero");
    }
    else if (lado == lado2 || lado2 == lado3 || lado3 == lado)
    {
        Console.WriteLine("El triangulo es Isósceles");
    }
    else
    {
        Console.WriteLine("El triangulo es Escaleno");
    }
}
