using System.Collections.Generic;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Utils;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void PrintByShape_TrianglesList_ReturnsCorrectReportInSpanish()
        {
            var shapes = new List<Shape>
            {
                new Triangle(4),
                new Triangle(9),
                new Triangle(4.2)
            };

            var report = Report.PrintByShape(shapes, Language.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>3 formas Perimetro 51.6 Area 49.64",
                report);
        }

        [Test]
        public void PrintByShape_TrianglesList_ReturnsCorrectReportInEnglish()
        {
            var shapes = new List<Shape>
            {
                new Triangle(4),
                new Triangle(9),
                new Triangle(4.2)
            };

            var report = Report.PrintByShape(shapes, Language.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>3 shapes Perimeter 51.6 Area 49.64",
                report);
        }

        [Test]
        public void PrintByShape_TrianglesList_ReturnsCorrectReportInItalian()
        {
            var shapes = new List<Shape>
            {
                new Triangle(4),
                new Triangle(9),
                new Triangle(4.2)
            };

            var report = Report.PrintByShape(shapes, Language.Italian);

            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>3 Triangoli | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>3 forme Perimetro 51.6 Area 49.64",
                report);
        }
    }
}
