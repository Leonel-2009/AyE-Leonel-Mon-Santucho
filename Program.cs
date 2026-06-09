ejercicio1();
ejercicio2();
ejercicio3();

void ejercicio1()
{
    Console.WriteLine("Ejercicio 1");
    Console.WriteLine("");
    Console.WriteLine("matriz 4x4 con números predeterminados:");
    Console.WriteLine("");

    int[,] m =
    {
        { 1, 1, 3, 6 },
        { 5, 5, 9, 8 },
        { 9, 0, 1, 5 },
        { 4, 8, 9, 7 }
    };

    for (int f = 0; f < m.GetLength(0); f++)
    {
        for (int c = 0; c < m.GetLength(1); c++)
        {
            Console.Write(m[f, c] + " ");
        }
        Console.WriteLine();
    }

    int suma = m[0, 0] + m[0, 3] + m[3, 0] + m[3, 3];

    Console.WriteLine("");
    Console.WriteLine($"La suma de sus esquinas son: {suma}");
}

void ejercicio2()
{
    Console.WriteLine("Ejercicio 2");
    Console.WriteLine("");
    Console.WriteLine("matriz 3x3 con números predeterminados:");
    Console.WriteLine("");

    int[,] m =
    {
        { 1, 1, 3 },
        { 5, 5, 9 },
        { 4, 8, 9 }
    };

    for (int f = 0; f < m.GetLength(0); f++)
    {
        for (int c = 0; c < m.GetLength(1); c++)
        {
            Console.Write(m[f, c] + " ");
        }
        Console.WriteLine();
    }

    int suma = m[0, 0] + m[1, 1] + m[2, 2];
    int suma2 = m[0, 2] + m[1, 1] + m[2, 0];

    Console.WriteLine("");
    Console.WriteLine($"La suma de todos los números de su diagonal principal es: {suma}");
    Console.WriteLine($"La suma de todos los números de su diagonal secundaria es: {suma2}");
}

void ejercicio3()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio 3");
    Console.WriteLine("");
    Console.WriteLine("matriz determinada por el usuario");
    Console.WriteLine("Ingrese el tamaño de su matriz, luego veremos su matriz de identidad");
    Console.WriteLine("");

    int n = Convert.ToInt16(Console.ReadLine());

    int[,] m = new int[n, n];

    for (int fila = 0; fila < n; fila++)
    {
        for (int columna = 0; columna < n; columna++)
        {
            if (fila == columna)
            {
                m[fila, columna] = 1;
            }
            else
            {
                m[fila, columna] = 0;
            }
        }
    }

    Console.WriteLine("");
    Console.WriteLine("La matriz identidad es:");
    Console.WriteLine("");

    for (int fila = 0; fila < n; fila++)
    {
        for (int columna = 0; columna < n; columna++)
        {
            Console.Write(m[fila, columna] + " ");
        }

        Console.WriteLine();
    }
}
