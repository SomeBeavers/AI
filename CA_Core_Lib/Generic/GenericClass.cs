﻿namespace CA_Core_Lib.Generic;

public class GenericClass<T> where T : struct, IGenericInterface<T>
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

struct MyStruct : IGenericInterface<MyStruct>
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

    public void GetNameMethod<T>(T t)
    {
        throw new NotImplementedException();
    }
}
struct MyStruct2 : IGenericInterface<MyStruct2>
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
    public void GetNameMethod<T>(T t)
    {
        throw new NotImplementedException();
    }
}

public interface IGenericInterface<T>
{
    void GetNameMethod<U>();
}


public class UseMyStruct
{
    public void Use()
    {
        var myStruct = new MyStruct(1, 2);
        var (x, y) = myStruct;
        myStruct.GetNameMethod<int>();
    }
}