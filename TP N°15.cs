using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

ejercicio1();
ejercicio2();
ejercicio3();
ejercicio4();
ejercicio5();
ejercicio6();
ejercicio7();
ejercicio8();

static void ejercicio1()
{
    Console.WriteLine("-----Ejercico N°1-----");
    Console.WriteLine("matriz 3x3 con numeros del 1 al 9:");
    Console.WriteLine("");

    int[,] m =
    {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };

    for (int f = 0; f < m.GetLength(0); f++)
    {
        for (int c = 0; c < m.GetLength(1); c++)
        {
            Console.Write(m[f, c] + " ");
        }
        Console.WriteLine();
    }
}

static void ejercicio2()
{
    Console.WriteLine("");
    Console.WriteLine("-----Ejercicio 2-----");
    Console.WriteLine("matriz 3x3 con numeros del 10 al 90:");
    Console.WriteLine("");

    int acum = 0;

    int[,] m3 =
    {
        { 10, 20, 30 },
        { 40, 50, 60 },
        { 70, 80, 90 }
    };

    for (int f = 0; f < m3.GetLength(0); f++)
    {
        for (int c = 0; c < m3.GetLength(1); c++)
        {
            Console.Write(m3[f, c] + " ");
            int num = m3[f, c];
            acum += num;
        }
        Console.WriteLine();
    }

    Console.WriteLine("La suma de todos los numeros es: " + acum);
}

