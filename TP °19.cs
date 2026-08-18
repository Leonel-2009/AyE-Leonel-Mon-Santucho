using static ConsoleApp19.Program;

namespace ConsoleApp19
{
    internal class Program
    {
        public struct Pokemon
        {
            public string nombre { get; set; }
            public string tipo { get; set; }
            public int nivel { get; set; }
            public int puntos_salud { get; set; }
            public int puntos_salud_actual { get; set; }
            public int ataque { get; set; }
            public int ataque_especial { get; set; }
            public int defensa { get; set; }
            public int defensa_especial { get; set; }
            public int velocidad { get; set; }
            public string estado { get; set; }
            public Pokemon(string n, string t, int niv, int ps, int PSa, int atk, int atkEs, int def, int defEs, int v, string est)
            {
                nombre = n;
                tipo = t;
                nivel = niv;
                puntos_salud = ps;
                ataque = atk;
                ataque_especial = atkEs;
                defensa = def;
                defensa_especial = defEs;
                velocidad = v;
                estado = est;
            }

            public void cambio_estado(string estado_actual)
            {
                if (estado_actual == "Normal")
                {
                    Console.WriteLine($"El pokemon {nombre} esta en estado {estado}");
                }
                else if (estado_actual != estado)
                {
                    Console.WriteLine($"El pokemon {nombre} pasó de estado {estado} a {estado_actual}");
                }
                else
                {
                    Console.WriteLine($"el pokemon {nombre} no cambió de estado");
                }
            }

            public void Curacion()
            {
                puntos_salud_actual = puntos_salud;
            }

            public bool pokemon_controlable(int medallas)
            {
                int nivel_controlable = 20 + (medallas * 10);

                if (nivel_controlable > nivel)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Daño(bool tipo)
            {
                int porcentajeDefensa = 0;
                if (tipo)
                {
                    porcentajeDefensa = (ataque * (defensa / 2)) / 100;
                    puntos_salud_actual = puntos_salud_actual - (ataque - porcentajeDefensa);
                }
                else
                {
                    porcentajeDefensa = (ataque_especial * (defensa_especial / 2)) / 100;
                    puntos_salud_actual = puntos_salud_actual - (ataque_especial - porcentajeDefensa);
                }
            }

            public bool Peligrosidad()
            {
                int peligrosidad = (ataque + ataque_especial + velocidad) / 3;

                if (peligrosidad < 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public struct Entrenador
        {
            public string nombre { get; set; }
            public int pokedolares { get; set; }
            public int cont_medallas { get; set; }
            public string[] medalla { get; set; }
            public Pokemon[] equipo { get; set; }

            public Entrenador(string n, int pdol, int contM ,string[] meda, Pokemon[] equi)
            {
                nombre = n;
                pokedolares = pdol;
                cont_medallas = contM;
                medalla = meda;
                equipo = equi;
            }
            public int nivel()
            {
                int acum = 0;

                for (int x = 0; x < 6; x++)
                {
                    acum += equipo[x].nivel;
                }

                return acum;
            }
            public int Controlables()
            {
                int cant_controlables = 0;
                int cant_medallas = medalla.Length;
                for (int x = 0; x < 5; x++)
                {
                    if (equipo[x].pokemon_controlable(cant_medallas))
                    {
                        cant_controlables += 1;
                    }
                }
                Console.WriteLine(cant_controlables);
                return cant_controlables;
            }

            public void CurarEquipo()
            {
                for (int x = 0; x < 5; x++)
                {
                    equipo[x].Curacion();
                }
                Console.WriteLine("Equipo curado");
            }
            public int Cont_peligrosidad()
            {
                int acum = 0;
                for (int x = 0; x < 5; x++)
                {
                    if (equipo[x].Peligrosidad())
                    {
                        acum += 1;
                    }
                }
                return acum;
            }
        }
        //-----------------------------funciones---------------------------------

        public void comparar_medallas(Entrenador entrenador1, Entrenador entrenador2)
        {
            if(entrenador1.cont_medallas > entrenador2.cont_medallas)
            {
                Console.WriteLine($"El entrenador {entrenador1.nombre} tiene más medallas que el entrenador {entrenador2.nombre}");
            }
            else
            {
                Console.WriteLine($"El entrenador {entrenador2.nombre} tiene más medallas que el entrenador {entrenador1.nombre}");
            }
        }

        public void comparar_nivel(Entrenador entrenador1, Entrenador entrenador2)
        {
            if(entrenador1.nivel() > entrenador2.nivel())
            {
                Console.WriteLine($"El entrenador {entrenador1.nombre} tiene más pokemones de nivel alto que el entrenador {entrenador2.nombre}");
            }
            else
            {
                Console.WriteLine($"El entrenador {entrenador2.nombre} tiene más pokemones de nivel alto que el entrenador {entrenador1.nombre}");
            }
        }



        //-----------------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }    
}