# Tema 2: Dispositivos de Almacenamiento secundario y la necesidad de Archivos
Todo dato almacenado en variables o cualquier estructura dentro de un programa existe unicamente en tiempo de ejecución. Por esto, surge la necesidad de usar archivos para guardar de forma permanente la información en algún medio de almacenamiento.

## Por qué los Datos almacenados en un programa son Temporales
Los datos en variables y estructuras de datos son almacenados de manera temporal en la memoria RAM. Cuando finaliza el programa, estos dejan de existir.
Por lo tanto, para guardar datos de forma permanente recurrimos a archivos.

## Arquitectura del Almacenamiento Persistente
1. Arquitectura persistente de Objetos: Este enfoque utiliza el mapeo objeto-relacional(ORM) para almacenar datos como objetos en una base de datos relacional o de valores clave.
2. Arquitectura persistente de bloques: Utiliza dispositivos de almacenamiento a nivel de bloque, que son útiles cuando se almacenan archivos de gran tamaño.
3. Arquitectura persistente de almacén de archivos: Utiliza un sistema de archivos para almacenar datos.

## Programa
Un programa de consola que utilice la clase System.IO.File para crear un archivo vacío en una ubicación especificada en el disco (File.Create("miarchivo.txt")). El programa simplemente informaría que el archivo ha sido creado. El énfasis en el video sería mostrar que este archivo persiste en el sistema de archivos del sistema operativo después de que el programa C# termina su ejecución, demostrando la persistencia en un dispositivo de almacenamiento secundario, a diferencia de los datos en variables de memoria que desaparecen

[ver programa]()