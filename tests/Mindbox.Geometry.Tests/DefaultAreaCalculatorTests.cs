using Mindbox.Geometry.Abstract;
using Moq;

namespace Mindbox.Geometry.Tests
{
    public class DefaultAreaCalculatorTests
    {
        [Fact]
        public void DefaultAreaCalculator_��������_�����_CalculateArea_������_������()
        {
            var figure = new Mock<IFigure>();
            var sut = new DefaultAreaCalculator();

            var act = sut.CalculateArea(figure.Object);

            figure.Verify(x => x.CalculateArea(), Times.Once);
        }
    }
}