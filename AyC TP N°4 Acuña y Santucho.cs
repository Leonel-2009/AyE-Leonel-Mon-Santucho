// Ejercicio 1

Console.WriteLine("A continuacion una lista de numeros del 1 al 10:");
for (int x = 1; x <= 10; x++)
{
    Console.WriteLine(x);
}

// Ejercicio 2
Console.WriteLine("");
Console.WriteLine("'¡Hola, mundo!' pero por 5 veces");

for (int cont = 0; cont <= 5; cont++)
{
    Console.WriteLine("¡Hola, mundo!");
}

//Ejercicio 3
Console.WriteLine(""); 
Console.WriteLine("Numeros pares del 2 al 20");

for (int A = 2; A <= 20; A+=2)
{
    Console.WriteLine(A);
}

//Ejercicio 4
Console.WriteLine("");
Console.WriteLine("Tabla del 7:");

for (int B = 1; B <= 10; B++)
{
   int res = B*7;
    Console.WriteLine(res);
}

// Ejercicio 5
Console.WriteLine("");
Console.WriteLine("A continuacion se presentan numeros del 1 al 5 que se suman entre si , es decir (1+2+3+4+5)");
int acum = 0;
for (int C = 1; C <= 5; C++)
{
    acum = acum + C;
    Console.WriteLine(acum);
}