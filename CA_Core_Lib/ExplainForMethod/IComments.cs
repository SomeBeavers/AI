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