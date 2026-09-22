using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext();

            Punto2D puntitos = new Punto2D(60, 48);
            Punto2D puntitos2 = new Punto2D(10, 70);
            Punto2D puntitos3 = new Punto2D(50, 50);

            Console.WriteLine("Puntos determinados:");
            puntitos.Mostrar();
            puntitos2.Mostrar();
            puntitos3.Mostrar();

            //Insertar
            db.Puntos.Add(puntitos);
            db.Puntos.Add(puntitos2);
            db.Puntos.Add(puntitos3);

            db.SaveChanges();

            //Actualizar puntitos3
            Console.WriteLine("");
            Console.WriteLine("Actualizar tercer punto:");
            Console.WriteLine("Ingrese un nuevo punto (x,y):");
            Console.Write("punto X:");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.Write("punto Y:");
            int y = Convert.ToInt16(Console.ReadLine());

            puntitos3.X = x;
            puntitos3.Y = y;

            db.Puntos.Update(puntitos3);
            db.SaveChanges();

            //Remover puntitos1
            Console.WriteLine("");
            Console.WriteLine("Se removió el primer punto");
            Console.WriteLine("");
            db.Puntos.Remove(puntitos);
            db.SaveChanges();

            //Mostrar la info de Sql
            Console.WriteLine("");
            Console.WriteLine("SQL:");
            var todos = db.Puntos.ToList();
            foreach (var punto in todos)
            {
                Console.WriteLine($"ID: {punto.ID} | (X: {punto.X}, Y: {punto.Y})");
            }
        }
    }
}
