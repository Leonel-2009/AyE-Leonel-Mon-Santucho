namespace Evaluacion_simulacro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Ubicacion> historialUbicaciones = new Stack<Ubicacion>();

            Ubicacion Ubication = new Ubicacion(120, 30, "Bosque");
            Ubicacion Ubication2 = new Ubicacion(340, 120, "Selva");
            Ubicacion Ubication3 = new Ubicacion(-230, 20, "Pantano");

            historialUbicaciones.Push(Ubication);
            historialUbicaciones.Push(Ubication2);
            historialUbicaciones.Push(Ubication3);

            Console.WriteLine("\n Ubicaciones buscadas:");

            var eliminado = historialUbicaciones.Pop();

            foreach (Ubicacion Url in historialUbicaciones)
            {
                Console.WriteLine($"- Coordenadas: {Url.X} ; {Url.Y} | Nombre: {Url.NombreZona}");
            }

            Console.WriteLine("\n Ubicación eliminada:");
            
           
            Console.WriteLine($"{eliminado}");
                


            
        }
    }
}
