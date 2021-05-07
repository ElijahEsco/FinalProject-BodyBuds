using Microsoft.EntityFrameworkCore;

namespace FinalProject_BodyBuds.Models
{
	public class BodyTypeDbContext : DbContext
	{
		public BodyTypeDbContext (DbContextOptions<BodyTypeDbContext> options)
			: base(options)
		{
		}
		public DbSet<Workout> Workouts {get; set;}
		public DbSet<BodyType> BodyTypes {get; set;}
	}
}
