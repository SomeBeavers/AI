using System.Linq.Expressions;

namespace CA_Core_Lib.ExplainForMethod;

public interface IComments<T> where T : class
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Save();

    T GetEntityById(int id);
    IEnumerable<T> GetEntities();
    IEnumerable<T> GetAll();
    IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total);
    IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda);
    IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderByLambda, bool isAsc);
    IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderByLambda, bool isAsc, Expression<Func<T, TKey>> thenByLambda, bool thenIsAsc);
}

class CommentsRepo<T> : IComments<T> where T : class
{
    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
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

    public IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda,
        Expression<Func<T, TKey>> orderByLambda, bool isAsc)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda,
        Expression<Func<T, TKey>> orderByLambda, bool isAsc, Expression<Func<T, TKey>> thenByLambda, bool thenIsAsc)
    {
        throw new NotImplementedException();
    }
}