using System.Collections.Generic;

namespace FileSharingSite.Models
{
    public class FileViewModel
    {
        public List<FileDetails> Files { get; set; }
            = new List<FileDetails>();
    }
    public class FileDetails
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }
    }