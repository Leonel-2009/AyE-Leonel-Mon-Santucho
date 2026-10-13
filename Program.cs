namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext();
            Datos[] Agent = new Datos[5];
            Console.WriteLine("Evaluación");

            int menu;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Elija una de las siguientes opciones:");
                Console.WriteLine("1- Consultar todos");
                Console.WriteLine("2- Agregar");
                Console.WriteLine("3- Actualizar");
                Console.WriteLine("4- Eliminar");
                Console.WriteLine("5- Crear árbol");
                Console.WriteLine("6- Mostrar árbol");
                Console.WriteLine("7- Buscar por árbol");
                Console.Write("Opción: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("");
                        ConsultarTodos();
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        AgregarAgente();
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        ActualizarAgente();
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("");
                        EliminarAgente();
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("");
                        CrearArbol();
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        MostrarArbol();
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        BuscarEnArbol();
                        Console.WriteLine("");
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

        static AppDbContext db = new AppDbContext();

        static void ConsultarTodos()
        {
            Console.WriteLine("---Consultar---");
            var todos = db.Agentes_valorant.ToList();
            foreach (var punto in todos)
            {
                punto.Mostrar();
            }

        }

        static void AgregarAgente()
        {
            Console.WriteLine("---Agregar---");
            Console.WriteLine("");
            Console.WriteLine("ingrese los datos del agente que quiere agregar:");

            Datos agente = new Datos();

            Console.Write("ID: ");
            agente.ID = Leer();
    
            Console.Write("Nombre: ");
            agente.Nombre_agente = Console.ReadLine();

            Console.Write("Tipo: ");
            agente.Tipo_agente = Console.ReadLine();
    
            Console.Write("Nacionalidad: ");
            agente.Nacionalidad = Console.ReadLine();

            Console.Write("Fecha lanzamiento: ");
            agente.Fecha_lanzamiento = Console.ReadLine();


            Datos existente = db.Agentes_valorant.Find(agente.ID);

            if (existente != null)
            {
                Console.WriteLine("Ya existe un agente con el ID");
                return;
            }
            else
            {
                db.Agentes_valorant.Add(agente);
                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine("agente agregado");
            }
        }

        static void ActualizarAgente()
        {
            Console.WriteLine("---Actualizar---");
            Console.WriteLine("");
            Console.Write("Ingrese el ID del agente: ");
            int id = Leer();

            Datos agente = db.Agentes_valorant.Find(id);

            if (agente == null)
            {
                Console.WriteLine("No se encontro el agente");
                return;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("agente actual:");
                agente.Mostrar();
        
                Console.WriteLine();
                Console.WriteLine("Ingrese los nuevos datos:");

                Console.Write("Nombre: ");
                agente.Nombre_agente = Console.ReadLine();

                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine("agente actualizado");
            }
        }

        static void EliminarAgente()
        {
            Console.WriteLine("---Eliminar---");
            Console.WriteLine("");
            Console.Write("Ingrese el ID del agente: ");
            int id = Leer();
            Datos agente = db.Agentes_valorant.Find(id);
    
            if (agente == null)
            {
                Console.WriteLine("No se encontro ese agente");
                return;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("agente a eliminar:");
                agente.Mostrar();


                db.Agentes_valorant.Remove(agente);
                db.SaveChanges();

                Console.WriteLine("agente eliminado");
            }
        }


        static ArbolBinario arbol = new ArbolBinario();

        static void CrearArbol()
        {
            Console.WriteLine("---Creación del arbol---");

            arbol.Limpiar();

            List<Datos> agentes = db.Agentes_valorant.OrderBy(p => p.ID).ToList();

            foreach (Datos a in agentes)
            {
                arbol.Insertar(a);
            }

            Console.WriteLine("Arbol creado");
            Console.WriteLine($"Cantidad de agentes: {agentes.Count}");

        }

        static void MostrarArbol()
        {
            Console.WriteLine("---Mostrar árbol---");

            if (arbol.raiz == null)
            {
                Console.WriteLine("El arbol esta vacio (seleccione opción 5)");
                return;
            }
            else
            {
                arbol.Mostrar();
            }
        }

        static void BuscarEnArbol()
        {
            Console.WriteLine("---Busqueda en arbol---");

            if (arbol.raiz == null)
            {
                Console.WriteLine("El arbol esta vacio (Seleccione la opción 5)");
                return;
            }
            else
            {
                Console.Write("Ingrese el ID que quiere buscar: ");
                int id = Leer();

                Datos agentes = arbol.Buscar(id);

                Console.WriteLine("");

                if (agentes == null)
                {
                    Console.WriteLine("No se encontro ese agente");
                }
                else
                {
                    Console.WriteLine("agente encontrado:");
                    agentes.Mostrar();
                }
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
 }
