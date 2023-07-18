namespace CA_Core_Lib.ExplainForClass;

public class AbstractClassImpl : AbstractClass, ICommonMethods, IMy2
{
    public required string Name;

    public AbstractClassImpl(string name)
    {
        Name = name;
    }

    public string IP { get; set; }

    public override string GetName(string name)
    {
        return name;
    }

    public override string GetName2(string name, int myInt)
    {
        return name + "2";
    }

    public override int GetAge(int age)
    {
        return age;
    }

    public override InnerClass GetInnerClass(InnerClass innerClass)
    {
        return innerClass;
    }

    public override bool GetIsTrue(bool isTrue)
    {
        return isTrue;
    }

    public virtual string GetIP()
    {
        return IP;
    }
}