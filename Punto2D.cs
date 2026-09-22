using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Punto2D
    {
        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Punto2D(int x, int y)
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
