namespace DevelopmentChallenge.Data.Models
{   /// <summary>
    /// Clase base de figuras geometricas. Prop size se usa para lados/radio/altura, segun la figura
    /// </summary>
    public abstract class Shape
    {
        public double Size { get; set;}
        public Shape(double size)
        {
            Size = size;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
