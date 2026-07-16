using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3
{
    internal class Program
    {
        public struct Jugador
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public double CantidadGoles { get; set; }
            public double CantidadTirosArco { get; set; }
            public int NumeroCamiseta { get; set; }
            public string Posicion { get; set; }
            public string Equipo{ get; set; }

            public Jugador(string Nom, string Ape, double CG, double CTA, int NC, string Pos, string equipo)
            {
                Nombre = Nom;
                Apellido = Ape;
                CantidadGoles = CG;
                CantidadTirosArco = CTA;
                NumeroCamiseta = NC;
                Posicion = Pos;
                Equipo = equipo;
            }

            public double indiceAtaque()
            {
                double indice;
                indice = ( CantidadGoles / CantidadTirosArco ) * 100;
                return indice;
            }
            
        }
        static void Main(string[] args)
        {
  
            Jugador[] goleadores = new Jugador[]
            {
                new Jugador("Kylian", "Mbappé", 8, 19, 10, "Delantero", "Francia"),
                new Jugador("Lionel", "Messi", 8, 16, 10,"Delantero", "Argentina"),
                new Jugador("Erling", "Halaand", 7, 11, 9,"Delantero", "Noruega"),
                new Jugador("Harry", "Kane", 6, 10, 9,"Delantero", "Inglaterra"),
                new Jugador("Jude", "Bellinghan", 6, 9, 10,"Mediocampista", "Inglaterra"),
                new Jugador("Ousmane", "Dembelé", 5, 8, 7,"Delantero", "Francia"),
                new Jugador("Mikel", "Oryazabal", 5, 7, 21,"Delantero", "España")
            };
           
            Console.WriteLine("Lista de Goleadores");
            foreach (Jugador jugadores in goleadores)
            {
                Console.WriteLine($"Nombre y Apellido: {jugadores. Nombre} {jugadores.Apellido} | Goles: {jugadores.CantidadGoles} | Tiros al arco: {jugadores.CantidadTirosArco} | Dorsal: {jugadores.NumeroCamiseta} | Posición: {jugadores.Posicion} | Equipo: {jugadores.Equipo}");
            }
            Console.WriteLine("");
            Jugador jugador = IndiceAtaque(goleadores);
            Console.WriteLine($"Jugador con Mayor Indice de Ataque: {jugador.Nombre} {jugador.Apellido} con {jugador.indiceAtaque()}");

        }

        public static Jugador IndiceAtaque(Jugador[] jugadores)
        {
            Jugador JugadorMayorIndice = jugadores[0];
            Jugador JugadorAct = new Jugador();

            for (int x = 0; x < jugadores.Length; x++)
            {
                JugadorAct = jugadores[x];

                if(JugadorAct.indiceAtaque() > JugadorMayorIndice.indiceAtaque())
                {
                    JugadorMayorIndice = JugadorAct;
                }
            }
            return JugadorMayorIndice;
        } 
    }
}