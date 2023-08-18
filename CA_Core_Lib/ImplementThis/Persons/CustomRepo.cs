using System.Collections;

namespace CA_Core_Lib.ImplementThis.Persons;

public class CustomRepo<T> : IEnumerable<T>
{
	private readonly List<T> items = new();
	public T this[int index]
	{
		get => items[index];
		set => items[index] = value;
	}
	public int Count => items.Count;
	public IEnumerator<T> GetEnumerator()
	{
		return items.GetEnumerator();
	}
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
	public void Add(T item)
	{
		items.Add(item);
	}
}
