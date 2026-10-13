using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Nodo
    {
        public Datos agente { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(Datos agent)
        {
            agente = agent;
            Izquierda = null;
            Derecha = null;
        }
    }
}
