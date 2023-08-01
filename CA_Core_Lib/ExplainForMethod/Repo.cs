//namespace CA_Core_Lib.ExplainForMethod;

//public abstract class Repo<T> where T : class
//{
//    public abstract T GetEntityById(int id);
//    public abstract IEnumerable<T> GetEntities();
//    public abstract IEnumerable<T> GetAll();
//    public abstract IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total);

//    public abstract IEnumerable<T> GetEntitiesByPage(int pageSize, int pageIndex, out int total,
//        System.Linq.Expressions.Expression<Func<T, bool>> whereLambda);

//    public abstract IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
//        System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, TKey>> orderByLambda, bool isAsc);

//    public abstract IEnumerable<T> GetEntitiesByPage<TKey>(int pageSize, int pageIndex, out int total,
//        System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, TKey>> orderByLambda, bool isAsc,
//        System.Linq.Expressions.Expression<Func<T, TKey>> thenByLambda, bool thenIsAsc);
//}