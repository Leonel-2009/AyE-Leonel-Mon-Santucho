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
            equipo[f, 0] = pokedex[f];
        }
        for (int f = 0; f < equipo.GetLength(0); f++)
        {
            equipo[f, 1] = tipo[f];
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
    Console.WriteLine("---Semifinales---");
    Console.WriteLine("");
    if (valoracion(red) > valoracion(green))
    {
        Console.WriteLine("El equipo Red pasa a la final");
    }
    else if (valoracion(red) < valoracion(green))
    {
        Console.WriteLine("El equipo Green pasa a la final");
    }

    if (valoracion(blue) > valoracion(yellow))
    {
        Console.WriteLine("El equipo Blue pasa a la final");
    }
    else if (valoracion(blue) < valoracion(yellow))
    {
        Console.WriteLine("El equipo Yellow pasa a la final");
    }

    Console.WriteLine("");
    Console.WriteLine("---Final---");
    if (valoracion(red) > valoracion(blue))
    {
        Console.WriteLine("El equipo Red ganó el torneo");
    }
    else if (valoracion(red) > valoracion(yellow))
    {
        Console.WriteLine("El equipo Red ganó el torneo");
    }
    else if (valoracion(green) > valoracion(yellow))
    {
        Console.WriteLine("El equipo Green ganó el torneo");
    }
    else if (valoracion(green) > valoracion(blue))
    {
        Console.WriteLine("El equipo Green ganó el torneo");
    }
    else if (valoracion(red) < valoracion(blue))
    {
        Console.WriteLine("El equipo Blue ganó el torneo");
    }
    else if (valoracion(green) < valoracion(blue))
    {
        Console.WriteLine("El equipo BLuie ganó el torneo");
    }
    else if (valoracion(red) < valoracion(yellow))
    {
        Console.WriteLine("El equipo Yellow ganó el torneo");
    }
    else if (valoracion(green) < valoracion(yellow))
    {
        Console.WriteLine("El equipo Yellow ganó el torneo");
    }
}

void ejercicio2()
{
    int recursiva(int num)
    {
        if(num == 55)
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