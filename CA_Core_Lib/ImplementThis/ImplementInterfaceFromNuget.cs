namespace CA_Core_Lib.ImplementThis;

public class ImplementInterfaceFromNuget : Newtonsoft.Json.JsonConverter
{
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        JsonConvert.SerializeObject();
        new ImplementInterfaceFromNuget()
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override bool CanConvert(Type objectType)
    {
        throw new NotImplementedException();
    }
}