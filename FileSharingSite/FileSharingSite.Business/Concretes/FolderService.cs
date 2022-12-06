using FileSharingSite.Business.Abstracts;
using FileSharingSite.DataAccess.EntityFramework.Repository.Abstracts;
using FileSharingSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSharingSite.Business.Concretes
{

}
public class FolderService : IFolderService
{
    private readonly IRepository<Folder> repository;
    private readonly IUnitOfWork unitOfWork;

    public FolderService(IRepository<Folder> repository, IUnitOfWork unitOfWork)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
    }

    public void AddFolder(Folder folder)
    {
        repository.Add(folder);
        unitOfWork.Commit();
    }
    public void DeleteFile(Folder folder)
    {
        repository.Delete(folder);
        unitOfWork.Commit();
    }

    public void DeleteFolder(Folder folder)
    {
        throw new NotImplementedException();
    }

    public List<Folder> GetAllFile()
    {
        throw new NotImplementedException();
    }

    public List<Folder> GetAllFolder()
    {
        return repository.Get().ToList();
    }

    public void UpdateFolder(Folder folder)
    {
        try
        {
            if (folder == null)
            {
                throw new ArgumentNullException();
            }
            repository.Update(folder);
            unitOfWork.Commit();

        }
        catch (Exception)
        {

            throw;
        }
    }
}