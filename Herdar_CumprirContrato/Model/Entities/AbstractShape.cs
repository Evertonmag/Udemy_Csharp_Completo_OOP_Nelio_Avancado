using Herdar_CumprirContrato.Model.Enums;

namespace Herdar_CumprirContrato.Model.Entities;
internal abstract class AbstractShape : IShape
{
    public Color Color { get; set; }

    public abstract double Area();
}
