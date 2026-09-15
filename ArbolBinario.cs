using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArbolBinario
    {
        public Nodo raiz;

        public void Insertar(int valor)
        {
            raiz = Recursiva(raiz, valor);
        }

        public Nodo Recursiva(Nodo nodo, int valor)
        {
            if(nodo == null)
            {
                return new Nodo(valor);
            }

            if (valor < nodo.valor)
            {
                nodo.Izquierda = Recursiva(nodo.Izquierda, valor);
            }
            else
            {
                nodo.Derecha = Recursiva(nodo.Derecha, valor);
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
                Console.WriteLine(nodo.valor + "");
                Mostrarr(nodo.Derecha);
            }
        }


        public int ObtenerMin()
        {
            if(raiz == null)
            {
                throw new InvalidOperationException("Arbol lado izquierdo vacio :))");
            }

            Nodo actual = raiz;

            while(actual.Izquierda != null)
            {
                actual = actual.Izquierda;
            }
            return actual.valor;
        }
        public int ObtenerMayor()
        {
            if (raiz == null)
            {
                throw new InvalidOperationException("Arbol lado derecho vacio :))");
            }

            Nodo actual = raiz;

            while (actual.Derecha != null)
            {
                actual = actual.Derecha;
            }
            return actual.valor;
        }


        public int CantidadNodos()
        {
            return ContNodos(raiz);
        }
        public int ContNodos(Nodo nodo)
        {
            if(nodo == null)
            {
                return 0;
            }

            return 1 + ContNodos(nodo.Izquierda) + ContNodos(nodo.Derecha);

        }


        public int ObtenerAltura()
        {
            return Altura(raiz);
        }
        public int Altura(Nodo nodo)
        {
            if(nodo == null)
            {
                return 0;
            }

            int LadoIzq = Altura(nodo.Izquierda);
            int LadoDer = Altura(nodo.Derecha);

            if(LadoIzq > LadoDer)
            {
                return LadoIzq + 1;
            }
            else
            {
                return LadoDer + 1;
            }
        }


        public int CantidadNodosNull()
        {
            return ContNodosNull(raiz);
        }
        public int ContNodosNull(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            if(nodo.Izquierda == null && nodo.Derecha == null)
            {
                return 1;
            }

            return ContNodosNull(nodo.Izquierda) + ContNodosNull(nodo.Derecha);
        }


        public void EliminarNodo(int valor)
        {
            raiz = Eliminar(raiz, valor);
        }
        public Nodo Eliminar(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                if (nodo == null)
                {
                    return new Nodo(valor);
                }

                if (valor < nodo.valor)
                {
                    nodo.Izquierda = Eliminar(nodo.Izquierda, valor);
                }
                else if(valor > nodo.valor)
                {
                    nodo.Derecha = Eliminar(nodo.Derecha, valor);
                }
                else
                {
                    if(nodo.Izquierda == null)
                    {
                        return nodo.Derecha;
                    }

                    if (nodo.Derecha == null)
                    {
                        return nodo.Izquierda;
                    }

                    Nodo aux = nodo.Derecha;

                    while(aux.Izquierda != null)
                    {
                        aux = aux.Izquierda;
                    }

                    nodo.valor = aux.valor;

                    nodo.Derecha = Eliminar(nodo.Derecha, aux.valor);
                }
            }
            return nodo;
        }

    }
}
