import random

def ejercicio1():
    print("Ejercicio 1")
    print("Adivinanza")

    while (True):

        num = int(input("Ingrese el numero a adivinar: "))
        secreto = random.randint(1, 40)

        if(num > secreto):
            print("El numero es menor")
        elif(num < secreto):
            print("El numero es mayor")
        else:
            print(f"acertaste, el numero es {secreto}")
            break
def ejercicio2():
    print("Ejercicio 2")
    n = int(input("Ingrese un numero: "))
    print(f"Divisores de {n}")

    for i in range(1, n + 1):
        if n % i == 0:
            print(i)
def ejercicio3():
    print("Ejercicio 3")
    a = 0
    b = 1
    for i in range(1, 20):
        print(a)
        siguiente = a + b
        a = b
        b = siguiente
def ejercicio4():
    print("Ejercicio 4")
    print("Calculadora")
    opcion = input("Ingrese una operacion: ")
    num1 = int(input("Ingrese el primer numero: "))
    num2 = int(input("Ingrese el segundo numero: "))

    print(f"Operacion: {num1} {opcion} {num2}")

    if opcion == "+":
        print("Resultado:", num1 + num2)
    elif opcion == "-":
        print("Resultado:", num1 - num2)
    elif opcion == "*":
        print("Resultado:", num1 * num2)
    elif opcion == "/":
        print("Resultado:", num1 / num2)
def ejercicio5():
    print("Ejercicio 5")
    num = int(input("Ingrese un numero: "))
    resultado = 1
    if num < 0:
        print("No existe el factorial para este número")
        return
    for i in range(1, num + 1):
        resultado = resultado * i
        print(f"El factorial de {num} es {resultado}")
def ejercicio6():
    print("Ejercicio 6")
    nombres = []
    print("Ingresá nombres (escribí 'fin' para terminar):")
    while True:
        nombre = input("Nombre: ")
        if nombre.lower() == "fin":
            break
        nombres.append(nombre)
    print("Turnos asignados:")
    numero = 1
    for nombre in nombres:
        print(f"Turno {numero}: {nombre}")
        numero += 1
def ejercicio7():
    print("Ejercicio 7")
    contador = 0
    for i in range(1, 101):
        if i % 2 == 0:
            print(i)
            contador += 1
    print(f"Hay {contador} números que son pares entre 1 a 100")

def ejercicio8():
    print("Ejercicio 8")


def ejercicio9():
    print("Ejercicio 9")

def ejercicio10():
    print("Ejercicio 10")

def ejercicio11():
    print("Ejercicio 11")

def ejercicio12():
    print("Ejercicio 12")

def ejercicio13():
    print("Ejercicio 13")

def ejercicio14():
    print("Ejercicio 14")

#ejercicio1()
#ejercicio2()
#ejercicio3()
#ejercicio4()
#ejercicio5()
#ejercicio6()
#ejercicio7()
ejercicio8()
#ejercicio9()
#ejercicio10()
#ejercicio11()
#ejercicio12()
#ejercicio13()
#ejercicio14()
