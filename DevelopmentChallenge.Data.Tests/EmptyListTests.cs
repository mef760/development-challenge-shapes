using System.Collections.Generic;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Utils;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class EmptyListTests
    {
        [Test]
        public void PrintByShape_EmptyList_ReturnsEmptyMessageInItalian()
        {
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>",
                Report.PrintByShape(new List<Shape>(), Language.Italian));
        }

        [Test]
        public void PrintByShape_EmptyList_ReturnsEmptyMessageInEnglish()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Report.PrintByShape(new List<Shape>(), Language.English));
        }

        [Test]
        public void PrintByShape_EmptyList_ReturnsEmptyMessageInSpanish()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Report.PrintByShape(new List<Shape>(), Language.Spanish));
        }
    }
}
