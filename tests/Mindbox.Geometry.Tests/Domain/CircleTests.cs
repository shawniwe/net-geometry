using FluentAssertions;
using Mindbox.Geometry.Domain.Figures;

namespace Mindbox.Geometry.Tests.Domain
{
    public class CircleTests
    {
        [Fact]
        public void Площадь_круга_равна_28_274333882308138_при_радиусе_3()
        {
            var sut = new Circle(radius: 3);

            double area = sut.CalculateArea();

            area.Should().Be(28.274333882308138);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-3)]
        public void ArgumentException_при_попытке_создать_круг_с_невалидным_радиусом(double invalidRadius)
        {
            var sut = () => new Circle(radius: invalidRadius);
            sut.Should().Throw<ArgumentException>();
        }
    }
}
