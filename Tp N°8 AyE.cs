//ejercicio 1
using System.Timers;

Console.WriteLine("Ingrese una frase");
string frase = Console.ReadLine();
string vocales = ("aeiouAEIOU");
int contador = 0;

foreach (char f in frase)
{
    foreach (char v in vocales)
    {
        if (f == v)
        {
            contador = contador + 1;
            break;
        }

    }
}
Console.WriteLine("La cantidad de vocales que tiene es: " + contador);


//ejercicio 2
Console.WriteLine("");
Console.WriteLine("Ingrese una palabra para invertirla:");
String palabra = Console.ReadLine();
String invertido = ""; 
foreach (char l in palabra)
{
    invertido = l + invertido;
}
Console.WriteLine("");
Console.WriteLine("La palabra invertida es: " + invertido);


//ejercicio 3
Console.WriteLine("");
Console.WriteLine("Ingrese un numero");
string texto = Console.ReadLine();
int aux = 0;
int aux2 = 0;

foreach (char n in texto)
{
    aux = Convert.ToInt32("" + n);
    aux2 = aux + aux2;
}
Console.WriteLine("");
Console.WriteLine("La suma de esos numero es: " + aux2);


//ejercicio 4
Console.WriteLine("");
Console.WriteLine("Ingrese un texto largo:");
string frase3 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese una frase prohibida");
string fraseprohibida = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese una frase para reemplazarla");
string frasereemplazo = Console.ReadLine();
string nuevafrase = "";
if (frase3.Contains(fraseprohibida) == true)
{
    nuevafrase = frase3.Replace(fraseprohibida, frasereemplazo);
}
Console.WriteLine("");
Console.WriteLine("Esta es la frase: " + nuevafrase);



//ejercicio 5
Console.WriteLine("");
Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese su apellido");
string apellido = Console.ReadLine();
string iniciales = "";
iniciales = nombre[0] + "." + apellido[0];
Console.WriteLine("");
Console.WriteLine("Su nombre es: " + nombre);
Console.WriteLine("");
Console.WriteLine("Su apellido es: " + apellido);
Console.WriteLine("");
Console.WriteLine("Sus iniciales son: " + iniciales);


//ejercicio 6
Console.WriteLine("");
Console.WriteLine("Ingrese una palabra para identificar si es un palindromo:");
String palindromo = Console.ReadLine();
palindromo = palindromo.ToLower();
String invertido2 = "";
foreach (char j in palindromo)
{
    invertido2 = j + invertido2;
}
if (palindromo == invertido2) 
{
    Console.WriteLine("");
    Console.WriteLine("La palabra '" + palindromo + "' es un palindromo");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("La palabra '" + palindromo + "' NO es un palindromo");
}
