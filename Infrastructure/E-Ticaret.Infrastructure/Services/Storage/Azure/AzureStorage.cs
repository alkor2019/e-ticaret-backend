using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using E_Ticaret.Application.Abstractions.Storage;
using E_Ticaret.Application.Abstractions.Storage.Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace E_Ticaret.Infrastructure.Services.Storage.Azure
{
    public class AzureStorage : Storage, IAzureStorage
    {
         private readonly BlobServiceClient _blobServiceClient;
         private BlobContainerClient _blobContainerClient;
        public AzureStorage(IConfiguration configuration)
        {
            _blobServiceClient = new(configuration["Storage:Azure"]);
        }

        public async Task DeleteAsync(string containerName, string fileName)
        {
            await Task.Run(async () => {
                _blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
                var blobClient =  _blobContainerClient.GetBlobClient(fileName);
                await blobClient.DeleteAsync();
             });
        }

        public async Task<bool> HasFileAsync(string containerName, string fileName)
        {
            return await Task.Run(() => {
                _blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
                return _blobContainerClient.GetBlobs().Any(b => b.Name == fileName);
             });
        }

        public async Task<List<(string path, string fileName)>> UploadAsync(string containerName, IFormFileCollection files)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            await _blobContainerClient.CreateIfNotExistsAsync();
            await _blobContainerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer);

            List<(string fileName, string pathOrContainerName)> datas = new();
            foreach (IFormFile file in files)
            {
                string fileNewName = await RenameFileAsync(containerName, file.Name, GetFilesAsync);

                BlobClient blobClient = _blobContainerClient.GetBlobClient(fileNewName);
                await blobClient.UploadAsync(file.OpenReadStream());
                datas.Add(($"{containerName}/{fileNewName}", fileNewName));
            }
            return datas;
        }

        public  async Task<List<string>> GetFilesAsync(string containerName)
        {
             return await Task.Run(() => {
                _blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
                return _blobContainerClient.GetBlobs().Select(b => b.Name).ToList();
             });
        }
    }
}