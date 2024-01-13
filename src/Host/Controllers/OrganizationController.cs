using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Host.Models.Organizations;
using YAGO.FantasyWorld.Host.Models.Users;

namespace YAGO.FantasyWorld.Host.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrganizationController : ControllerBase
	{
		public OrganizationController()
		{
		}

		[HttpGet]
		[Route("getOrganizations")]
		public async Task<IEnumerable<OrganizationLine>> GetOrganizations(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			return await Task.FromResult(organizationLines);
		}

		private readonly OrganizationLine[] organizationLines = new[]
		{
			new OrganizationLine(1, "ТестовоеПервое", 500, null),
			new OrganizationLine(2, "ТестовоеВторое", 500, null),
			new OrganizationLine(3, "ТестовоеДлинное", 500, new UserLink(1, "ТестовоеДлинное")),
		};
	}
}
