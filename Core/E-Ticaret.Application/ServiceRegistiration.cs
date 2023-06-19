using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace E_Ticaret.Application
{
    public static class ServiceRegistiration
    {
         public static void AddApplicationServices(this IServiceCollection services)
         {
               services.AddMediatR(typeof(ServiceRegistiration));
         }
    }
}