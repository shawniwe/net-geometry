using Mindbox.Geometry.Abstract;
using Mindbox.Geometry.Domain;
using Mindbox.Geometry.Domain.Figures;
using Mindbox.Geometry.Example.CustomFigures;
using Mindbox.Geometry.Example.Decorators;

namespace Mindbox.Geometry.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            IAreaCalculator calculator = new DefaultAreaCalculator();

            var circle = new Circle(radius: 2);
            double circleArea = calculator.CalculateArea(circle);
            Console.WriteLine($"area of circle with radius {circle.Radius} is {circleArea}");

            var triangle = new Triangle(sideX: 5, sideY: 5, sideZ: 8);
            double triangleArea = calculator.CalculateArea(triangle);
            Console.WriteLine($"area of triangle with sides [{triangle.SideX}, {triangle.SideY}, {triangle.SideZ}] is {triangleArea}");
            Console.WriteLine($@"triangle is right?: {triangle.IsRight()}");

            var rectangle = new Rectangle(width: 5, height: 10);
            IFigure[] figures = [circle, triangle, rectangle];
            foreach (var figure in figures)
                Console.WriteLine($"area of unknown figure is {calculator.CalculateArea(figure)}");

            /*
             * пример, отражающий удобство использования паттерна стратегии в этой задаче -
             * в данном конкретном примере нам не придется писать декораторы под все фигуры,
             * достаточно написать один декоратор для калькулятора площади.
             */
            calculator = new DefaultAreaCalculatorLoggingDecorator(calculator);
            foreach (var figure in figures)
                calculator.CalculateArea(figure);
        }
    }
}
