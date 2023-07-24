namespace CA_Core_Lib.Lambda;

public class Lambda1
{
    public void Test<T>(List<T> list)
    {
        var any = list.Where(x => x != null).Any(x => x == null);
    }

    public void Test2()
    {
        UniqueStringWithUniqueName( );
        Test(new List<int>());
        new Lambda1();
    }

    public string UniqueStringWithUniqueName()
    {
        return "";
    }
}