Console.WriteLine("----TA TE TI----");
Console.WriteLine("Les presentamos a TA TE TI (version Alpha)");
Console.Write("Ingrese nombre del jugador N°1: ");
Console.WriteLine("");

string Jugador = Console.ReadLine();
string x = "x";

Console.WriteLine("");
Console.Write("Ingrese nombre del jugadr N°2: ");
Console.WriteLine("");

string Jugador2 = Console.ReadLine();
string o = "o";

string[] jugadores = [Jugador, Jugador2];

Random eleccion = new Random();

int inicio = eleccion.Next(0, jugadores.Length);

string[,] matriz =
{
    {"1" , "2" , "3"},
    {"4" , "5" , "6"},
    {"7" , "8" , "9"}
};

Console.WriteLine("");
Console.WriteLine($"El jugador {jugadores[inicio]} empieza la ronda con X");
Console.WriteLine($"El jugador {(jugadores[1 - inicio])} seguira con O");
Console.WriteLine("");
Console.WriteLine("Tablero del TATETI:");
Console.WriteLine("");

tablero();
juego();

void juego()
{
    int turno = 1;

    while (turno <= 9)
    {
        if (turno % 2 == 1)
        {
            jugador1();

           if (verificar_ganador(x))
            {
                ganador();
                break;
            }
        }
        else if (turno % 2 == 0)
        {
            jugador2();

            if (verificar_ganador(o))
            {
                ganador();
                break;
            }
        }
        turno++;
    }
    if (turno > 9)
    {
        Console.WriteLine("La partida quedó en empate :DD");
    }
}

void tablero()
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($" {matriz[i, 0]} | {matriz[i, 1]} | {matriz[i, 2]}");

        if (i < 2)
        {
            Console.WriteLine("---|---|---");
        }
    }
}

void jugador1()
{
    bool condicion = false;

    while (!condicion)
    {
        Console.WriteLine($"Ingrese la posición donde ira la x el jugador {jugadores[inicio]}");

        string posicion = Console.ReadLine();

        if (posicion.All(char.IsLetter))
        {
            Console.WriteLine("No se permiten letras o caracteres especiales, intentelo de nuevo");
        }
        else
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (matriz[f, c] == posicion)
                    {
                        condicion = true;
                        matriz[f, c] = x;
                    }
                }
            }

            if (!condicion)
            {
                Console.WriteLine("Posición ocupada, intentelo de nuevo");
            }
        }
    }
    tablero();
}

void jugador2()
{
    bool condicion = false;

    while (!condicion)
    {
        Console.WriteLine($"Ingrese la posición donde ira la o el jugador {(jugadores[1 - inicio])}");

        string posicion = Console.ReadLine();

        if (posicion.All(char.IsLetter))
        {
            Console.WriteLine("No se permiten letras o caracteres especiales, intentelo de nuevo");
        }
        else
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (matriz[f, c] == posicion)
                    {
                        condicion = true;
                        matriz[f, c] = o;
                    }
                }
            }

            if (!condicion)
            {
                Console.WriteLine("Posición ocupada, intentelo de nuevo");
            }
        }
    }
    tablero();
}
bool verificar_ganador(string verificar)
{
    for (int i = 0; i < 3; i++)
    {
        if (matriz[0,i] == verificar && matriz[1,i] == verificar && matriz[2,i] == verificar)
        {
            return true;
        }
    }

    for (int i = 0; i < 3; i++)
    {
        if (matriz[i, 0] == verificar && matriz[i, 1] == verificar && matriz[i, 2] == verificar)
        {
            return true;
        }
    }

    if (matriz[0, 0] == verificar && matriz[1, 1] == verificar && matriz[2, 2] == verificar)
    {
        return true;
    }

    if (matriz[0, 2] == verificar && matriz[1, 1] == verificar && matriz[2, 0] == verificar)
    {
        return true;
    }

    return false;
}

void ganador()
{
    if (verificar_ganador(x))
    {
        Console.WriteLine($"El jugador {jugadores[inicio]} ganó la partida :DDD");
    }
    else if (verificar_ganador(o))
    {
        Console.WriteLine($"El jugador {(jugadores[1 - inicio])} ganó la partida :DD");
    }
}