namespace SampleApp.Persistence.Factory;

[AttributeUsage(AttributeTargets.Field)]//the closest one can get to use only enum members
public class ViewAttributeAttribute : Attribute
{
    private Type _type;

    public ViewAttributeAttribute(Type type)
    {
        _type = type;
    }

    public Type Type
    {
        get
        {
            return _type;
        }
    }
}
