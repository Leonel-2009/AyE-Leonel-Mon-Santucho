// Bloque 1
// Ejercicio 1

void ejercicio1()
{
    Console.WriteLine("Ingrese el numero 0 para mostrar los numeros multiplos de 3 del 1 al 100:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    for (int A = 0; A <= 100; A += 3)
    {
        Console.WriteLine(A);
    }
}

// Ejercicio 2
void ejercicio2()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad < 18)
    {
        Console.WriteLine("Usted es menor de edad");
    }
    else
    {
        Console.WriteLine("Usted es mayor de edad");
    }
}

// Ejercicio 3
void ejercicio3()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese una palabra: ");
    string palabra = Convert.ToString(Console.ReadLine());
    int contador = 0;

    for (int i = 0; i < palabra.Length; i++)
    {
        contador++;
    }
    Console.WriteLine("Esta palabra tiene: " + contador + " de letras");
}

//Ejercicio 4
void ejercicio4()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese la contraseña secreta (tiene 5 intentos):");
    string contraseña = Convert.ToString(Console.ReadLine());
    int contador2 = 5;
    while (contraseña != "bocajr2000")
    {
        if (contador2 != 1)
        {
            contador2 = contador2 - 1;
            Console.WriteLine("incorrecto, usted tiene " + contador2 + " intentos para ingresar la contraseña correcta");
            contraseña = Convert.ToString(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Sistema bloqueado");
            break;
        }
    }
    if (contraseña == "bocajr2000")
    {
        Console.WriteLine("Entrando al sistema...");
    }
}

// Ejercicio 5
void ejercicio5()
{
    Console.WriteLine("");
    Console.WriteLine("ingrese 10 numeros y veremos cual es el mayor de todos:");

    int num4 = Convert.ToInt32(Console.ReadLine());
    int mayor = 0;
    for (int i = 1; i <= 10; i++)
    {
        num4 = Convert.ToInt32(Console.ReadLine());

        if (i == 1)
        {
            mayor = num4;
        }

        if (num4 > mayor)
        {
            mayor = num4;
        }
    }
    Console.WriteLine("El numero mayor es: " + mayor);
}

//Ejercicio 6
void ejercicio6()
{
    Console.WriteLine("");
    Console.WriteLine("Tabla del 7:");

    for (int B = 1; B <= 10; B++)
    {
        int res = B * 7;
        Console.WriteLine(res);
    }
}

//Ejercicio 7
void ejercicio7()
{
    Console.WriteLine("");
    Console.WriteLine("Cuenta regresiva desde el 10:");
    int b;

    for (b = 10; b >= 1; b--)
    {
        Console.WriteLine(b);
    }
    Console.WriteLine("Oa (xd)");
}

//Ejercicio 8
void ejercicio8()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un número y veremos si es par o impar:");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0)
    {
        Console.WriteLine("Es par");
    }
    else
    {
        Console.WriteLine("Es impar");
    }
}

//Ejercicio 9
void ejercicio9()
{
    Console.WriteLine("Ingrese una frase y determinaremos cuantas vocales tiene");
    string frase = Console.ReadLine();
    string vocales = ("aeiouAEIOU");
    int contador3 = 0;

    foreach (char f in frase)
    {
        foreach (char v in vocales)
        {
            if (f == v)
            {
                contador3 = contador3 + 1;
                break;
            }

        }
    }
    Console.WriteLine("La cantidad de vocales que tiene es: " + contador3);
}

//Ejercicio 10
void ejercicio10()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un numero del 1 al 12 y haremos su tabla de multiplicación:");
    int B = Convert.ToInt16(Console.ReadLine());
    int Multiplicacion = B;
    Console.WriteLine("");
    if (Multiplicacion <= 12 && Multiplicacion > 0)
    {
        for (Multiplicacion = 1; Multiplicacion <= 10; Multiplicacion++)
        {
            int res2 = Multiplicacion * B;
            Console.WriteLine(B + " X " + Multiplicacion + " = " + res2);
        }
    }
    else
    {
        Console.WriteLine("El numero es mayor o menor a lo pedido (se cierra el programa)");
    }
}

//Ejercicio 11
void ejercicio11()
{

    int suma = 0;
    int numero;

    while (suma < 100)
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese los numeros que vos quieras (limite: la suma de todos dan 100):");
        numero = Convert.ToInt16(Console.ReadLine());
        suma = suma + numero;
        Console.WriteLine("Contador total " + suma);
    }
}

//Ejercicio 12
void ejercicio12()
{
    Console.WriteLine("");
    Console.WriteLine("Escriba una palabra y luego la separaremos en distintas lineas sus letras");
    string palabra2 = Console.ReadLine();

    for (int t = 0; t < palabra2.Length; t++)
    {
        char letraActual = palabra2[t];
        Console.WriteLine(letraActual);
    }
}

//Ejercicio 13
void ejercicio13()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese su edad para saber si puede votar, conducir, hacer ambas cosas o ninguna:");
    int edad2 = Convert.ToInt16(Console.ReadLine());

    if (edad2 < 16)
    {
        Console.WriteLine("Usted no puede hacer ninguna opción");
    }
    else if (edad2 == 16)
    {
        Console.WriteLine("Usted puede votar");
    }
    else if (edad2 == 17)
    {
        Console.WriteLine("Usted puede conducir");
    }
    else if (edad2 >= 18)
    {
        Console.WriteLine("Usted puede hacer ambas opciones");
    }
}

