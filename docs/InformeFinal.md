# Informe Final - Proyecto Biblioteca Escolar

## 1. Tabla de Comparaciones de Búsqueda por ISBN (Día 7)
| Consulta ISBN | Resultado | Comparaciones (Propia) | Verificación (Array.BinarySearch) |
| :--- | :--- | :---: | :---: |
| 978-0156013987 | Encontrado | 3 | Encontrado |
| 978-8424922405 | Encontrado | 1 | Encontrado |
| 978-9681608781 | Encontrado | 2 | Encontrado |
| 978-8437604183 | Encontrado | 3 | Encontrado |
| 000-0000000000 | No Encontrado | 3 | No Encontrado |

## 2. Respuestas a Preguntas Guía
* **¿Qué habría pasado si cada título tuviera exactamente 5 ejemplares?**
  No habría sido necesario usar una estructura irregular/escalonada (`List<Ejemplar>`), bastaría con una matriz o arreglo bidimensional fijo.
* **¿El algoritmo de ordenamiento preserva el orden alfabético en empates?**
  Sí, la implementación de Insertion Sort es estable gracias a la evaluación secundaria alfabética en caso de igual cantidad de préstamos.
* **¿Por qué la búsqueda binaria exige ordenar por ISBN y no por préstamos?**
  Porque la búsqueda binaria requiere que el arreglo esté ordenado según la clave específica que se va a buscar (ISBN) para poder descartar la mitad superior o inferior en cada iteración.

## 3. Anexo: Salida del Catálogo Ordenado