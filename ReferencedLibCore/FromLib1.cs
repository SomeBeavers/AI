namespace ReferencedLibCore;

public record FromLib1
{
    public FromLib1(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public string Name { get; init; }
    public int Age { get; init; }

    public void Deconstruct(out string Name, out int Age)
    {
        var padLeft = "".PadLeft(1);
        Name = this.Name;
        Age = this.Age;

        Console.WriteLine("padLeft");
    }
}