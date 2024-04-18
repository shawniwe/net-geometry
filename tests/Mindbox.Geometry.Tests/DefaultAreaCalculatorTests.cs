using FluentAssertions;
using Mindbox.Geometry.Abstract;
using Mindbox.Geometry.Domain;
using Moq;

namespace Mindbox.Geometry.Tests
{
    public class DefaultAreaCalculatorTests
    {
        [Fact]
        public void sut_вызывает_метод_CalculateArea_внутри_фигуры()
        {
            var figure = new Mock<IFigure>();
            var sut = new DefaultAreaCalculator();

            var act = sut.CalculateArea(figure.Object);

            figure.Verify(x => x.CalculateArea(), Times.Once);
        }

        [Fact]
        public void sut_выбрасывает_ArgumentNullException_если_фигура_равна_null()
        {
            IFigure? figure = null;
            var sut = new DefaultAreaCalculator();

            var act = () => sut.CalculateArea(figure);

            act.Should().Throw<ArgumentNullException>();
        }
    }
}