namespace CA_Core_Lib.Generic;

public class GenericClass<T> where T : struct, IGenericInterface<T>
{
    private List<T>? _list;

    public void SortList(List<T>? list)
    {
        if (list == null) return;
        list.Sort();
        _list = list;
    }

    public void PrintList()
    {
        if (_list == null) return;
        foreach (var item in _list)
        {
            Console.WriteLine(item);
        }
    }
}

public class UseGenericClass
{
    public void Use()
    {
        var genericClass = new GenericClass<MyStruct>();
    }
}

internal struct MyStruct : IGenericInterface<MyStruct>
{
    public int X;
    public int Y;

    public MyStruct(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }

    public void GetNameMethod()
    {
        throw new NotImplementedException();
    }

    public void GetNameMethod<U>()
    {
        throw new NotImplementedException();
    }
}

internal struct MyStruct2 : IGenericInterface<MyStruct2>
{
    public int X;
    public int Y;

    public MyStruct2(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }

    public void GetNameMethod<U>()
    {
        throw new NotImplementedException();
    }
}

public interface IGenericInterface<T>
{
    void GetNameMethod<U>();
}