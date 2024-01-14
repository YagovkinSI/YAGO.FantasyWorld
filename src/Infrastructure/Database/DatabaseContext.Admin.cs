using YAGO.FantasyWorld.Application.Database;
using YAGO.FantasyWorld.Domain.Organization;

namespace YAGO.FantasyWorld.Infrastructure.Database
{
	public partial class DatabaseContext : IDatabaseService
	{
		public void AddOrganization(Organization organization)
		{
			var organizationDb = ToDatabse(organization);
			Add(organizationDb);
			SaveChanges();
		}

		private static Models.Organization ToDatabse(Organization organization)
		{
			return organization == null
				? null
				: new Models.Organization
				{
					Name = organization.Name,
					Power = organization.Power,
				};
		}
	}
}
