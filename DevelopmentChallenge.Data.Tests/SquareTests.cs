using System.Collections.Generic;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Utils;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void PrintByShape_SingleSquare_ReturnsCorrectReportInSpanish()
        {
            var squares = new List<Shape> { new Square(5) };

            var report = Report.PrintByShape(squares, Language.Spanish);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", report);
        }

        [Test]
        public void PrintByShape_MultipleSquares_ReturnsCorrectReportInEnglish()
        {
            var squares = new List<Shape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };

            var report = Report.PrintByShape(squares, Language.English);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", report);
        }

        [Test]
        public void PrintByShape_MultipleSquares_ReturnsCorrectReportInItalian()
        {
            var squares = new List<Shape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };

            var report = Report.PrintByShape(squares, Language.Italian);

            Assert.AreEqual("<h1>Rapporto delle forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 forme Perimetro 36 Area 35", report);
        }
    }
}