// Ejercicio 14
void ejercicio14()
{
    Console.WriteLine("");
    Console.WriteLine("Cuenta regresiva desde el 50 al 0:");
    int c;

    for (c = 50; c >= 0; c -= 5)
    {
        Console.WriteLine(c);
    }
}

// Ejercicio 15
void ejercicio15()
{
    Console.WriteLine("");
    Console.WriteLine("Escriban dos contraseñas para ver si coinciden:");
    Console.WriteLine("");
    Console.WriteLine("Escriba la 1ra contraseña:");
    string contraseña1 = Console.ReadLine();
    Console.WriteLine("Escriba la 2da contraseña");
    string contraseña2 = Console.ReadLine();

    if (contraseña1 != contraseña2)
    {
        Console.WriteLine("No coinciden las contraseñas, intentelo de nuevo");
        Console.WriteLine("Escriba la 1ra contraseña:");
        string cont1 = Console.ReadLine();
        Console.WriteLine("Escriba la 2da contraseña:");
        string cont2 = Console.ReadLine();

        while (cont1 != cont2)
        {
            Console.WriteLine("No coinciden las contraseñas, intentelo de nuevo");
            Console.WriteLine("Escriba la 1ra contraseña:");
            cont1 = Console.ReadLine();
            Console.WriteLine("Escriba la 2da contraseña:");
            cont2 = Console.ReadLine();
        }
        if (cont1 == cont2)
        {
            Console.WriteLine(" Las contraseñas coinciden");
        }
    }
    else
    {
        Console.WriteLine(" Las contraseñas coinciden");
    }

}

// Ejercicio 16
void ejercicio16()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese varios nombres (limite: que un nombre contenga 10 o más caracteres):");
    string nombre = Console.ReadLine();

    while (nombre.Length <= 10)
    {
        nombre = Console.ReadLine();
    }
    Console.WriteLine(nombre + " supera los 10  caracteres");
}

// Ejercicio 17
void ejercicio17()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese una oración para determinar cuantas vocales 'a y A' tiene:");
    string frase2 = Console.ReadLine();
    string vocales2 = ("aA");
    int contador5 = 0;

    foreach (char f in frase2)
    {
        foreach (char v in vocales2)
        {
            if (f == v)
            {
                contador5 = contador5 + 1;
                break;
            }

        }
    }
    Console.WriteLine("La cantidad de 'a' y 'A' que tiene es: " + contador5);
}

// Ejercicio 18
void ejercicio18()
{
    Console.WriteLine("");
    Console.WriteLine("Escriba su nombre:");
    string nombre = Console.ReadLine();
    string primletra = nombre.Substring(0, 1).ToUpper();
    string resto = nombre.Substring(1).ToLower();

    Console.WriteLine("Hola " + primletra + resto);
}

bool seguimos = true;

while (seguimos == true)
{
    Console.WriteLine("");
    Console.WriteLine("Inserte numeros del 1 al 18 que estan en la siguiente lista para ir a cada ejercicio: ");
    Console.WriteLine("1 = ejercicio 1");
    Console.WriteLine("2 = ejercicio 2");
    Console.WriteLine("3 = ejercicio 3");
    Console.WriteLine("4 = ejercicio 4");
    Console.WriteLine("5 = ejercicio 5");
    Console.WriteLine("6 = ejercicio 6");
    Console.WriteLine("7 = ejercicio 7");
    Console.WriteLine("8 = ejercicio 8");
    Console.WriteLine("9 = ejercicio 9");
    Console.WriteLine("10 = ejercicio 10");
    Console.WriteLine("11 = ejercicio 12");
    Console.WriteLine("12 = ejercicio 12");
    Console.WriteLine("13 = ejercicio 13");
    Console.WriteLine("14 = ejercicio 14");
    Console.WriteLine("15 = ejercicio 15");
    Console.WriteLine("16 = ejercicio 16");
    Console.WriteLine("17 = ejercicio 17");
    Console.WriteLine("18 = ejercicio 18");
    Console.WriteLine("si quiere cerrar el programa escriba '0'");
    Console.WriteLine("");

    int menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 1:
            ejercicio1();
            break;
        case 2:
            ejercicio2();
            break;
        case 3:
            ejercicio3();
            break;
        case 4:
            ejercicio4();
            break;
        case 5:
            ejercicio5();
            break;
        case 6:
            ejercicio6();
            break;
        case 7:
            ejercicio7();
            break;
        case 8:
            ejercicio8();
            break;
        case 9:
            ejercicio9();
            break;
        case 10:
            ejercicio10();
            break;
        case 11:
            ejercicio11();
            break;
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
        case 0:
            seguimos = false;
            break;
        default:
            Console.WriteLine("");
            Console.WriteLine("El numero no esta en la lista, Escriba los quw están ahí");
            Console.WriteLine("");
            break;
    }
}
