namespace CA_Core_Lib.ExplainForProperty;

public class ExplainForProperty: IExplainForProperty
{
    private string _name;
    public string Name
    {
        get { return _name; }
        init { _name = value; }
    }

    public ExplainForProperty(string name)
    {
        _name = name;
    }

    public void PrintName()
    {
        Console.WriteLine(_name);
    }

    public int Count { get; set; }
}

public class UseExplainForProperty
{
    public void Test()
    {
        IExplainForProperty explainForProperty = new ExplainForProperty("Name");

        Console.WriteLine(explainForProperty.Count);
    }
}

interface IExplainForProperty<T>
{
    public int Count { get; set; }

    List<T> TransformCount();

    int TransformCount(T transformation);
}