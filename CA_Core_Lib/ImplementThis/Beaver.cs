namespace CA_Core_Lib.ImplementThis;

public class Beaver : IAnimal
{
    public string Name { get; set; }

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

public static class Extension
{
    public static Beaver ToBeaver(this string name)
    {
    }
}