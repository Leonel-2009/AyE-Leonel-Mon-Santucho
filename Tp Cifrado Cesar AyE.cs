Console.WriteLine("Cifrado Cesar");
Console.WriteLine("Elija alguna de estas funciones sobre el Cifrado Cesar: ");
Console.WriteLine("1: Cifrado           2: Descifrado         0: Cerrar Programa");
Console.WriteLine("");

int menu = Convert.ToInt32(Console.ReadLine());

switch (menu)
{
    case 1:
        string mensaje = funcion1();
        Console.WriteLine("Ingrese la clave:");
        int clave = Convert.ToInt32(Console.ReadLine());
        string resultado = Cifrado(mensaje, clave);
        Console.WriteLine("El mensaje cifrado es: " + resultado);
        break;

    case 2:
        string mensaje2 = funcion1();
        Console.WriteLine("Ingrese la clave:");
        int clave2 = Convert.ToInt32(Console.ReadLine());
        string resultado2 = Descifrado(mensaje2, clave2);
        Console.WriteLine("El mensaje descifrado es: " + resultado2);
        break;

    case 0:
        Console.WriteLine("Fin del programa");
        break;
    default:
        Console.WriteLine("Opcion no permitida");
        break;
}

// Función 1
string funcion1()
{

    string mensaje = "";
    bool Valido = false;

    while (!Valido)
    {
        Console.WriteLine("");
        Console.WriteLine("Escribe el mensaje");
        mensaje = Console.ReadLine();
        mensaje = mensaje.ToLower();
        string permitidos = "abcdefghijklmnopqrstuvwxyz ";

        bool Error = false;

        for (int i = 0; i < mensaje.Length; i++)
        {
            char caracterUsuario = mensaje[i];
            bool encontrado = false;

            for (int j = 0; j < permitidos.Length; j++)
            {
                if (caracterUsuario == permitidos[j])
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Error = true;
                break;
            }
        }

        if (Error)
        {
            Console.WriteLine("El mensaje contiene caracteres que no estan permitidos");
        }
        else
        {
            Valido = true;
        }


    }
    return mensaje;
}

// Función 2: Cifrado

string Cifrado(string texto, int clave)
{
    string abc = "abcdefghijklmnopqrstuvwxyz";
    string textocifrado = "";
    int aux;
    int movimiento;

    for (int x = 0; x < texto.Length; x++)
    {

        for (int i = 0; i < abc.Length; i++)
        {

            if (texto[x] == ' ')
            {
                textocifrado += " ";
                break;
            }

            if (abc[i] == texto[x])
            {
                if (i + clave > 26)
                {
                    aux = 0;
                    movimiento = aux + (clave - 1);
                    textocifrado += abc[aux + movimiento];
                }
                else
                {
                    movimiento = clave;
                    textocifrado += abc[i + movimiento];
                }
            }

        }

    }

    return textocifrado;
}


//Función 2: Descifrado

string Descifrado(string texto, int clave)
{
    string abc = "abcdefghijklmnopqrstuvwxyz";
    string textodescifrado = "";
    int aux;
    int movimiento;

    for (int x = 0; x < texto.Length; x++)
    {

        for (int i = 0; i < abc.Length; i++)
        {

            if (texto[x] == ' ')
            {
                textodescifrado += " ";
                break;
            }

            if (abc[i] == texto[x])
            {
                if (i - clave < 0)
                {
                    aux = 26;
                    movimiento = aux - (clave - 1);
                    textodescifrado += abc[movimiento];
                }
                else
                {
                    movimiento = clave;
                    textodescifrado += abc[i - movimiento];
                }
            }

        }

    }

    return textodescifrado;
}