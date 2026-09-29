namespace BB_en_BDD
{
    internal class Program
{
    static void Main(string[] args)
    {
        
        using var db = new AppDbContext();

        Console.WriteLine("Programa N°8");

        int menu;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Pokemon Base de Datos");
            Console.WriteLine("Elija alguna de las siguientes opciones:");
            Console.WriteLine("1 - Consultar todos los Pokemon");
            Console.WriteLine("2 - Consultar Pokemon por ID");
            Console.WriteLine("3 - Agregar Pokemon");
            Console.WriteLine("4 - Actualizar Pokemon");
            Console.WriteLine("5 - Eliminar Pokemon");
            Console.WriteLine("6 - Crear arbol binario");
            Console.WriteLine("7 - Mostrar arbol");
            Console.WriteLine("8 - Buscar Pokemon en el arbol");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("");

            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    ConsultarTodos();
                    break;

                case 2:
                    Console.WriteLine("");
                    ConsultarPorId();
                    break;

                case 3:
                    Console.WriteLine("");
                    AgregarPokemon();
                    break;

                case 4:
                    Console.WriteLine("");
                    ActualizarPokemon();
                    break;

                case 5:
                    Console.WriteLine("");
                    EliminarPokemon();
                    break;

                case 6:
                    Console.WriteLine("");
                    CrearArbol();
                    break;

                case 7:
                    Console.WriteLine("");
                    MostrarArbol();
                    break;

                case 8:
                    Console.WriteLine("");
                    BuscarEnArbol();
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta, elija otra opción");
                    break;

            }
        }
        while (menu != 0);
    }

   static void ConsultarTodos()
    {
        using var db = new AppDbContext();

        {
            var todos = db.pokemon.ToList();
            foreach (var punto in todos)
            {
                punto.Mostrar();
            }
        }
    }

    static void ConsultarPorId()
    {
        Console.Write("Ingrese el ID del Pokemon: ");
        int id = Leer();

        using var db = new AppDbContext();

        {
            Pokemon pokemon = db.pokemon.Find(id);

            if (pokemon == null)
            {
                Console.WriteLine("No se encontro ese Pokemon.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Pokemon encontrado:");
                pokemon.Mostrar();
            }
        }
    }

    static void AgregarPokemon()
    {
        Console.WriteLine("AGREGAR POKEMON");

        Pokemon pokemon = new Pokemon();

        Console.Write("ID: ");
        pokemon.ID = Leer();

        Console.Write("Nombre: ");
        pokemon.Nombre = Console.ReadLine();

        Console.Write("Tipo 1: ");
        pokemon.Tipo_1 = Console.ReadLine();

        Console.Write("Tipo 2 (dejar vacio si no tiene): ");
        string tipo2 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(tipo2))
        {
            pokemon.Tipo_2 = null;
        }
        else
        {
            pokemon.Tipo_2 = tipo2;
        }

        Console.Write("HP: ");
        pokemon.Hp = Leer();

        Console.Write("Ataque: ");
        pokemon.ataque = Leer();

        Console.Write("Defensa: ");
        pokemon.defensa = Leer();

        Console.Write("Ataque especial: ");
        pokemon.ataque_especial = Leer();

        Console.Write("Defensa especial: ");
        pokemon.defensa_especial = Leer();

        Console.Write("Velocidad: ");
        pokemon.velocidad = Leer();

        Console.Write("Nivel: ");
        pokemon.nivel = Leer();

        using var db = new AppDbContext();

        {
            Pokemon existente = db.pokemon.Find(pokemon.ID);

            if (existente != null)
            {
                Console.WriteLine("Ya existe un Pokemon con ese ID.");
                return;
            }

            db.pokemon.Add(pokemon);
            db.SaveChanges();
        }

        Console.WriteLine();
        Console.WriteLine("Pokemon agregado correctamente.");
    }
    
    static void ActualizarPokemon()
    {
        Console.WriteLine("ACTUALIZAR POKEMON");

        Console.Write("Ingrese el ID del Pokemon: ");
        int id = Leer();

        using var db = new AppDbContext();

        {
            Pokemon pokemon = db.pokemon.Find(id);

            if (pokemon == null)
            {
                Console.WriteLine("No se encontro ese Pokemon.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Pokemon actual:");
            pokemon.Mostrar();

            Console.WriteLine();
            Console.WriteLine("Ingrese los nuevos datos:");

            Console.Write("Nombre: ");
            pokemon.Nombre = Console.ReadLine();

            Console.Write("Tipo 1: ");
            pokemon.Tipo_1 = Console.ReadLine();

            Console.Write("Tipo 2 (dejar vacio si no tiene): ");
            string tipo2 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(tipo2))
            {
                pokemon.Tipo_2 = null;
            }
            else
            {
                pokemon.Tipo_2 = tipo2;
            }

            Console.Write("HP: ");
            pokemon.Hp = Leer();

            Console.Write("Ataque: ");
            pokemon.ataque = Leer();

            Console.Write("Defensa: ");
            pokemon.defensa = Leer();

            Console.Write("Ataque especial: ");
            pokemon.ataque_especial = Leer();

            Console.Write("Defensa especial: ");
            pokemon.defensa_especial = Leer();

            Console.Write("Velocidad: ");
            pokemon.velocidad = Leer();

            Console.Write("Nivel: ");
            pokemon.nivel = Leer();

            db.SaveChanges();
        }

        Console.WriteLine();
        Console.WriteLine("Pokemon actualizado correctamente.");
    }

    static void EliminarPokemon()
    {
        Console.WriteLine("ELIMINAR POKEMON");

        Console.Write("Ingrese el ID del Pokemon: ");
        int id = Leer();

        using var db = new AppDbContext();

        {
            Pokemon pokemon = db.pokemon.Find(id);

            if (pokemon == null)
            {
                Console.WriteLine("No se encontro ese Pokemon.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Pokemon a eliminar:");
            pokemon.Mostrar();

            Console.WriteLine();
            Console.Write("¿Seguro que quiere eliminarlo? (s/n): ");

            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "s")
            {
                db.pokemon.Remove(pokemon);
                db.SaveChanges();

                Console.WriteLine("Pokemon eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Operacion cancelada.");
            }
        }
    }



    static ArbolBinario arbol = new ArbolBinario();

    static void CrearArbol()
    {
        Console.WriteLine("CREAR ARBOL");

        arbol.Limpiar();

        using var db = new AppDbContext();

        {
            List<Pokemon> pokemons = db.pokemon.OrderBy(p => p.ID).ToList();

            foreach (Pokemon pokemon in pokemons)
            {
                arbol.Insertar(pokemon);
            }

            Console.WriteLine("Arbol creado correctamente.");
            Console.WriteLine("Pokemon cargados: " + pokemons.Count);
        }
    }

    static void MostrarArbol()
    {
        Console.WriteLine("ARBOL BINARIO");

        if (arbol.raiz == null)
        {
            Console.WriteLine("El arbol esta vacio.");
            Console.WriteLine("Primero seleccione la opcion 6.");
            return;
        }

        arbol.Mostrar();
    }

    static void BuscarEnArbol()
    {
        Console.WriteLine("BUSCAR EN ARBOL");

        if (arbol.raiz == null)
        {
            Console.WriteLine("El arbol esta vacio.");
            Console.WriteLine("Primero seleccione la opcion 6.");
            return;
        }

        Console.Write("Ingrese el ID que quiere buscar: ");
        int id = Leer();

        Pokemon pokemon = arbol.Buscar(id);

        Console.WriteLine();

        if (pokemon == null)
        {
            Console.WriteLine("No se encontro ese Pokemon.");
        }
        else
        {
            Console.WriteLine("Pokemon encontrado:");
            pokemon.Mostrar();
        }
    }

    static int Leer()
    {
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Ingrese un numero valido: ");
        }

        return numero;
    }
}
