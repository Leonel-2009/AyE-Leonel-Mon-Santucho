using System.Drawing;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

Console.WriteLine("---TP N°12 Primera parte---");
Console.WriteLine("Elija del 1 al 11");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        ejercicio1();
        break;
    case 2:
        ejercicio2();
        break;
    case 3:
        ejercicio3();
        break;
    case 4:
        ejercicio4();
        break;
    case 5:
        ejercicio5();
        break;
    case 6:
        ejercicio6();
        break;
    case 7:
        ejercicio7();
        break;
    case 8:
        ejercicio8();
        break;
    case 9:
        ejercicio9();
        break;
    case 10:
        ejercicio10();
        break;
    case 11:
        ejercicio11();
        break;
    default:
        Console.WriteLine("Opción invalida");
        break;
}
void ejercicio1()
{
    Console.WriteLine("----Ejercicio 1----");
    Console.WriteLine("");
    Console.WriteLine("Ingrese alguno de los siguientes codigos y verá cuál es su categoria: ");
    Console.WriteLine("Codigos: I, C, J, A");

    string entrada = Console.ReadLine().ToUpper();

    if (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Error: No se permite espacios en blanco");
    }
    else if (entrada.Length != 1 || !char.IsLetter(entrada[0]))
    {
        Console.WriteLine("Error: No se permiten números ni caracteres especiales");
    }
    else if (entrada is not ("I" or "C" or "J" or "A"))
    {
        Console.WriteLine("No se encontró la categoría");
    }
    else
    {
        string codigo = entrada;

        switch (codigo)
        {
            case "I":
                Console.WriteLine("Categoría: Infantiles");
                Console.WriteLine("Cuota: $800,00");
                Console.WriteLine("");
                break;

            case "C":
                Console.WriteLine("Categoría: Cadete");
                Console.WriteLine("Cuota: $1.000,00");
                Console.WriteLine("");
                break;

            case "J":
                Console.WriteLine("Categoría: Juvenil");
                Console.WriteLine("Cuota: $1.200,00");
                Console.WriteLine("");
                break;

            case "A":
                Console.WriteLine("Categoría: Adulto");
                Console.WriteLine("Cuota: $900,00");
                Console.WriteLine("");
                break;
        }
    }
}
void ejercicio2()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("----Ejercicio 2----");
        Console.WriteLine("");

        float costo = 300;
        float resTipo = 0;
        float resDestino = 0;

        Console.WriteLine("Ingrese el tipo y destino de la encomienda sabiendo que: ");
        Console.WriteLine("Codigo de tipo: S, X, E");
        Console.WriteLine("Codigo de encomienda: L, N");
        Console.WriteLine("");
        Console.WriteLine("Ingrese el tipo:");

        char tipo = Convert.ToChar(Console.ReadLine().ToUpper());

        Console.WriteLine("Ahora el destino de la encomienda");

        char destino = Convert.ToChar(Console.ReadLine().ToUpper());

        if (!char.IsLetter(tipo))
        {
            Console.WriteLine("Error: No se permite números");
        }
        else if (!char.IsLetter(destino))
        {
            Console.WriteLine("Error: No se permite números");
        }
        else if (!char.IsLetter(tipo) && !char.IsLetter(destino))
        {
            Console.WriteLine("Error: No se permiten números");
        }
        else if (tipo is not ('S' or 'X'or 'E') || destino is not ('L' or 'N'))
        {
            Console.WriteLine("No se encontró el destino o tipo de la encomienda");
        }
        else
        {
            switch (tipo)
            {
                case 'S':
                    resTipo = 0;
                    break;

                case 'X':
                    resTipo = 0.20f;
                    break;

                case 'E':
                    resTipo = 0.40f;
                    break;
            }
            switch (destino)
            {
                case 'L':
                    resDestino = 0.05f;
                    break;

                case 'N':
                    resDestino = 0.20f;
                    break;
            }

            costo = costo + (costo * resTipo) + (costo * resDestino);

            Console.WriteLine("El costo total es de: $" + costo);
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: No se permiten números");
    }
}
void ejercicio3()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("----Ejercicio 3----");
        Console.WriteLine("");
        Console.WriteLine("Ingrese los datos de los siguientes puntos que le pide Trilobite SA");

        double sueldoBasico;
        double porcAnt = 0;
        double antiguedad;
        double presentismo;
        double remuneracion;
        double jubilacion;
        double obraSocial;
        double descuento;
        double sueldoNeto;

        Console.WriteLine("Ingrese su sueldo básico: ");

        sueldoBasico = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese alguno de los códigos de antigüedad: ");
        Console.WriteLine("1 = Menos de un año");
        Console.WriteLine("2 = Desde 1 a 3 años");
        Console.WriteLine("3 = Desde 3 a 5 años");
        Console.WriteLine("4 = 5 años o mas");

        int codigo2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("¿Usted tiene presentismo?");

        char pres = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (codigo2)
        {
            case 1:
                porcAnt = 0;
                break;
            case 2:
                porcAnt = 0.10;
                break;
            case 3:
                porcAnt = 0.15;
                break;
            case 4:
                porcAnt = 0.20;
                break;
        }

        antiguedad = sueldoBasico * porcAnt;

        if (pres == 'V')
        {
            presentismo = sueldoBasico * 0.10;
        }
        else
        {
            presentismo = 0;
        }

        remuneracion = sueldoBasico + antiguedad + presentismo;

        jubilacion = remuneracion * 0.13;
        obraSocial = remuneracion * 0.03;

        descuento = jubilacion + obraSocial;

        sueldoNeto = remuneracion - descuento;

        Console.WriteLine("La remuneracion es: $" + remuneracion);
        Console.WriteLine("El descuentos es: $" + descuento);
        Console.WriteLine("El sueldo neto es: $" + sueldoNeto);
    }
    catch (OverflowException)
    {
        Console.WriteLine("¿Quien sos Elon Musk?, afuera por chistoso");
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permiten caracteres, espacios en blanco o letras");
    }
}
void ejercicio4()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("----Ejercicio 4----");
        Console.WriteLine("");
        Console.WriteLine("Ingrese una fecha");
        Console.WriteLine("Dia:");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mes:");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Año (Solo dos digitos):");
        int año = Convert.ToInt32(Console.ReadLine());

        string Mes = "";

        switch (mes)
        {
            case 1:
                Mes = "enero";
                break;
            case 2:
                Mes = "febrero";
                break;
            case 3:
                Mes = "marzo";
                break;
            case 4:
                Mes = "abril";
                break;
            case 5:
                Mes = "mayo";
                break;
            case 6:
                Mes = "junio";
                break;
            case 7:
                Mes = "julio";
                break;
            case 8:
                Mes = "octubre";
                break;
            case 9:
                Mes = "septiembre";
                break;
            case 10:
                Mes = "octubre";
                break;
            case 11:
                Mes = "noviembre";
                break;
            case 12:
                Mes = "diciembre";
                break;
            default:
                Console.WriteLine("Este mes no existe");
                break;
        }

        año = año + 2000;

        Console.WriteLine("La fecha es: " + dia + " de " + Mes + " de " + año);
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permite caracteres o espacios en blanco");
    }
}
void ejercicio5()
{

}
void ejercicio6()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("----Ejercicio 6----");
        Console.WriteLine("");
        Console.WriteLine("Ingrese el valor total que debe pagar:");

        float pago = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Ok, debe pagar $" + pago + ", Saque una bolita y digame que color le toca para hacerle un descuento");
        Console.Write("Los colores que le puede tocar son: blanco, verde, amarillo, azul, rojo: ");

        string bolita = Console.ReadLine();
        float valorBol = 0;

        switch (bolita)
        {
            case "blanco":
                Console.WriteLine("A usted le toco el descuento del 0%");
                valorBol = 0;
                break;
            case "verde":
                Console.WriteLine("A usted le toco el descuento del 10%");
                valorBol = 10;
                break;
            case "amarillo":
                Console.WriteLine("A usted le toco el descuento del 25%");
                valorBol = 25;
                break;
            case "azul":
                Console.WriteLine("A usted le toco el descuento del 50%");
                valorBol = 50;
                break;
            case "rojo":
                Console.WriteLine("¡Que suerte!, A usted le toco el descuento del 100%");
                valorBol = 100;
                break;
            default:
                Console.WriteLine("Este color no está en las bolitas");
                break;
        }
        if (bolita == "blanco" || bolita == "verde" || bolita == "azul" || bolita == "amarillo" || bolita == "rojo")
        {
            float pagoFinal = pago - (pago * valorBol / 100);
            Console.WriteLine("El precio a pagar es $" + pagoFinal);
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permiten caracteres o espacios en blanco");
    }
}
void ejercicio7()
{
    Console.WriteLine("");
    Console.WriteLine("----Ejercicio 7----");
    Console.WriteLine("");
    Console.WriteLine("----Juego De Preguntas----");
    Console.WriteLine("Se le hara una serie de tres preguntas, tiene que responder con *SI* o con *NO*. Si se responde mal cualquiera de ellas se termina el juego");
    Console.Write("1ra Pregunta:");
    Console.WriteLine("¿Colon descubrió América ?");

    string pregunta1 = Console.ReadLine();

    if (pregunta1.All(char.IsDigit))
    {
        Console.WriteLine("No se permite números");
    }
    else if(pregunta1 is not ("no" or "NO" or "No" or "nO") && pregunta1 is not ("si" or "Si" or "sI" or "SI")) 
    {
        Console.WriteLine("Tiene que responder con si o con no");
        Console.WriteLine("Fin del juego");
    }
    else
    {
        if (pregunta1 is ("no" or "NO" or "nO" or "No"))
        {
            Console.WriteLine("Respuesta incorrecta (No podes ser tan malo amigo)");
        }
        else
        {
            Console.WriteLine("Respuesta correcta. Siguiente pregunta");
            Console.Write("2da Pregunta: ");
            Console.WriteLine("¿La independencia de México fue en el año 1810?");

            string pregunta2 = Console.ReadLine().ToLower();

            if (pregunta2.All(char.IsDigit))
            {
                Console.WriteLine("No se permite números");
            }
            else if (pregunta2 is not ("no" or "NO" or "No" or "nO") && pregunta2 is not ("si" or "Si" or "sI" or "SI"))
            {
                Console.WriteLine("Tiene que responder con si o con no");
                Console.WriteLine("Fin del juego");
            }
            else
            {
                if (pregunta2 is ("no" or "NO" or "No" or "nO"))
                {
                    Console.WriteLine("Respuesta incorrecta (Nada mal pero bueno)");
                }
                else
                {
                    Console.WriteLine("Respuesta correcta. Ultima pregunta");
                    Console.Write("3da Pregunta: ");
                    Console.WriteLine("¿The Doors fue un grupo de rock Americano?");

                    string pregunta3 = Console.ReadLine().ToLower();

                    if (pregunta3.All(char.IsDigit))
                    {
                        Console.WriteLine("No se permite números");
                    }
                    else if (pregunta3 is not ("no" or "NO" or "No" or "nO") && pregunta3 is not ("si" or "Si" or "sI" or "SI"))
                    {
                        Console.WriteLine("Tiene que responder con si o con no");
                        Console.WriteLine("Fin del juego");
                    }
                    else
                    {
                        if (pregunta3 is ("no" or "NO" or "No" or "nO"))
                        {
                            Console.WriteLine("Respuesta incorrecta (Te falto muy poco)");
                        }
                        else
                        {
                            Console.WriteLine("Respuesta correcta");
                            Console.WriteLine("¡¡¡¡¡¡¡¡¡¡¡Ganaste broooooooo!!!!!!!!!!!");
                        }
                    }
                }
            }
        }
    }
}
void ejercicio8()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("----Ejercicio 8----");
        Console.WriteLine("");
        Console.WriteLine("Ingrese el valor total que debe pagar:");

        float pago = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Ok, hoy está de suerte ya que se está haciendo una promoción en el supermercado :)");
        Console.WriteLine("Usted saque un número al azar,si es menor a 74 el descuento es del 15% pero si es mayor o igual el descuento será del 20%");

        int numero = Convert.ToInt32(Console.ReadLine());
        float descuento = 0f;
        int descuento1 = 0;

        if (numero < 74)
        {
            descuento1 = 15;
            descuento = 0.15f;
        }
        else if (numero >= 74)
        {
            descuento1 = 20;
            descuento = 0.20f;
        }

        float precio_final = pago - (pago * descuento);

        Console.WriteLine($"El precio a pagar es de: ${pago}");
        Console.WriteLine($"El descuento es del {descuento1}%");
        Console.WriteLine($"El precio final es: ${precio_final}");
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permite letras");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Ese número no esta permitido");
    }
}
void ejercicio9()
{
    Console.WriteLine("");
    Console.WriteLine("----Ejercicio 9----");
    Console.WriteLine("");
    Console.WriteLine("calcularemos sus pulsaciones");
    Console.Write("antes de eso digame, ¿Usted qué sexualidad es?: ");

    string sexualidad = Console.ReadLine().ToLower();

    if (sexualidad != "masculino" && sexualidad != "femenino")
    {
        Console.WriteLine("Solo escriba si es hombre o mujer, no se aceptan números u otras cosas chistoso");
    }
    else
    {
        switch (sexualidad)
        {
            case "masculino":
                pulsaciones_hombre();
                break;
            case "femenino":
                pulsaciones_mujer();
                break;
        }
        void pulsaciones_hombre()
        {
            Console.WriteLine("Ok, usted es del sexo masculino");
            Console.WriteLine("Ingrese su edad ahora");

            int edad = Convert.ToInt16(Console.ReadLine());

            if (edad >= 122)
            {
                Console.WriteLine("Edad sospechosa");
            }
            else
            {
                int num_pulsaciones = (210 - edad) / 10;

                Console.WriteLine($"Sus pulsaciones son de {num_pulsaciones} por cada 10 segundos");
            }
        }
        void pulsaciones_mujer()
        {
            Console.WriteLine("Ok, usted es del sexo femenino");
            Console.WriteLine("Ingrese su edad ahora");

            int edad = Convert.ToInt16(Console.ReadLine());

            if (edad >= 122)
            {
                Console.WriteLine("Edad sospechosa");
            }
            else
            {
                int num_pulsaciones = (220 - edad) / 10;

                Console.WriteLine($"Sus pulsaciones son de {num_pulsaciones} por cada 10 segundos");
            }
        }
    }
}
void ejercicio10()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("----Ejercicio 10----");
        Console.WriteLine("");
        Console.WriteLine("Ingrese la mejor nota de sus 3 alumnos y veremos quien es el abanderado, 1er escolta y 2do escolta");
        Console.WriteLine("");

        string[] nombres = new string[3];
        string[] apellidos = new string[3];
        double[] promedios = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Datos del alumno N° {i + 1}");

            Console.Write("Nombre del alumno: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Apellido del alumno: ");
            apellidos[i] = Console.ReadLine();

            Console.Write("Promedio del alumno: ");
            promedios[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = i + 1; j < 3; j++)
            {
                if (promedios[j] > promedios[i])
                {
                    double auxPromedio = promedios[i];
                    promedios[i] = promedios[j];
                    promedios[j] = auxPromedio;

                    string auxNombre = nombres[i];
                    nombres[i] = nombres[j];
                    nombres[j] = auxNombre;

                    string auxApellido = apellidos[i];
                    apellidos[i] = apellidos[j];
                    apellidos[j] = auxApellido;
                }
            }
        }
        Console.WriteLine($" El abanderado será el alumno: {nombres[0]} {apellidos[0]} - Promedio: {promedios[0]}");
        Console.WriteLine($"El primer escolta será el alumno: {nombres[1]} {apellidos[1]} - Promedio: {promedios[1]}");
        Console.WriteLine($"El segundo escolta será el alumno: {nombres[2]} {apellidos[2]} - Promedio: {promedios[2]}");
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permite caracteres o espacios en blanco");
    }
}
void ejercicio11()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("----Ejercicio 11----");
        Console.WriteLine("");
        Console.WriteLine("Ingrese un número, luego se lo devolvemos en ingles");
        Console.WriteLine("--Solo se permiten números entre 0 y 9--");
        Console.Write("Ingrese el número: ");

        int numero = Convert.ToInt16(Console.ReadLine());

        switch (numero)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine, 'LA COBRA 🗣'");
                break;
            default:
                Console.WriteLine("No se encuentra en el rango");
                break;
        }
    }
    catch (OverflowException)
    {
        Console.WriteLine("Se pasó de chistoso");
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permiten palabras u espacios en blanco");
    }
}

