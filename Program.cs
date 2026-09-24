namespace BB_en_BDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa N°8");
            Console.WriteLine("");

            int menu;

            do
            {
                Console.WriteLine("Menu Pokemon Base de Datos");
                Console.WriteLine("Elija alguna de las siguientes opciones:");
                Console.WriteLine("1- Agregar Pokemon");
                Console.WriteLine("2- Consultar Base de Datos Pokemon");
                Console.WriteLine("3- Eliminar Pokemon de Base de Datos Pokemon");
                Console.WriteLine("4- Buscar en el Arbol Binario");
                Console.WriteLine("5- Fin Programa");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;

                }
            }
            while (menu != 5);
        }
    }
}
