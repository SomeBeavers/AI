namespace CA_Core_Lib.ImplementThis;

file class UseBeaver
{
    public void Use()
    {
        Beaver beaver = new Beaver(Fluffiness.VeryFluffy);
        Beaver beaver2 = Beaver.Create(Fluffiness.ExtremelyFluffy);
    }
    public void EmptyMethod(int myInt, int myInt2)
    {
        //unused method
    }
}