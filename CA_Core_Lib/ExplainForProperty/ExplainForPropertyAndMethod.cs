using System.Reflection;

namespace CA_Core_Lib.ExplainForProperty;

public class ExplainForPropertyAndMethod<T> : IExplainForProperty<T>
{
    public ExplainForPropertyAndMethod(string name)
    {
        Name = name;
    }

    public string Name { get; init; }

    public int Count { get; set; }

    public List<T> TransformCount()
    {
        throw new NotImplementedException();
    }

    public int TransformCount(T transformation)
    {
        throw new NotImplementedException();
    }

    public void PrintName()
    {
        Console.WriteLine(Name);
    }
}