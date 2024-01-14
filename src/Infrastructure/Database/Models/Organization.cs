using Microsoft.EntityFrameworkCore;

namespace YAGO.FantasyWorld.Infrastructure.Database.Models
{
	public class Organization
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public double Power { get; set; }
		public string UserId { get; set; }

		public virtual User User { get; set; }

		internal static void CreateModel(ModelBuilder builder)
		{
			var model = builder.Entity<Organization>();
			model.HasKey(m => m.Id);
			model.HasOne(m => m.User)
				.WithMany(m => m.Organizations)
				.HasForeignKey(m => m.UserId);

			model.HasIndex(m => m.UserId);
		}
	}
}
