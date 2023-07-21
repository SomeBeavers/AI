namespace Core_Lib_Referenced;

public class Address<T> where T: class, IAnimalInterface
{
    public T? Animal;

    public Address(T? animal)
    {
        Animal = animal;
    }

    public void Print()
    {
        if (Animal == null) return;
        Console.WriteLine(Animal.Address);
    }
}

public interface IAnimalInterface
{
    string Name { get; set; }
    string Address { get; set; }
    public string GetNameMethodFromAnimal();
    public string GetNameMethodFromAnimal<U>(U u);
}