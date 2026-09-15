using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Nodo
    {
        public int valor { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(int val)
        {
            valor = val;
            Izquierda = null;
            Derecha = null;
        }
    }
}
