using System.Diagnostics.CodeAnalysis;
//Bloque 5

//Ejercicio 1
void Contraseña()
{
    Console.WriteLine("Ingrese la contraseña");
    string contraseña = Console.ReadLine();
   
    if (contraseña == "veggeta777")
    {
        Console.WriteLine("Entrando al sistema");
    }
    else
    {
        Console.WriteLine("Incorrecto, intentelo de vuelta");
        Contraseña();
    }
}
Contraseña();


//Ejercicio 2
bool recursiva(int N)
{
    if (N == 6)
    {
        return false;
    }
    else
    {
        recursiva(N + 1);
        Console.WriteLine(N);
        return true;
    }
}
Console.WriteLine("");
Console.WriteLine("Cuenta regresiva");
recursiva(1);
Console.WriteLine("Despegueeeee");


//Ejercicio 3
void NumSecreto()
{
    try
    { 
        Console.WriteLine("");
        Console.WriteLine("tiene que adivinar el número secreto");
        Console.WriteLine("Ingrese el número");

        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 19)
        {
            Console.WriteLine("¡Adivinaste! :D");
        }
        else
        {
            Console.WriteLine("Incorrecto, intentelo de vuelta");
            NumSecreto();
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Lo que ingresó no es valido en este ejercicio");
    }
    catch (OverflowException)
    {
        Console.WriteLine("El número supera el limite chistoso");
    }
}
NumSecreto();


//Ejercicio 4
void Sumas()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese varios números, luego los sumaremos entre sí");

        int num = Convert.ToInt32(Console.ReadLine());
        int contador = num;

        while (num > 0)
        {
            num = Convert.ToInt32(Console.ReadLine());
            contador = contador + num;
        }
        Console.WriteLine("");
        Console.WriteLine("La suma de todos los números es: " + contador);
    }
    catch (FormatException)
    {
        Console.WriteLine("El caracter es invalido en este ejercicio");
    }
    catch (OverflowException)
    {
        Console.WriteLine("El número supera el limite chistoso");
    }
}
Sumas();