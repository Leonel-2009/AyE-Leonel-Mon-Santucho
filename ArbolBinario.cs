using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class ArbolBinario
    {
        public Nodo raiz;

        public void Insertar(Datos agente)
        {
            raiz = Recursiva(raiz, agente);
        }
        public Nodo Recursiva(Nodo nodo, Datos agente)
        {
            if (nodo == null)
            {
                return new Nodo(agente);
            }

            if (agente.ID < nodo.agente.ID)
            {
                nodo.Izquierda = Recursiva(nodo.Izquierda, agente);
            }
            else
            {
                nodo.Derecha = Recursiva(nodo.Derecha, agente);
            }

            return nodo;
        }


        public void Mostrar()
        {
            Mostrarr(raiz);
        }
        public void Mostrarr(Nodo nodo)
        {
            if (nodo != null)
            {
                Mostrarr(nodo.Izquierda);
                nodo.agente.Mostrar();
                Mostrarr(nodo.Derecha);
            }
        }


        public Datos Buscar(int id)
        {
            Nodo actual = raiz;

            while (actual != null)
            {
                if (id == actual.agente.ID)
                {
                    return actual.agente;
                }

                if (id < actual.agente.ID)
                {
                    actual = actual.Izquierda;
                }
                else
                {
                    actual = actual.Derecha;
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
