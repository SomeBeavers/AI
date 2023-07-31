﻿using System.Linq.Expressions;

namespace CA_Core_Lib.ExplainForMethod;

public interface IComments<T> where T : class
{
    public List<T> Entities { get; set; }

    public void Add(T entity)
    {
       Entities.Add(entity);
    }

    void Update(T entity);
    void Delete(T entity);

    void Print()
    {
        using var writer = new StreamWriter("output.txt");
        foreach (var entity in Entities)
        {
            writer.WriteLine(entity);
        }
    }

    T GetEntityById(int id);
    IEnumerable<T> GetEntities();
    IEnumerable<T> GetAll();
    IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total);
    IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda);

    IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
        Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderByLambda, bool isAsc);

    IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
        Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderByLambda, bool isAsc,
        Expression<Func<T, TKey>> thenByLambda, bool thenIsAsc);
}

internal class CommentsRepo<T> : IComments<T> where T : class
{
    public List<T> Entities { get; set; } = new List<T>();


    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    void IComments<T>.Print()
    {
        //foreach (var entity in Entities)
        //{
        //    Console.WriteLine(entity);
        //}

        var value = Entities.FirstOrDefault();

        if (value == null)
        {
            Console.WriteLine("No data");
        }
        else
        {
            Console.WriteLine(value);
        }
    }

    public T GetEntityById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetEntities()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total,
        Expression<Func<T, bool>> whereLambda)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
        Expression<Func<T, bool>> whereLambda,
        Expression<Func<T, TKey>> orderByLambda, bool isAsc)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
        Expression<Func<T, bool>> whereLambda,
        Expression<Func<T, TKey>> orderByLambda, bool isAsc, Expression<Func<T, TKey>> thenByLambda, bool thenIsAsc)
    {
        throw new NotImplementedException();
    }
}


public class Use
{
    public void CreateComments(Comment comment)
    {
        IComments<Comment> comments = new CommentsRepo<Comment>();
        comments.Add(comment);
        comments.Print();

        var commentsRepo = new CommentsRepo<Comment>();
        ((IComments < Comment > )commentsRepo).Print();
    }
}