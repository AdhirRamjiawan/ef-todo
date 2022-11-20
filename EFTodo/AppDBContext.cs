using System;
using Microsoft.EntityFrameworkCore;

namespace EFTodo
{
	public class AppDbContext : DbContext
	{
		public DbSet<TodoItem> TodoItems { get; set; }

		public AppDbContext() : base()
		{
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }


        /*
		 * 
		 * 
		 * Cannot write DateTime with Kind=Local to PostgreSQL type 'timestamp with time zone', only UTC is supported. Note that it's not possible to mix DateTimes with different Kinds 
		 * in an array/range. See the Npgsql.EnableLegacyTimestampBehavior AppContext switch to enable legacy behavior.
		 * 
		 */

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			builder.UseNpgsql("Host=localhost;Database=TodoDB;Username=postgres;Password=adhir", pgOptions =>
			{
			});

			base.OnConfiguring(builder);
		}
	}
}

