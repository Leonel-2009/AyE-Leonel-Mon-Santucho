Console.WriteLine("programa N°4");
Console.WriteLine("");
Console.WriteLine("-----BALATRO-----");

int cantidad;
int carta_descartada;
string palo, numero;
bool cartas_repartidas = false;
bool seguimos = true;

Random random = new Random();

string[] palos = ["Picas", "Corazones", "Treboles", "Diamantes"];
string[] numeros = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"];

string[] carta1 = new string[2];
string[] carta2 = new string[2];
string[] carta3 = new string[2];
string[] carta4 = new string[2];
string[] carta5 = new string[2];
string[] carta6 = new string[2];
string[] carta7 = new string[2];
string[] carta8 = new string[2];

while (seguimos)
{
    Console.WriteLine("Elija una opción:");
    Console.WriteLine("");
    Console.WriteLine("1- Pedir cartas");
    Console.WriteLine("2- Descartar cartas");
    Console.WriteLine("3- Salir");

    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            pedir_cartas();
            cartas_repartidas = true;
            Console.WriteLine("");
            Console.WriteLine("Tus cartas:");
            Console.WriteLine("");
            mostrar_cartas();
            break;

        case 2:
            if (cartas_repartidas)
            {
                descartar();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Primero debes pedir cartas");
            }
            break;

        case 3:
            Console.WriteLine("Saliendo del programa...");
            Console.WriteLine("Fin del juego");
            seguimos = false;
            break;

        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }
}

void pedir_cartas()
{
    palo = palos[random.Next(0, 4)];
    numero = numeros[random.Next(0, 13)];
    carta1 = [palo, numero];

    palo = palos[random.Next(0, 4)];
    numero = numeros[random.Next(0, 13)];
    carta2 = [palo, numero];

    palo = palos[random.Next(0, 4)];
    numero = numeros[random.Next(0, 13)];
    carta3 = [palo, numero];

    palo = palos[random.Next(0, 4)];
    numero = numeros[random.Next(0, 13)];
    carta4 = [palo, numero];

    palo = palos[random.Next(0, 4)];
    numero = numeros[random.Next(0, 13)];
    carta5 = [palo, numero];

    palo = palos[random.Next(0, 4)];
    numero = numeros[random.Next(0, 13)];
    carta6 = [palo, numero];

    palo = palos[random.Next(0, 4)];
    numero = numeros[random.Next(0, 13)];
    carta7 = [palo, numero];

    palo = palos[random.Next(0, 4)];
    numero = numeros[random.Next(0, 13)];
    carta8 = [palo, numero];
}

void descartar()
{
    Console.WriteLine("");
    Console.WriteLine("¿Cuantas cartas quiere descartar?");
    cantidad = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese el numero de carta a descartar");
        carta_descartada = Convert.ToInt32(Console.ReadLine());

        palo = palos[random.Next(0, 4)];
        numero = numeros[random.Next(0, 13)];

        switch (carta_descartada)
        {
            case 1:
                carta1 = [palo, numero];
                break;
            case 2:
                carta2 = [palo, numero];
                break;
            case 3:
                carta3 = [palo, numero];
                break;
            case 4:
                carta4 = [palo, numero];
                break;
            case 5:
                carta5 = [palo, numero];
                break;
            case 6:
                carta6 = [palo, numero];
                break;
            case 7:
                carta7 = [palo, numero];
                break;
            case 8:
                carta8 = [palo, numero];
                break;
            default:
                Console.WriteLine("Error, no se encontro esa carta");
                break;
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Cartas actualizadas:");
    Console.WriteLine("");
    mostrar_cartas();
}

void mostrar_cartas()
{
    Console.WriteLine($"{carta1[1]} de {carta1[0]}");
    Console.WriteLine($"{carta2[1]} de {carta2[0]}");
    Console.WriteLine($"{carta3[1]} de {carta3[0]}");
    Console.WriteLine($"{carta4[1]} de {carta4[0]}");
    Console.WriteLine($"{carta5[1]} de {carta5[0]}");
    Console.WriteLine($"{carta6[1]} de {carta6[0]}");
    Console.WriteLine($"{carta7[1]} de {carta7[0]}");
    Console.WriteLine($"{carta8[1]} de {carta8[0]}");
}
