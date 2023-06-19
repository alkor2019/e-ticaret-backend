using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Storage.Local;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace E_Ticaret.Infrastructure.Services.Storage.Local
{
    public class LocalStorage :Storage, ILocalStorage
    {
         private readonly IWebHostEnvironment _webHostEnvironment;

        public LocalStorage(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public Task DeleteAsync(string path, string fileName)
         => Task.Run(() => File.Delete($"{_webHostEnvironment.WebRootPath}/{path}{fileName = ""}"));

        public async Task<List<string>> GetFilesAsync(string path)
        {
            return await Task.Run(() => {
                 DirectoryInfo directoryInfo = new(path);
                 return directoryInfo.GetFiles().Select(f => f.Name).ToList();
            });
        }

        public async Task<bool> HasFileAsync(string path, string fileName)
        => await Task.Run(() => File.Exists($"{_webHostEnvironment.WebRootPath}/{path}/{fileName = ""}"));

        public async Task<List<(string path, string fileName)>> UploadAsync(string path, IFormFileCollection files)
        {
            string uploadPath = await CreatePathAsync(path);
            List<(string path, string fileName)> datas = new();

            foreach(IFormFile file in files)
            {
                  string newFileName = await RenameFileAsync(uploadPath, file.Name, GetFilesAsync);
                  var result = await CopyFileAsync($"{uploadPath}/{newFileName}", file);
                  datas.Add(($"{path}/{newFileName}", newFileName));      
            }

                return datas;
        }

        private async Task<string> CreatePathAsync(string path)
        {
            string result = await Task.Run(() => {
                string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, path);
                if(!Directory.Exists(uploadPath))
                     Directory.CreateDirectory(uploadPath);
                return uploadPath;
            });

            return result;
        }


        private async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try{
                 using FileStream fileStream = new(
                        path,
                        FileMode.Create,
                        FileAccess.Write,
                        FileShare.None,
                        1024 * 1024,
                        useAsync:false
                    );
                    await file.CopyToAsync(fileStream);
                    await fileStream.FlushAsync();
                return true;
            }
            catch(Exception ex)
            {
                 throw ex;
            }
        }
    }
}