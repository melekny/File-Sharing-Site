using FileSharingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSharingSite.Business.Abstracts
{
    public interface IFolderService
    {
        List<Folder> GetAllFile();
        void AddFolder(Folder folder);
        void UpdateFolder(Folder folder);
        void DeleteFolder(Folder folder);
    }
}