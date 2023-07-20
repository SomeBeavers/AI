namespace CA_Core_Lib.ImplementThis;

public static class Extension
{
    public static Beaver ToBeaver(this Fluffiness fluffiness)
    {
        return Beaver.Create(fluffiness);
    }

    public static string TrimSpacesFromEnd(this string str)
    {
        return str.TrimEnd();
    }

}