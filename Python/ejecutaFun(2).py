# -*- coding: utf-8 -*-
"""
Created on Thu Nov 21 11:22:42 2019

@author: dai
"""

import ejemFunciones as f

print(f.suma(5,3))

print(f.suma(a=5,b=3))

print(f.suma())

print(f.suma(5))

print(f.suma(b=15))

print(list(f.circulo(10)))
t=list(f.circulo(10))
print(type(t))

def saludar(idioma):
    def esp():
        print('hola')
    def ing():
        print('hello')
    def fran():
        print('salut')
    idiomaFun={'es':esp(),
               'in':ing(),
               'fr':fran()}
    return idiomaFun[idioma]

print(saludar('fr'))