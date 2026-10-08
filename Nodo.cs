using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro
{
    internal class Nodo
    {
        public Jugadores jugador { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(Jugadores J)
        {
            jugador = J;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
