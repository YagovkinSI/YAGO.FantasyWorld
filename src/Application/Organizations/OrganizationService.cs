using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Application.Organizations.Interfaces;
using YAGO.FantasyWorld.Domain.Organization;

namespace YAGO.FantasyWorld.Application.Organizations
{
	/// <summary>
	/// Сервис работы с ррганизациями
	/// </summary>
	public class OrganizationService
	{
		private readonly IOrganizationDatabaseService _databaseService;

		public OrganizationService(IOrganizationDatabaseService databaseService)
		{
			_databaseService = databaseService;
		}

		/// <summary>
		/// Получение прогноза погоды на пять дней
		/// </summary>
		/// <param name="cancellationToken">Токен отмены</param>
		/// <returns>Прогноз погоды на пять дней</returns>
		public async Task<IEnumerable<Organization>> GetOrganizations(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			var organizations = await _databaseService.GetOrganizations(cancellationToken);
			return organizations;
		}
	}
}
