using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace YAGO.FantasyWorld.Infrastructure.Database.Models
{
	public class User : IdentityUser
	{
		public DateTimeOffset Registration { get; set; }
		public DateTimeOffset LastActivity { get; set; }

		public virtual List<Organization> Organizations { get; set; }
	}
}
