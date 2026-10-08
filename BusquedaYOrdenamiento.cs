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

            Console.Write("Vector: ");
            Mostrar(vector_C);
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
                        if (lugar4 != 0)
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
                        int cant = Stalin(vector);
                        for (int f = 0; f < cant; f++)
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

        //Busquedas Simple
        //Explicación:Recorre la lista elemento por elemento desde el principio hasta el final, comparando cada uno con el valor buscado.

        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de búsqueda?
        // No se necesita cumplir ninguna condición, la lista puede estar desordenada y funcionar perfectamente.

        //¿Que complejidad algorítmica tiene Busqueda Simple?
        //Tiene la complejidad de O(n) - Lineal. En el peor caso recorre toda la lista. 

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

        //Busquedas Optimizada
        //Explicación:Recorre la lista elemento por elemento desde el principio hasta el final, pero se detiene si encuentra un número más grande que el buscado.

        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de búsqueda?
        //La lista debe estar ordenada si queremos que funcione correctamente la busqueda.

        //¿Que complejidad algorítmica tiene Busqueda Optimizada?
        //Tiene la complejidad de O(n) - Lineal. En el peor caso recorre toda la lista pero reduce algunos pasos. 
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

        //Busquedas Binaria (Iterativa)
        //Explicación:Divide repetidamente el rango de búsqueda a la mitad, comparando el elemento central con el valor buscado.

        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de búsqueda?
        // La lista debe estar ordenada si o si, sino no funcionará la busqueda.

        //¿Que complejidad algorítmica tiene Busqueda Binaria Iterativa?
        //Tinene la complejidad de O(log n) - Logarítmica. Es sumamente eficiente. 
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

        //Busquedas Binaria (Recursiva)
        //Explicación: Misma función que la Busqueda Binaria Iterativa, pero se llama a sí misma reduciendo los límites (izquierda y derecha) en cada ejecución.

        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de búsqueda?
        //Debe estar ordenada si o si, sino no funciona la busqueda

        //¿Que complejidad algorítmica tiene Busqueda Binaria Recursiva?
        //Tinene la complejidad de O(log n) - Logarítmica (usa espacio en memoria O(log n) por la pila de llamadas).
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

        //Ordenamineto Burbuja Simple
        //Explicación: Compara parejas de elementos adyacentes y los intercambia si están en el orden incorrecto, repitiendo esto para toda la lista n veces.

        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de ordenamiento?
        //Ninguna condición, puede funcionar en cualquier lista.

        //¿Que complejidad algorítmica tiene Ordenamiento Burbuja Simple?
        //Tiene la complejidad de O(n²) - Cuadrática. Siempre ejecuta todos los bucles.
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



        //Ordenamineto Burbuja Optimizada
        //Explicación: Compara parejas de elementos adyacentes y los intercambia si están en el orden incorrecto, repitiendo esto para toda la lista n veces.

        //¿Qué condiciones se deben cumplir para utilizar este tipo de ordenamiento?
        //Ninguna condición, funciona sobre cualquier lista desordenada.

        //¿Qué complejidad algorítmica tiene el Ordenamiento Burbuja Optimizada?
        //Tiene la complejidad de O(n²) en el peor caso, pero O(n) si la lista ya está ordenada.
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

                if (intercambio == false)
                {
                    break;
                }
            }
        }



        //Ordenamineto Selección
        //Explicación: Busca el elemento más pequeño de la lista y lo intercambia con el elemento de la primera posición, repitiendo para el resto de la lista.

        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de ordenamiento?
        //Ninguna condición, funciona con cualquier lista rellena con datos comparables.

        //¿Que complejidad algorítmica tiene Ordenamiento Selección?
        //Tiene la complejidad O(n²) - Cuadrática. Siempre busca el mínimo en el resto de la lista.
        static void Seleccion(int[] lista)
        {
            for (int x = 0; x < lista.Length - 1; x++)
            {
                int Pos = x;

                for (int i = x + 1; i < lista.Length; i++)
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


        //Ordenamineto Inserción
        //Explicación: Compara parejas de elementos adyacentes y los intercambia si están en el orden incorrecto, repitiendo esto para toda la lista n veces.

        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de ordenamiento?
        //Ninguna. Es muy eficiente para listas que ya están casi ordenadas.

        //¿Que complejidad algorítmica tiene Ordenamiento Inserción?
        //Tiene la complejidad O(n²) - Cuadrática en el peor caso; O(n) en el mejor caso.
        static void Insercion(int[] lista)
        {
            for (int x = 1; x < lista.Length; x++)
            {
                int actual = lista[x];
                int i = x - 1;

                while (i >= 0 && lista[i] > actual)
                {
                    lista[i + 1] = lista[i];
                    i--;
                }

                lista[i + 1] = actual;
            }
        }



        //Ordenamineto QuickSort
        //Explicación: Elige un elemento como "pivote" y divide la lista moviendo los menores a la izquierda y los mayores a la derecha. Luego se aplica recursivamente.

        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de ordenamiento?
        //Ninguna condición, trabaja sobre la estructura interna usando índices..

        //¿Que complejidad algorítmica tiene Ordenamiento QuickSort?
        //Tiene la complejidad O(n log n) en promedio. O(n²) en el peor de los casos (pivote muy malo).
        static void QuickSort(int[] lista, int inicio, int fin)
        {
            if (inicio < fin)
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

            for (int x = inicio; x < fin; x++)
            {
                if (lista[x] >= piv)
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

        //Ordenamineto Stalin
        //Explicación: Un ordenamiento satírico. Recorre la lista y elimina ("liquida") cualquier elemento que rompa el orden ascendente respecto al máximo actual.


        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de ordenamiento?
        //Ninguna condición, pero destruye datos. La lista resultante estará ordenada, pero incompleta.

        //¿Que complejidad algorítmica tiene Ordenamiento Stalin?
        //Tiene la complejidad O(n) - Lineal. Pasa solo una vez por la lista.
        static int Stalin(int[] lista)
        {
            int cant = lista.Length;
            int i = 0;
            int M_Actual = lista[0];

            while (i < cant - 1)
            {
                if (lista[i + 1] < M_Actual)
                {
                    for (int x = i + 1; x < cant - 1; x++)
                    {
                        lista[x] = lista[x + 1];
                    }

                    cant--;
                }
                else
                {
                    M_Actual = lista[i + 1];
                    i++;
                }
            }

            return cant;
        }

        //Ordenamiento BogoSort
        //Explicación:Algoritmo humorístico sumamente ineficiente.Desordena aleatoriamente la lista (Permutación)
        //y luego verifica si está ordenada.Si no lo está, repite el proceso infinitamente hasta apuntarle al orden por puro azar.Es el equivalente a ordenar un mazo de cartas tirándolo al aire, recogiéndolo y revisando si quedó ordenado.
      
        //¿Qué condiciones se deben cumplir?
        //Ninguna condición previa en la estructura de la lista. Sin embargo, como condición práctica de rendimiento, el tamaño de la lista debe ser extremadamente pequeño
        //(menos de 6 u 8 elementos), de lo contrario la computadora tardará años o incluso una eternidad en terminar.
     
        //¿Qué complejidad algorítmica tiene Ordenamiento BogoSort?: 
        //Caso promedio: O(n* n!) debido a la cantidad exponencial de permutaciones posibles.
        //Peor caso: O(∞) (Infinito), ya que al ser aleatorio podría no acertar nunca a la combinación correcta.
        //Mejor caso: O(n), si la lista ya ingresa ordenada de antemano y solo se verifica una vez.
        static int BogoSort(int[] lista)
        {
            Random aleatorio = new Random();
            int cont = 0;
            while (!Ordenado(lista))
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
        static bool Ordenado(int[] lista)
        {
            for (int x = 0; x < lista.Length - 1; x++)
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

