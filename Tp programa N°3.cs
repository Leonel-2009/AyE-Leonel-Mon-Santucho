try
{
    Console.WriteLine("-----AHORCADO-----");
    Console.WriteLine("Elija alguna de estas opciones:");
    Console.WriteLine("Juego 1");
    Console.WriteLine("Juego 2");
    Console.WriteLine("Juego 3 (dificil)");
    Console.WriteLine("Juego 4 (dificil)");
    Console.WriteLine("Juego 5");
    Console.WriteLine("Opcion 0: Salir del programa");
    Console.WriteLine("");

    int menu = Convert.ToInt32(Console.ReadLine());
    string palabra = "";
    bool seguimos = true;

    switch (menu)
    {
        case 1:
            palabra = "chocolate";
            ahorcado(palabra);
            break;
        case 2:
            palabra = "algoritmos";
            ahorcado(palabra);
            break;
        case 3:
            palabra = "externocleidoxippitomastoideo ";
            ahorcado(palabra);
            break;
        case 4:
            palabra = "electroencefalografista";
            ahorcado(palabra);
            break;
        case 5:
            palabra = "tecnica";
            ahorcado(palabra);
            break;
        case 0:
            Console.WriteLine("Cerrando programa");
            seguimos = false;
            break;
        default:
            Console.WriteLine("");
            Console.WriteLine("Usted eligió una opción no valida");
            Console.WriteLine("");
        break;
    }   

    void ahorcado(string palabra)
    {
        char letra;
        int intentos = 7;
        bool ganaste = false;
        string seguimiento = "";

        for (int i = 0; i < palabra.Length; i++)
        {
            seguimiento += "_";
        }

        while (intentos > 0 && !ganaste)
        {
            Console.WriteLine("");
            Console.WriteLine("La palabra a adivinar es: " + seguimiento);
            Console.WriteLine("Intentos: " + intentos);
            Console.WriteLine("Ingrese una letra:");
            Console.WriteLine("");
            letra = Convert.ToChar(Console.ReadLine().ToLower());

            if (!char.IsLetter(letra))
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese solo letras");
                continue;
            }

            bool encontrado = false;
            string nuevo = "";

            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == letra)
                {
                    nuevo += letra;
                    encontrado = true;
                }
                else
                {
                    nuevo += seguimiento[i];
                }
            }

            seguimiento = nuevo;

            if (encontrado)
            {
                Console.WriteLine("");
                Console.WriteLine("Letra encontrada :)");
            }
            else
            {
                intentos--;
                Console.WriteLine("");
                Console.WriteLine("Letra incorrecta");
            }

            if (seguimiento == palabra)
            {
                ganaste = true;
            }


            if (ganaste)
            {
                Console.WriteLine("");
                Console.WriteLine("Acertaste, la palabra correcta es: " + palabra);
            }
             else if (intentos == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Perdiste, la palabra correcta es: " + palabra);
            }
        }
    } 
}
catch (System.FormatException)
{
    Console.WriteLine("");
    Console.WriteLine("el caracter no es valido, chistoso");
}



