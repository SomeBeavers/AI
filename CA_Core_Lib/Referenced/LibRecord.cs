namespace CA_Core_Lib.Referenced;

public record LibRecord(string? id)
{
    public string Name { get; init; }
    public string Surname { get; init; }
    public string FullName => $"{Name} {Surname}";

    public override string ToString()
    {
        if (IsIdNull())
        {
            return FullName;
        }
        return $"ID: {id}";
    }

    public void Deconstruct(out string name, out string surname)
    {
        name = Name;
        surname = Surname;
    }

    public virtual bool IsIdNull() => id is { } s;
    public static string Get(Func<string> func)
    {
        var result = func();
        return result;
    }
#nullable disable
    ReadOnlySpan<char> ReturnsNull()
    {
        return null;
    }

    void TestNull()
    {
        if (ReturnsNull() == null) ;
    }

    void Test()
    {
        string s = "";

    }
}