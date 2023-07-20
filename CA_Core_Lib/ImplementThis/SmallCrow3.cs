namespace CA_Core_Lib.ImplementThis;

record SmallCrow3(string Name, int Age) : Crow(Name)
{
    public override string ToString()
    {
        return $"Name : {Name}, Age : {Age}";
    }
}