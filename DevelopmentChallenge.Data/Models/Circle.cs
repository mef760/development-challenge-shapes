using System;

namespace DevelopmentChallenge.Data.Models
{
    public class Circle: Shape
    {
        public Circle(double size): base(size) { }

        public override double GetArea()
        {
            return Math.PI * (base.Size / 2) * (base.Size / 2);
        }

        public override double GetPerimeter()
        {
            return Math.PI * base.Size;
        }
    }
}
