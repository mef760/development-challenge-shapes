using System.Collections.Generic;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Utils;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class MultipleShapesTests
    {
        [Test]
        public void PrintByShape_MultipleShapes_ReturnsCorrectReportInEnglish()
        {
            var shapes = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new Triangle(4),
                new Square(2),
                new Triangle(9),
                new Circle(2.75),
                new Triangle(4.2),
                new Trapezoid(5, 8, 4)
            };

            var report = Report.PrintByShape(shapes, Language.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>1 Trapezoid | Area 30 | Perimeter 23.4 <br/>TOTAL:<br/>8 shapes Perimeter 121.07 Area 121.65",
                report);
        }

        [Test]
        public void PrintByShape_MultipleShapes_ReturnsCorrectReportInSpanish()
        {
            var shapes = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new Triangle(4),
                new Square(2),
                new Triangle(9),
                new Circle(2.75),
                new Triangle(4.2)
            };

            var report = Report.PrintByShape(shapes, Language.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                report);
        }

        [Test]
        public void PrintByShape_MultipleShapes_ReturnsCorrectReportInItalian()
        {
            var shapes = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new Triangle(4),
                new Square(2),
                new Triangle(9),
                new Circle(2.75),
                new Triangle(4.2)
            };

            var report = Report.PrintByShape(shapes, Language.Italian);

            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13.01 | Perimetro 18.06 <br/>3 Triangoli | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 forme Perimetro 97.66 Area 91.65",
                report);
        }
    }
}
