using System;

namespace DevelopmentChallenge.Data.Models
{
    // base.size es la altura del trapecio
    public class Trapezoid : Shape
    {
        private double _base1;
        private double _base2;

        public Trapezoid(double height, double base1, double base2): base(height) 
        {
            _base1= base1;
            _base2= base2;
        }

        public override double GetArea()
        {
            // base + base * altura sobre 2
            return ((_base1 + _base2) * base.Size) / 2;
        }

        public override double GetPerimeter()
        {
            double leg = CalcLeg();
            return _base1 + _base2 + base.Size + leg;
        }

        // calcula lado oblicuo
        private double CalcLeg()
        {
            return Math.Sqrt(Math.Pow(_base1 - _base2, 2) + Math.Pow(base.Size, 2));
        }
    }
}
