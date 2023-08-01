using X = System.Linq.Expressions;

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
        foreach (var entity in Entities) writer.WriteLine(entity);
    }
}

public abstract class Repo<T> where T : class
{
    public abstract T GetEntityById(int id);
    public abstract IEnumerable<T> GetEntities();
    public abstract IEnumerable<T> GetAll();
    public abstract IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total);

    public abstract IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total,
        X.Expression<Func<T, bool>> whereLambda);

    public abstract IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
        X.Expression<Func<T, bool>> whereLambda, X.Expression<Func<T, TKey>> orderByLambda, bool isAsc);

    public abstract IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
        X.Expression<Func<T, bool>> whereLambda, X.Expression<Func<T, TKey>> orderByLambda, bool isAsc,
        X.Expression<Func<T, TKey>> thenByLambda, bool thenIsAsc);
}

public class Countable<T>
{
    public int Count { get; set; }
/// <summary>
/// Increments the Count property by the specified value.
/// </summary>
/// <param name="value">The value to add to the Count property.</param>
    public virtual void MyCount(int value)
    {
        Count += value;
    }
}

internal class CommentsRepo<T> : Countable<T>, /*Repo<T>,*/ IComments<T> where T : class
{
    public override void MyCount(int value)
    {
        Count-=value;
    }

    #region Properties
    public List<T> Entities { get; set; } = new();
    #endregion
    #region IComments Implementation

    public void Add(T entity)
    {
        Console.WriteLine("Add to Entities");
        Entities = new List<T>();
        Entities.Add(entity);
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }
    public void Print()
    {
        var value = Entities.FirstOrDefault();
        if (value == null)
            Console.WriteLine("No data");
        else
            Console.WriteLine(value);
    }
    #endregion
    //#region Repo Overrides
    //public override T GetEntityById(int id)
    //{
    //    return Entities[id];
    //}
    //public override IEnumerable<T> GetEntities()
    //{
    //    throw new NotImplementedException();
    //}
    //public override IEnumerable<T> GetAll()
    //{
    //    throw new NotImplementedException();
    //}
    //public override IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total)
    //{
    //    throw new NotImplementedException();
    //}
    //public override IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total,
    //    Expression<Func<T, bool>> whereLambda)
    //{
    //    throw new NotImplementedException();
    //}
    //public override IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
    //    Expression<Func<T, bool>> whereLambda,
    //    Expression<Func<T, TKey>> orderByLambda, bool isAsc)
    //{
    //    throw new NotImplementedException();
    //}
    //public override IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
    //    Expression<Func<T, bool>> whereLambda,
    //    Expression<Func<T, TKey>> orderByLambda, bool isAsc, Expression<Func<T, TKey>> thenByLambda, bool thenIsAsc)
    //{
    //    throw new NotImplementedException();
    //}
    //#endregion
}

public class Use
{
    public void CreateComments(List<Comment> comments, int id)
    {
        var commentsRepo = new CommentsRepo<Comment>();
        foreach (var comment in comments)
        {
            commentsRepo.Add(comment);
            commentsRepo.Print();
        }

        commentsRepo.MyCount(1);

        //commentsRepo.GetEntityById(id);
    }
}