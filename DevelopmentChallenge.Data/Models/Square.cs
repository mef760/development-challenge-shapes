namespace DevelopmentChallenge.Data.Models
{
    public class Square : Shape
    {
        public Square(double size): base(size) { }

        public override double GetArea()
        {
            return base.Size * base.Size;
        }

        public override double GetPerimeter()
        {
            return base.Size * 4;
        }
    }
}
