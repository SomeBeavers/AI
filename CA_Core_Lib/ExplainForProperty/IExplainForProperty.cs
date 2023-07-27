namespace CA_Core_Lib.ExplainForProperty;

internal interface IExplainForProperty<T>
{
    public int Count { get; set; }

    List<T> TransformCount();

    int TransformCount(T transformation);
}