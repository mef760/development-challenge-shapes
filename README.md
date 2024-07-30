# Development Challenge

## ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas?

Para este desafío de desarrollo, se requiere realizar las siguientes tareas:

### TODO:

1. **Refactorizar la clase para respetar principios de la programación orientada a objetos.**

2. **Implementar la forma Trapecio/Rectángulo.**

3. **Agregar el idioma Italiano (o el deseado) al reporte.**

4. **Incluir nuevos tests unitarios:**
   - Validar el comportamiento de la nueva funcionalidad agregada.
   - Asegurarse de que los tests actuales y los nuevos pasen correctamente al entregar la solución.

5. **Subir el código a un repositorio GIT:**
   - Proveer la URL del repositorio para que podamos utilizar la nueva versión.

**Nota:** Se agradece la inclusión de comentarios y documentación adicional para facilitar la comprensión del código y las nuevas funcionalidades agregadas.


## Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

```plaintext
project-root/
├── models/                # Modelos de figuras geométricas
│   ├── Circle.cs          # Clase para la figura Círculo
│   ├── Shape.cs           # Clase base
│   ├── Square.cs          # Clase para la figura Cuadrado
│   ├── Triangle.cs        # Clase para la figura Triángulo
│   ├── Trapezoid.cs       # Clase para la figura Trapecio
├── utils/                 # Utilidades
│   ├── ReportGenerator.cs # Clase estática para imprimir los reportes
│   └── Translations.cs    # Clase estática para manejar las traducciones
├── localization/          # Archivos de traducciones
│   ├── en.json            # Traducción al inglés
│   ├── es.json            # Traducción al español
│   └── it.json            # Traducción al italiano
├── tests/                 # Tests por figuras
│   ├── CircleTests.cs     # Tests para Círculo
│   ├── MultipleShapesTests.cs # Tests para múltiples figuras
│   ├── EmptyListTests.cs  # Tests para listas vacías
│   ├── SquareTests.cs     # Tests para Cuadrado
│   ├── TriangleTests.cs   # Tests para Triángulo
│   ├── TrapezoidTests.cs  # Tests para Trapecio
└── README.md              # Documentación del proyecto
