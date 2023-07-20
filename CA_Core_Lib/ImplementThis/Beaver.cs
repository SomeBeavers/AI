namespace CA_Core_Lib.ImplementThis;

public class Beaver(Fluffiness parameter) : IAnimal
{

    #region Properties
    public string Name { get; set; }
    public BeaverHome Home { get; set; }
    #endregion
    #region Methods
    public static Beaver Create(Fluffiness fluffiness)
    {
        return new Beaver(fluffiness);
    }

    public static List<Beaver> CreateBeavers(List<string> names)
    {
        var beavers = new List<Beaver>();
        LocalFunction(beavers);
        return beavers;

        void LocalFunction(List<Beaver> t)
        {
            t.AddRange(names.Select(name => new Beaver(Fluffiness.ExtremelyFluffy)));
        }
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
    #endregion

    public class BeaverHome
    {
        public Location Location { get; set; }

        public BeaverHome(Location location)
        {
            Location = location;
        }
    }

    public class Location
    {
    }
}



file class UseBeaver
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
    VeryFluffy,
    ExtremelyFluffy
}