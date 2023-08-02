namespace CA_Core_Lib.ExplainForMethod;

public class Countable<T>
{
    public Countable(int count)
    {
        Console.WriteLine("initialize Countable");
        Count = count;
    }

    public int Count { get; set; }

    /// <summary>
    ///     Increments the Count property by the specified value.
    /// </summary>
    /// <param name="value">The value to add to the Count property.</param>
    public virtual void IncreaseCount(int value)
    {
        
        Count += value;
    }
}