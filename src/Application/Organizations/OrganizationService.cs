using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Domain.Organization;

namespace YAGO.FantasyWorld.Application.Organizations
{
	/// <summary>
	/// Сервис работы с ррганизациями
	/// </summary>
	public class OrganizationService
	{
		private readonly Organization[] organizations = new[]
		{
			new Organization(1, "ТестовоеПервое", 500, null),
			new Organization(2, "ТестовоеВторое", 500, null),
			new Organization(3, "ТестовоеДлинное", 500, new Domain.BaseModels.Link<string>("ТестовоеДлинное", "ТестовоеДлинное")),
		};

		/// <summary>
		/// Получение прогноза погоды на пять дней
		/// </summary>
		/// <param name="cancellationToken">Токен отмены</param>
		/// <returns>Прогноз погоды на пять дней</returns>
		public Task<IEnumerable<Organization>> GetOrganizations(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();

			return Task.FromResult(organizations.AsEnumerable());
		}
	}
}
