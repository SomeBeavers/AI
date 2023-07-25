namespace CA_Core_Lib.Lambda;

public class Lambda1
{
    const string s = b;
    private  string b = "VALUE";

    public void Test<T>(List<T> list)
    {
        var any = list.Where(x => x != null).Any(x => x == null);
    }

    public string S { get; set; init; }

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