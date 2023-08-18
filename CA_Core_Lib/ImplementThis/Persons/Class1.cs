namespace ReproNulls
{
	internal class Program
	{
		static void Main(string[] args)
		{
		
		}

		public static void Repro(string s)
		{
			if (string.IsNullOrWhiteSpace(s))
				throw new ArgumentException("Value cannot be null or whitespace.", nameof(s));
		}
	}
}