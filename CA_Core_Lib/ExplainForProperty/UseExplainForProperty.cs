namespace CA_Core_Lib.ExplainForProperty;

public class UseExplainForProperty
{
    public void Test()
    {
        IExplainForProperty<string> explainForProperty = new ExplainForPropertyAndMethod<string>("Name");

        Console.WriteLine(explainForProperty.Count);
    }
}