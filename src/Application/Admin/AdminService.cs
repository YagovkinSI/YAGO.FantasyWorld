using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Application.Admin.Interfaces;
using YAGO.FantasyWorld.Application.Organizations.Interfaces;
using YAGO.FantasyWorld.Domain.Organization;

namespace YAGO.FantasyWorld.Application.Admin
{
	/// <summary>
	/// Сервис работы с ррганизациями
	/// </summary>
	public class AdminService
	{
		private const int ORGANIZATION_POWER_DEFAULT = 500;

		private readonly IAdminDatabaseService _adminDatabaseService;
		private readonly IOrganizationDatabaseService _organizationDatabaseService;

		public AdminService(
			IAdminDatabaseService adminDatabaseService,
			IOrganizationDatabaseService organizationDatabaseService)
		{
			_adminDatabaseService = adminDatabaseService;
			_organizationDatabaseService = organizationDatabaseService;
		}

		/// <summary>
		/// Инициализация данных для игры
		/// </summary>
		/// <param name="cancellationToken">Токен отмены</param>
		public async Task InitData(CancellationToken cancellationToken)
		{
			var currentOrganizations = await _organizationDatabaseService.GetOrganizations(cancellationToken);
			if (currentOrganizations.Count() == _organizations.Length)
				return;

			foreach (var organization in _organizations)
			{
				if (currentOrganizations.Any(o => o.Id == organization.Id))
					continue;

				_adminDatabaseService.AddOrganization(organization);
			}
		}

		private readonly Organization[] _organizations = new[]
		{
			new Organization(1, "Сан-Горьенжо", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(2, "Макаче", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(3, "Лусаро", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(4, "Фартиано", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(5, "Кедулония", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(6, "Арчодонно", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(7, "Вольжуна", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(8, "Аручоли", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(9, "Керенсиго", ORGANIZATION_POWER_DEFAULT, null),
			new Organization(10, "Кауццоо", ORGANIZATION_POWER_DEFAULT, null)
		};
	}
}
