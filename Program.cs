namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            arbol.Insertar(50);
            arbol.Insertar(30);
            arbol.Insertar(80);
            arbol.Insertar(90);
            arbol.Insertar(10);
            arbol.Insertar(100);
            arbol.Insertar(60);
            arbol.Insertar(20);

            arbol.Mostrar();

            Console.WriteLine($"Valor minimo del arbol: {arbol.ObtenerMin()}");
            Console.WriteLine($"Valor maximo del arbol: {arbol.ObtenerMayor()}");
            Console.WriteLine($"Nodos totales: {arbol.CantidadNodos()}");
            Console.WriteLine($"Altura: {arbol.ObtenerAltura()}");
            Console.WriteLine($"Nodos null: {arbol.CantidadNodosNull()}");
            arbol.EliminarNodo(30);
        }
    }
}
