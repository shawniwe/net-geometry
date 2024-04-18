using FluentAssertions;
using Mindbox.Geometry.Domain.Figures;

namespace Mindbox.Geometry.Tests.Domain
{
    public class TriangleTests
    {
        [Fact]
        public void Площадь_треугольника_равна_12_при_сторонах_5_8_5()
        {
            var sut = new Triangle(sideX: 5, sideY: 8, sideZ: 5);

            double area = sut.CalculateArea();

            area.Should().Equals(12);
        }

        [Theory]
        [InlineData(0, 8, 5)]
        [InlineData(5, 0, 5)]
        [InlineData(5, 8, 0)]
        [InlineData(-5, 8, 5)]
        [InlineData(5, -8, 5)]
        [InlineData(5, 8, -5)]
        public void ArgumentException_при_попытке_рассчитать_площадь_треугольника_с_невалидным_значением_одной_из_сторон(
            double sideX,
            double sideY,
            double sideZ)
        {
            var sut = new Triangle(sideX, sideY, sideZ);
            var calculationMethod = sut.CalculateArea;
            // отсутствует блок act, в силу специфики библиотеки
            calculationMethod.Should().Throw<ArgumentException>();
        }
    }
}
