using FluentAssertions;
using Mindbox.Geometry.Domain.Figures;

namespace Mindbox.Geometry.Tests.Domain
{
    public class CircleTests
    {
        [Fact]
        public void Площадь_круга_равна_28_2743338823_при_радиусе_3()
        {
            var sut = new Circle(radius: 3);

            double area = sut.CalculateArea();

            area.Should().Equals(28.2743338823);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-3)]
        public void ArgumentException_при_попытке_рассчитать_площадь_круга_с_невалидным_значением_радиуса(double radius)
        {
            var sut = new Circle(radius);
            // тут, в отличии от теста в TriangleTests.cs, блок act присутствует (просто для примера)
            var act = Record.Exception(() => sut.CalculateArea());

            act.Should().NotBeNull().And.BeOfType<ArgumentException>();
        }
    }
}
