using System;

namespace DevelopmentChallenge.Data.Models
{   /// <summary>
    /// Triangulo equilatero
    /// </summary>
    public class Triangle : Shape
    {
        public Triangle(double size): base(size) { }

        public override double GetArea()
        {
            return (Math.Sqrt(3) / 4) * base.Size * base.Size;
        }

        public override double GetPerimeter()
        {
            return base.Size * 3;
        }
    }
}
