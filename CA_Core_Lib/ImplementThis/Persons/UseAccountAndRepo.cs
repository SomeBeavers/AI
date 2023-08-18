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

	/// <summary>
	///     Tries to add the given accounts to the provided AccountRepo.
	/// </summary>
	/// <param name="accountRepo">The AccountRepo to which the accounts will be added.</param>
	/// <param name="accounts">The accounts to be added to the AccountRepo.</param>
	/// <returns>Returns true if all accounts are added successfully, false otherwise.</returns>
	public bool TryAddAccounts(AccountRepo accountRepo, params Account[] accounts)
	{
		try
		{
			// Iterate over each account in the provided array
			foreach (var account in accounts)
				// Try to add the account to the AccountRepo
				accountRepo.Add(account);
			// If all accounts are added successfully, return true
			return true;
		}
		catch (Exception)
		{
			// If any exception is thrown during the process, return false
			return false;
		}
	}


	public bool TrySetGuid(Account account, string newGuid)
	{
		try
		{
			account.SetGuid(newGuid);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
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
		var e =
			from a1 in new List<string>()
			from a2 in new List<string>()
			from a3 in new List<string>()
			select 1;


		// Create a new Account
		var account = new Account(1, "New Account", logger)
		{
			IsActive = true // Set the required property
		};
		// Add the new Account to the AccountRepo
		accountRepo.Add(account);
	}

	
	public void Test()
	{
		// implement method to delete an account
	}


	public Account GetAccount(AccountRepo accountRepo, int itemInRepo)
	{
		if (itemInRepo >= 0 && itemInRepo < accountRepo.Count)
			return accountRepo[itemInRepo];
		throw new IndexOutOfRangeException("Item index is out of range.");
	}
}