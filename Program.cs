namespace ConsoleApp4
{
    internal class Program
    {
        public struct Producto
        {
            public string Nombre { get; set; }
            public int Codigo { get; set; }
            public double Precio { get; set; }
        }
        static void Main(string[] args)
        {
            Producto[] inventario = new Producto[3];

            inventario[0] = new Producto { Nombre = "Patito de Hule + tres patitos chiquitos", Codigo = 7896, Precio = 5900.52 };
            inventario[1] = new Producto { Nombre = "TV 65 pulgadas", Codigo = 9876, Precio = 9900000 };
            inventario[2] = new Producto { Nombre = "Optimus Prime", Codigo = 10223, Precio = 100000 };

            foreach (Producto producto in inventario)
            {
                Console.WriteLine($"Producto: {producto.Nombre} | Codigo: {producto.Codigo} | Precio: {producto.Precio}");
            }

            using var db = new AppDbContext();

            foreach(Producto p in inventario)
            {
                Productos productitos = new Productos
                {
                    Nombre = p.Nombre,
                    Codigo = p.Codigo,
                    Precio = p.Precio
                };

                db.Productos.Add(productitos);

                db.SaveChanges();
            }
        }
    }
}
