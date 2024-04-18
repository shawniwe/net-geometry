using FluentAssertions;
using Mindbox.Geometry.Abstract;
using Moq;

namespace Mindbox.Geometry.Tests
{
    public class DefaultAreaCalculatorTests
    {
        [Fact]
        public void sut_��������_�����_CalculateArea_������_������()
        {
            var figure = new Mock<IFigure>();
            var sut = new DefaultAreaCalculator();

            var act = sut.CalculateArea(figure.Object);

            figure.Verify(x => x.CalculateArea(), Times.Once);
        }

        [Fact]
        public void sut_�����������_ArgumentNullException_����_������_�����_null()
        {
            IFigure? figure = null;
            var sut = new DefaultAreaCalculator();

            var act = () => sut.CalculateArea(figure);

            act.Should().Throw<ArgumentNullException>();
        }
    }
}