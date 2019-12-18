# -*- coding: utf-8 -*-
"""
Editor de Spyder

Este es un archivo temporal.
"""
#Imprimir algo 
print("hola mundo DAI")

x=10
y=12.5
z='100'
#Obtener el tipo de un objeto 
type(x)

xy=x+y
xz1=str(x)+z
xz2=x+int(z)

a=10
b=3
division=a/b #division con decimales
cociente=a//b #division entera
residuo=a%b
#

c=1234.56789
d=100

import math

help("keywords") # te da las principales palabras reservadas 
help("while")
print(c, d, math.pi)

# lista - mutable
strA='AAA'
listA=['a', 'e', 'i', 'o', 'u']
listB=[100, listA, 10, 20, strA]
print(listB)

strA='aaaa'
listB[3]='woow'

print(listB)

# tuplas - inmutable

tupla={1, 'python', True}

print(type(tupla))
print(tupla)

#conjunto - mutable
#Estructura de datos, no ordenados que no permite elementos repetidos, 
#los datos son mutables(set), solo acepta objetos inmutables como elementos
conj2=set(listA)

#Diccionario (dict) delimitador { llave: valor }
idiomaFun={'es':"esp",
               'in':"ing",
               'fr':"fran"}