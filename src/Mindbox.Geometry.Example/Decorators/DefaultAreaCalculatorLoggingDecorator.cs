using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Example.Decorators
{
    public class DefaultAreaCalculatorLoggingDecorator : IAreaCalculator
    {
        private IAreaCalculator _decorate;

        public DefaultAreaCalculatorLoggingDecorator(IAreaCalculator decorate)
        {
            _decorate = decorate;
        }
        public double CalculateArea(IFigure figure)
        {
            try
            {
                double result = _decorate.CalculateArea(figure);
                Console.WriteLine($"The figure's area is: {result}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
