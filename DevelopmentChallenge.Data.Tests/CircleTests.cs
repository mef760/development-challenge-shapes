using System.Collections.Generic;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Utils;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void PrintByShape_CirclesList_ReturnsCorrectReportInItalian()
        {
            var shapes = new List<Shape>
            {
                new Circle(3),
                new Circle(2.75)
            };

            var report = Report.PrintByShape(shapes, Language.Italian);

            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>2 Cerchi | Area 13.01 | Perimetro 18.06 <br/>TOTAL:<br/>2 forme Perimetro 18.06 Area 13.01",
                report);
        }

        [Test]
        public void PrintByShape_CirclesList_ReturnsCorrectReportInEnglish()
        {
            var shapes = new List<Shape>
            {
                new Circle(3),
                new Circle(2.75)
            };

            var report = Report.PrintByShape(shapes, Language.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Circles | Area 13.01 | Perimeter 18.06 <br/>TOTAL:<br/>2 shapes Perimeter 18.06 Area 13.01",
                report);
        }

        [Test]
        public void PrintByShape_CirclesList_ReturnsCorrectReportInSpanish()
        {
            var shapes = new List<Shape>
            {
                new Circle(3),
                new Circle(2.75)
            };

            var report = Report.PrintByShape(shapes, Language.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>TOTAL:<br/>2 formas Perimetro 18.06 Area 13.01",
                report);
        }
    }
}
