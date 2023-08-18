using System.Collections;

namespace CA_Core_Lib.ImplementThis.Persons;

public class AccountRepo : IEnumerable<Account>
{
	private readonly List<Account> accounts = new();

	public Account this[int index]
	{
		get => accounts[index];
		set => accounts[index] = value;
	}

	public int Count => accounts.Count;

	public IEnumerator<Account> GetEnumerator()
	{
		return accounts.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void Add(Account account)
	{
		accounts.Add(account);
	}
}