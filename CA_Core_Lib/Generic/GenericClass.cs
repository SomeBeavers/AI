namespace CA_Core_Lib.Generic;

public class GenericClass<T> where T : struct, IComparable<T>
{
    public void SortList(List<T> list)
    {
        list.Sort();
    }
}


public class UseGenericClass
{
    public void Use()
    {
        var genericClass = new GenericClass<MyStruct>();
    }
}

struct MyStruct : IComparable<MyStruct>, IGenericInterface<MyStruct>
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
}
struct MyStruct2 : IComparable<MyStruct2>, IGenericInterface<MyStruct2>
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
}

internal interface IGenericInterface<T>
{
    void GetNameMethod();
}