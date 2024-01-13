using System;
using YAGO.FantasyWorld.Host.Models.Users;

namespace YAGO.FantasyWorld.Host.Models.Organizations
{
	/// <summary>
	/// Организация
	/// </summary>
	public class OrganizationLine
	{
		internal OrganizationLine(long id, string name, double power, UserLink user)
		{
			Id = id;
			Name = name;
			Power = power;
			User = user;
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
		/// Игрок
		/// </summary>
		public UserLink User { get; }
	}
}
