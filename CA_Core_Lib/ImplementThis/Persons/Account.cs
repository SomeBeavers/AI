using Microsoft.Extensions.Logging;

namespace CA_Core_Lib.ImplementThis.Persons;

public class Account(int id, string name, ILogger<Account> _logger)
{
	// NOTE: there can't be more than 10 accounts.
	// TODO: why 10?
	public static int _maxId = 10;

	private readonly ILogger<Account> _logger = _logger;

	public string Guid { get; private set; }

	public required bool IsActive { get; set; }

	public int ID { get; set; } = id;
	public string Name { get; set; } = name;

	public void SetGuid(string newGuid)
	{
		Guid = newGuid;
	}


	public void Deconstruct(out int id, out string name)
	{
		id = ID;
		name = Name;

		_logger.LogInformation($"Deconstructing Account: ID = {id}, Name = {name}");
	}
}