namespace CA_Core_Lib.ImplementThis.Persons;

public class Account
{
	public int ID { get; set; }
	public string Name { get; set; }

	public Account(int id)
	{
	}




	protected bool Equals(Account other)
	{
		return ID == other.ID;
	}
}

public class AcountRepo : IEnumerable<Account>
{

}