//Ejercicio N°1
Console.WriteLine("ingrese la contraseña");
string a;
a = Console.ReadLine();

while (a != "BocaJr2000")
{
    Console.WriteLine("");
    Console.WriteLine("Intentelo de nuevo");
    a = Console.ReadLine();
}
Console.WriteLine("");
Console.WriteLine("Entrando...");


//Ejercicio N°2
Console.WriteLine("");
Console.WriteLine("Preparandose para el despegue:");
int b;

for(b=1; b<=5; b++)
{
    Console.WriteLine(b);
}
Console.WriteLine("");
Console.WriteLine("Listo para despegar bro");
Console.WriteLine("");
Console.WriteLine("¡Hasta la vista!");

//Ejercicio N°3
Console.WriteLine(""); 
Console.WriteLine("Adivina el numero");
int c = Convert.ToInt32(Console.ReadLine());
while (c != 26)
{
    Console.WriteLine("incorrecto, inserte otro número:");
    c = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Adivinaste bro");

//Ejercicio N°4

Console.WriteLine("");
Console.WriteLine("Escriba algunos números para sumarlos");
Console.WriteLine("Si quiere terminar el proceso, escriba el número 0");

int d = 0;
int e = Convert.ToInt32(Console.ReadLine());

while (e != 0)
{
    d = d + e;
    e = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("");
Console.WriteLine("La suma de todos lso numeros que escribio es:");
Console.WriteLine(d);