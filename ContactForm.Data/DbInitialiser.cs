namespace ContactForm.Data
{
	public class DbInitialiser
	{
		public static void Initialize(ContactFormContext context)
		{
			context.Database.EnsureCreated();
		}
	}
}
