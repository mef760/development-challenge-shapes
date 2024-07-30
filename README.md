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

project-root/
├── models/ # Modelos de figuras geometricas
│   ├── Circle.cs
|   ├── Shape.cs # Clase base
│   ├── Square.cs
│   ├── Triangle.cs
│   ├── Trapezoid.cs
├── utils/
│   ├── ReportGenerator.cs # Clase static para imprimir los reportes
│   └── Translations.cs # Clase static para manejar las traducciones
├── localization/ # Archivos de traducciones
│   ├── en.json
│   ├── es.json
│   └── it.json
├── tests/ # Test por figuras
│   ├── CircleTests.cs
|   ├── MultipleShapeTests.cs
|   ├── EmptyListTests.cs
│   ├── SquareTests.cs
│   ├── TriangleTests.cs
│   ├── TrapezoidTests.cs
└── README.md
