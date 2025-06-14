# Tema 1: Jerarquía de Datos

## Archivos/Ficheros
- Un archivo es una unidad de almacenamiento que contiene datos estructurados en registros.
- Es un conjunto de datos estructurados en una colección de entidades elementales denominadas *registros* o *artículos* que son de igual tipo y constan de diferentes entidades de nivel más bajo denominadas *campos*.
- Permiten guardar información de manera permanente.

## Estructura jerárquica de la información
1. Bit: unidad mínima (0,1)
2. Caracter: Letra, número o símbolo
3. Campo: Grupo de caracteres con significado
4. Registro: Conjunto de campos relacionados
5. Archivo: Conjunto de registros
6. Base de datos: Conjunto de archivos relacionados

## Campo
- Un campo es la unidad mínima de información con significado.
- Tiene un tipo de dato y una longitud
- Puede dividirse en subcampos

## Registro
- Un registro es un conjunto de campos relacionados entre sí.
- Representa una entidad completa.
- Puede tener longitud fija o variable.
- Equivale a una estructura de datos en programación.

## Archivo
- Es un conjunto organizado de registros similares
- Se utiliza para almacenar y procesar datos con un propósito definido

## Base de Datos
- Es un conjunto de archivos relacionados entre sí que son accesible por programas.
- Permiten centralizar la información.

## Programa
Un programa de consola simple que defina una class o struct en C# (ej. Persona con propiedades como Nombre, Edad, Ciudad). El programa crearía varias instancias de esta clase/struct y las almacenaría en una lista en memoria (List<Persona>). Luego, iteraría sobre la lista para mostrar la información de cada "registro" en la consola. La explicación del programa se centraría en cómo cada instancia de la clase/struct representa un registro lógico y la lista completa representa una colección de estos registros, similar a un archivo a nivel conceptual, pero residiendo temporalmente en la memoria principal. Esto ilustra la estructura lógica de los datos antes de ser guardados permanentemente en un archivo.


[Ver programa](Tema_1/Program.cs)
