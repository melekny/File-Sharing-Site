using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSharingSite.Business.Abstracts
{
    public interface IFileService
    {
        List<File> GetAllFile();
        void AddFile(File file);
        void UpdateFile(File file);
        void DeleteFile(File file);
    }
}