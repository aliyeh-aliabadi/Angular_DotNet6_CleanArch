using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCarTel.Dashboard.Application.ViewModels
{
    public class ServerLogsViewModel
    {
        public string LogMessage { get; set; }
        public string LogStream { get; set; }
        public DateTime LogTime { get; set; }
    }
}
