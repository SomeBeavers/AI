using System.Reflection;

namespace CA_Core_Lib.ExplainForProperty;

public class DerivedClass : AbstractClassWithGetFields
{
    public override void GetFields()
    {
        var fields = GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        foreach (var field in fields) Console.WriteLine(field.Name);
    }
}