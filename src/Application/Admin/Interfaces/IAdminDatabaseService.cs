using YAGO.FantasyWorld.Domain.Organization;

namespace YAGO.FantasyWorld.Application.Admin.Interfaces
{
	/// <summary>
	/// Сервис работы с данными организаций
	/// </summary>
	public interface IAdminDatabaseService
	{
		/// <summary>
		/// Лобавление организации
		/// </summary>
		/// <param name="organization">Организация</param>
		void AddOrganization(Organization organization);
	}
}
