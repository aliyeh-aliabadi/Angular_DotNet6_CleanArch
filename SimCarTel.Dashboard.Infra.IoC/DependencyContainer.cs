using Microsoft.Extensions.DependencyInjection;
using SimCarTel.Dashboard.Application.Interfaces;
using SimCarTel.Dashboard.Application.Services;
using SimCarTel.Dashboard.Data.Context;
using SimCarTel.Dashboard.Data.Repositories.Base;
using SimCarTel.Dashboard.Domian.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCarTel.Dashboard.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            //services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domian Handler
            //services.AddScoped<IRequestHandler<CreateProductCommand, bool>, ProductCommandHandler>();

            //Applicatior Layer
            services.AddScoped<IServerLogsService, ServerLogsService>();

            //Infra.Data Layer
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


            //services.AddScoped<ApplicationDbContext>();
        }
    }
}
