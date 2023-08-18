using Microsoft.Extensions.Logging;

namespace CA_Core_Lib.ImplementThis.Persons;

public class UseAccountAndRepo
{
	public static int count = 100;

	public UseAccountAndRepo()
	{
		Account._maxId = count;
	}

	public bool TryAssignMaxId(int id)
	{
		if (id > Account._maxId)
		{
			Account._maxId = id;
			return true;
		}

		return false;
	}



	public void Use()
	{
		// Create a LoggerFactory
		var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
		// Create a logger
		var logger = loggerFactory.CreateLogger<Account>();

		var accountRepo = new AccountRepo();
		for (var i = 1; i <= 10; i++)
		{
			// Now you can pass the logger to the Account constructor
			var account = new Account(i, $"Account {i}", logger)
			{
				IsActive = false
			};


			var (id, name) = account;

			accountRepo.Add(account);
		}
	}

	public void SetNewGuidForAccount(Account account, string newGuid)
	{
		account.SetGuid(newGuid);
	}


	public void CreateNewAccount(AccountRepo accountRepo, ILogger<Account> logger)
	{
		// Create a new Account
		var account = new Account(1, "New Account", logger)
		{
			IsActive = true // Set the required property
		};
		// Add the new Account to the AccountRepo
		accountRepo.Add(account);
	}


	public Account GetAccount(AccountRepo accountRepo, int itemInRepo)
	{
		if (itemInRepo >= 0 && itemInRepo < accountRepo.Count)
			return accountRepo[itemInRepo];
		throw new IndexOutOfRangeException("Item index is out of range.");
	}
}