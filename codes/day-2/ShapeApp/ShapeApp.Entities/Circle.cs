namespace ShapeApp.Entities
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle()
        {

        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea() => Math.PI * Radius * Radius;
    }
}
