using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using E_Ticaret.Infrastructure.Operations;

namespace E_Ticaret.Infrastructure.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<bool> CopyToFileAsync(string path, IFormFile file)
        {
            try
            {
                    await using FileStream fileStream = new(
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
            catch (Exception ex) 
            {
                // todo log!
                throw ex;
            }

        }

        private async Task<string> CreateDirectory(string path)
        {
            
           return  await Task.Run(() =>{
                string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, path);
                if (!Directory.Exists(uploadPath))
                    Directory.CreateDirectory(uploadPath);
                return uploadPath;
            });
        }

        private async Task<string> FileRenameAsync(string path, string fileName, bool loop = true)
        {
            string newFileName = 
            await Task.Run<string>(() => {
                    string extension = Path.GetExtension(fileName);
                    string oldName = Path.GetFileNameWithoutExtension(fileName);
                    string regulatedFileName = ReplaceHelper.CharRegulator(oldName);
                    var files = Directory.GetFiles(path, regulatedFileName +"*");
                    
                    if(files.Length <= 0) 
                        return regulatedFileName + "-1" + extension;
                    int[] fileNumbers = new int[files.Length];
                    int lastHypenIndex;
                    for (int i = 0; i < files.Length; i++)
                    {
                        lastHypenIndex = files[i].LastIndexOf("-");
                        string substringFile = files[i].Substring(lastHypenIndex +1, files[i].Length - extension.Length- lastHypenIndex-1);
                        fileNumbers[i] = int.Parse(substringFile);
                    }
                    int bigNumbers = fileNumbers.Max();
                    bigNumbers++;
                    return $"{regulatedFileName}-{bigNumbers}{extension}";
            });

            return newFileName;
           
        }

        public async Task<List<(string fileName, string pathName)>> UploadFieAsync(string path, IFormFileCollection files)
        {
              string uploadPath = await CreateDirectory(path);

              List<(string fileName, string pathName)> datas = new();
              List<bool> results = new();
              foreach (var file in files)
              {
                    string fileRename = await FileRenameAsync(uploadPath, file.FileName);
                    string fullPath = $"{uploadPath}/{fileRename}";
                    bool result = await CopyToFileAsync(fullPath, file);
                    
                    datas.Add((fileRename, fullPath));
                    results.Add(result);
              }

              if(results.TrueForAll(r => r.Equals(true)))
                 return datas;
              return null;
        }
    }
}