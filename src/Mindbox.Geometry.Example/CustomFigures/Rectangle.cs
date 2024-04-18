using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Example.CustomFigures
{
    // Пример добавления фигуры. Unit-test'ы на эту фигуру не написал, т. к. это демо-проект
    public class Rectangle : RectangleBase
    {
        public Rectangle(double width, double height) : base(width, height) { }

        public override double CalculateArea() => Width * Height;
    }
}
