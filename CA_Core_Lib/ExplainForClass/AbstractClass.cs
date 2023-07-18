namespace CA_Core_Lib.ExplainForClass;

public abstract class AbstractClass
{
    public string Name;
    public int Age;
    public InnerClass InnerClass;
    public bool IsTrue;

    public abstract string GetName(string name);
    public abstract string GetName2(string name, int myInt);

    public abstract int GetAge(int age);
    public abstract InnerClass GetInnerClass(InnerClass innerClass);
    public abstract bool GetIsTrue(bool isTrue);
}

public class InnerClass
{
}
