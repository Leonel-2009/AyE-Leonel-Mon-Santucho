using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Datos
    {
        public int ID { get; set; }
        public string Nombre_agente { get; set; }
        public string Tipo_agente { get; set; }
        public string Nacionalidad { get; set; }
        public string Fecha_lanzamiento { get; set; }

        public Datos()
        {

        }

        public Datos(int id, string N_A, string T_A, string N, string F_L)
        {
            ID = id;
            Nombre_agente = N_A;
            Tipo_agente = T_A;
            Nacionalidad = N;
            Fecha_lanzamiento = F_L;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Agente: ID: {ID}, Nombre: {Nombre_agente}, Tipo: {Tipo_agente}, Nacionalidad: {Nacionalidad}, Fecha lanzamiento: {Fecha_lanzamiento}");
        }
    }

}
