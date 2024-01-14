namespace YAGO.FantasyWorld.Host.Models.Users
{
	/// <summary>
	/// Пользователь
	/// </summary>
	public class UserLink
	{
		internal UserLink(string id, string name)
		{
			Id = id;
			Name = name;
		}

		/// <summary>
		/// Идентификатор
		/// </summary>
		public string Id { get; }

		/// <summary>
		/// Имя
		/// </summary>
		public string Name { get; }
	}
}
