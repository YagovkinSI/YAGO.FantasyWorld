namespace YAGO.FantasyWorld.Domain.BaseModels
{
	/// <summary>
	/// Идентификатор сущности и название для ссылки
	/// </summary>
	public class Link<T>
	{
		public Link(T id, string name)
		{
			Id = id;
			Name = name;
		}

		/// <summary>
		/// Идентификатор
		/// </summary>
		public T Id { get; }

		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; }
	}
}
