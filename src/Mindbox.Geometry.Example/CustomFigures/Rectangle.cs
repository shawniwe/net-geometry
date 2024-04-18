using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Example.CustomFigures
{
    /*
     * Пример добавления фигуры. Unit-test'ы на эту фигуру не написал,
     * т. к. это демо-проект и модель не должна использоваться
     */
    public class Rectangle : IFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea() => Width * Height;
    }
}
