// Ejercicio N°1
Console.WriteLine("Inserte un numero, luego se determinará si es primo o no:");
int num;
num = Convert.ToInt32(Console.ReadLine());

bool primo = true;

if (num <= 1)
{
    primo = false;
}

if (num == 2)
{
    primo = true;
}

if (num % 2 == 0)
{
    primo = false;
}

for (int i = 3; i < num; i++)
{
    if (num % i == 0)
    {
        primo = false;
        break;
    }
}

if (primo)
{
    Console.WriteLine("El número es primo");
}
else
{
    Console.WriteLine("El número no es primo");
}


//Ejercicio N°2
Console.WriteLine("");
Console.WriteLine("Ingrese un número, luego determinaremos su factorial");
int num2;
num2 = Convert.ToInt32(Console.ReadLine());
int acum = 1;

if (num2 <= 1)
{
    Console.WriteLine("No se permite números negativos, el número 0 o el número 1");
}
else
{
    for (int b = num2 -1; b >= 0; b--)
    {
        acum = acum * b;
        Console.WriteLine(acum);
    }
}

//Ejercicio 3
int Aux;
int Pt = 0;
int St = 1;
Console.WriteLine("");
Console.WriteLine("Ingrese un número para realizar la secuencia Fibonnaci:");
int num3;
num3 = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num3; i++)
{
    Console.WriteLine(Pt);
    Aux = Pt;
    Pt = St;
    St = Aux + St;
}

//Ejercicio 4

bool seguimos = true;

while (seguimos == true)
{
    Console.WriteLine("");
    Console.WriteLine("Inserte numeros del 1 al 3 que estan en la siguiente lista: ");
    Console.WriteLine("1 = Hola");
    Console.WriteLine("2 = Chau");
    Console.WriteLine("3 = Se termina el programa");
    Console.WriteLine("");
    int menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Console.WriteLine("");
            Console.WriteLine("Hola");
            Console.WriteLine("");
            break;
        case 2:
            Console.WriteLine("");
            Console.WriteLine("Chau");
            Console.WriteLine("");
            break;
        case 3:
            seguimos = false;
            Console.WriteLine("");
            Console.WriteLine("Se terminó el programa");
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("");
            Console.WriteLine("El numero no esta en la lista mencionada");
            Console.WriteLine("");
            break;
    }
}

