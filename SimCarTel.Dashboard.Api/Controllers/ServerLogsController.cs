using Microsoft.AspNetCore.Mvc;
using SimCarTel.Dashboard.Application.Interfaces;
using SimCarTel.Dashboard.Application.ViewModels;

namespace SimCarTel.Dashboard.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerLogsController : ControllerBase
    {
        private readonly IServerLogsService _serverLogsService;

        public ServerLogsController(IServerLogsService serverLogsService)
        {
            _serverLogsService = serverLogsService;
        }

        [HttpGet]
        public IEnumerable<ServerLogsViewModel> GetServerLogs()
        {
            IEnumerable<ServerLogsViewModel> result = new List<ServerLogsViewModel>();

             result =  _serverLogsService.GetServerLogs().ToList();
            return result;
            
        }
    }
}
