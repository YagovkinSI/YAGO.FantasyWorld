using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Application.Database;
using YAGO.FantasyWorld.Domain.Organization;

namespace YAGO.FantasyWorld.Infrastructure.Database
{
	public partial class DatabaseContext : IDatabaseService
	{
		public async Task<IEnumerable<Organization>> GetOrganizations(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			var organizations = await Organizations
				.Include(o => o.User)
				.ToArrayAsync(cancellationToken: cancellationToken);
			return organizations.Select(o => ToDomain(o));
		}

		private static Organization ToDomain(Models.Organization organization)
		{
			return organization == null
				? null
				: new Organization
				(
					organization.Id,
					organization.Name,
					organization.Power,
					organization.User == null
						? null
						: new Domain.BaseModels.Link<string>(organization.User.Id, organization.User.UserName)
				);
		}
	}
}
