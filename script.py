def ejercicio1():
   print("Ejercicio 1")
   for i in range(1, 101):
       if i % 3 == 0:
           print(i)


def ejercicio2():
   print("Ejercicio 2")
   edad = int(input("¿Cuántos años tenés?: "))
   print(edad)
   if edad > 18:
       print("Sos mayor pana")
   elif edad < 18:
       print("Sos menor pana")
   else:
       print("Tenes justo 18 pana")


def ejercicio3():
   print("Ejercicio 3")
   palabra = input("Introduzca una palabra: ")
   print(palabra)
   print("cantidad de letras: ", end="")
   print(len(palabra))
   print(len(palabra))


def ejercicio4():
   print("Ejercicio 4")
   contraseña_secreta = "papa1234"
   intento = 4
   while (intento != 0):
       palabra = input("Escriba la contraseña secreta: ")


       if (palabra == contraseña_secreta):
           print("Acertasteeee!!!!")
           break
       else:
           print("No acertaste, cantidad de intentos: ", end="")
           print(intento)
           intento -= 1


   if (intento == 0):
       print("Perdiste, la contraseña secreta era: ", end="")
       print(contraseña_secreta)


def ejercicio5():
   print("Ejercicio 5")
   mayor = None


   for i in range(10):


       num = int(input("Introduzca numeros: "))


       if mayor is None or num > mayor:
           mayor = num


   print("El número más alto es:", mayor)


def ejercicio6():
   print("Ejercicio 6")
   nombre = input("Introduzca su nombre: ")
   print("Hola mi estimado/a", nombre.title())


def ejercicio7():
   print("Ejercicio 7")
   print("Tabla del 7")
   for i in range(11):
       print( i, "x 7 =", i * 7)
   print("Oaa")


def ejercicio8():
   print("Ejercicio 8")
   numero = int(input("Escriba un numero: "))
   print(numero)


   if((numero % 2) == 0):
       print("El número es par")
   else:
       print("El numero es impar")


def ejercicio9():
   print("Ejercicio 9")


   contador = 0
   frase = input("Introduzca una frase: ")
   print("frase: ", end="")

   for letra in frase:
       if letra in "aeiou":
           contador += 1

   print(frase)
   print("Contador de vocales:", contador)


def ejercicio10():
   print("Ejercicio 10")
   numero = int(input("Introduzca un numero: "))
   for i in range(1, 13):
       print(numero, "x", i, "=", numero * i)


def ejercicio11():
   print("Ejercicio 11")
   print("introduzca un numero hasta que llegue o supere los 100")


   numero = int(input("Introduzca numeros: "))
   acum = 0


   while (numero >= 100):
       numero = int(input("Introduzca numeros: "))
       acum += numero


   print("superaste el limite, numero: ", numero)


def ejercicio12():
   print("Ejercicio 12")
   palabra = input("Ingresá una palabra: ")

   for letra in palabra:
       print(letra)


def ejercicio13():
   print("Ejercicio 13")
   edad = int(input("Introduzca su edad: "))
   if (edad >= 18):
       print("Usted puede manejar y votar")
   elif (edad <= 17 and edad >= 15):
       print("Usted puede votar")
   elif (edad <= 14):
       print("Usted no puede hacer nada")

def ejercicio14():
   print("Ejercicio 14")
   for numero in range(50, -1, -5):
       print(numero)


def ejercicio15():
   print("Ejercicio 15")

   while True:
       contrasena1 = input("Escribí tu contraseña: ")
       contrasena2 = input("Confirmá tu contraseña: ")

       if contrasena1 == contrasena2:
           print("Acceso permitido")
           break
       else:
           print("Las contraseñas no coinciden, intentelo de nuevo")


def ejercicio16():
    print("Ejercicio 16")
    intento = 10

    while intento != 0:
        nombre = input("Introduzca tu nombre: ")
        intento -= 1

        if len(nombre) > 10:
            print(f"El nombre más largo es {nombre} con {len(nombre)} caracteres")
            break


def ejercicio17():
   print("Ejercicio 17")

   oracion = input("Introduzca una oracion: ")
   contador = 0

   for letra in oracion:
       if letra in "a":
           contador += 1

   print("cantidad de letras:", contador)


ejercicio1()
print("")
ejercicio2()
print("")
ejercicio3()
print("")
ejercicio4()
print("")
ejercicio5()
print("")
ejercicio6()
print("")
ejercicio7()
print("")
ejercicio8()
print("")
ejercicio9()
print("")
ejercicio10()
print("")
ejercicio11()
print("")
ejercicio12()
print("")
ejercicio13()
print("")
ejercicio14()
print("")
ejercicio15()
print("")
ejercicio16()
print("")
ejercicio17()