try
{
    Console.WriteLine("-----Ejercicio 1-----");
    Console.WriteLine("");
    Console.WriteLine("Ingrese 5 números");

    int[] listanum = new int[5];

    for (int n = 0; n < listanum.Length; n++)
    {
        listanum[n] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("");
    Console.WriteLine("Lista de numeros que usted escribió:");
    for (int n = 0; n < listanum.Length; n++)
    {
        Console.WriteLine(listanum[n]);
    }
}
catch(FormatException)
{
    Console.WriteLine("No se permite caracteres");
}
catch(OverflowException)
{
    Console.WriteLine("No exagere con el tamaño del número pibe");
}
    



Console.WriteLine("");
Console.WriteLine("-----Ejercicio 2-----");
Console.WriteLine("");
Console.WriteLine("Ingrese una fruta y veremos si esta en la lista");

string fruta = Console.ReadLine();

if (contieneEspeciales)
{
    Console.WriteLine("no se permite caracteres especiales");
}
else if(noContieneNumeros)
{
    Console.WriteLine("no se permite números");
}
else if (!contieneEspeciales && !noContieneNumeros)
{
    bool encontrado = false;

    string[] listafrutas = { "manzana", "pera", "durazno", "papaya", "fruta del dragon" };

    for (int m = 0; m < listafrutas.Length; m++)
    {
        if (listafrutas[m] == fruta)
        {
            Console.WriteLine("La fruta " + fruta + " fue encontrada en el índice " + m);
            encontrado = true;
        }
    }
    if (!encontrado)
    {
        Console.WriteLine("La fruta " + fruta + " no está en la lista");
    }
}




Console.WriteLine("");
Console.WriteLine("-----Ejercicio 3-----");
Console.WriteLine("");
Console.WriteLine("Ingrese 10 notas de distintos alumnos");

string[] estudiante = { "Leonel", "Matias", "Pepe", "Cesar", "Cucurrella", "Joaquin", "Astor", "Ponte", "Messi", "Queque" };
float[] notas = new float[10];
float suma = 0;
double prom;
try
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine("Estudiante: " + estudiante[i]);
        Console.Write("Nota: ");
        notas[i] = Convert.ToSingle(Console.ReadLine());
        suma += notas[i];
    }

    prom = (double)suma / notas.Length;
    Console.WriteLine("La suma de todas las notas del curso es: " + suma + " y el promedio en general es de: " + prom);
}
catch (FormatException)
{
    Console.WriteLine("No se permite caracteres");
}
catch (OverflowException)
{
    Console.WriteLine("No exagere con la nota");
}




Console.WriteLine("");
Console.WriteLine("-----Ejercicio 4-----");
Console.WriteLine("");
Console.WriteLine("Lista de temperaturas:");

float[] temperaturas = {26.3f, 25.6f, -10.2f, 34f, 14f, 25f, 9f, 28f, -2f, -7.5f};
float maxima = temperaturas[0];
float minima = temperaturas[0];

for (int m = 0; m < temperaturas.Length; m++)
{
    Console.WriteLine(temperaturas[m]);
}

for (int p = 0; p < temperaturas.Length; p++)
{
    if (temperaturas[p] > maxima)
    {
        maxima = temperaturas[p];
    }
    if (temperaturas[p] < minima)
    {
        minima = temperaturas[p];
    }
}
Console.WriteLine("La temperatura máxima es: " + maxima);
Console.WriteLine("La temperatura mínima es: " + minima);




Console.WriteLine("");
Console.WriteLine("-----Ejercicio 5-----");
Console.WriteLine("");
Console.WriteLine("Lista de números desordenada");

int[] desorden = { 1, 5, 79, 85, 105, 34, 12, 4};

for (int d = 0; d < desorden.Length; d++)
{
    Console.WriteLine(desorden[d]);
}

Array.Sort(desorden);

Console.WriteLine("Lista de números ordenado");

for (int i = 0; i < desorden.Length ;i++)
{
    int orden = desorden[i];
    Console.WriteLine(orden);
}




Console.WriteLine("");
Console.WriteLine("-----Ejercicio 6-----");
Console.WriteLine("");
Console.WriteLine("Lista de 15 números");

int[] numeros = {10, 3, 5, 6, 9, 12, 54, 99, 27, 1, 33, 101, 256, 670, 24, 2};

Console.WriteLine("");
Console.WriteLine("Ahora veremos cuales son pares e impares");

int contadorPares = 0;
int contadorImpares = 0;

for (int d = 0; d < numeros.Length; d++)
{
    Console.WriteLine(numeros[d]);
}
foreach (int n in numeros)
{
    if(n % 2 == 0)
    {
        contadorPares++;
    }
    else
    {
        contadorImpares++;
    }
}
Console.WriteLine("");
Console.WriteLine("La cantidad de números pares son: " + contadorPares);
Console.WriteLine("La cantidad de números impares son: " + contadorImpares);
