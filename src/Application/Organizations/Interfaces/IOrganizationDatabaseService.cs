using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Domain.Organization;

namespace YAGO.FantasyWorld.Application.Organizations.Interfaces
{
	/// <summary>
	/// Сервис работы с данными организаций
	/// </summary>
	public interface IOrganizationDatabaseService
	{
		/// <summary>
		/// Получение списка организаций
		/// </summary>
		/// <param name="cancellationToken">Токен отмены</param>
		/// <returns>Список организаций</returns>
		Task<IEnumerable<Organization>> GetOrganizations(CancellationToken cancellationToken);
	}
}
