using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Application.Organizations;
using YAGO.FantasyWorld.Domain.Organization;
using YAGO.FantasyWorld.Host.Models.Organizations;
using YAGO.FantasyWorld.Host.Models.Users;

namespace YAGO.FantasyWorld.Host.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrganizationController : ControllerBase
	{
		private readonly OrganizationService _organizationService;

		public OrganizationController(OrganizationService organizationService)
		{
			_organizationService = organizationService;
		}

		[HttpGet]
		[Route("getOrganizations")]
		public async Task<IEnumerable<OrganizationLine>> GetOrganizations(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			var organizations = await _organizationService.GetOrganizations(cancellationToken);
			return organizations
				.Select(w => ToApi(w));
		}

		private static OrganizationLine ToApi(Organization organization)
		{
			return new OrganizationLine
			(
				organization.Id,
				organization.Name,
				organization.Power,
				organization.UserLink == null
					? null
					: new UserLink(organization.UserLink.Id, organization.UserLink.Name)
			);
		}
	}
}
