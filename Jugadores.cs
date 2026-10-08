using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Simulacro
{
    internal class Jugadores
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string pais { get; set; }
        public string posicion { get; set; }
        public int goles { get; set; }
        public int mundiales_jugados { get; set; }
        public Jugadores()
        {

        }

        public Jugadores(int id, string N, string A, string P, string Pos, int G, int MJ)
        {
            ID = id;
            nombre = N;
            apellido = A;
            pais = P;
            posicion = Pos;
            goles = G;
            mundiales_jugados = MJ;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Jugador: ID: {ID} | Nombre: {nombre} | apellido: {apellido} | pais: {pais} | posición: {posicion} | goles: {goles} | mundiales jugados: {mundiales_jugados}");
        }
    }
}
