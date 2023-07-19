namespace CA_Core_Lib.ImplementThis;

public class Beaver : IAnimal
{
    #region constructors
    public Beaver(string name, Fluffiness fluffiness) : this(name)
    {
        Fluffiness = fluffiness;
    }
    public Beaver(string name)
    {
        Name = name;
        Fluffiness = Fluffiness.NotFluffy;
    }

    #endregion

    public Fluffiness Fluffiness { get; set; }
    public string Name { get; set; }

    public static Beaver Create(string name)
    {
        return new Beaver(name, default);
    }


    public async Task<string> GetSoundAsync()
    {
        await GetNameAsync();
        return "gnaw-gnaw";
    }

    private async Task<string> GetNameAsync()
    {
        await Task.Yield(); // Simulate async operation
        return Name;
    }
}

public class UseBeaver
{
    public void Use()
    {
        Beaver beaver = new Beaver("Bucky", Fluffiness.VeryFluffy);
        Beaver beaver2 = Beaver.Create("Bucky");
    }
}


public enum Fluffiness
{
    NotFluffy,
    Fluffy,
    VeryFluffy
}