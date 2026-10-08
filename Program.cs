using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.EntityFrameworkCore;

namespace Simulacro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var db = new AppDbContext();

            Console.WriteLine("==========Simulacro de evaluación==========");
            Console.WriteLine();
            Console.WriteLine("Elija una opción: ");

            int menu;

            do
            {
                Console.WriteLine("1 - Consultar todos los Jugadores");
                Console.WriteLine("2 - Consultar Jugador por ID");
                Console.WriteLine("3 - Agregar Jugador");
                Console.WriteLine("4 - Actualizar Jugador");
                Console.WriteLine("5 - Eliminar Jugador");
                Console.WriteLine("6 - Crear arbol binario");
                Console.WriteLine("7 - Mostrar arbol");
                Console.WriteLine("8 - Buscar Jugador en el arbol");
                Console.WriteLine("9 - Ordenar Jugadores");
                Console.WriteLine("0 - Salir");
                Console.WriteLine();
                Console.Write("Opcion: ");
                menu = Convert.ToInt16(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine();
                        Consultar();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        ConsultarID();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        Consultar();
                        Console.WriteLine();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;
                }


            } while (menu != 0);
        }

        static AppDbContext db = new AppDbContext();

        static void Consultar()
        {
            var todos = db.goleadores_mundial.ToList();
            foreach (var punto in todos)
            {
                punto.Mostrar();
            }
        }
        static void ConsultarID()
        {
            Console.Write("Ingrese el ID del Pokemon: ");
            int id = Leer();

            {
                Jugadores jugador = db.goleadores_mundial.Find(id);

                if (jugador == null)
                {
                    Console.WriteLine("No se encontro ese Pokemon.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Pokemon encontrado:");
                    jugador.Mostrar();
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
