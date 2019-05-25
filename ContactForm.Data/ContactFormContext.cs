using ContactForm.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactForm.Data
{
	public class ContactFormContext : DbContext
	{
		public ContactFormContext(DbContextOptions<ContactFormContext> options) : base(options)
		{
		}

		public DbSet<Message> Messages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Message>().ToTable("Message");
		}
	}
}
