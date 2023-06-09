using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Services;
using E_Ticaret.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace E_Ticaret.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
                services.AddScoped<IFileService, FileService>();
        }
    }
}