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

            area.Should().Be(12);
        }

        /*
         * В задании немного не хватает информации по бизнес-логике, поэтому, делаю предположение,
         * что заказчику не требуется допускать фигуры с нулевым или отрицательным значением сторон/
         * радиуса. На реальном кейсе, я бы обратился за уточнениями по ТЗ, т. к., например, если
         * модели фигур используются в графическом редакторе, фигура запросто может иметь нулевую
         * сторону и это не будет считаться ошибкой (даже если это не будет иметь смысла), хотя,
         * с точки зрения математики, треугольник с нулевой стороной больше напоминает отрезок :)
        */
        [Theory]
        [InlineData(0, 8, 5)]
        [InlineData(5, 0, 5)]
        [InlineData(5, 8, 0)]
        [InlineData(-5, 8, 5)]
        [InlineData(5, -8, 5)]
        [InlineData(5, 8, -5)]
        public void ArgumentException_при_попытке_создать_треугольник_с_невалидным_значением_одной_из_сторон(
            double sideX,
            double sideY,
            double sideZ)
        {
            // отсутствует блок act, в силу специфики теста
            var sut = () => new Triangle(sideX, sideY, sideZ);
            sut.Should().Throw<ArgumentException>();
        }
    }
}
