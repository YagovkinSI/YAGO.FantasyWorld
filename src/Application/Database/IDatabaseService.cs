using YAGO.FantasyWorld.Application.Organizations.Interfaces;
using YAGO.FantasyWorld.Application.Users.Interfaces;

namespace YAGO.FantasyWorld.Application.Database
{
	public interface IDatabaseService : IUserDatabaseService, IOrganizationDatabaseService
	{
	}
}
