Console.WriteLine("-----BUSCADOR DE TESOROS-----");
Console.WriteLine("Le presentamos el buscador de tesoros (Version Alpha), a continuacion un par de reglas a seguir:");
Console.WriteLine("Reglas:");
Console.WriteLine("-Tiene que escribir las coordenadas para determinar si el tesoro se encuentra en esa ubicación");
Console.WriteLine("-Tiene un total de 5 intentos, si las pierde a todas, finaliza el juego. Si encuentra un tesoro, se reinician sus intentos");
Console.WriteLine("-No se permiten caracteres especiales, letras o espacios en blanco");
Console.WriteLine("-Solo se aceptan números entre los rangos 0 y 9");
Console.WriteLine("");
Console.WriteLine("Tamaño del mapa de busqueda: 10x10");

string[,] matriz = new string[10, 10];
bool[,] intentado = new bool[10, 10];
Random random = new Random();

int intentos = 5;
int tesorosDescubiertos = 0;
int colocados = 0;

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        matriz[i, j] = "No encontrado";
    }
}

while (colocados < 3)
{
    int x = random.Next(0, 10);
    int y = random.Next(0, 10);

    if (matriz[x, y] != "Tesoro encontrado")
    {
        matriz[x, y] = "Tesoro encontrado";
        colocados++;
    }
}

void MostrarMapa(bool mostrarTesoros = false)
{
    Console.WriteLine("");
    Console.WriteLine("Referencias: E = Encontrado, X = Intento fallido, . = Casilla sin explorar");
    Console.WriteLine("");

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            string c;
            
            if (matriz[i, j] == "Encontrado")
            {
                c = "E";
            }
            else if (intentado[i, j])
            {
                c = "X";
            }
            else if (mostrarTesoros && matriz[i, j] == "Tesoro")
            {
                c = "T";
            }
            else
            {
                c = ".";
            }

            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

while (intentos > 0 && tesorosDescubiertos < 3)
{
    MostrarMapa();
    Console.WriteLine($"Tesoros Descubiertos: {tesorosDescubiertos}/3 || intentos: {intentos}");
    Console.WriteLine("Ingrese la coordenada x: "); string X = Console.ReadLine();
    Console.WriteLine("Ingrese la coordenada y: "); string Y = Console.ReadLine();

    int x;
    int y;

    if (string.IsNullOrWhiteSpace(X) || string.IsNullOrWhiteSpace(Y))
    {
        Console.WriteLine("Las coordenadas son incorrectas, no se permiten espacios en blanco");
        continue;
    }

    if (!int.TryParse(X, out x) || !int.TryParse(Y, out y))
    {
        Console.WriteLine("Las coordenadas son incorrectas, intentelo de nuevo");
        continue;
    }
    else if (intentado[x, y])
    {
        Console.WriteLine("Ya has intentado esta casilla.");
        continue;
    }
    
    intentado[x, y] = true;
    string estado = matriz[x, y];

    if (estado == "Tesoro")
    {
        Console.WriteLine("¡Un tesoro fue encontrado!");
        matriz[x, y] = "Encontrado";
        tesorosDescubiertos++;
        intentos = 5;
    }
    else
    {
        Console.WriteLine("Tesoro no encontrado :(");
        intentos--;
    }
    Console.WriteLine();
}
if (tesorosDescubiertos == 3)
{
    Console.WriteLine("¡¡¡¡¡ Hurraaaa ganaste el juego, encontraste todos los tesoros :DDD !!!!! ");
}
else
{
    Console.WriteLine("Lo lamento, perdiste el juego. Pero no te rindas, podras ganar la proxima :D");
}
Console.WriteLine();
Console.WriteLine("Mapa (T = Tesoro no encontrado, E = Encontrado, . = Casilla sin explorar):");
MostrarMapa(mostrarTesoros: true);
