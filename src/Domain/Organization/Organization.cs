using YAGO.FantasyWorld.Domain.BaseModels;

namespace YAGO.FantasyWorld.Domain.Organization
{
	/// <summary>
	/// Организация
	/// </summary>
	public class Organization
	{
		public Organization(long id, string name, double power, Link<string> userLink)
		{
			Id = id;
			Name = name;
			Power = power;
			UserLink = userLink;
		}

		/// <summary>
		/// Идентификатор
		/// </summary>
		public long Id { get; }

		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Могущество
		/// </summary>
		public double Power { get; }

		/// <summary>
		/// Идентификатор игрока
		/// </summary>
		public Link<string> UserLink { get; }
	}
}
