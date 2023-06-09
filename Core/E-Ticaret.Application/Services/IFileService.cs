using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace E_Ticaret.Application.Services
{
    public interface IFileService
    {
        
        Task<bool> CopyToFileAsync(string path, IFormFile file);
        Task<List<(string fileName, string pathName)>> UploadFieAsync(string path, IFormFileCollection files);

    }
}