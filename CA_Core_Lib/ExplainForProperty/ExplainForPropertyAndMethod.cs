namespace CA_Core_Lib.ExplainForProperty;

public class ExplainForPropertyAndMethod<T>: IExplainForProperty<T>
{
    private string _name;
    public string Name
    {
        get { return _name; }
        init { _name = value; }
    }

    public ExplainForPropertyAndMethod(string name)
    {
        _name = name;
    }

    public void PrintName()
    {
        Console.WriteLine(_name);
    }

    public int Count { get; set; }
    public List<T> TransformCount()
    {
        throw new NotImplementedException();
    }

    public int TransformCount(T transformation)
    {
        throw new NotImplementedException();
    }
}

public class UseExplainForProperty
{
    public void Test()
    {
        IExplainForProperty<string> explainForProperty = new ExplainForPropertyAndMethod<string>("Name");

        Console.WriteLine(explainForProperty.Count);
    }
}

public abstract class AbstractClassWithGetFields
{
    public abstract void GetFields();
}


interface IExplainForProperty<T>
{
    public int Count { get; set; }

    List<T> TransformCount();

    int TransformCount(T transformation);
}