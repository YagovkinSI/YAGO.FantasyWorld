﻿using System;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Application.Users.Interfaces;
using YAGO.FantasyWorld.Domain.User;

namespace YAGO.FantasyWorld.Application.Users
{
	/// <summary>
	/// Сервис обновления даты и времени последней активности пользователя
	/// </summary>
	public class UserLastActivityService
	{
		private readonly IUserDatabaseService _userDatabaseService;

		public UserLastActivityService(IUserDatabaseService userDatabaseService)
		{
			_userDatabaseService = userDatabaseService;
		}

		/// <summary>
		/// Актуализация даты и времени последней активности пользователя
		/// </summary>
		/// <param name="user">Данные пользователя</param>
		/// <param name="cancellationToken">Токен отмены</param>
		public async Task UpdateUserLastActivity(User user, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (user == null || user.LastActivity > DateTimeOffset.Now - TimeSpan.FromSeconds(5))
				return;

			await _userDatabaseService.UpdateLastActivity(user.Id, cancellationToken);
		}
	}
}
