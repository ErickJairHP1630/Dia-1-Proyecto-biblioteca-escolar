# Proyecto-biblioteca-escolar
## Facultad de Ciencias y Tecnologías de la Información  
### Alumno: Erick Jair Hernández Pacheco 
### Docente: Roberto Rosario Cruz 

## **Contexto:**  Una biblioteca escolar presta libros, pero no todos los títulos tienen la misma cantidad de ejemplares: algunos tienen cinco copias y otros una sola.

## **Objetivo:**  Elegir entre arreglo escalonado y List<T> 
para representar títulos con
distinta cantidad de ejemplares; implementar el ordenamiento por inserción para
preservar el orden alfabético entre títulos con igual número de préstamos; aplicar
búsqueda binaria sobre una copia ordenada por ISBN.
## Dia 1
realizamos la configuración inicial y la documentación base:

Configuración del entorno: Creamos el proyecto de consola en .NET con la orden dotnet new console y configuramos el repositorio local en Git.

Documentación preliminar: Creamos el archivo docs/DisenoPreliminar.md definiendo el alcance, los requisitos y la arquitectura inicial del sistema.
## Dia 2
implementamos la estructura base de los datos del catálogo:

Modelos de datos: Creamos las clases Titulo y Ejemplar dentro de la carpeta Models/ para estructurar la información de los libros y sus copias físicas.

Carga de datos inicial: Se inicializó en el Program.cs una lista de 8 libros con diferentes cantidades de ejemplares para simular el inventario de la biblioteca.
## Dia 3
implementamos la lógica central de disponibilidad y la simulación de operaciones:

Cálculo de disponibilidad: Creamos una rutina para filtrar y contar los ejemplares en estado "Disponible" frente al total de copias de cada título.

Registro de préstamos: Desarrollamos la función Prestar() para actualizar el estado del ejemplar a "Prestado" e incrementar en +1 el historial de PrestamosHistoricos.

Pruebas simuladas: Realizamos la ejecución de 3 préstamos de prueba para validar que el inventario y los estados cambien correctamente en la consola.