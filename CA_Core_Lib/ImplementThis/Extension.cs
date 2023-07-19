namespace CA_Core_Lib.ImplementThis;

public static class Extension
{
    public static Beaver ToBeaver(this string name)
    {
        return Beaver.Create(name);
    }

    public static string TrimSpacesFromEnd(this string str)
    {
        return str.TrimEnd();
    }

}