using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Infrastructure.Utilities;
using Microsoft.AspNetCore.Http;

namespace E_Ticaret.Infrastructure.Services.Storage
{
    public class Storage
    {
         protected delegate Task<List<string>> GetFilesAsync(string pathOrContainerName);
         protected async Task<string> RenameFileAsync(string pathOrContainerName, string fileName, GetFilesAsync getFilesAsyncMethod)
        {
            string result = await Task.Run(async ()=> {
                string extension = Path.GetExtension(fileName);
                string oldName = Path.GetFileNameWithoutExtension(fileName);
                string regulatedName = RenameHelper.CharacterRegulatory(oldName);
                var files = await getFilesAsyncMethod(pathOrContainerName); //Directory.GetFiles(path, regulatedName+"*");
                files = files.Where(x => x.Contains(regulatedName)).ToList();
                if(files.Count <= 0)
                     return regulatedName + extension;

                else if(files.Count == 1)
                     return regulatedName + "-2" + extension;
                 else {
                      string firstAddedFile = $"{regulatedName}{extension}";

                      int indexNo = Array.IndexOf(files.ToArray(), firstAddedFile);
                      files = files.Where((value, index) => index != indexNo).ToList();

                      int[] fileNumbers = new int[files.Count];
                      int lastHypenIndex;
                      for(int i = 0; i< files.Count; i++)
                      {
                           lastHypenIndex = files[i].LastIndexOf("-");
                           int parsingInt = int.Parse(files[i].Substring(lastHypenIndex + 1, files[i].Length - extension.Length -lastHypenIndex -1));
                           fileNumbers[i] = parsingInt;
                      }
                      var bigNumber = fileNumbers.Max();
                      bigNumber++;
                      return $"{regulatedName}-{bigNumber}{extension}";
                 }
            });
            return result;
        }

    }
}