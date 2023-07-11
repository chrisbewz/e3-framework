using e3;
using E3Framework.Contracts.Abstractions;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.E3ContentHandlers;

public class Attribute : AttributeAbstract
{
    private Attribute(int id)
    {
        this.Id = id;
    }

    private Attribute(int id, IAttributeInterface instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    public static Attribute FromId(int id)
    {
        return new Attribute(id);
    }
    
    public static Attribute FromId(int id,IAttributeInterface instance)
    {
        return new Attribute(id, instance);
    }

    public override async Task Init()
    {
        await this.ConfigureValues();
    }

    private async Task ConfigureValues()
    {
        this.Instance.SetId(this.Id);
        this.Name = this.Instance.GetName();
        this.Value = this.Instance.GetValue();
        this.FormattedValue = this.Instance.GetFormattedValue();
        this.Owner = this.Instance.GetOwnerId().ToString();
    }
}