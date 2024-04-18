using Mindbox.Geometry.Abstract;
using Moq;

namespace Mindbox.Geometry.Tests
{
    public class DefaultAreaCalculatorTests
    {
        [Fact]
        public void DefaultAreaCalculator_вызывает_метод_CalculateArea_внутри_фигуры()
        {
            var figure = new Mock<IFigure>();
            var sut = new DefaultAreaCalculator();

            var act = sut.CalculateArea(figure.Object);

            figure.Verify(x => x.CalculateArea(), Times.Once);
        }
    }
}