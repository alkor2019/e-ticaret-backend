using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Storage;
using E_Ticaret.Infrastructure.Enums;
using E_Ticaret.Infrastructure.Services.Storage;
using E_Ticaret.Infrastructure.Services.Storage.Local;
using Microsoft.Extensions.DependencyInjection;

namespace E_Ticaret.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
              
                services.AddScoped<IStorageService, StorageService>();
        }
        public static void AddStorage<T>(this IServiceCollection services) where T:Storage, IStorage
        {
              
                services.AddScoped<IStorage, T>();
        }
        public static void AddStorage(this IServiceCollection services, StorageType storageType)
        {
              switch (storageType)
              {
                case StorageType.Local:
                    services.AddScoped<IStorage, LocalStorage>();
                break;
                
                default:
                    services.AddScoped<IStorage, LocalStorage>();
                break;
              }
                
        }
    }
}