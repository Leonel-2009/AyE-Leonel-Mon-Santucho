using System.ComponentModel;
using System.Linq.Expressions;
using System.Numerics;

namespace BusquedasyOrdenamientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = [42, 17, 8, 31, 23, 5, 49, 14, 38, 26, 45, 11, 29, 3, 20, 36, 12, 47, 34, 1, 25, 40, 9, 33, 22, 16, 50, 7, 28, 44, 19, 43, 4, 37, 13, 24, 46, 30, 2, 35, 18, 41, 15, 6, 21, 32, 48, 10, 39, 27];
            int[] vector_C = [42, 17, 8, 31, 23, 5, 49, 14, 38, 26, 45, 11, 29, 3, 20, 36, 12, 47, 34, 1, 25, 40, 9, 33, 22, 16, 50, 7, 28, 44, 19, 43, 4, 37, 13, 24, 46, 30, 2, 35, 18, 41, 15, 6, 21, 32, 48, 10, 39, 27];

            Mostrar(vector);
            Console.WriteLine("");

            int menu;
            int menu2;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Busqueda binaria y ordenamiento");
                Console.WriteLine("");
                Console.WriteLine("Elija alguna de las opciones de Busqueda:");
                Console.WriteLine("1- Busqueda Simple");
                Console.WriteLine("2- Busqueda Optimizada");
                Console.WriteLine("3- Busqueda Binaria (Iterativa)");
                Console.WriteLine("4- Busqueda Binaria (Recursiva)");
                Console.WriteLine("5- Fin Programa Busqueda");

                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("¿Que numero está buscando?");
                        int busqueda = int.Parse(Console.ReadLine());
                        int lugar = BusquedaSimple(vector_C, busqueda);

                        if (lugar != 0)
                        {
                            Console.WriteLine("Número encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Número no encontrado");
                        }
                        break;
                    case 2:
                        Console.WriteLine("¿Que numero está buscando?");
                        int busqueda2 = int.Parse(Console.ReadLine());
                        int lugar2 = BusquedaOptimizada(vector_C, busqueda2);
                        if (lugar2 != 0)
                        {
                            Console.WriteLine("Número encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Número no encontrado");
                        }
                        break;
                    case 3:
                        Console.WriteLine("¿Que numero está buscando?");
                        int busqueda3 = int.Parse(Console.ReadLine());
                        int lugar3 = BusquedaBinariaIterativa(vector_C, busqueda3);
                        if (lugar3 != 0)
                        {
                            Console.WriteLine("Número encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Número no encontrado");
                        }
                        break;
                    case 4:
                        Console.WriteLine("¿Que numero está buscando?");
                        int busqueda4 = int.Parse(Console.ReadLine());
                        int lugar4 = BusquedaBinariaRecursiva(vector_C, busqueda4, 0, vector.Length - 1);
                        if (lugar4 != 0 )
                        {
                            Console.WriteLine("Número encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Número no encontrado");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Fin del programa :)");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;

                }
            }
            while (menu != 5);

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Elija alguna de las opciones de Ordenamiento:");
                Console.WriteLine("1- Ordenamiento Burbuja Simple");
                Console.WriteLine("2- Ordenamiento Burbuja Optimizada");
                Console.WriteLine("3- Ordenamiento Selección");
                Console.WriteLine("4- Ordenamiento Inserción");
                Console.WriteLine("5- Ordenamiento QuickSort");
                Console.WriteLine("6- Ordenamiento Stanlin");
                Console.WriteLine("7- Ordenamiento BogoSort");

                menu2 = int.Parse(Console.ReadLine());

                switch (menu2)
                {
                    case 1:
                        Console.Write("Ordenamineto Burbuja Simple: ");
                        Ord_Burbuja(vector);
                        Mostrar(vector);
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.Write("Ordenamineto Burbuja Optimizada: ");
                        Ord_Burbuja_Opti(vector);
                        Mostrar(vector);
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.Write("Ordenamineto Selección: ");
                        Seleccion(vector);
                        Mostrar(vector);
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.Write("Ordenamineto Inserción: ");
                        Insercion(vector);
                        Mostrar(vector);
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.Write("Ordenamineto QuickSort: ");
                        QuickSort(vector, 0, vector.Length - 1);
                        Mostrar(vector);
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.Write("Ordenamineto Stanlin: ");
                        int cant = Stanlin(vector);
                        for(int f = 0; f < cant; f++)
                        {
                            Console.Write($"{vector[f] + ""} ");
                        }
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.Write("Ordenamineto BogoSort: ");
                        int intentos = BogoSort(vector);
                        Mostrar(vector);
                        Console.WriteLine($"Cantidad de intentos: {intentos}");
                        Console.WriteLine("");
                        break;
                    case 8:
                        Console.WriteLine("Fin Programa completo :)");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta, intente otra vez");
                        break;
                }
            }
            while (menu2 != 8);
        }

        //Mostrar
        static void Mostrar(int[] lista)
        {
            foreach (int v in lista)
            {
                Console.Write($"{v + ""} ");
            }
        }

        //Busquedas
        static int BusquedaSimple(int[] lista, int busqueda)
        {

            for (int x = 0; x < lista.Length; x++)
            {
                if (lista[x] == busqueda)
                {
                    return 1;
                }
            }

            return 0;
        }
        static int BusquedaOptimizada(int[] lista, int busqueda)
        {
            for (int x = 0; x < lista.Length; x++)
            {
                if (lista[x] == busqueda)
                {
                    return 1;
                }

                if (lista[x] > busqueda)
                {
                    return 0;
                }
            }

            return 0;
        }
        static int BusquedaBinariaIterativa(int[] lista, int busqueda)
        {
            int inicio = 0;
            int fin = lista.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (lista[medio] == busqueda)
                {
                    return medio;
                }

                if (lista[medio] < busqueda)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return 0;
        }
        static int BusquedaBinariaRecursiva(int[] lista, int busqueda, int inicio, int fin)
        {
            if (inicio > fin)
            {
                return 0;
            }

            int medio = (inicio + fin) / 2;

            if (lista[medio] == busqueda)
            {
                return medio;
            }

            if (lista[medio] < busqueda)
            {
                return BusquedaBinariaRecursiva(lista, busqueda, medio + 1, fin);
            }
            else
            {
                return BusquedaBinariaRecursiva(lista, busqueda, inicio, medio - 1);
            }
        }

        //Ordenamientos
        static void Ord_Burbuja(int[] lista)
        {
            for (int x = 0; x < lista.Length - 1; x++)
            {
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        int aux = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = aux;
                    }
                }
            }
        }
        static void Ord_Burbuja_Opti(int[] lista)
        {
            bool intercambio;

            for (int x = 0; x < lista.Length - 1; x++)
            {
                intercambio = false;

                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        int aux = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = aux;

                        intercambio = true;
                    }
                }

                if(intercambio == false)
                {
                    break;
                }
            }
        }
        static void Seleccion(int[] lista)
        {
            for(int x = 0; x < lista.Length - 1; x++)
            {
                int Pos = x;

                for(int i = x + 1; i < lista.Length; i++)
                {
                    if (lista[i] < lista[Pos])
                    {
                        Pos = i;
                    }
                }

                int aux = lista[x];
                lista[x] = lista[Pos];
                lista[Pos] = aux;
            }
        }
        static void Insercion(int[] lista)
        {
            for (int x = 1; x < lista.Length; x++)
            {
                int actual = lista[x];
                int i = x - 1;

                while(i >= 0 && lista[i] > actual)
                {
                    lista[i + 1] = lista[i];
                    i--;
                }

                lista[i + 1] = actual;
            }
        }

        static void QuickSort(int[] lista, int inicio, int fin)
        {
            if(inicio < fin)
            {
                int Pos = Particion(lista, inicio, fin);

                QuickSort(lista, inicio, Pos - 1);
                QuickSort(lista, Pos + 1, fin);
            }
        }
        static int Particion(int[] lista, int inicio, int fin)
        {
            int piv = lista[fin];

            int i = inicio - 1;

            for(int x = inicio; x < fin; x++)
            {
                if (lista[x] < piv)
                {
                    i++;

                    int aux = lista[i];
                    lista[i] = lista[x];
                    lista[x] = aux;
                }
            }

            int aux2 = lista[i + 1];
            lista[i + 1] = lista[fin];
            lista[fin] = aux2;

            return i + 1;
        }

        static int Stanlin(int[] lista)
        {
            int cant = lista.Length;
            int i = 0;

            while (i < cant - 1)
            {
                if (lista[i + 1] > lista[i])
                {
                    for(int x = i + 1; x < cant - 1; x++)
                    {
                        lista[x] = lista[x + 1];
                    }

                    cant--;
                }
                else
                {
                    i++;
                }
            }

            return cant;
        }

        static int BogoSort(int[] lista)
        {
            Random aleatorio = new Random();
            int cont = 0;
            while (!ordenado(lista))
            {
                Random(lista, aleatorio);
                cont++;
            }

            return cont;
        }
        static void Random(int[] lista, Random aleatorio)
        {
            for (int x = 0; x < lista.Length; x++)
            {
                int Pos = aleatorio.Next(lista.Length);
                int aux = lista[x];
                lista[x] = lista[Pos];
                lista[Pos] = aux;
            }

        }
        static bool ordenado(int[] lista)
        {
            for(int x = 0; x < lista.Length - 1; x++)
            {
                if (lista[x] > lista[x + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

