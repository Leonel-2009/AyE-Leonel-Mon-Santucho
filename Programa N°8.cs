using System.ComponentModel.Design;

Console.WriteLine("Programa N°8:");
Console.WriteLine("");
Console.WriteLine("-----BALATRO-----");
Console.WriteLine("Version Alpha xd");

string[,] mazo = { { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" } };
string[] palo = ["Diamante", "Picas", "Treboles", "Corazones"];
string[,] mano = new string[8, 2];
Random aleatorio = new Random();
int menu;
bool pedirCarta = false;

try
{
    do
    {
        Console.WriteLine("");
        Console.WriteLine("Elija una opción:");
        Console.WriteLine("1-Pedir cartas"); Console.WriteLine("2-Descartar cartas"); Console.WriteLine("3-Salir programa");
        Console.WriteLine("");

        menu = Convert.ToInt32(Console.ReadLine());

        switch (menu)
        {
            case 1:
                Pedir_carta();
                break;
            case 2:
                Descartar_carta();
                break;
            case 3:
                Console.WriteLine("Saliendo del programa");
                Console.WriteLine("Goodbye ;]");
                break;
            default:
                Console.WriteLine("Opcion incorreta, intente de nuevo");
                break;
        }
    } while (menu != 3);
}
catch (FormatException)
{
    Console.WriteLine("Formato incorrecto, escriba números");
}
void Pedir_carta()
{
    pedirCarta = true;
    for (int f = 0; f < mano.GetLength(0); f++)
    {
        int columna = aleatorio.Next(mazo.GetLength(1));

        mano[f, 0] = mazo[0, columna];
        mano[f, 1] = palo[aleatorio.Next(palo.Length)];
    }
    Console.WriteLine("");
    Console.WriteLine("Tus cartas: ");
    Mostrar_carta();
    Console.Write("");
}
void Mostrar_carta()
{
    for (int f = 0; f < mano.GetLength(0); f++)
    {
        Console.WriteLine($"{mano[f, 0]} de {mano[f, 1]}");
    }
}
void Descartar_carta()
{
    try
    {
        if (!pedirCarta)
        {
            Console.WriteLine("");
            Console.WriteLine("No hay ninguna mano para intercambiar cartas, pida primero cartas para realizar esta acción");
        }
        else 
        {
            Console.Write("¿Cuántas cartas deseas descartar?: ");

            int descarte = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < descarte; i++)
            {
                Console.Write($"Ingrese la posición de la carta a descartar {i + 1} (0-7): ");
                int pos = Convert.ToInt32(Console.ReadLine());

                while (pos < 0 || pos >= mano.GetLength(0))
                {
                    Console.Write("Posición inválida, intente de nuevo: ");
                    pos = Convert.ToInt32(Console.ReadLine());
                }

                int columna = aleatorio.Next(mazo.GetLength(1));

                mano[pos, 0] = mazo[0, columna];
                mano[pos, 1] = palo[aleatorio.Next(palo.Length)];
            }

            Console.WriteLine("\nMano actualizada:");
            Console.Write("");
            Mostrar_carta();
            Console.Write("");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permiten letras, caracteres especiales, etc.");
    }
}
