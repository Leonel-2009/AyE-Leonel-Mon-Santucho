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
            
            //¿Por qué el ancho de d1 no cambió a 99?
            
            //El ancho de d1 no cambia a 99 porque los structs son tipos de valor (conocidos como "value types"). 
            //Al hacer "Dimensiones d2 = d1", no se crea una referencia al objeto original, sino que se realiza una copia completa y exacta de todos los datos de d1 en una nueva posición de memoria asignada a d2.
            //Como ambas variables son totalmente independientes en la memoria, cualquier modificación en los campos o propiedades de d2 no afecta en absoluto a d1.
            
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
            Estudiante alumno2 = new Estudiante();
            Estudiante alumno3 = new Estudiante();

            alumno.nombreAlumno = "Pablo Sornia";
            alumno.notas = new double[] { 9, 8.75, 8 };
            alumno2.nombreAlumno = "Menzo Benavidez";
            alumno2.notas = new double[] { 9, 7, 8 };
            alumno3.nombreAlumno = "Pablo Sornia";
            alumno3.notas = new double[] { 7, 7.5, 7 };

            double promedio = alumno.CalcularPromedio();
            double promedio2 = alumno2.CalcularPromedio();
            double promedio3 = alumno3.CalcularPromedio();

            Console.WriteLine($"Estudiante: {alumno.nombreAlumno} | Promedio: {promedio}");
            Console.WriteLine($"Estudiante: {alumno2.nombreAlumno} | Promedio: {promedio2}");
            Console.WriteLine($"Estudiante: {alumno3.nombreAlumno} | Promedio: {promedio3}");
        }
    }
}


