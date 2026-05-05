string numcomp = "1234567890";

Console.WriteLine("Calculadora de factoriales con intentos limitados");

//funcion 1(Colado)
int Colador()
{
    bool valido = false;
    string num = "";
    int intentos = 3;

    while (!valido && intentos > 0)
    {
        Console.WriteLine("");
        Console.WriteLine("Inserte un numero entero para calcular su factorial:");
        num = Console.ReadLine();
        bool error = false;

        for (int j = 0; j < num.Length; j++)
        {
            char caracter = num[j];
            bool encontrado = false;

            for (int x = 0; x < numcomp.Length; x++)
            {
                if (caracter == numcomp[x])
                {
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                error = true;
                break;
            }
        }

        if (error)
        {
            intentos--;
            Console.WriteLine("Usted insertó un caracter inválido.");

            if (intentos > 0)
            {
                Console.WriteLine("Te quedan " + intentos + " intentos.");
            }
            else
            {
                Console.WriteLine("Usted se a quedado sin intentos");
            }
        }
        else
        {
            valido = true;
        }
    }


    return Convert.ToInt32(num);
}

int num = Colador();
//funcion 2 (factorial)
int factorial(int num)
{
    int resultado = 1;

    for (int i = 1; i <= num; i++)
    {
        resultado *= i;
    }

    return resultado;
}
Console.WriteLine("El factorial de " + num + " es:");
Console.WriteLine(factorial(num));