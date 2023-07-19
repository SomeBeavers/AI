// See https://aka.ms/new-console-template for more information

using CA_Core_Lib;
using CA_Core_Lib.ImplementThis;

var declaration = new InvokedOn().Declaration(new List<Type> { typeof(Beaver) });
Console.WriteLine(declaration);