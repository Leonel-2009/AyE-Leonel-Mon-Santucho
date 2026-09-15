using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    internal class ProcesarTarea
    {
        Stack<Tarea> tareas = new Stack<Tarea>();

        public void AgregarTarea(Tarea tarea)
        {
            tareas.Push(tarea);
        }
        public void cima()
        {
            if(tareas.Count > 0)
            {
                Tarea tarea = tareas.Peek();

                Console.Write("Tarea de la cima: ");
                Console.WriteLine($"ID: {tarea.ID} | Titulo: {tarea.Titulo} | Prioridad: {tarea.Prioridad} | Estimacion de tiempo: {tarea.EstimacioMinutos} Min.");
            }
        }
        public void AtenderTarea()
        {
            if(tareas.Count > 0)
            {
                Tarea tarea = tareas.Pop();
                Console.WriteLine($"Atendiendo a: {tarea.Titulo}");
            }
            else
            {
                Console.WriteLine("No se está atendiendo una tarea");
            }
        }

    }
}
