using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    internal class GestorEdicion
    {
        Stack<AccionTexto> historial = new Stack<AccionTexto>();

        public void Agregar(string tipo, string contenido)
        {
            AccionTexto accion = new AccionTexto(tipo, contenido);
            historial.Push(accion);
        }

        public void Deshacer()
        {
            if (historial.Count > 0)
            {
                AccionTexto accion = historial.Pop();

                Console.WriteLine($"Deshaciendo: {accion.TipoAccion}");
                Console.WriteLine($"Contenido: {accion.Contenido}");
            }
            else
            {
                Console.WriteLine("No hay acciones para deshacer");
            }
        }

        
    }
}
