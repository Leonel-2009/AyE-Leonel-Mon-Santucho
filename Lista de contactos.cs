using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Programa 5:");
Console.WriteLine("-----Lista de Contactos-----");

List <string> contactos = new List<string>(){ "Leonel", "Joaquin", "Elias", "Astor", "Cielo", "Fernandez", "Jenifer"};
List<string> telefono = new List<string>(){ "541152354375", "541152175830", "541152190321", "541153529473", "541152175936", "541185913064", "525597219185" };

try
{
    Console.WriteLine("");
    Console.WriteLine("Elija una opción:");
    Console.WriteLine("1: Agregar contactos");
    Console.WriteLine("2: Mostrar contactos");
    Console.WriteLine("3: Buscar contactos");
    Console.WriteLine("4: Salir del programa");
    Console.WriteLine("");

    int opcion;

    do
    {
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                agregar_contactos(contactos, telefono);
                break;
            case 2:
                mostrar_contacto(contactos, telefono);
                break;
            case 3:
                buscar_contacto(contactos, telefono);
                break;
            case 4:
                Console.WriteLine("");
                Console.WriteLine("----CIERRE DE PROGRAMA----");
                Console.WriteLine("Nos vemos ;)");
                break;
            default:
                Console.WriteLine("Opción invalida");
                break;
        }

    } while (opcion != 4);
}
catch (FormatException)
{
    Console.WriteLine("No se permite caracteres en esta sección");
    Console.WriteLine("Cierre del programa");
}

void agregar_contactos(List<string> contacto, List<string> telefono)
{
    Console.WriteLine("");
    Console.WriteLine("----INGRESAR CONTACTO----");
    Console.WriteLine("");
    Console.WriteLine("ingrese el nombre");

    string nombre = Console.ReadLine();

    Console.WriteLine("");
    Console.WriteLine("ingrese el número");

    string numero = Console.ReadLine();

    contacto.Add(nombre);
    telefono.Add(numero);

    Console.WriteLine("");
    Console.WriteLine("Contacto agregado");

    Console.WriteLine("");
    Console.WriteLine("Recordatorio de opciones:");
    Console.WriteLine("1: Agregar contactos");
    Console.WriteLine("2: Mostrar contactos");
    Console.WriteLine("3: Buscar contactos");
    Console.WriteLine("4: Salir del programa");
    Console.WriteLine("");
}

void mostrar_contacto(List<string> contacto, List<string> telefono)
{
    Console.WriteLine("");
    Console.WriteLine("----MOSTRAR CONTACTO----");

    for (int i = 0; i < contacto.Count; i++)
    {
        Console.WriteLine(contacto[i] + " // " + telefono[i]);
    }
    
    Console.WriteLine("");
    Console.WriteLine("Recordatorio de opciones:");
    Console.WriteLine("1: Agregar contactos");
    Console.WriteLine("2: Mostrar contactos");
    Console.WriteLine("3: Buscar contactos");
    Console.WriteLine("4: Salir del programa");
    Console.WriteLine("");
}

void buscar_contacto(List<string> contacto, List<string> telefono)
{
    Console.WriteLine("");
    Console.WriteLine("----BUSCAR CONTACTO----");
    Console.WriteLine("");
    string buscar = Console.ReadLine();

    bool encontrado = false;

    for (int i = 0; i < contacto.Count; i++)
    {
        if (contacto[i] == buscar)
        {
            encontrado = true;
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + contacto[i]);
            Console.WriteLine("Numero: " + telefono[i]);
        }
    }
    if (!encontrado)
    {
        Console.WriteLine("");
        Console.WriteLine("Contacto no encotrado ;(");
    }

    Console.WriteLine("");
    Console.WriteLine("Recordatorio de opciones:");
    Console.WriteLine("1: Agregar contactos");
    Console.WriteLine("2: Mostrar contactos");
    Console.WriteLine("3: Buscar contactos");
    Console.WriteLine("4: Salir del programa");
    Console.WriteLine("");
}