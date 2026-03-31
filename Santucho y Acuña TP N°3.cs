// Ejercicio 1: Numero positivo?
Console.WriteLine("Ingrese un número para identificar si es positivo o negativo");
string ejercicio1(int n)
{
    string resultado;
    if (n > 0)
    {
        resultado = ("el número es positivo");
        return resultado;

    }
    else if (n < 0)
    {

        resultado = ("el número es negativo");
        return resultado;
    }
    else
    {
        resultado = ("el número es 0");
        return resultado;
    }

}

int n = Convert.ToInt32(Console.ReadLine());
string resultado = ejercicio1(n);
Console.WriteLine(resultado);


// Ejercicio 2: Mayor de edad?
Console.WriteLine("");
Console.WriteLine("Digame su edad porfavore, es para saber si podeis entrar a la discopary");
string ejercicio2(int edad)
{
    string resultado2;
    if (edad >= 18)
    {
        resultado2 = ("Bienvenido a la discopary mi broda");
        return resultado2;
    }
    else
    {
        resultado2 = ("No puede entrar, retirese por favor");
        return resultado2;
    }
}

int edad = Convert.ToInt32(Console.ReadLine());
string resultado2 = ejercicio2(edad);
Console.WriteLine(resultado2);


// Ejercicio 3: Contraseña secreta
Console.WriteLine("");
Console.WriteLine("Ingrese la contraseña secreta secretiña");

string ejercicio3(string contraseña)
{
    string resultado3;
    if (contraseña == "python123")
    {
        resultado3 = ("¡Contraseña correcta! Acceso concedido.");
        return resultado3;
    }
    else
    {
        resultado3 = ("¡Contraseña incorrecta, Autodestrucción en 5 minutos!");
        return resultado3;
    }
}

string contraseña = Convert.ToString(Console.ReadLine());
string resultado3 = ejercicio3(contraseña);
Console.WriteLine(resultado3);


// Ejercicio 4: Par o Impar?
Console.WriteLine("");
Console.WriteLine("Ingrese un número para identificar si es par o impar");

string ejercicio4(int a)
{
    string resultado4;
    if (a % 2 == 0)
    {
        resultado4 = ("El numero es par");
        return resultado4;
    }
    else
    {
        resultado4 = ("El numero es impar");
        return resultado4;
    }
}
int a = Convert.ToInt32(Console.ReadLine());
string resultado4 = ejercicio4(a);
Console.WriteLine(resultado4);


// Ejercicio 5: Entrada gratis?

Console.WriteLine("");
Console.WriteLine("Saludos caballero, hoy ofrecemos entradas gratis para el cine");
Console.WriteLine("Por favor, ingrese su edad");

string ejercicio5(int edad2, string respuesta)
{
    string resultado5;
    if (edad2 >= 65 && respuesta == "si")
    {
        resultado5 = ("Cumple con los requisitos, tenga su entrada gratuita");
        return resultado5;
    }
    else
    {
        resultado5 = ("Usted no cumple con los requisitos para la entrada gratuita");
        return resultado5;
    }
}
int edad2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Usted compró palomitas?");
string respuesta = Convert.ToString(Console.ReadLine());
string resultado5 = ejercicio5(edad2, respuesta);
Console.WriteLine(resultado5);