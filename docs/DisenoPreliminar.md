# Documento de Diseño Preliminar - Biblioteca Escolar

##  Objetivo del Sistema
Gestionar el catálogo de libros, el inventario físico (con distinta cantidad de ejemplares por título) y el registro de préstamos y devoluciones en la biblioteca escolar.

##  Comparación de Estructuras Candidatas (Día 1)

| Estructura | Pros | Contras | Selección |
|---|---|---|---|
| **Arreglo Escalonado (`int[][]` o `Ejemplar[][]`)** | Permite filas de distinto tamaño sin desperdiciar memoria (sin celdas vacías). | Tamaño fijo tras inicializarse; complejo para insertar o eliminar ejemplares dinámicamente. | Rechazado |
| **Lista de Arreglos (`List<int[]>`)** | Permite agregar títulos dinámicamente y mantener arreglos de tamaño variable. | Pierde legibilidad de código y orientación a objetos al manejar arreglos numéricos planos. | Rechazado |
| **Lista de Objetos (`List<Título>`)** | Cada `Título` encapsula una lista propia `List<Ejemplar>`. Soporta ejemplares irregulares sin celdas vacías, es dinámico y sigue POO. | Requiere mayor gestión de clases y memoria por instanciación de objetos. | **SELECCIONADO** |

##  Modelo de Dominio (Entidades Principales)

| Entidad | Descripción | Atributos Principales |
|---|---|---|
| **Título** | Representa la obra en general en el catálogo. | `Id`, `Nombre`, `Autor`, `ISBN`, `PrestamosHistoricos`, `List<Ejemplar>` |
| **Ejemplar** | Copia física individual en los estantes. | `Id`, `CodigoBarras`, `Estado` (Disponible, Prestado, Reparación) |

## 4. Reglas de Negocio
- Un **Título** contiene una colección dinámica de **Ejemplares** (Relación 1 a N sin celdas vacías).
- No se admite préstamo si el estado del **Ejemplar** no es `Disponible`.
- El catálogo permite ordenamiento por préstamos históricos de mayor a menor y búsqueda binaria por ISBN.