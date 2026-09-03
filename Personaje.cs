using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Personaje
    {
        public int vidaTotal { get; set; }
        public int vidaActual { get; set; }
        public string UltimaAccion { get; set; }

        public Personaje(int VidaT, int VidaA, string Accion)
        {
            vidaTotal = VidaT;
            vidaActual = VidaA;
            UltimaAccion = Accion;
        }

    }
}
