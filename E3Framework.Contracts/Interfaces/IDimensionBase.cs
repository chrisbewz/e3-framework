using e3;

namespace E3Framework.Contracts.Interfaces;

public interface IDimensionBase
{
    IEnumerable<IAttributeBase> Attributes { get; set; }

    IDimensionStyle Style { get; set; }

    double LineWidth { get; set; }

    double LineHeight { get; set; }

    bool IsALongPath { get; set; }

    string Text { get; set; }

    int Level { get; set; }
}