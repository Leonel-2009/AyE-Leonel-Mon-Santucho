using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Puntos2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Puntos2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Coordenadas ({X},{Y})");
        }
    }
}
