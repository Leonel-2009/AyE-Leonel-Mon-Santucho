namespace ConsoleApp2
{
    internal class Program
    {
        public struct Personaje
        {
            public string nombre { get; set; }
            public int poder { get; set; }
            public string item { get; set; }
            public string[] items { get; set; }
            public int cantidadItems { get; set; }

            public Personaje(string nombre, int poder, string[] items, int cantidadItems)
            {
                this.nombre = nombre;
                this.poder = poder;
                this.items = items;
                this.cantidadItems = cantidadItems;
            }
            public void Mostrar()
            {
                Console.WriteLine($"Personaje: {nombre}");
                Console.WriteLine($"Poder: {poder}");
                Console.WriteLine($"Item del personaje: {item}");
                Console.WriteLine($"Items: {cantidadItems}");
            }
        }

        public struct Salas
        {
            public int dificultad { get; set; }
            public string itemsSala { get; set; }
            public int poderItem { get; set; }

            public Salas(int dificultad, string itemsSala, int poderItem)
            {
                this.dificultad = dificultad;
                this.itemsSala = itemsSala;
                this.poderItem = poderItem;
            }
            public void MostrarSala()
            {
                Console.WriteLine($"Dificultad: {dificultad}");
                Console.WriteLine($"item de la Sala: {itemsSala}");
                Console.WriteLine($"Poder del item: {poderItem}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----Mazmorra----");
            Console.WriteLine("Pre-pre-pre-alpha xd");
            Console.WriteLine("Estos son los siguientes personajes:");

            string[] personaje = ["Link", "Goku", "Da Vinci", "Di Caprio", "Messi", "Cristiano", "Alfredo", "Pepe"];
            string[] item = ["Espada", "Arco", "Hacha", "Escudo", "Machete"];
            string[] items = ["Espada Maestra", "BFG 9000", "Lancer", "Champiñon", "Espada Buster", "Pistola de Gravedad", "Espada del Caos", "Portal Gun", "Cuchillo Oculto", "Cero Absoluto (rifle)", "DMR", "Hoja del Caos", "Super Star", "Redeemer", "Fatman", "Lanza", "Megabuster", "Espada de Diamante Encantada", "Manzana Notch", "Esmeralda del caos"];
            Random aleatorio = new Random();

            Personaje p1 = new Personaje();
            p1.nombre = personaje[aleatorio.Next(personaje.Length)];
            p1.item = item[aleatorio.Next(item.Length)];
            p1.items = new string[20];
            p1.poder = 50;
            p1.cantidadItems = 0;

            Console.WriteLine("");
            Console.WriteLine("Personaje 1:");
            p1.Mostrar();
            Console.WriteLine("");

            Personaje p2 = new Personaje();
            p2.nombre = personaje[aleatorio.Next(personaje.Length)];
            p2.item = item[aleatorio.Next(item.Length)];
            p2.items = new string[20];
            p2.poder = 50;


            Console.WriteLine("");
            Console.WriteLine("Personaje 2:");
            p2.Mostrar();

            Console.WriteLine("Pausa (usa enter para salir)");
            string tiempo = Console.ReadLine();

            Salas[] salas = new Salas[20];

            for (int s = 0; s < salas.Length; s++)
            {
                salas[s] = new Salas();
                salas[s].dificultad = aleatorio.Next(10, 100);
                salas[s].itemsSala = items[aleatorio.Next(items.Length)];
                salas[s].poderItem = aleatorio.Next(20, 100);
            }

            int turnos = 0;

            while (turnos < 2)
            {
                Console.WriteLine("");
                Console.WriteLine($"---Turno {turnos++}---");
                Console.WriteLine("");

                Salas sala1 = salas[aleatorio.Next(salas.Length)];
                Salas sala2 = salas[aleatorio.Next(salas.Length)];
                Salas sala3 = salas[aleatorio.Next(salas.Length)];

               
                    Console.WriteLine("Sala 1");
                    sala1.MostrarSala();
                    Console.WriteLine("Sala 2");
                    sala2.MostrarSala();
                    Console.WriteLine("Sala 3");
                    sala3.MostrarSala();


                    Console.WriteLine("");
                    Console.WriteLine($"Turno: {p1.nombre} ");
                    Console.WriteLine("");
                    Console.WriteLine("¿A que sala quieres entrar?");

                    int opcion = 0;
                    bool estado = false;

                    while (!estado)
                    {
                        try
                        {
                            opcion = Convert.ToInt16(Console.ReadLine());
                            estado = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("No se permite caracteres, intentelo de nuevo");
                        }
                    }

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Usted eligio la sala 1");

                            if (p1.poder > sala1.dificultad)
                            {
                                Console.WriteLine("¡Logro agarra el item!");
                                p1.poder += sala1.poderItem;
                                p1.items[p1.cantidadItems] = sala1.itemsSala;
                                p1.cantidadItems++;
                            }
                            else
                            {
                                Console.WriteLine("Sala muy complicada");
                            }

                            break;
                        case 2:
                            Console.WriteLine("Usted eligio la sala 2");

                            if (p1.poder > sala2.dificultad)
                            {
                                Console.WriteLine("¡Logro agarra el item!");
                                p1.poder += sala2.poderItem;
                                p1.items[p1.cantidadItems] = sala2.itemsSala;
                                p1.cantidadItems++;
                            }
                            else
                            {
                                Console.WriteLine("Sala muy complicada");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Usted eligio la sala 3");

                            if (p1.poder > sala3.dificultad)
                            {
                                Console.WriteLine("¡Logro agarra el item!");
                                p1.poder += sala3.poderItem;
                                p1.items[p1.cantidadItems] = sala3.itemsSala;
                                p1.cantidadItems++;
                            }
                            else
                            {
                                Console.WriteLine("Sala muy complicada");
                            }
                            break;
                        default:
                            Console.WriteLine("Sala incorrecta, pierde su turno");
                            break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("¿Quiere ver sus stats?");

                    string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "si")
                {
                    Console.WriteLine("");
                    p1.Mostrar();
                    Console.WriteLine("Tiempo para ver stats");
                    Console.WriteLine("");
                    tiempo = Console.ReadLine();
                }
                else if (respuesta == "no")
                {
                    Console.WriteLine("Seguimooooooooos");
                    Console.WriteLine("");
                }
                else
                {
                    while (respuesta != "si" || respuesta != "no")
                    {
                        Console.WriteLine("Respuesta incorrecta");
                        respuesta = Console.ReadLine();

                        if (respuesta == "si")
                        {
                            p1.Mostrar();
                            Console.WriteLine("Tiempo para ver stats");
                            Console.WriteLine("");
                            tiempo = Console.ReadLine();
                            break;
                        }
                        else if (respuesta == "no")
                        {
                            Console.WriteLine("Seguimooooooooos");
                            Console.WriteLine("");
                            break;
                        }
                    }
                }
                    
                


                
                    sala1 = salas[aleatorio.Next(salas.Length)];
                    sala2 = salas[aleatorio.Next(salas.Length)];
                    sala3 = salas[aleatorio.Next(salas.Length)];

                    Console.WriteLine("Sala 1");
                    sala1.MostrarSala();
                    Console.WriteLine("Sala 2");
                    sala2.MostrarSala();
                    Console.WriteLine("Sala 3");
                    sala3.MostrarSala();

                    Console.WriteLine("");
                    Console.WriteLine($"Turno: {p2.nombre} ");
                    Console.WriteLine("");
                    Console.WriteLine("¿A que sala quieres entrar?");

                    int opcion2 = 0;
                    bool estado2 = false;

                    while (!estado2)
                    {
                        try
                        {
                            opcion2 = Convert.ToInt16(Console.ReadLine());
                            estado2 = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("No se permite caracteres, intentelo de nuevo");
                        }
                    }

                    switch (opcion2)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Usted eligio la sala 1");

                            if (p2.poder > sala1.dificultad)
                            {
                                Console.WriteLine("¡Logro agarra el item!");
                                p2.poder += sala1.poderItem;
                                p2.items[p2.cantidadItems] = sala1.itemsSala;
                                p2.cantidadItems++;
                            }
                            else
                            {
                                Console.WriteLine("Sala muy complicada");
                            }

                            break;
                        case 2:
                            Console.WriteLine("Usted eligio la sala 2");

                            if (p2.poder > sala2.dificultad)
                            {
                                Console.WriteLine("¡Logro agarra el item!");
                                p2.poder += sala2.poderItem;
                                p2.items[p2.cantidadItems] = sala2.itemsSala;
                                p2.cantidadItems++;
                            }
                            else
                            {
                                Console.WriteLine("Sala muy complicada");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Usted eligio la sala 3");

                            if (p2.poder > sala3.dificultad)
                            {
                                Console.WriteLine("¡Logro agarra el item!");
                                p2.poder += sala3.poderItem;
                                p2.items[p2.cantidadItems] = sala3.itemsSala;
                                p2.cantidadItems++;
                            }
                            else
                            {
                                Console.WriteLine("Sala muy complicada");
                            }
                            break;
                        default:
                            Console.WriteLine("Sala incorrecta, pierde su turno");
                            break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("¿Quiere ver sus stats?");

                    string respuesta2 = Console.ReadLine().ToLower();

                if (respuesta2 == "si")
                {
                    Console.WriteLine("");
                    p2.Mostrar();
                    Console.WriteLine("Tiempo para ver stats");
                    Console.WriteLine("");
                    tiempo = Console.ReadLine();
                }
                else if (respuesta2 == "no")
                {
                    Console.WriteLine("Seguimooooooooos");
                    Console.WriteLine("");
                }
                else
                {
                    while (respuesta2 != "si" || respuesta2 != "no")
                    {
                        Console.WriteLine("Respuesta incorrecta");
                        respuesta2 = Console.ReadLine();

                        if (respuesta2 == "si")
                        {
                            Console.WriteLine("");
                            p2.Mostrar();
                            Console.WriteLine("Tiempo para ver stats");
                            Console.WriteLine("");
                            tiempo = Console.ReadLine();
                            break;
                        }
                        else if (respuesta2 == "no")
                        {
                            Console.WriteLine("Seguimooooooooos");
                            Console.WriteLine("");
                            break;
                        }
                    }
                }
               
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---Pelea---");
            Console.WriteLine("");
            p1.Mostrar();
            Console.WriteLine("");
            p2.Mostrar();
            Console.WriteLine("");

            tiempo = Console.ReadLine();

            Console.WriteLine("Ganador de la pelea:");
            if (p1.poder > p2.poder)
            {
                Console.WriteLine("");
                Console.WriteLine("El ganador de la pelea es el personaje 1 :DDDDDD");
                Console.WriteLine("");
                p1.Mostrar();
                for (int x = 0; x < p1.cantidadItems; x++)
                {
                    Console.WriteLine("- " + p1.items[x]);
                }
            }
            else if (p2.poder > p1.poder)
            {
                Console.WriteLine("");
                Console.WriteLine("El ganador de la pelea es el personaje 2 :DDDDDD");
                Console.WriteLine("");
                p2.Mostrar();
                for (int x = 0; x < p2.cantidadItems; x++)
                {
                    Console.WriteLine("- " + p2.items[x]);
                }
            }
            else
            {
                Console.WriteLine("Empate");
            }
        }

    }
}
