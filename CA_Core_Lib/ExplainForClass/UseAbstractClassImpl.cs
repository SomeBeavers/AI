namespace CA_Core_Lib.ExplainForClass;

class UseAbstractClassImpl
{
    public void UseAbstractClassImplMethod()
    {
        var abstractClassImpl = new AbstractClassImpl("name")
        {
            Name = "Jane Doe"
        };

        var name = abstractClassImpl.GetName("name");
        abstractClassImpl.GetIP();
    }
}