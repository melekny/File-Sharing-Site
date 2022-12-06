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
    public class FileService : IFileService
    {
        private readonly IRepository<File> repository;
        private readonly IUnitOfWork unitOfWork;

        public FileService(IRepository<File> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void AddFile(File file)
        {
            repository.Add(file);
            unitOfWork.Commit();
        }
        public void DeleteFile(File file)
        {
            repository.Delete(file);
            unitOfWork.Commit();
        }

        public List<File> GetAllFile()
        {
            return repository.Get().ToList();
        }

        public void UpdateFile(File file)
        {
            try
            {
                if (file == null)
                {
                    throw new ArgumentNullException();
                }
                repository.Update(file);
                unitOfWork.Commit();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}