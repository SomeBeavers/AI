namespace CA_Core_Lib;

public record RecordWithPrimaryParameters(int Id, string Name, DateTime DateCreated)
{
    public void PrintParameters()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, DateCreated: {DateCreated}");
    }
}