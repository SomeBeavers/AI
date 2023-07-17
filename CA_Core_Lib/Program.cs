// See https://aka.ms/new-console-template for more information

using CA_Core_Lib;

var declaration = new InvokedOn().Declaration(new List<Type> { typeof(Beaver) });
Console.WriteLine(declaration);

public class Beaver
{
}