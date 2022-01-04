using SimCarTel.Dashboard.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCarTel.Dashboard.Application.Interfaces
{
    public interface IServerLogsService
    {
        IEnumerable<ServerLogsViewModel> GetServerLogs();
    }
}
