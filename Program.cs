namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluacion");
            Console.WriteLine("");

            Stack<Personaje> historialDelPersonaje = new Stack<Personaje>();

            Personaje person = new Personaje(100, 100, "Caminar");
            Personaje person2 = new Personaje(100, 100, "Correr");
            Personaje person3 = new Personaje(100, 100, "Saltar");
            Personaje person4 = new Personaje(100, 100, "Dormir");

            historialDelPersonaje.Push(person);
            historialDelPersonaje.Push(person2);
            historialDelPersonaje.Push(person3);
            historialDelPersonaje.Push(person4);

            foreach (Personaje m in historialDelPersonaje)
            {
                Console.WriteLine($"- vida Actual: {m.vidaTotal} | Vida Total: {m.vidaActual} | Acción realizada: {m.UltimaAccion}");
            }

            Console.WriteLine("");
            VolverEnElTiempo(historialDelPersonaje);
            Console.WriteLine("");
            Golpear(historialDelPersonaje);
        }

        static Personaje VolverEnElTiempo(Stack<Personaje> historialDelPersonaje)
        {
            var retroceder = historialDelPersonaje.Pop();

            Console.WriteLine($"Accion borrada: {retroceder.UltimaAccion}");
            Console.WriteLine("");

            Console.WriteLine("Historial actualizado");
            foreach (var m in historialDelPersonaje)
            {
                Console.WriteLine($"- {m.UltimaAccion}");
            }

            return retroceder;
        }
        static Personaje Golpear(Stack<Personaje> historialDelPersonaje)
        {
            var daño = 20;

            Personaje person = new Personaje(100 , 100 - daño, "Golpe recibido");

            historialDelPersonaje.Push(person);

            Console.WriteLine("");
            Console.WriteLine("Historial actualizado:");
            foreach (var m in historialDelPersonaje)
            {
                Console.WriteLine($"- vida Actual: {m.vidaActual} | Vida Total: {m.vidaTotal} | Acción realizada: {m.UltimaAccion}");
            }

            return person;
        }
    }
}
