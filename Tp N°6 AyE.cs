//Funciones
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


//Ejercicio
Console.WriteLine("Inserte numeros del 1 al 5 para efectuar ejercicios del tp3 los ejercicios son:");
Console.WriteLine("1 = Numero positivo?");
Console.WriteLine("2 = Mayor de edad?");
Console.WriteLine("3 = Contraseña secreta");
Console.WriteLine("4 = Par o Impar?");
Console.WriteLine("5 =Entrada gratis?");
Console.WriteLine("0 = Cierre de programa");
Console.WriteLine("");
bool seguimos = true;

while (seguimos == true)
{
    int menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Console.WriteLine("");
            Console.WriteLine("Inserte un numero para determinar si es positivo o negativo:");
            Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("");
            break;
        case 2:
            Console.WriteLine("");
            Console.WriteLine("Ingrese su edad:");
            Console.WriteLine(ejercicio2(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("");
            break;
        case 3:
            Console.WriteLine("");
            Console.WriteLine("Inserte la contraseña:");
            Console.WriteLine(ejercicio3(Convert.ToString(Console.ReadLine())));
            Console.WriteLine("");
            break;
        case 4:
            Console.WriteLine("");
            Console.WriteLine("Inserte un número para determinar si es par o impar");
            Console.WriteLine(ejercicio4(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("");
            break;
        case 5:
            Console.WriteLine("");
            Console.WriteLine("Ingrese su edad:");
            int Ej5_Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¡Usted compró pochoclos?");
            string Ej5_Compro = Console.ReadLine();
            Console.WriteLine(ejercicio5( Ej5_Edad, Ej5_Compro));
            Console.WriteLine("");
            break;
        case 0:
            seguimos = false;
            break;
        default:
            Console.WriteLine("");
            Console.WriteLine("El numero no esta en la lista mencionada");
            Console.WriteLine("");
            break;
    }
}