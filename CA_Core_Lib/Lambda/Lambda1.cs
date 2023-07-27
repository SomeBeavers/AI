namespace CA_Core_Lib.Lambda;

public class Lambda1
{
    private const string s = "VALUE";

    /// <summary>
    ///     The Test method is a generic method that takes a list of items of type T as an argument.
    ///     It checks if any item in the list is null and returns a boolean value.
    /// </summary>
    /// <typeparam name="T">The type of items in the list.</typeparam>
    /// <param name="list">The list of items to check for null values.</param>
    public void Test<T>(List<T> list)
    {
        Test2();
        var any = list.Where(x => x != null).Any(x => x == null);
    }

    public string S { get; set; }

    public void Test2()
    {
        int t = 1;
        UniqueStringWithUniqueName( );
        Test(new List<int>());
        new Lambda1();
    }

    public string UniqueStringWithUniqueName()
    {
        return "";
    }
}