static void ejercicio3()
{
    Console.WriteLine("");
    Console.WriteLine("-----Ejercicio 3-----");
    Console.WriteLine("matriz 4x4 con numeros random");
    Console.WriteLine("");

    int[,] m3 =
    {
        { 10, 5, 48, 50 },
        { 9, 50, 69, 99 },
        { 110, 20, 76, 60 },
        { 0, 8, 90, 25 }
    };

    for (int f = 0; f < m3.GetLength(0); f++)
    {
        for (int c = 0; c < m3.GetLength(1); c++)
        {
            Console.Write(m3[f, c] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("");
    Console.WriteLine("ingrese el numero de fila");
    int fila = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el numero de columna");
    int columna = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("El numero correspondiente a esa coordenada es " + m3[fila,columna]);
}

static void ejercicio4()
{
    Console.WriteLine("");
    Console.WriteLine("-----Ejercicio 4-----");
    Console.WriteLine("matriz 4x4 con números predeterminado");
    Console.WriteLine("");

    int[,] m4 =
    {
        { 10, 20, 15, 25 },
        { 40, 55, 50, 75 },
        { 65, 80, 90, 85 },
        { 35, 110, 60, 45 }
    };

    for (int f = 0; f < m4.GetLength(0); f++)
    {
        for (int c = 0; c < m4.GetLength(1); c++)
        {
            Console.Write(m4[f, c] + " ");
        }
        Console.WriteLine();
    }

    int max = int.MinValue;

    Console.WriteLine();
    for (int f = 0; f < m4.GetLength(0); f++)
    {
        for (int c = 0; c < m4.GetLength(1); c++)
        {
            if (m4[f, c] > max)
            {
                max = m4[f, c];
            }
        }
    }
    Console.WriteLine("El número mas grande de la matriz es: " + max);
}

static void ejercicio5()
{
    Console.WriteLine("");
    Console.WriteLine("-----Ejercicio 5-----");
    Console.WriteLine("matriz 4x4 con números predeterminados");
    Console.WriteLine("");

    int[,] m5 =
    {
        { 1, 3, 4, 2 },
        { 6, 1, 2, 7 },
        { 1, 3, 1, 1 },
        { 4, 1, 5, 8 }
    };

    int fila = 0;
    int fila1 = 0;
    int fila2 = 0;
    int fila3 = 0;
    int columna = 0;
    int columna1 = 0;
    int columna2 = 0;
    int columna3 = 0;

    for (int f = 0; f < m5.GetLength(0); f++)
    {
        for (int c = 0; c < m5.GetLength(1); c++)
        {
            Console.Write(m5[f, c] + " ");

            int num = m5[f, c];

            if (f == 0)
            {
                fila = fila + num;
            }
            else if (f == 1) 
            {
                fila1 = fila1 + num;
            }
            else if (f == 2)
            {
                fila2 = fila2 + num;
            }
            else if (f == 3)
            {
                fila3 = fila3 + num;
            }

            if (c == 0)
            {
                columna = columna + num;
            }
            else if (c == 1)
            {
                columna1 = columna1 + num;
            }
            else if (c == 2)
            {
                columna2 = columna2 + num;
            }
            else if (c == 3)
            {
                columna3 = columna3 + num;
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("");
    Console.WriteLine("La suma de todos los números de la fila 0 es: " + fila);
    Console.WriteLine("La suma de todos los números de la fila 1 es: " + fila1);
    Console.WriteLine("La suma de todos los números de la fila 2 es: " + fila2);
    Console.WriteLine("La suma de todos los números de la fila 3 es: " + fila3);
    Console.WriteLine("");
    Console.WriteLine("La suma de todos los números de la columna 0 es: " + columna);
    Console.WriteLine("La suma de todos los números de la columna 1 es: " + columna1);
    Console.WriteLine("La suma de todos los números de la columna 2 es: " + columna2);
    Console.WriteLine("La suma de todos los números de la columna 3 es: " + columna3);
}

static void ejercicio6()
{
    Console.WriteLine("");
    Console.WriteLine("-----Ejercicio 6-----");
    Console.WriteLine("matriz 4x4 determinada");
    Console.WriteLine("");

    int[,] m6 =
    {
        { 1, 2, 3, 4 },
        { 5, 6, 7, 8 },
        { 9, 10, 11, 12 },
        { 13, 14, 15, 16 }
    };

    for (int f = 0; f < m6.GetLength(0); f++)
    {
        for (int c = 0; c < m6.GetLength(1); c++)
        {
            Console.Write(m6[f, c] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("");
    Console.WriteLine("Su traspuesta es: ");
    Console.WriteLine("");

    for (int c = 0; c < m6.GetLength(0); c++)
    {
        for (int f = 0; f < m6.GetLength(1); f++)
        {
            Console.Write(m6[f, c] + " ");
        }
        Console.WriteLine();
    }

}

static void ejercicio7()
{
    Console.WriteLine("");
    Console.WriteLine("-----Ejercicio 7-----");
    Console.WriteLine("matriz tipo 4x4");
    Console.WriteLine("");

    int[,] m7 =
    {
        { 1, 5, 3, 5 },
        { 8, 5, 9, 2 },
        { 4, 5, 6, 7 }
    };

    Console.WriteLine("Ingrese un número y veremos cuantas veces se repite");
    Console.WriteLine("");
    int numero = Convert.ToInt32(Console.ReadLine());
    int contador = 0;

    for (int f = 0; f < m7.GetLength(0); f++)
    {
        for (int c = 0; c < m7.GetLength(1); c++)
        {
            if (m7[f, c] == numero)
            {
                contador += 1;
            }
        }
    }

    if (contador == 0)
    {
        Console.WriteLine("");
        Console.WriteLine("No se encuentra en la matriz :)");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine($"El numero {numero} se encuentra repetido {contador} vez/veces");
    }
}

static void ejercicio8()
{
    Console.WriteLine("");
    Console.WriteLine("-----Ejercicio 8-----");
    Console.WriteLine("matriz 4x4");
    Console.WriteLine("");

    int[,] m8 =
    {
        { 1, 2, 3, 4 },
        { 5, 6, 7, 8 },
        { 9, 10, 11, 12 },
        { 13, 14, 15, 16 }
    };

    int acum = 0;
    for (int f = 0; f < m8.GetLength(0); f++)
    {
        for (int c = 0; c < m8.GetLength(1); c++)
        {
            Console.Write(m8[f, c] + " ");
            int num = m8[f, c];
            acum += num;
        }
        Console.WriteLine();
    }
    int prom = acum / 16;

    Console.WriteLine("");
    Console.WriteLine($"El promedio de todos los numeros es {prom}");
    Console.WriteLine("");
    Console.WriteLine("la nueva matriz es:");
    Console.WriteLine("");

    for (int f = 0; f < m8.GetLength(0); f++)
    {
        for (int c = 0; c < m8.GetLength(1); c++)
        {
            int num = m8[f, c];

            if (num < prom)
            {
                Console.Write(prom + " "); 
            }
            else
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
}