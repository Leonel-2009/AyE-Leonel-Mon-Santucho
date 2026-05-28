Console.WriteLine("------Ejercicio 1------");
Console.WriteLine("");
Console.WriteLine("Lista de nombres");
Console.WriteLine("");

string[] nombres = {"Leonel", "Joaquin", "Elias", "Nicolas", "Maximiliano", "Pepe", "Ramiro", "Kevin", "Santiago", "Cielo", "Venelope", "Patricia"};
string nombre_largo = nombres[0];

for(int m = 0; m < nombres.Length; m++)
{
    Console.WriteLine(nombres[m]);
}

Console.WriteLine("");

for (int i = 0; i < nombres.Length; i++)
{
    if (nombres[i].Length > nombre_largo.Length) 
    {
        nombre_largo = nombres[i];
    }
}

Console.WriteLine("El nombre con más caracteres es: " + nombre_largo);

Console.WriteLine("");
Console.WriteLine("------Ejercicio 2------");
Console.WriteLine("");
Console.WriteLine("Lista de nombres");
Console.WriteLine("");

string[] nombres2 = {"Leonel", "Joaquin", "Elias", "Nicolas", "Maximiliano", "Pepe", "Ramiro", "Kevin", "Santiago", "Cielo", "Venelope", "Patricia"};
string vocales = "aeiouAEIOU";

for (int m = 0; m < nombres2.Length; m++)
{
    Console.WriteLine(nombres2[m]);
}

Console.WriteLine("");

int contador = 0;

for(int n = 0; n < nombres2.Length; n++)
{
    for (int p = 0; p < nombres2[n].Length; p++)
    {
        for (int v = 0; v < vocales.Length; v++)
        {
            if (nombres2[n][p] == vocales[v])
            {
                contador = contador + 1;
            }
        }
    }
}

Console.WriteLine("La cantidad de vocales que hay en la lista es: " + contador);

Console.WriteLine("");
Console.WriteLine("------Ejercicio 3------");
Console.WriteLine("");
Console.WriteLine("Lista de números");

int[] numeros = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
int factor = 6;

for (int w = 0; w < numeros.Length; w++)
{
    Console.WriteLine(numeros[w]);
}

Console.WriteLine("");
Console.WriteLine("ahora se multiplica por la factorial determinada (6):");
Console.WriteLine("");

for (int q = 0; q < numeros.Length; q++) 
{
   int resultado = numeros[q] * factor;
   Console.WriteLine(numeros[q] + " X " + factor + " = " + resultado);
}