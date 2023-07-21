namespace CA_Core_Lib.UseAttribute;

[AttributeUsage(AttributeTargets.Method)]
public class MyAttribute<T>:Attribute where T : notnull 
{
    public T Parameter { get; set; }

    public MyAttribute(T parameter)
    {
        Parameter = parameter;
    }
}

class UseAttribute
{
    [My<string>(nameof(GetName))]
    public string GetName(string name)
    {
        if (name == null) throw new ArgumentNullException(nameof(name));
        return name;
    }
    
    [My<int>(1)]
    public int GetName(int name)
    {
        return name;
    }
}