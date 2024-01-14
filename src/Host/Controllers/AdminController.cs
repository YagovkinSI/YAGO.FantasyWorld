using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using YAGO.FantasyWorld.Application.Admin;

namespace YAGO.FantasyWorld.Host.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AdminController : ControllerBase
	{
		private readonly AdminService _adminService;

		public AdminController(AdminService adminService)
		{
			_adminService = adminService;
		}

		[HttpGet]
		[Route("initData")]
		public async Task InitData(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			await _adminService.InitData(cancellationToken);
		}
	}
}
