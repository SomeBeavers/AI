namespace CA_Core_Lib;

public class InvokedOn
{
    public Type? Declaration(Type type)
    {
        return type.DeclaringType;
    }
}