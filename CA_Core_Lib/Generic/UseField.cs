using CA_Core_Lib.ImplementThis;
using Core_Lib_Referenced;

namespace CA_Core_Lib.Generic;

public class UseField
{
    public void Test(CustomAddress customAddress)
    {
        customAddress.Animal = new Dog();
    }
}

public class CustomAddress: Address<Dog>
{
    public CustomAddress(Dog? animal) : base(animal)
    {
    }
}

public class Dog : IAnimalInterface
{
    public string Name { get; set; }
    public string Address { get; set; }

    string IAnimalInterface.GetNameMethodFromAnimal()
    {
        return Name;
    }

    public string GetNameMethodFromAnimal<U>(U u)
    {
        return Name + u;
    }
}