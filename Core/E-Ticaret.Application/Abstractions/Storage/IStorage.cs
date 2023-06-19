using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace E_Ticaret.Application.Abstractions.Storage
{
    public interface IStorage
    {
        Task<List<(string path, string fileName)>> UploadAsync(string pathOrContainerName, IFormFileCollection files);
        Task<List<string>> GetFilesAsync(string pathOrContainerName);
        Task<bool> HasFileAsync(string pathOrContainerName, string fileName);
        Task DeleteAsync(string pathOrContainerName, string fileName);
    }
}