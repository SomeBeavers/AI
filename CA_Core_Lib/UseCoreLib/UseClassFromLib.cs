using System.Collections;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace CA_Core_Lib.UseCoreLib;


public class Implement: Random, IQueryable
{
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public Type ElementType { get; }
    public Expression Expression { get; }
    public IQueryProvider Provider { get; }
}

public class MyCollection<T> : IEnumerable<T>
{
    private List<T> _items = new List<T>();
    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void Add(T item)
    {
        _items.Add(item);
    }
}


public class UseClassFromLib : IDisposable
{
    private bool disposed = false; // to detect redundant calls
    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    { 
        Dispose(true);
        GC.SuppressFinalize(this);           
    }
    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return; 
        if (disposing) {
            // Free any other managed objects here.
            //
        }
        // Free any unmanaged objects here.
        //
        disposed = true;
    }
    ~UseClassFromLib()
    {
       Dispose(false);
    }
}
