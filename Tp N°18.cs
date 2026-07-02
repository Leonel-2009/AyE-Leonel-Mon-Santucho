using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp15
{
    internal class Program
    {
        public struct Punto2D
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Punto2D(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Mostrar()
            {
                Console.WriteLine($"Posición: ({X}, {Y})");
            }

        }
        public struct Dimensiones
        {
            public int ancho { get; set; }
            public int largo { get; set; }

            public Dimensiones(int a, int l)
            {
                ancho = a;
                largo = l;
            }

            public void Mostrar()
            {
                Console.WriteLine($"Ancho: {ancho}, Largo: {largo}");
            }
        }
        public struct Producto
        {
            public string nombre { get; set; }
            public int codigo { get; set; }
            public double precio { get; set; }
        }
        public struct Estudiante
        {
            public string nombreAlumno { get; set; }
            public double[] notas { get; set; }

            public double CalcularPromedio()
            {
                if (notas.Length == 0)
                {
                    return 0.0;
                }

                double suma = 0;
                foreach (double Nota in notas)
                {
                    suma += Nota;
                }

                return suma / notas.Length;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("");

            Punto2D punto = new Punto2D(5, 10);
            punto.Mostrar();

            Console.WriteLine("");
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("");

            Dimensiones d1 = new Dimensiones(10, 20);
            Dimensiones d2 = d1;
            d2 = new Dimensiones(99, 20);
            d1.Mostrar();
            d2.Mostrar();

            Console.WriteLine("");
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("");
            Console.WriteLine("Lista de productos:");
            Console.WriteLine("");

            Producto[] inventario = new Producto[3];

            inventario[0] = new Producto { nombre = "Patito de Hule + tres patitos chiquitos" , codigo = 11023, precio = 5900.52};
            inventario[1] = new Producto { nombre = "TV 65 pulgadas", codigo = 11011, precio = 9900000 };
            inventario[2] = new Producto { nombre = "Optimus Prime", codigo = 10223, precio = 100000 };

            foreach (Producto producto in inventario)
            {
                Console.WriteLine($"Producto: {producto.nombre} | Codigo: {producto.codigo} | Precio: {producto.precio}");
            }

            Console.WriteLine("");
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("");
            Console.WriteLine("Alumnos:");
            Console.WriteLine("");

            Estudiante alumno = new Estudiante();

            alumno.nombreAlumno = "Pablo Sornia";
            alumno.notas = new double[] {9, 8.75, 8};

            double promedio = alumno.CalcularPromedio();

            Console.WriteLine($"Estudiante: {alumno.nombreAlumno} | Promedio: {promedio}");
        }
    }
}


