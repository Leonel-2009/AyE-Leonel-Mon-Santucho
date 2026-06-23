ejercicio1();
ejercicio2();

void ejercicio1()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°1");
    Console.WriteLine("");
    Console.WriteLine("----Torneo Pokemon----");
    Console.WriteLine("");

    string[,] red = new string[6, 3];
    string[,] green = new string[6, 3];
    string[,] blue = new string[6, 3];
    string[,] yellow = new string[6, 3];

    string[,] equipos(string[,] equipo)
    {
        string[] pokedex = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
        string[] tipo = { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" };
        Random aleatorio = new Random();

        for (int f = 0; f < equipo.GetLength(0); f++)
        {
            int pos = aleatorio.Next(pokedex.Length);
            equipo[f, 0] = pokedex[pos];
            equipo[f, 1] = tipo[pos];
        }
        for (int f = 0; f < equipo.GetLength(0); f++)
        {
            equipo[f, 2] = aleatorio.Next(50, 81).ToString();
        }

        return equipo;
    }
    void mostrar(string[,] equipo)
    {
        for (int f = 0; f < equipo.GetLength(0); f++)
        {
            for (int c = 0; c < equipo.GetLength(1); c++)
            {
                Console.WriteLine(equipo[f, c]);
            }

        }
    }
    int valoracion(string[,] equipo)
    {
        int resultado = 0;

        for (int f = 0; f < equipo.GetLength(0); f++)
        {
            resultado = resultado + Convert.ToInt32(equipo[f, 2]);
        }

        return resultado;
    }

    equipos(red);
    equipos(green);
    equipos(blue);
    equipos(yellow);

    Console.WriteLine("Equipo Red:");
    Console.WriteLine("");
    mostrar(red);
    Console.WriteLine("");
    Console.WriteLine("Equipo Green:");
    Console.WriteLine("");
    mostrar(green);
    Console.WriteLine("");
    Console.WriteLine("Equipo Blue:");
    Console.WriteLine("");
    mostrar(blue);
    Console.WriteLine("");
    Console.WriteLine("Equipo Yellow:");
    Console.WriteLine("");
    mostrar(yellow);

    Console.WriteLine("");
    Console.WriteLine("----SEMIFINALES----");
    Console.WriteLine("");

    string[,] finalista1;
    string nombre1;
    if (valoracion(red) > valoracion(green))
    {
        finalista1 = red;
        nombre1 = "Red";
    }
    else
    {
        finalista1 = green;
        nombre1 = "Green";
    }
    Console.WriteLine($"El equipo {nombre1} pasa a la final");


    string[,] finalista2;
    string nombre2;
    if (valoracion(yellow) > valoracion(blue))
    {
        finalista2 = yellow;
        nombre2 = "Yellow";
    }
    else
    {
        finalista2 = blue;
        nombre2 = "Blue";
    }
    Console.WriteLine($"El equipo {nombre2} pasa a la final");

    Console.WriteLine("");
    Console.WriteLine("----FINAL----");
    Console.WriteLine("");

    if(valoracion(finalista1) > valoracion(finalista2))
    {
        Console.WriteLine($"El ganador del torneo es el equipo {nombre1}");
        Console.WriteLine("");
        Console.WriteLine($"Equipo {nombre1}: ");
        Console.WriteLine("");
        mostrar(finalista1);
    }
    else
    {
        Console.WriteLine($"El ganador del torneo es el equipo {nombre2}");
        Console.WriteLine("");
        Console.WriteLine($"Equipo {nombre2}: ");
        Console.WriteLine("");
        mostrar(finalista2);
    }
}

void ejercicio2()
{
    int recursiva(int num)
    {
        if (num == 55)
        {
            return 55;
        }
        else
        {
            recursiva(num + 5);
            Console.WriteLine(num);
            return num;
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Ejercicio N°2");
    Console.WriteLine("Desde el 50 al 0: ");
    Console.WriteLine("");
    recursiva(0);
}