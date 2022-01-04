using Microsoft.EntityFrameworkCore;
using SimCarTel.Dashboard.Application.Interfaces;
using SimCarTel.Dashboard.Application.ViewModels;
using SimCarTel.Dashboard.Domian.Interfaces.Repositories;
using SimCarTel.Dashboard.Domian.Interfaces.Repositories.Base;
using SimCarTel.Dashboard.Domian.Models.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCarTel.Dashboard.Application.Services
{
    public class ServerLogsService : IServerLogsService
    {
        private IRepository<ServerLogs> _serverLogsRepository;

        public ServerLogsService(IRepository<ServerLogs> serverLogsRepository)
        {
            _serverLogsRepository = serverLogsRepository;
        }

        public IEnumerable<ServerLogsViewModel> GetServerLogs()
        {
            //return _serverLogsRepository.GetAll();

            IEnumerable<ServerLogsViewModel> serverLogs = _serverLogsRepository.TableNoTracking.Include(current => current.Message)
                .Select(b => new ServerLogsViewModel
                {
                    LogMessage = b.Message.Description,
                    LogStream = b.LogStream,
                    LogTime = b.LoggedOnDate
                    // etc
                });

            return serverLogs;
        }

    }
}
