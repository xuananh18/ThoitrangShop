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
    public interface IPostCatService
    {
        PostCat Add(PostCat postCategory);

        void Update(PostCat postCategory);

        PostCat Delete(int id);

        IEnumerable<PostCat> GetAll();

        IEnumerable<PostCat> GetAllByParentId(int parentId);

        PostCat GetById(int id);

        void Save();
    }
    public class PostCatService : IPostCatService
    {
        private IPostCatRepository _postCatRepository;
        private IUnitOfWork _unitOfWork;
        public PostCatService(IPostCatRepository postCatRepository, IUnitOfWork unitOfWork)
        {
            this._postCatRepository = postCatRepository;
            this._unitOfWork = unitOfWork;
        }
        public PostCat Add(PostCat postCat)
        {
            return _postCatRepository.Add(postCat);
        }

        public PostCat Delete(int id)
        {
            return _postCatRepository.Delete(id);
        }

        public IEnumerable<PostCat> GetAll()
        {
            return _postCatRepository.GetAll();
        }

        public IEnumerable<PostCat> GetAllByParentId(int parentId)
        {
            return _postCatRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCat GetById(int id)
        {
            return _postCatRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCat postCategory)
        {
            _postCatRepository.Update(postCategory);
        }
    }
}
