namespace CA_Core_Lib.ImplementThis;

public class Beaver : IAnimal
{
    public string Name { get; set; }
    public Fluffiness Fluffiness { get; set; }

    #region constructors
    public Beaver(string name, Fluffiness fluffiness)
    {

    }

    #endregion

    public static Beaver Create(string name)
    {
        return new Beaver { Name = name };
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

public enum Fluffiness { NotFluffy, Fluffy, VeryFluffy }