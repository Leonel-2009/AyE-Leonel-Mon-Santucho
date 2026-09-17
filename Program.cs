namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puntos2D puntitos = new Puntos2D(60, 48);
            Puntos2D puntitos2 = new Puntos2D(10, 70);
            Puntos2D puntitos3 = new Puntos2D(50, 50);

            puntitos.Mostrar();
            puntitos2.Mostrar();
            puntitos3.Mostrar();
        }
    }
}
