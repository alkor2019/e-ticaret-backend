using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Domain.Entities.Common;

namespace E_Ticaret.Domain.Entities
{
    public class FileEntity : BaseEntity
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public string StorageName { get; set; }
    }
}