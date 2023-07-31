using CA_Core_Lib.Referenced;

record DBRecord(string? id) :LibRecord(id)
{
    //public override string ToString()
    //{
    //    return base.ToString();
    //}

    public override bool IsIdNull()
    {
        Console.WriteLine(nameof(IsIdNull));
        Console.WriteLine(nameof(IsIdNull));
        Console.WriteLine(nameof(IsIdNull));
        return base.IsIdNull();
    }
}