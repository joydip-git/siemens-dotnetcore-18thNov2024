namespace ShapeApp.Entities
{
    public class Triangle : IShape
    {
        public double TBase { get; set; }
        public double THeight { get; set; }
        public Triangle()
        {

        }
        public Triangle(double tbase, double theight)
        {
            TBase = tbase;
            THeight = theight;
        }

        public double CalculateArea() => 0.5 * TBase * THeight;
    }
}
