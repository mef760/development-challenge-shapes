using System.Collections.Generic;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Utils;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class TrapezoidTests
    {
        [Test]
        public void PrintByShape_TrapezoidsList_ReturnsCorrectReportInItalian()
        {
            var shapes = new List<Shape>
            {
                new Trapezoid(5, 8, 4)
            };

            var report = Report.PrintByShape(shapes, Language.Italian);

            Assert.AreEqual(
                "<h1>Rapporto delle forme</h1>1 Trapezio | Area 30 | Perimetro 23.4 <br/>TOTAL:<br/>1 forme Perimetro 23.4 Area 30",
                report);
        }

        [Test]
        public void PrintByShape_TrapezoidsList_ReturnsCorrectReportInEnglish()
        {
            var shapes = new List<Shape>
            {
                new Trapezoid(5, 8, 4)
            };

            var report = Report.PrintByShape(shapes, Language.English);

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Trapezoid | Area 30 | Perimeter 23.4 <br/>TOTAL:<br/>1 shapes Perimeter 23.4 Area 30",
                report);
        }

        [Test]
        public void PrintByShape_TrapezoidsList_ReturnsCorrectReportInSpanish()
        {
            var shapes = new List<Shape>
            {
                new Trapezoid(5, 8, 4)
            };

            var report = Report.PrintByShape(shapes, Language.Spanish);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Trapecio | Area 30 | Perimetro 23.4 <br/>TOTAL:<br/>1 formas Perimetro 23.4 Area 30",
                report);
        }
    }
}
