using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Data.Repositories;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Service
{
    public interface ICatService
    {
        Cat Add(Cat Cat);

        void Update(Cat Cat);

        Cat Delete(int id);

        IEnumerable<Cat> GetAll();

        IEnumerable<Cat> GetAll(string keyword);

        IEnumerable<Cat> GetAllByParentId(int parentId);

        Cat GetById(int id);

        void Save();
    }
    public class CatService: ICatService
    {
        private ICatRepository _catRepository;
        private IUnitOfWork _unitOfWork;
        public CatService(ICatRepository catRepository, IUnitOfWork unitOfWork)
        {
            this._catRepository = catRepository;
            this._unitOfWork = unitOfWork;
        }
        public Cat Add(Cat Cat)
        {
            return _catRepository.Add(Cat);
        }

        public Cat Delete(int id)
        {
            return _catRepository.Delete(id);
        }

        public IEnumerable<Cat> GetAll()
        {
            return _catRepository.GetAll();
        }

        public IEnumerable<Cat> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _catRepository.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword));
            else
                return _catRepository.GetAll();

        }

        public IEnumerable<Cat> GetAllByParentId(int parentId)
        {
            return _catRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public Cat GetById(int id)
        {
            return _catRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Cat ProductCategory)
        {
            _catRepository.Update(ProductCategory);
        }
    }
}
