using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Storage;
using Microsoft.AspNetCore.Http;

namespace E_Ticaret.Infrastructure.Services.Storage
{
    public class StorageService : IStorageService
    {
         private readonly IStorage _storage;

        public StorageService(IStorage storage)
        {
            _storage = storage;
        }

        public string StorageName => _storage.GetType().Name;

        public Task DeleteAsync(string pathOrContainerName, string fileName)
        => _storage.DeleteAsync(pathOrContainerName, fileName);

        public Task<List<string>> GetFilesAsync(string pathOrContainerName)
        => _storage.GetFilesAsync(pathOrContainerName);

        public Task<bool> HasFileAsync(string pathOrContainerName, string fileName)
        => _storage.HasFileAsync(pathOrContainerName, fileName);

        public Task<List<(string path, string fileName)>> UploadAsync(string pathOrContainerName, IFormFileCollection files)
        => _storage.UploadAsync(pathOrContainerName, files);
    }
}