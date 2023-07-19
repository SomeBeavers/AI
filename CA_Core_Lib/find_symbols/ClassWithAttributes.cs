namespace CA_Core_Lib.find_symbols;

[Serializable]
public class ClassWithAttributes
{
    public string Xml { get; set; } = """
                                      this
                                      is
                                      an
                                      xml with
                                      """;

    public void SortList(List<string> xmls)
    {
        xmls.Sort();
    }

    public void Use()
    {
        var xml = Xml;
        var xmls = new List<string>();
        SortList(xmls);
    }
}