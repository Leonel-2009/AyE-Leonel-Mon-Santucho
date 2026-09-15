using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    internal class Tarea
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public int Prioridad { get; set; }
        public int EstimacioMinutos { get; set; }

        public Tarea (int id, string titulo, int prio, int EM)
        {
            ID = id;
            Titulo = titulo;
            Prioridad = prio;
            EstimacioMinutos = EM;
        }
    }
}
