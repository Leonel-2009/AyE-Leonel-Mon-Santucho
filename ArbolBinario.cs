using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro
{
    internal class ArbolBinario
    {
        public Nodo raiz;

        public void Insertar(Jugadores jugador)
        {
            raiz = Recursiva(raiz, jugador);
        }
        public Nodo Recursiva(Nodo nodo, Jugadores jugador)
        {
            if(nodo == null)
            {
                return new Nodo(jugador);
            }

            if(jugador.ID < nodo.jugador.ID)
            {
                nodo.Izquierdo = Recursiva(nodo.Izquierdo, jugador);
            }
            else
            {
                nodo.Derecho = Recursiva(nodo.Derecho, jugador);
            }

            return nodo;
        }


        public void Mostrarr()
        {
            Mostrando(raiz);
        }
        public void Mostrando(Nodo nodo)
        {
            if (nodo != null)
            {
                Mostrando(nodo.Izquierdo);
                nodo.jugador.Mostrar();
                Mostrando(nodo.Derecho);
            }
        }


        public Jugadores Buscar(int id)
        {
            Nodo actual = raiz;

            while (actual != null)
            {
                if (id == actual.jugador.ID)
                {
                    return actual.jugador;
                }

                if (id < actual.jugador.ID)
                {
                    actual = actual.Izquierdo;
                }
                else
                {
                    actual = actual.Derecho;
                }
            }
            return null;
        }

        public void Limpiar()
        {
            raiz = null;
        }
    }
}
