namespace CA_Core_Lib.ImplementThis;

public interface IAnimal
{
    public string GetName()
    {
        return Name;
    }

    string Name { get; init; }
}