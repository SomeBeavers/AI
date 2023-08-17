using System.Collections.Immutable;
using System.Text;
using static CA_Core_Lib.InvokedOn;
using System.Text.RegularExpressions;

namespace CA_Core_Lib.ExplainForMethod;

internal class CommentsRepo<T> : Countable<T>, /*Repo<T>,*/ IComments<T> where T : class, new()
{
	public void Deconstruct(out int count, out Action<T> func, out ImmutableArray<T> array, out List<T> entities)
	{
		count = Count;
		func = _func;
		array = _array;
		entities = Entities;
	}

	public static string Method(int i)
	{
		if (i == 0)
			return GetString();

		var text = GetString();
		return text;
		try
		{
			string a;
			var match = Regex.Match(a, "^");
		}
		catch (Exception e)
		{
			Bar foo1 = new Bar();
			Bar bar = new Bar();
			Bar foo2 = new Bar();
			Console.WriteLine(e);
			throw;
		}
		string GetString() => "xyz";
	}


	public T this[int i]
	{
		get { return _array[i]; }
	}

	private readonly Action<T> _func = delegate(T arg)
	{
		Console.WriteLine(arg is not null) ;
		return;
	};

    ImmutableArray<T> _array = ImmutableArray<T>.Empty;

    /// <summary>
    ///     Initializes a new instance of the <see cref="CommentsRepo{T}" /> class.
    /// </summary>
    /// <param name="entities">The list of entities to be managed by the repository.</param>
    public CommentsRepo(List<T> entities) : base(entities.Count)
    {
        Console.WriteLine("initialize CommentsRepo");
        Entities = entities;
    }

    public override string ToString()
    {
        Tuple<int, int> tuple = new(1, 2);
	    ImmutableArray<T> add = _array.Add(new T());
        Console.WriteLine(tuple.Item1);
	    var builder = new StringBuilder();
        builder.AppendLine($"{nameof(CommentsRepo<T>)} with Count: {Count} and Entities count: {Entities.Count}");
        foreach (var entity in Entities) builder.AppendLine("\t" + entity);
        return builder.ToString();
    }

    public CommentsRepo() : base(0)
    {
    }

    #region Properties

    public List<T> Entities { get; set; }

    #endregion

    public override void IncreaseCount(int value)
    {
        Count += value;
    }

    #region IComments Implementation

    public void Add(T entity)
	{
		_func(entity);
		//Console.WriteLine("Add to Entities");
		//Entities.Add(entity);
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
        Console.WriteLine(ToString());
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

internal class Bar
{
}