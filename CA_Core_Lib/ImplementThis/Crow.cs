namespace CA_Core_Lib.ImplementThis;

public record Crow(string Name) : IAnimal
{
    public override string ToString()
    {
        return $"Name : {Name}";
    }
}