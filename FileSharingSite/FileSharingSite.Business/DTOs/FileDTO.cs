using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSharingSite.Business.DTOs
{
    public class FileDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FileName { get; set; }
        public string FileExtention { get; set; }
        public string FileSize { get; set; }
        public DateTime UploadedAt { get; set; }

    }
}
