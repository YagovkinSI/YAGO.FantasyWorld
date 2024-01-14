using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YAGO.FantasyWorld.Application.Database;
using YAGO.FantasyWorld.Application.Organizations.Interfaces;
using YAGO.FantasyWorld.Application.Admin.Interfaces;
using YAGO.FantasyWorld.Application.Users.Interfaces;

namespace YAGO.FantasyWorld.Infrastructure.Database
{
	public static partial class ServiceCollectionExtensions
	{
		public static IServiceCollection AddDatabase(
			this IServiceCollection services,
			IConfiguration configuration)
		{
			services.AddDbContext<DatabaseContext>(options =>
				options.UseSqlServer(
					configuration.GetConnectionString("DefaultConnection")
				));

			services
				.AddScoped<IDatabaseService, DatabaseContext>()
				.AddScoped<IUserDatabaseService, DatabaseContext>()
				.AddScoped<IOrganizationDatabaseService, DatabaseContext>()
				.AddScoped<IAdminDatabaseService, DatabaseContext>();

			return services;
		}
	}
}
