﻿namespace CA_Core_Lib;

public class InvokedOn
{
    private const string Beaver = "Beaver";

    public string Declaration(List<Type> types, string? message = "This is not the null string")
    {
        int t = 1;
        if (message is not null)
        {
            Console.WriteLine(message);
        }

        var list = types.Where(x => x.Name == Beaver).ToList();
        return types.Count > 0 ? list[0].Name : "empty list";
    }

    public async Task Test()
    {
        await using IAsyncDisposable a = null, b = null;
        await Task.Delay(10);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }

    public class A
    {
        private string s;

        void PrintS()
        {
        }
    }
}
