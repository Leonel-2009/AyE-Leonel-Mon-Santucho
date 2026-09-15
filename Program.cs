namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void fun1()
            {
                Console.WriteLine("Actividad N°1");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una palabra");

                string palabra = Console.ReadLine();

                Stack<char> invertido = new Stack<char>();

                foreach (char c in palabra)
                {
                    invertido.Push(c);
                }

                Console.Write("Palabra invertida: ");

                while (invertido.Count > 0)
                {
                    Console.Write(invertido.Pop());
                }
            }
            void fun2()
            {
                Console.WriteLine("Actividad N°2");
                Console.WriteLine("");
                Console.WriteLine("Navegador Wep");
                Console.WriteLine("Opciones:");
                Console.WriteLine("1- visitar web");
                Console.WriteLine("2- ir a la web anterior");
                Console.WriteLine("3- salir");
                Console.WriteLine("");

                Stack<string> Webs = new Stack<string>();

                string Pagina = "Nada";

                int opcion;

                do
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {

                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese la pagina que quiere buscar");

                            string PaginaNueva = Console.ReadLine();
                            Pagina = PaginaNueva;
                            Webs.Push(Pagina);

                            Console.WriteLine($"Pagina: {Pagina}");
                            Console.WriteLine("");

                            break;
                        case 2:
                            if (Webs.Count > 0)
                            {
                                Pagina = Webs.Pop();
                                Console.WriteLine("");
                                Console.WriteLine($"Pagina anterior: {Pagina}");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("No has buscado una pagina");
                                Console.WriteLine("");
                            }
                            break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("Nos vemos ;)");
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Opcion incorrecta");
                            break;
                    }

                    Console.WriteLine("Opciones:");
                    Console.WriteLine("1- visitar web");
                    Console.WriteLine("2- ir a la web anterior");
                    Console.WriteLine("3- salir");
                    Console.WriteLine("");
                }
                while (opcion != 3);
            }
            void fun3()
            {
                Console.WriteLine("Actividad N°3");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una expresión:");
                string textazo = Console.ReadLine();

                bool resultado = DelimitadoresCorrectos(textazo);

                Console.WriteLine("Resultado: " + resultado);
            }
            void fun4()
            {
                GestorEdicion gestor = new GestorEdicion();

                gestor.Agregar("Agregar", "Hola");
                gestor.Agregar("Agregar", "¿Como estas?");
                gestor.Agregar("Eliminar", "Hola");
                gestor.Agregar("Eliminar", "¿Como estas?");

                gestor.Deshacer();
                gestor.Deshacer();
                gestor.Deshacer();
                gestor.Deshacer();
            }
            void fun5()
            {
                Console.WriteLine("Actividad N°5");
                Console.WriteLine("Calculadora");
                Console.WriteLine("Escriba '=' para mostrar el resultado");
                Console.WriteLine("Escriba 'salir' para terminar");
                Console.WriteLine();

                Stack<double> pila = new Stack<double>();
                string entrada;

                while (true)
                {
                    Console.Write("Ingrese números y operadores: ");
                    entrada = Console.ReadLine();

                    if (entrada == "salir")
                    {
                        break;
                    }

                    if (entrada == "=")
                    {
                        if (pila.Count > 0)
                        {
                            Console.WriteLine($"Resultado: {pila.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía");
                        }

                        continue;
                    }

                    double numero;
                    if (double.TryParse(entrada, out numero))
                    {
                        pila.Push(numero);
                        Console.WriteLine("Número agregado a la pila");
                    }
                    else if (entrada == "+" || entrada == "-" ||
                             entrada == "*" || entrada == "/")
                    {
                        if (pila.Count < 2)
                        {
                            Console.WriteLine("No hay suficientes números en la pila");
                            continue;
                        }

                        double num2 = pila.Pop();
                        double num1 = pila.Pop();

                        double resultado = 0;

                        switch (entrada)
                        {
                            case "+":
                                resultado = num1 + num2;
                                break;

                            case "-":
                                resultado = num1 - num2;
                                break;

                            case "*":
                                resultado = num1 * num2;
                                break;

                            case "/":
                                if (num2 == 0)
                                {
                                    Console.WriteLine("No se puede dividir por cero");

                                    pila.Push(num1);
                                    pila.Push(num2);

                                    continue;
                                }

                                resultado = num1 / num2;
                                break;
                        }

                        pila.Push(resultado);

                        Console.WriteLine($"Resultado agregado a la pila: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida");
                    }
                }

                Console.WriteLine("Fin programa");
            }

            ProcesarTarea orden = new ProcesarTarea();

            Tarea tarea = new Tarea(1, "Informe", 1, 30);
            Tarea tarea2 = new Tarea(2, "Laboratorio", 4, 30);
            Tarea tarea3 = new Tarea(3, "Estudios de medicina", 2, 45);
            Tarea tarea4 = new Tarea(4, "Informe Técnico", 3, 50);

            orden.AgregarTarea(tarea);
            orden.AgregarTarea(tarea2);
            orden.AgregarTarea(tarea3);
            orden.AgregarTarea(tarea4);
            Console.WriteLine();
            orden.cima();
            Console.WriteLine();
            orden.AtenderTarea();
            Console.WriteLine();
            orden.cima();
            Console.WriteLine();
            orden.AtenderTarea();
            Console.WriteLine();
            orden.cima();
            Console.WriteLine();
            orden.AtenderTarea();
            Console.WriteLine();
            orden.cima();
            Console.WriteLine();
            orden.AtenderTarea();
        }

        static bool DelimitadoresCorrectos(string textazo)
        {
            Stack<char> deli = new Stack<char>();

            foreach (char texto in textazo)
            {

                if (texto == '(' || texto == '[' || texto == '{')
                {
                    deli.Push(texto);
                }

                else if (texto == ')' || texto == ']' || texto == '}')
                {
                    if (deli.Count == 0)
                    {
                        return false;
                    }

                    char apertura = deli.Pop();

                    if ((texto == ')' && apertura != '(') || (texto == ']' && apertura != '[') || (texto == '}' && apertura != '{'))
                    {
                        return false;
                    }
                }
            }

            return deli.Count == 0;
        }

        
    }
}   
 
        

    


